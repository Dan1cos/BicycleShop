using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleStore.Models
{
    public static class TestData
    {
        public static void Init(BicycleContext context)
        {
            if(!context.Bicycles.Any())
            {
                context.AddRange(
                    new Bicycle
                    {
                        Title = "Cannondale",
                        Model = "TRAIL 7",
                        Price = 800,
                        WDiameter = 29,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc hydraulic",
                        Color = "Black"
                    },
                    new Bicycle
                    {
                        Title = "Cannondale",
                        Model = "TRAIL 5",
                        Price = 950,
                        WDiameter = 29,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc hydraulic",
                        Color = "Red"
                    },
                    new Bicycle
                    {
                        Title = "Cannondale",
                        Model = "TOPSTONE",
                        Price = 1100,
                        WDiameter = 28,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc mechanical",
                        Color = "Blue"
                    },
                    new Bicycle
                    {
                        Title = "Cannondale",
                        Model = "CAAD Optimo Claris",
                        Price = 800,
                        WDiameter = 28,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc mechanical",
                        Color = "Black"
                    },
                    new Bicycle
                    {
                        Title = "Ardis",
                        Model = "Vincent",
                        Price = 350,
                        WDiameter = 26,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc mechanical",
                        Color = "Grey"
                    },
                    new Bicycle
                    {
                        Title = "Ardis",
                        Model = "Titan",
                        Price = 350,
                        WDiameter = 29,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc mechanical",
                        Color = "Grey"
                    },
                    new Bicycle
                    {
                        Title = "Ardis",
                        Model = "Silver Bike 500-2",
                        Price = 250,
                        WDiameter = 26,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc mechanical",
                        Color = "Black"
                    },
                    new Bicycle
                    {
                        Title = "Ardis",
                        Model = "Hiland",
                        Price = 300,
                        WDiameter = 29,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc mechanical",
                        Color = "Black"
                    },
                    new Bicycle
                    {
                        Title = "Ardis",
                        Model = "LX200 ECO",
                        Price = 300,
                        WDiameter = 26,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc mechanical",
                        Color = "Blue"
                    },
                    new Bicycle
                    {
                        Title = "Ardis",
                        Model = "Cleo",
                        Price = 300,
                        WDiameter = 26,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc mechanical",
                        Color = "Black"
                    },
                    new Bicycle
                    {
                        Title = "Trek",
                        Model = "MARLIN 7",
                        Price = 1000,
                        WDiameter = 29,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc hydraulic",
                        Color = "Navy"
                    },
                    new Bicycle
                    {
                        Title = "Trek",
                        Model = "MARLIN 5",
                        Price = 700,
                        WDiameter = 29,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc hydraulic",
                        Color = "Yellow"
                    },
                    new Bicycle
                    {
                        Title = "Formula",
                        Model = "Atlas",
                        Price = 200,
                        WDiameter = 26,
                        FrameMaterial = "Steel",
                        BrakeType = "Rim",
                        Color = "Anthracite"
                    },
                    new Bicycle
                    {
                        Title = "Formula",
                        Model = "F-1 DD",
                        Price = 300,
                        WDiameter = 27,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc mechanical",
                        Color = "Blue"
                    },
                    new Bicycle
                    {
                        Title = "Formula",
                        Model = "Magnum",
                        Price = 200,
                        WDiameter = 26,
                        FrameMaterial = "Steel",
                        BrakeType = "Rim",
                        Color = "Grey"
                    },
                    new Bicycle
                    {
                        Title = "Salut",
                        Model = "F-5",
                        Price = 150,
                        WDiameter = 26,
                        FrameMaterial = "Steel",
                        BrakeType = "Pedal",
                        Color = "Grey"
                    },
                    new Bicycle
                    {
                        Title = "Orbea",
                        Model = "Carpe 40",
                        Price = 800,
                        WDiameter = 28,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc mechanical",
                        Color = "Blue"
                    },
                    new Bicycle
                    {
                        Title = "Orbea",
                        Model = "Occam H20",
                        Price = 3000,
                        WDiameter = 29,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc hydraulic",
                        Color = "Salmon"
                    },
                    new Bicycle
                    {
                        Title = "Orbea",
                        Model = "Wild FS H10",
                        Price = 7000,
                        WDiameter = 29,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc hydraulic",
                        Color = "Red"
                    },
                    new Bicycle
                    {
                        Title = "Orbea",
                        Model = "Orca M40 53",
                        Price = 3100,
                        WDiameter = 29,
                        FrameMaterial = "Carbon",
                        BrakeType = "Disc hydraulic",
                        Color = "Amber"
                    },
                    new Bicycle
                    {
                        Title = "Scott",
                        Model = "SPARK 960",
                        Price = 3400,
                        WDiameter = 29,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc hydraulic",
                        Color = "Grey"
                    },
                    new Bicycle
                    {
                        Title = "Scott",
                        Model = "Aspect 970",
                        Price = 700,
                        WDiameter = 29,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc mechanical",
                        Color = "Yellow"
                    },
                    new Bicycle
                    {
                        Title = "Scott",
                        Model = "Scale 970",
                        Price = 1700,
                        WDiameter = 29,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc mechanical",
                        Color = "Red"
                    },
                    new Bicycle
                    {
                        Title = "Factor",
                        Model = "Slick Disc Sram",
                        Price = 11000,
                        WDiameter = 28,
                        FrameMaterial = "Carbon",
                        BrakeType = "Disc hydraulic",
                        Color = "Red"
                    },
                    new Bicycle
                    {
                        Title = "TORPADO",
                        Model = "Matador XX1AX",
                        Price = 10000,
                        WDiameter = 29,
                        FrameMaterial = "Carbon",
                        BrakeType = "Disc hydraulic",
                        Color = "Blue"
                    },
                    new Bicycle
                    {
                        Title = "Dorozhnik",
                        Model = "ONYX",
                        Price = 350,
                        WDiameter = 20,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Pedal",
                        Color = "Blue"
                    },
                    new Bicycle
                    {
                        Title = "Discovery",
                        Model = "Kelly DD",
                        Price = 200,
                        WDiameter = 26,
                        FrameMaterial = "Steel",
                        BrakeType = "Disc mechanical",
                        Color = "Silver"
                    },
                    new Bicycle
                    {
                        Title = "VNC",
                        Model = "RockRider A7",
                        Price = 450,
                        WDiameter = 27,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc hydraulic",
                        Color = "Black"
                    },
                    new Bicycle
                    {
                        Title = "Leon",
                        Model = "TN-70",
                        Price = 700,
                        WDiameter = 29,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc hydraulic",
                        Color = "Grey"
                    },
                    new Bicycle
                    {
                        Title = "Atlantic",
                        Model = "Rekon Junior NX",
                        Price = 250,
                        WDiameter = 24,
                        FrameMaterial = "Aluminium",
                        BrakeType = "Disc mechanical",
                        Color = "Black"
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}
