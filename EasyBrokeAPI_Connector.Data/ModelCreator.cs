using EasyBrokeAPI_Connector.Model.Agent;
using EasyBrokeAPI_Connector.Model.Features;
using EasyBrokeAPI_Connector.Model.Location;
using EasyBrokeAPI_Connector.Model.Operations;
using EasyBrokeAPI_Connector.Model.Property;
using EasyBrokeAPI_Connector.Model.PropertyImages;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Data
{
    public static class ModelCreator
    {
        public static OperationModel CreateOperation(JObject op)
        {
            if ($"{op["type"]}".Equals(en_SaleOrRentalType.temporary_rental.ToString()))
            {
                return new TemproraryRentalModel(
                    amount: int.Parse($"{op["amount"]}"),
                    formatted: $"{op["formatted_amount"]}",
                    currency: $"{op["currency"]}",
                    period: $"{op["period"]}"
                    );
            }
            else
            {
                return new SaleOrRentalModel(
                    type: $"{op["type"]}",
                    amount: int.Parse($"{op["amount"]}"),
                    currency: $"{op["currency"]}",
                    formatted: $"{op["formatted_amount"]}",
                    unit: $"{op["unit"]})"
                    );
            }
        }

        public static PropertyImagesModel CreateImageProp(JObject img)
        {
            return new PropertyImagesModel(
                url: $"{img["url"]}",
                title: $"{img["title"]}"
                );
        }

        public static AgentModel CreateAgent(JObject agent)
        {
            return new AgentModel(
                id: int.Parse($"{agent["id"]}"),
                name: $"{agent["name"]}",
                fullName: $"{agent["full_name"]}",
                mobilePhone: $"{agent["mobile_phone"]}",
                profileImageURL: $"{agent["profile_image_url"]}",
                email: $"{agent["email"]}"
                );
        }

        public static FeatureModel CreateFeature(JObject feature)
        {
            return new FeatureModel(
                name: $"{feature["name"]}",
                category: $"{feature["category"]}"
                );
        }

        public static LocationModel CreateLocation(JObject location)
        {
            return new LocationModel(
                name: $"{location["name"]}",
                latitude: double.Parse($"{location["latitude"]}"),
                longitude: double.Parse($"{location["longitude"]}"),
                street: $"{location["street"]}",
                postalCode: $"{location["postal_code"]}",
                showExactLocation: bool.Parse($"{location["show_exact_location"]}"),
                exteriorNumber: $"{location["exterior_number"]}",
                interiorNumber: $"{location["interior_number"]}"
                );
        }

        public static PropertySingleModel CreateSingleProperty(JObject property)
        {
            List<PropertyImagesModel> imgProps = new List<PropertyImagesModel>();
            List<OperationModel> operations = new List<OperationModel>();
            AgentModel agent = CreateAgent((JObject)property["agent"]);
            List<FeatureModel> features = new List<FeatureModel>();
            //List<string> files = new List<string>();
            //List<string> videos = property["videos"].ToObject<List<string>>();
            //List<string> tags = new List<string>();
            LocationModel propertyLocation = CreateLocation((JObject)property["location"]);

            var imgPropsObj = property["property_images"];
            var featuresObj = property["features"];
            var operationsObj = property["operations"];

            foreach (JObject img in imgPropsObj)
            {
                imgProps.Add(CreateImageProp(img));
            }

            foreach (JObject feature in featuresObj)
            {
                features.Add(CreateFeature(feature));
            }

            foreach (JObject op in operationsObj)
            {
                operations.Add(CreateOperation(op));
            }
            
            return new PropertySingleModel(
                publicID: $"{property["public_id"]}",
                title: $"{property["title"]}",
                propertyImages: imgProps.ToArray(),
                description: $"{property["description"]}",
                bedrooms: string.IsNullOrEmpty($"{property["bedrooms"]}") ? 0 : int.Parse($"{property["bedrooms"]}"),
                bathrooms: string.IsNullOrEmpty($"{property["bathrooms"]}") ? 0 : int.Parse($"{property["bathrooms"]}"),
                halfBathrooms: string.IsNullOrEmpty($"{property["half_bathrooms"]}") ? 0 : int.Parse($"{property["half_bathrooms"]}"),
                parkingSpaces: string.IsNullOrEmpty($"{property["parking_spaces"]}") ? 0 : int.Parse($"{property["parking_spaces"]}"),
                lotSize: double.Parse($"{property["lot_size"]}"),
                constructionSize: double.Parse($"{property["construction_size"]}"),
                lotLength: string.IsNullOrEmpty($"{property["lot_length"]}") ? 0 : int.Parse($"{property["lot_length"]}"),
                lotWidth: string.IsNullOrEmpty($"{property["lot_width"]}") ? 0 : int.Parse($"{property["lot_width"]}"),
                floors: string.IsNullOrEmpty($"{property["floors"]}") ? 0 : int.Parse($"{property["floors"]}"),
                floor: string.IsNullOrEmpty($"{property["floor"]}") ? 0 : int.Parse($"{property["floor"]}"),
                age: $"{property["age"]}",
                internalID: $"{property["internal_id"]}",
                expenses: $"{property["expenses"]}",
                propertyType: $"{property["property_type"]}",
                agent: agent,
                createdAt: $"{property["created_at"]}",
                updatedAt: $"{property["updated_at"]}",
                publishedAt: $"{property["published_at"]}",
                features: features.ToArray(),
                publicURL: $"{property["public_url"]}",
                collaborationNotes: $"{property["collaboration_notes"]}",
                propertyFiles: property["property_files"].ToObject<string[]>(),
                videos: property["videos"].ToObject<string[]>(),
                virtualTour: $"{property["virtual_tour"]}",
                location: propertyLocation,
                tags: property["tags"].ToObject<string[]>(),
                showPrices: bool.Parse($"{property["show_prices"]}"),
                shareCommission: bool.Parse($"{property["share_commission"]}"),
                operations: operations.ToArray()
                );
        }

        public static PropertyForListModel CreatePropertyForList(JObject property)
        {
            List<OperationModel> operations = new List<OperationModel>();

            var operationsObj = property["operations"];
            foreach (JObject op in operationsObj)
            {
                if ($"{op["type"]}".Equals(en_SaleOrRentalType.temporary_rental.ToString()))
                {
                    operations.Add(new TemproraryRentalModel(
                        amount: int.Parse($"{op["amount"]}"),
                        formatted: $"{op["formatted_amount"]}",
                        currency: $"{op["currency"]}",
                        period: $"{op["period"]}"
                        ));
                }
                else
                {
                    operations.Add(new SaleOrRentalModel(
                        type: $"{op["type"]}",
                        amount: int.Parse($"{op["amount"]}"),
                        currency: $"{op["currency"]}",
                        formatted: $"{op["formatted_amount"]}",
                        unit: $"{op["unit"]})"
                        ));
                }

            }
            
            return new PropertyForListModel(
                id: $"{property["public_id"]}",
                title: $"{property["title"]}",
                titleImg: $"{property["title_image_full"]}",
                location: $"{property["location"]}",
                opModel: operations.ToArray(),
                bedrooms: string.IsNullOrEmpty($"{property["bedrooms"]}") ? 0 : int.Parse($"{property["bedrooms"]}"),
                bathrooms: string.IsNullOrEmpty($"{property["bathrooms"]}") ? 0 : int.Parse($"{property["bathrooms"]}"),
                parkingSpaces: string.IsNullOrEmpty($"{property["parking_spaces"]}") ? 0 : int.Parse($"{property["parking_spaces"]}"),
                propType: $"{property["property_type"]}",
                lotSize: int.Parse($"{property["lot_size"]}"),
                constructionSize: int.Parse($"{property["construction_size"]}"),
                updatedAt: $"{property["updated_at"]}",
                agent: $"{property["agent"]}",
                showP: bool.Parse($"{property["show_prices"]}"),
                shareC: bool.Parse($"{property["share_commission"]}")
            );
        }

        public static LocationListModel CreateLocationList(JObject location)
        {
            List<LocalityModel> localities = new List<LocalityModel>();
            var localitiesObj = JArray.Parse($"{location["localities"]}");


            foreach (JObject locality in localitiesObj)
            {
                localities.Add(CreateLocality(locality));
            }

            return new LocationListModel(
                name: $"{location["name"]}",
                fullName: $"{location["full_name"]}",
                type: $"{location["type"]}",
                localities: localities.ToArray()
            );
        }

        public static LocalityModel CreateLocality(JObject locality)
        {
            return new LocalityModel(
                name: $"{locality["name"]}",
                fullName: $"{locality["full_name"]}",
                type: $"{locality["type"]}"
                );
        }
    }
}
