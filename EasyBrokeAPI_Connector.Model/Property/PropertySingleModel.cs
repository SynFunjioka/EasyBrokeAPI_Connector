using EasyBrokeAPI_Connector.Model.Agent;
using EasyBrokeAPI_Connector.Model.Features;
using EasyBrokeAPI_Connector.Model.Location;
using EasyBrokeAPI_Connector.Model.Operations;
using EasyBrokeAPI_Connector.Model.PropertyImages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Model.Property
{
    public class PropertySingleModel
    {
        public PropertySingleModel(string publicID, string title, PropertyImagesModel[] propertyImages, 
            string description, int bedrooms, int bathrooms, int halfBathrooms, int parkingSpaces, 
            double lotSize, double constructionSize, int lotLength, int lotWidth, int floors, int floor, 
            string age, string internalID, string expenses, string propertyType, AgentModel agent, 
            string createdAt, string updatedAt, string publishedAt, FeatureModel[] features, string publicURL, 
            string collaborationNotes, string virtualTour, 
            LocationModel location, bool showPrices, bool shareCommission, OperationModel[] operations, string[] tags = null, string[] propertyFiles = null, string[] videos =null)
        {
            PublicID = publicID;
            Title = title;
            Property_Images = propertyImages;
            Description = description;
            Bedrooms = bedrooms;
            Bathrooms = bathrooms;
            HalfBathrooms = halfBathrooms;
            ParkingSpaces = parkingSpaces;
            LotSize = lotSize;
            ConstructionSize = constructionSize;
            LotLength = lotLength;
            LotWidth = lotWidth;
            Floors = floors;
            Floor = floor;
            Age = age;
            InternalID = internalID;
            Expenses = expenses;
            PropertyType = propertyType;
            Agent = agent;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            PublishedAt = publishedAt;
            Features = features;
            PublicURL = publicURL;
            CollaborationNotes = collaborationNotes;
            Operations = operations;
            PropertyFiles = propertyFiles;
            Videos = videos;
            VirtualTour = virtualTour;
            Location = location;
            Tags = tags;
            ShowPrices = showPrices;
            shareCommission = shareCommission;
        }

        public string PublicID { get; set; }
        public string Title { get; set; }
        public PropertyImagesModel[] Property_Images { get; set; }
        public string Description { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int HalfBathrooms { get; set; }
        public int ParkingSpaces { get; set; }
        public double LotSize { get; set; }
        public double ConstructionSize { get; set; }
        public int LotLength { get; set; }
        public int LotWidth { get; set; }
        public int Floors { get; set; }
        public int Floor { get; set; }
        public string Age { get; set; }
        public string InternalID { get; set; }
        public string Expenses { get; set; }
        public string PropertyType { get; set; }
        public AgentModel Agent { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string  PublishedAt { get; set; }
        public FeatureModel[] Features { get; set; }
        public string PublicURL{ get; set; }
        public string CollaborationNotes { get; set; }
        public OperationModel[] Operations { get; set; }
        public string[] PropertyFiles { get; set; }
        public string[] Videos { get; set; }
        public string VirtualTour { get; set; }
        public LocationModel Location{ get; set; }
        public string[] Tags { get; set; }
        public bool ShowPrices { get; set; }
        public bool shareCommission { get; set; }
    }
}
