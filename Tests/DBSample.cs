
using System.Collections.ObjectModel;
using WpfEnergyCalculator.Models;

namespace WpfEnergyCalculator.Tests
{
    class DBSample
    {
        public static StructureCategory strusture_category_wall = new StructureCategory()
        {
            StructureCategoryId = 1,
            StructureName = "Стена"
        };

        public static StructureCategory strusture_category_window = new StructureCategory()
        {
            StructureCategoryId = 2,
            StructureName = "Окно"
        };

        public static StructureCategory strusture_category_roof = new StructureCategory()
        {
            StructureCategoryId = 3,
            StructureName = "Кровля"
        };

        public static StructurePropertys structurePropertys_wall_1 = new StructurePropertys()
        {
            StructurePropertyId = 1,
            StructureCategory = strusture_category_wall,
            StructureThickness = 200,
            StructureName = "НС",
            HeatCapacity = 4000,
            ImagePath = "Images/wall.png"
        };

        public static StructurePropertys structurePropertys_wall_2 = new StructurePropertys()
        {
            StructurePropertyId = 2,
            StructureCategory = strusture_category_wall,
            StructureThickness = 300,
            StructureName = "НС2",
            HeatCapacity = 4000,
            ImagePath = "Images/wall.png"
        };

        public static StructurePropertys structurePropertys_roof_1 = new StructurePropertys()
        {
            StructurePropertyId = 3,
            StructureCategory = strusture_category_roof,
            StructureThickness = 100,
            StructureName = "КР1",
            HeatCapacity = 3000,
            ImagePath = "Images/roof.png"
        };

        public static StructurePropertys structurePropertys_roof_2 = new StructurePropertys()
        {
            StructurePropertyId = 4,
            StructureCategory = strusture_category_roof,
            StructureThickness = 100,
            StructureName = "КР2",
            HeatCapacity = 300,
            ImagePath = "Images/roof.png"
        };

        public static ObservableCollection<StructureCategory> _structure_category_list = new ObservableCollection<StructureCategory>()
           {
                strusture_category_wall,strusture_category_window,strusture_category_roof
           };

        public static ObservableCollection<StructurePropertys> _structure_property_list = new ObservableCollection<StructurePropertys>()
            {
                structurePropertys_wall_1,structurePropertys_wall_2,structurePropertys_roof_1,structurePropertys_roof_2
            };

        public static ObservableCollection<StructureInstance> _structure_collection = new ObservableCollection<StructureInstance>()
               {
                 new StructureInstance(){
            StructureInstanceID = 1,StructureProperty = structurePropertys_wall_1,StructureInstanceArea = 200,StructureInstanceOrientation = "С",

                    },
               new StructureInstance(){
            StructureInstanceID = 2,StructureProperty = structurePropertys_wall_2,StructureInstanceArea = 350,StructureInstanceOrientation = "Ю",

                    }
    };

        public static ObservableCollection<RoomData> _RoomPropertyList = new ObservableCollection<RoomData>()
            {
                new RoomData()
        {
           RoomDataID=1, RoomType = "Жилые",RoomProperty = "Отапливаемые",RoomArea = 20,RoomHeight = 3
                },
                new RoomData()
        {
            RoomDataID=2,RoomType = "Вспомогательные",RoomProperty = "Не Отапливаемые",RoomArea = 50,RoomHeight = 3
                },


            };
}
}
