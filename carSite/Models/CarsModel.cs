namespace carSite.Models
{
    public class CarsModel
    {
        public string title { get; set; }
        public string price { get; set; }
        public List<string> images { get; set; } = new List<string>() { };
        public string year { get; set; }
        public string mileage { get; set; }
        public string engine { get; set; }
        public string fuel { get; set; }
        public string transmission { get; set; }
        public string description { get; set; }
    }

    public class Cars
    {
        public static List<CarsModel> cars = new List<CarsModel> {

            new CarsModel(){
            title = "Bakkie Double Cab",
            price = "300 000",
            images  = new List<string>{"legend45_1.jpeg", "legend45_2.jpeg", "legend45_3.jpeg", "legend45_4.jpeg", "legend45_5.jpeg", "legend45_6.jpeg", "legend45_7.jpeg" },
            year  = "2015 Year",
            mileage  = "100 km mileage",
            engine  = "4.4L Engine",
            fuel  = "Diesel Fuel",
            transmission  = "Manual Transmission",
            description  = "Toyota Legend 45 manual 2015 model 3.0\n 4/4 Diesel 100 kilometers service history update full house zero problem price 300 000 seriu buyers call me"
            },

            new CarsModel(){
            title = "Bakkie Single Cab",
            price = "200 000",
            images  = new List<string>{"bsc_1.jpeg", "bsc_2.jpeg", "bsc_3.jpeg", "bsc_4.jpeg", "bsc_5.jpeg", "bsc_6.jpeg", "bsc_7.jpeg", "bsc_8.jpeg",  "bsc_9.jpeg" },
            year  = "2008 Year",
            mileage  = "273, 000 km mileage",
            engine  = "4.2L Engine",
            fuel  = "Diesel Fuel",
            transmission  = "Manual Transmission",
            description  = "Status Build Up! Sold AS IS!! needs brake drums rear and brake pads front new tires, some bulbs and fuses."
            },


            new CarsModel(){
            title = "Land Rover Sport",
            price = "400 000",
            images  = new List<string>{"lrrrs_1.jpeg", "lrrrs_2.jpeg", "lrrrs_3.jpeg", "lrrrs_4.jpeg", "lrrrs_5.jpeg", "lrrrs_6.jpeg", "lrrrs_7.jpeg", "lrrrs_8.jpeg",  "lrrrs_9.jpeg" },
            year  = "2017 Year",
            mileage  = "126, 000 km mileage",
            engine  = "5.0L Engine",
            fuel  = "Petrol Fuel",
            transmission  = "Automatic Multitronic Transmission",
            description  = "Land Rover Range Rover Sport 5.0 v8 Super Charged HSE Dynamic."
            },


             new CarsModel(){
            title = "Toyota hilux Dakar",
            price = "500 000",
            images  = new List<string>{"tyhd_1.jpeg", "tyhd_2.jpeg" },
            year  = "2018 Year",
            mileage  = "63, 000 km mileage",
            engine  = "2.8L Engine",
            fuel  = "Diesel Fuel",
            transmission  = "Manual Transmission",
            description  = "Full House. Full service history with toyota. Extended warranty uo to 120 000km. Pristine condition. cash or bank both welcome."
            },

                new CarsModel(){
            title = "Toyota Raider",
            price = "300 000",
            images  = new List<string>{"raider_1.jpeg", "raider_2.jpeg" },
            year  = "2012 Year",
            mileage  = "150, 000 km mileage",
            engine  = "3.0L Engine",
            fuel  = "Diesel Fuel",
            transmission  = "Manual Transmission",
            description  = "Accident free/aircon refilled roadworthy done/new" +
                    "tyre/canopy zzero mechanical problems fitted with all led."
            },

                     new CarsModel(){
            title = "Toyota Hilux 2.8D 4x4",
            price = "200 000",
            images  = new List<string>{"th_1.jpeg", "th_2.jpeg" },
            year  = "1995 Year",
            mileage  = "150, 000 km mileage",
            engine  = "2.8L Engine",
            fuel  = "Diesel Fuel",
            transmission  = "Manual Transmission",
            description  = "This bukkie is almost fully overhauled"
            },

                               new CarsModel(){
            title = "Tractor",
            price = "300 000",
            images  = new List<string>{"tr1.jpeg", "tr2.jpeg", "tr3.jpeg", "tr4.jpeg", "tr5.jpeg" , "tr6.jpeg", "tr7.jpeg", "tr8.jpeg"},
            year  = "",
            mileage  = "",
            engine  = "2.8L Engine",
            fuel  = "Diesel Fuel",
            transmission  = "Manual Transmission",
            description  = ""
            },
     //========================
     //========================

                                                    new CarsModel(){
            title = "Toyota Hilux 4x4",
            price = "300 000",
            images  = new List<string>{ "thn1.jpeg", "thn2.jpeg", "thn3.jpeg", "thn4.jpeg", "thn5.jpeg", "thn6.jpeg"},
            year  = "",
            mileage  = "",
            engine  = "2.8L Engine",
            fuel  = "Diesel Fuel",
            transmission  = "Manual Transmission",
            description  = ""
            },

                                                                         new CarsModel(){
            title = "Toyota Hilux D4D",
            price = "300 000",
            images  = new List<string>{ "thd4d1.jpeg", "thd4d2.jpeg", "thd4d3.jpeg", "thd4d4.jpeg", "thd4d5.jpeg", "thd4d6.jpeg"},
            year  = "2010 year",
            mileage  = "163 000km mileage",
            engine  = "4.0L Engine",
            fuel  = "Petrol Fuel",
            transmission  = "Manual Transmission",
            description  = ""
            },


                                                                                              new CarsModel(){
            title = "Toyota Runx",
            price = "300 000",
            images  = new List<string>{ "trx1.jpeg", "trx2.jpeg", "trx3.jpeg", "trx4.jpeg", "trx5.jpeg", "trx6.jpeg", "trx7.jpeg"},
            year  = "",
            mileage  = "",
            engine  = "1.5L Engine",
            fuel  = "Petrol Fuel",
            transmission  = "Manual Transmission",
            description  = ""
            },



                                                                                                                   new CarsModel(){
            title = "Toyota Hilux Single Cab",
            price = "300 000",
            images  = new List<string>{"scc1.jpeg", "scc2.jpeg"},
            year  = "",
            mileage  = "",
            engine  = "2.8L Engine",
            fuel  = "Diesel Fuel",
            transmission  = "Manual Transmission",
            description  = ""
            },



                                                                                                                                        new CarsModel(){
            title = "Toyota Runx Silver",
            price = "300 000",
            images  = new List<string>{"rxs1.jpeg", "rxs2.jpeg", "rxs3.jpeg", "rxs4.jpeg", "rxs5.jpeg", "rxs6.jpeg"},
            year  = "",
            mileage  = "",
            engine  = "1.5L Engine",
            fuel  = "Petrol Fuel",
                transmission  = "Manual Transmission",
            description  = ""
            },




                                                                                                                                                             new CarsModel(){
            title = "VW Polo",
            price = "300 000",
            images  = new List<string>{"polo1.jpeg", "polo2.jpeg", "polo3.jpeg", "polo4.jpeg", "polo5.jpeg", "polo6.jpeg", "polo7.jpeg", "polo8.jpeg"},
            year  = "",
            mileage  = "",
            engine  = "2.0L Engine",
            fuel  = "Diesel Fuel",
            transmission  = "Manual Transmission",
            description  = ""
            },



                                                                                                                                                                                  new CarsModel(){
            title = "Toyota Fortuner GD6",
            price = "300 000",
            images  = new List<string>{"tf1.jpeg", "tf2.jpeg", "tf3.jpeg", "tf4.jpeg", "tf5.jpeg", "tf6.jpeg"},
            year  = "",
            mileage  = "",
            engine  = "2.8L Engine",
            fuel  = "Diesel Fuel",
            transmission  = "Manual Transmission",
            description  = ""
            },




                                                                                                                                                                                                       new CarsModel(){
            title = "Chev Bukkie",
            price = "300 000",
            images  = new List<string>{"cb1.jpeg", "cb2.jpeg", "cb3.jpeg"},
            year  = "",
            mileage  = "",
            engine  = "1.8L Engine",
            fuel  = "Diesel Fuel",
            transmission  = "Manual Transmission",
            description  = ""
            },

                                                                                                                                                                                                                            new CarsModel(){
            title = "Toyota Raider",
            price = "300 000",
            images  = new List<string>{ "trza1.jpeg", "trza2.jpeg", "trza3.jpeg", "trza4.jpeg"},
            year  = "",
            mileage  = "",
            engine  = "2.8L Engine",
            fuel  = "Diesel Fuel",
            transmission  = "Manual Transmission",
            description  = ""
            },


                                                                                                                                                                                                                                                 new CarsModel(){
            title = "Toyota Dyna Truck",
            price = "300 000",
            images  = new List<string>{"tdt1.jpeg", "tdt2.jpeg"},
            year  = "",
            mileage  = "",
            engine  = "4.8L Engine",
            fuel  = "Diesel Fuel",
            transmission  = "Manual Transmission",
            description  = ""
            },

                                                                                                                                                                                                                                                 new CarsModel(){
            title = "VW Jetta",
            price = "300 000",
            images  = new List<string>{ "vwjeta1.jpeg", "vwjeta2.jpeg", "vwjeta3.jpeg"},
            year  = "",
            mileage  = "",
            engine  = "2.8L Engine",
            fuel  = "Diesel Fuel",
            transmission  = "Automatic Transmission",
            description  = ""
            },





        };
    }
}
