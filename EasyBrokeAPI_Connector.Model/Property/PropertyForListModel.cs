using EasyBrokeAPI_Connector.Model.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBrokeAPI_Connector.Model.Property
{
    public class PropertyForListModel
    {
        public PropertyForListModel(string id, string title, string titleImg, string location, 
            OperationModel[] opModel, int bedrooms, int bathrooms, int parkingSpaces, 
            string propType, int lotSize, int constructionSize, string updatedAt,
            string agent, bool showP, bool shareC)
        {
            ID = id;
            Title = title;
            TitleImage = titleImg;
            Location = location;
            Operations = opModel;
            Bedrooms = bedrooms;
            Bathrooms = bathrooms;
            ParkingSpaces = parkingSpaces;
            PropertyType = propType;
            LotSize = lotSize;
            ConstructionSize = constructionSize;
            UpdatedAt = updatedAt;
            Agent = agent;
            ShowPrices = showP;
            ShareCommission = shareC;
        }

        public string ID { get; set; }
        public string Title { get; set; }
        public string TitleImage { get; set; }
        public string Location { get; set; }
        public OperationModel[] Operations { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int ParkingSpaces { get; set; }
        public string PropertyType { get; set; }
        public int LotSize { get; set;}
        public int ConstructionSize { get; set; }
        public string UpdatedAt { get; set; }
        public string Agent { get; set; }
        public bool ShowPrices { get; set; }
        public bool ShareCommission { get; set; }
    }
}
