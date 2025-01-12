using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace Yepa.Models
{
    public class CountryModel
    {
		public CountryModel () 
		{
			Name = "United States";
			Code = "US";
			NativeName = "Estados Unidos";
			PhoneCode = "+1";
			Regions = new ObservableCollection<RegionModel>();
			PhoneFormat = "XXX XXX XXX";
		}

		public CountryModel(string name, string code, string phoneCode, string phoneFormat, params string[] nativeName)
		{
			Code = code ?? Code;
			Name = name ?? Name;
			PhoneCode = phoneCode ?? PhoneCode;
 			PhoneFormat = phoneFormat == string.Empty || phoneFormat == null  ? PhoneFormat : phoneFormat; 
			NativeName = nativeName == null ? NativeName : string.Join(",", nativeName);
		}

		public string Code { get; set; } = string.Empty;
		public string Name { get; set; } = string.Empty;
		public string NativeName { get; set; } = string.Empty;
		public string PhoneCode { get; set; } = string.Empty;
		public string PhoneFormat { get; set; } = "XXX XXX XXX";
		public ObservableCollection<RegionModel> Regions { get; set; } = new ObservableCollection<RegionModel>();
		//You can get a greatly improved Android Emulator experience by enabling Hyper-V.    Learn more   |   Don't show again 

		public string NativeNameText
		{
			get
			{
				if (NativeName == string.Empty)
				{
					return null;
				}
				return $"{Environment.NewLine} ({NativeName})";
			}
		}

		public static ObservableCollection<CountryModel> GetCountries()
		{ 
            return new ObservableCollection<CountryModel> 
			{
				#region A
				
				new CountryModel
				{
					Name = "Afghanistan",
					Code = "AF",
					NativeName = " افغانستان - افغانستان",
					PhoneCode = "+93",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Badakhshan",
							Code = "BDS"
						},
						new RegionModel
						{
							Name = "Badghis",
							Code = "BDG"
						},
						new RegionModel
						{
							Name = "Baghlan",
							Code = "BGL"
						},
						new RegionModel
						{
							Name = "Balkh",
							Code = "BAL"
						},
						new RegionModel
						{
							Name = "Bamyan",
							Code = "BAM"
						},
						new RegionModel
						{
							Name = "Daykundi",
							Code = "DAY"
						},
						new RegionModel
						{
							Name = "Farah",
							Code = "FRA"
						},
						new RegionModel
						{
							Name = "Faryab",
							Code = "FYB"
						},
						new RegionModel
						{
							Name = "Ghazni",
							Code = "GHA"
						},
						new RegionModel
						{
							Name = "Ghor",
							Code = "GHO"
						},
						new RegionModel
						{
							Name = "Helmand",
							Code = "HEL"
						},
						new RegionModel
						{
							Name = "Herat",
							Code = "HER"
						},
						new RegionModel
						{
							Name = "Jowzjan",
							Code = "JOW"
						},
						new RegionModel
						{
							Name = "Kabul",
							Code = "KAB"
						},
						new RegionModel
						{
							Name = "Kandahar",
							Code = "KAN"
						},
						new RegionModel
						{
							Name = "Kapisa",
							Code = "KAP"
						},
						new RegionModel
						{
							Name = "Khost",
							Code = "KHO"
						},
						new RegionModel
						{
							Name = "Kunar",
							Code = "KNR"
						},
						new RegionModel
						{
							Name = "Kunduz",
							Code = "KDZ"
						},
						new RegionModel
						{
							Name = "Laghman",
							Code = "LAG"
						},
						new RegionModel
						{
							Name = "Logar",
							Code = "LOW"
						},
						new RegionModel
						{
							Name = "Maidan Wardak",
							Code = "WAR"
						},
						new RegionModel
						{
							Name = "Nangarhar",
							Code = "NAN"
						},
						new RegionModel
						{
							Name = "Nimruz",
							Code = "NIM"
						},
						new RegionModel
						{
							Name = "Nuristan",
							Code = "NUR"
						},
						new RegionModel
						{
							Name = "Paktia",
							Code = "PIA"
						},
						new RegionModel
						{
							Name = "Paktika",
							Code = "PKA"
						},
						new RegionModel
						{
							Name = "Panjshir",
							Code = "PAN"
						},
						new RegionModel
						{
							Name = "Parwan",
							Code = "PAR"
						},
						new RegionModel
						{
							Name = "Samangan",
							Code = "SAM"
						},
						new RegionModel
						{
							Name = "Sar-e Pol",
							Code = "SAR"
						},
						new RegionModel
						{
							Name = "Takhar",
							Code = "TAK"
						},
						new RegionModel
						{
							Name = "Urozgan",
							Code = "ORU"
						},
						new RegionModel
						{
							Name = "Zabul",
							Code = "ZAB"
						}
					}
				},
				new CountryModel
				{
					Name = "Albania",
					Code = "AL",
					NativeName = "Shqipërisë , Shqiperise",
					PhoneCode = "+355",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel("Berat","01"),
						new RegionModel("Dibër","09"),
						new RegionModel("Durrës","02"),
						new RegionModel("Elbasan","03"),
						new RegionModel("Fier","04"),
						new RegionModel("Gjirokastër","05"),
						new RegionModel("Korçë","06"),
						new RegionModel("Kukës","07"),
						new RegionModel("Lezhë","08"),
						new RegionModel
						{
							Name = "Shkodër",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Tirana",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Vlorë",
							Code = "12"
						}
					}
				},
				new CountryModel
				{
					Name = "Algeria",
					Code = "DZ",
					NativeName = "ⴷⵣⴰⵢⴻⵔ , الجزائر‎",
					PhoneCode = "+213",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Adrar",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Aïn Defla",
							Code = "44"
						},
						new RegionModel
						{
							Name = "Aïn Témouchent",
							Code = "46"
						},
						new RegionModel
						{
							Name = "Algiers",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Annaba",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Batna",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Béchar",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Béjaïa",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Biskra",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Blida",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Bordj Bou Arréridj",
							Code = "34"
						},
						new RegionModel
						{
							Name = "Bouïra",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Boumerdès",
							Code = "35"
						},
						new RegionModel
						{
							Name = "Chlef",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Constantine",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Djelfa",
							Code = "17"
						},
						new RegionModel
						{
							Name = "El Bayadh",
							Code = "32"
						},
						new RegionModel
						{
							Name = "El Oued",
							Code = "39"
						},
						new RegionModel
						{
							Name = "El Tarf",
							Code = "36"
						},
						new RegionModel
						{
							Name = "Ghardaïa",
							Code = "47"
						},
						new RegionModel
						{
							Name = "Guelma",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Illizi",
							Code = "33"
						},
						new RegionModel
						{
							Name = "Jijel",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Khenchela",
							Code = "40"
						},
						new RegionModel
						{
							Name = "Laghouat",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Mascara",
							Code = "29"
						},
						new RegionModel
						{
							Name = "Médéa",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Mila",
							Code = "43"
						},
						new RegionModel
						{
							Name = "Mostaganem",
							Code = "27"
						},
						new RegionModel
						{
							Name = "Msila",
							Code = "28"
						},
						new RegionModel
						{
							Name = "Naâma",
							Code = "45"
						},
						new RegionModel
						{
							Name = "Oran",
							Code = "31"
						},
						new RegionModel
						{
							Name = "Ouargla",
							Code = "30"
						},
						new RegionModel
						{
							Name = "Oum el Bouaghi",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Relizane",
							Code = "48"
						},
						new RegionModel
						{
							Name = "Saïda",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Sétif",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Sidi Bel Abbès",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Skikda",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Souk Ahras",
							Code = "41"
						},
						new RegionModel
						{
							Name = "Tamanghasset",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Tébessa",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Tiaret",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Tindouf",
							Code = "37"
						},
						new RegionModel
						{
							Name = "Tipaza",
							Code = "42"
						},
						new RegionModel
						{
							Name = "Tissemsilt",
							Code = "38"
						},
						new RegionModel
						{
							Name = "Tizi Ouzou",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Tlemcen",
							Code = "13"
						}
					}
				},
				new CountryModel
				{
					Name = "American Samoa",
					Code = "AS",
					NativeName = "Amerika Sāmoa",
					PhoneCode = "+1 684",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Tutuila",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Aunu'u",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Ta'ū",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Ofu‑Olosega",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Rose Atoll",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Swains Island",
							Code = "22"
						}
					}
				},
				new CountryModel
				{
					Name = "Andorra",
					Code = "AD",
					NativeName = "Principat d'Andorra",
					PhoneCode = "+376",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Andorra la Vella",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Canillo",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Encamp",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Escaldes-Engordany",
							Code = "08"
						},
						new RegionModel
						{
							Name = "La Massana",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Ordino",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Sant Julià de Lòria",
							Code = "06"
						}
					}
				},
				new CountryModel
				{
					Name = "Angola",
					Code = "AO",
					NativeName = "",
					PhoneCode = "+244",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bengo",
							Code = "BGO"
						},
						new RegionModel
						{
							Name = "Benguela",
							Code = "BGU"
						},
						new RegionModel
						{
							Name = "Bié",
							Code = "BIE"
						},
						new RegionModel
						{
							Name = "Cabinda",
							Code = "CAB"
						},
						new RegionModel
						{
							Name = "Cuando Cubango",
							Code = "CCU"
						},
						new RegionModel
						{
							Name = "Cuanza Norte",
							Code = "CNO"
						},
						new RegionModel
						{
							Name = "Cuanza Sul",
							Code = "CUS"
						},
						new RegionModel
						{
							Name = "Cunene",
							Code = "CNN"
						},
						new RegionModel
						{
							Name = "Huambo",
							Code = "HUA"
						},
						new RegionModel
						{
							Name = "Huíla",
							Code = "HUI"
						},
						new RegionModel
						{
							Name = "Luanda",
							Code = "LUA"
						},
						new RegionModel
						{
							Name = "Lunda Norte",
							Code = "LNO"
						},
						new RegionModel
						{
							Name = "Lunda Sul",
							Code = "LSU"
						},
						new RegionModel
						{
							Name = "Malanje",
							Code = "MAL"
						},
						new RegionModel
						{
							Name = "Moxico",
							Code = "MOX"
						},
						new RegionModel
						{
							Name = "Namibe",
							Code = "NAM"
						},
						new RegionModel
						{
							Name = "Uíge",
							Code = "UIG"
						},
						new RegionModel
						{
							Name = "Zaire",
							Code = "ZAI"
						}
					}
				},
				new CountryModel
				{
					Name = "Anguilla",
					Code = "AI",
					NativeName = "",
					PhoneCode = "+1 264",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Anguilla",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Anguillita Island",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Blowing Rock",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Cove Cay",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Crocus Cay",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Deadman's Cay",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Dog Island",
							Code = "07"
						},
						new RegionModel
						{
							Name = "East Cay",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Little Island",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Little Scrub Island",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Mid Cay",
							Code = "11"
						},
						new RegionModel
						{
							Name = "North Cay",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Prickly Pear Cays",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Rabbit Island",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Sandy Island/Sand Island",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Scilly Cay",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Scrub Island",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Seal Island",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Sombrero/Hat Island",
							Code = "19"
						},
						new RegionModel
						{
							Name = "South Cay",
							Code = "20"
						},
						new RegionModel
						{
							Name = "South Wager Island",
							Code = "21"
						},
						new RegionModel
						{
							Name = "West Cay",
							Code = "22"
						}
					}
				},
				new CountryModel
				{
					Name = "Antigua and Barbuda",
					Code = "AG",
					NativeName = "",
					PhoneCode = "+1 268",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Antigua Island",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Barbuda Island",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Bird Island",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Bishop Island",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Blake Island",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Crump Island",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Dulcina Island",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Exchange Island",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Five Islands",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Great Bird Island",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Green Island",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Guiana Island",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Hawes Island",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Hells Gate Island",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Henry Island",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Johnson Island",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Kid Island",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Lobster Island",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Maiden Island",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Moor Island",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Nanny Island",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Pelican Island",
							Code = "27"
						},
						new RegionModel
						{
							Name = "Prickly Pear Island",
							Code = "28"
						},
						new RegionModel
						{
							Name = "Rabbit Island",
							Code = "29"
						},
						new RegionModel
						{
							Name = "Red Head Island",
							Code = "31"
						},
						new RegionModel
						{
							Name = "Redonda Island",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Sandy Island",
							Code = "32"
						},
						new RegionModel
						{
							Name = "Smith Island",
							Code = "33"
						},
						new RegionModel
						{
							Name = "The Sisters",
							Code = "34"
						},
						new RegionModel
						{
							Name = "Vernon Island",
							Code = "35"
						},
						new RegionModel
						{
							Name = "Wicked Will Island",
							Code = "36"
						},
						new RegionModel
						{
							Name = "York Island",
							Code = "37"
						}
					}
				},
				new CountryModel
				{
					Name = "Argentina",
					Code = "AR",
					NativeName = "",
					PhoneCode = "+54",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Buenos Aires",
							Code = "B"
						},
						new RegionModel
						{
							Name = "Capital Federal",
							Code = "C"
						},
						new RegionModel
						{
							Name = "Catamarca",
							Code = "K"
						},
						new RegionModel
						{
							Name = "Chaco",
							Code = "H"
						},
						new RegionModel
						{
							Name = "Chubut",
							Code = "U"
						},
						new RegionModel
						{
							Name = "Córdoba",
							Code = "X"
						},
						new RegionModel
						{
							Name = "Corrientes",
							Code = "W"
						},
						new RegionModel
						{
							Name = "Entre Ríos",
							Code = "E"
						},
						new RegionModel
						{
							Name = "Formosa",
							Code = "P"
						},
						new RegionModel
						{
							Name = "Jujuy",
							Code = "Y"
						},
						new RegionModel
						{
							Name = "La Pampa",
							Code = "L"
						},
						new RegionModel
						{
							Name = "La Rioja",
							Code = "F"
						},
						new RegionModel
						{
							Name = "Mendoza",
							Code = "M"
						},
						new RegionModel
						{
							Name = "Misiones",
							Code = "N"
						},
						new RegionModel
						{
							Name = "Neuquén",
							Code = "Q"
						},
						new RegionModel
						{
							Name = "Río Negro",
							Code = "R"
						},
						new RegionModel
						{
							Name = "Salta",
							Code = "A"
						},
						new RegionModel
						{
							Name = "San Juan",
							Code = "J"
						},
						new RegionModel
						{
							Name = "San Luis",
							Code = "D"
						},
						new RegionModel
						{
							Name = "Santa Cruz",
							Code = "Z"
						},
						new RegionModel
						{
							Name = "Santa Fe",
							Code = "S"
						},
						new RegionModel
						{
							Name = "Santiago del Estero",
							Code = "G"
						},
						new RegionModel
						{
							Name = "Tierra del Fuego",
							Code = "V"
						},
						new RegionModel
						{
							Name = "Tucumán",
							Code = "T"
						}
					}
				},
				new CountryModel
				{
					Name = "Armenia",
					Code = "AM",
					NativeName = "Հայաստան",
					PhoneCode = "+374",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aragatsotn",
							Code = "AG"
						},
						new RegionModel
						{
							Name = "Ararat",
							Code = "AR"
						},
						new RegionModel
						{
							Name = "Armavir",
							Code = "AV"
						},
						new RegionModel
						{
							Name = "Gegharkunik",
							Code = "GR"
						},
						new RegionModel
						{
							Name = "Kotayk",
							Code = "KT"
						},
						new RegionModel
						{
							Name = "Lori",
							Code = "LO"
						},
						new RegionModel
						{
							Name = "Shirak",
							Code = "SH"
						},
						new RegionModel
						{
							Name = "Syunik",
							Code = "SU"
						},
						new RegionModel
						{
							Name = "Tavush",
							Code = "TV"
						},
						new RegionModel
						{
							Name = "Vayots Dzor",
							Code = "VD"
						},
						new RegionModel
						{
							Name = "Yerevan",
							Code = "ER"
						}
					}
				},
				new CountryModel
				{
					Name = "Aruba",
					Code = "AW",
					NativeName = "",
					PhoneCode = "+297",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aruba",
							Code = "AW"
						}
					}
				},
				new CountryModel
				{
					Name = "Australia",
					Code = "AU",
					NativeName = "",
					PhoneCode = "+61",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Australian Capital Territory",
							Code = "ACT"
						},
						new RegionModel
						{
							Name = "New South Wales",
							Code = "NSW"
						},
						new RegionModel
						{
							Name = "Northern Territory",
							Code = "NT"
						},
						new RegionModel
						{
							Name = "Queensland",
							Code = "QLD"
						},
						new RegionModel
						{
							Name = "South Australia",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "Tasmania",
							Code = "TAS"
						},
						new RegionModel
						{
							Name = "Victoria",
							Code = "VIC"
						},
						new RegionModel
						{
							Name = "Western Australia",
							Code = "WA"
						}
					}
				},
				new CountryModel
				{
					Name = "Austria",
					Code = "AT",
					NativeName = "Österreich",
					PhoneCode = "+43",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Burgenland",
							Code = "1"
						},
						new RegionModel
						{
							Name = "Kärnten",
							Code = "2"
						},
						new RegionModel
						{
							Name = "Niederösterreich",
							Code = "3"
						},
						new RegionModel
						{
							Name = "Oberösterreich",
							Code = "4"
						},
						new RegionModel
						{
							Name = "Salzburg",
							Code = "5"
						},
						new RegionModel
						{
							Name = "Steiermark",
							Code = "6"
						},
						new RegionModel
						{
							Name = "Tirol",
							Code = "7"
						},
						new RegionModel
						{
							Name = "Vorarlberg",
							Code = "8"
						},
						new RegionModel
						{
							Name = "Wien",
							Code = "9"
						}
					}
				},
				new CountryModel
				{
					Name = "Azerbaijan",
					Code = "AZ",
					NativeName = "Azərbaycan",
					PhoneCode = "+994",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Abşeron",
							Code = "ABS"
						},
						new RegionModel
						{
							Name = "Ağcabədi",
							Code = "AGC"
						},
						new RegionModel
						{
							Name = "Ağdam",
							Code = "AGM"
						},
						new RegionModel
						{
							Name = "Ağdaş",
							Code = "AGS"
						},
						new RegionModel
						{
							Name = "Ağstafa",
							Code = "AGA"
						},
						new RegionModel
						{
							Name = "Ağsu",
							Code = "AGU"
						},
						new RegionModel
						{
							Name = "Astara",
							Code = "AST"
						},
						new RegionModel
						{
							Name = "Bakı",
							Code = "BAK"
						},
						new RegionModel
						{
							Name = "Babək",
							Code = "BAB"
						},
						new RegionModel
						{
							Name = "Balakən",
							Code = "BAL"
						},
						new RegionModel
						{
							Name = "Bərdə",
							Code = "BAR"
						},
						new RegionModel
						{
							Name = "Beyləqan",
							Code = "BEY"
						},
						new RegionModel
						{
							Name = "Biləsuvar",
							Code = "BIL"
						},
						new RegionModel
						{
							Name = "Cəbrayıl",
							Code = "CAB"
						},
						new RegionModel
						{
							Name = "Cəlilabad",
							Code = "CAL"
						},
						new RegionModel
						{
							Name = "Culfa",
							Code = "CUL"
						},
						new RegionModel
						{
							Name = "Daşkəsən",
							Code = "DAS"
						},
						new RegionModel
						{
							Name = "Füzuli",
							Code = "FUZ"
						},
						new RegionModel
						{
							Name = "Gədəbəy",
							Code = "GAD"
						},
						new RegionModel
						{
							Name = "Goranboy",
							Code = "GOR"
						},
						new RegionModel
						{
							Name = "Göyçay",
							Code = "GOY"
						},
						new RegionModel
						{
							Name = "Göygöl",
							Code = "GYG"
						},
						new RegionModel
						{
							Name = "Hacıqabul",
							Code = "HAC"
						},
						new RegionModel
						{
							Name = "İmişli",
							Code = "IMI"
						},
						new RegionModel
						{
							Name = "İsmayıllı",
							Code = "ISM"
						},
						new RegionModel
						{
							Name = "Kəlbəcər",
							Code = "KAL"
						},
						new RegionModel
						{
							Name = "Kǝngǝrli",
							Code = "KAN"
						},
						new RegionModel
						{
							Name = "Kürdəmir",
							Code = "KUR"
						},
						new RegionModel
						{
							Name = "Laçın",
							Code = "LAC"
						},
						new RegionModel
						{
							Name = "Lənkəran",
							Code = "LAN"
						},
						new RegionModel
						{
							Name = "Lerik",
							Code = "LER"
						},
						new RegionModel
						{
							Name = "Masallı",
							Code = "MAS"
						},
						new RegionModel
						{
							Name = "Neftçala",
							Code = "NEF"
						},
						new RegionModel
						{
							Name = "Oğuz",
							Code = "OGU"
						},
						new RegionModel
						{
							Name = "Ordubad",
							Code = "ORD"
						},
						new RegionModel
						{
							Name = "Qəbələ",
							Code = "QAB"
						},
						new RegionModel
						{
							Name = "Qax",
							Code = "QAX"
						},
						new RegionModel
						{
							Name = "Qazax",
							Code = "QAZ"
						},
						new RegionModel
						{
							Name = "Qobustan",
							Code = "QOB"
						},
						new RegionModel
						{
							Name = "Quba",
							Code = "QBA"
						},
						new RegionModel
						{
							Name = "Qubadli",
							Code = "QBI"
						},
						new RegionModel
						{
							Name = "Qusar",
							Code = "QUS"
						},
						new RegionModel
						{
							Name = "Saatlı",
							Code = "SAT"
						},
						new RegionModel
						{
							Name = "Sabirabad",
							Code = "SAB"
						},
						new RegionModel
						{
							Name = "Şabran",
							Code = "SBN"
						},
						new RegionModel
						{
							Name = "Sədərək",
							Code = "SAD"
						},
						new RegionModel
						{
							Name = "Şahbuz",
							Code = "SAH"
						},
						new RegionModel
						{
							Name = "Şəki",
							Code = "SAK"
						},
						new RegionModel
						{
							Name = "Salyan",
							Code = "SAL"
						},
						new RegionModel
						{
							Name = "Şamaxı",
							Code = "SMI"
						},
						new RegionModel
						{
							Name = "Şəmkir",
							Code = "SKR"
						},
						new RegionModel
						{
							Name = "Samux",
							Code = "SMX"
						},
						new RegionModel
						{
							Name = "Şərur",
							Code = "SAR"
						},
						new RegionModel
						{
							Name = "Siyəzən",
							Code = "SIY"
						},
						new RegionModel
						{
							Name = "Şuşa",
							Code = "SUS"
						},
						new RegionModel
						{
							Name = "Tərtər",
							Code = "TAR"
						},
						new RegionModel
						{
							Name = "Tovuz",
							Code = "TOV"
						},
						new RegionModel
						{
							Name = "Ucar",
							Code = "UCA"
						},
						new RegionModel
						{
							Name = "Xaçmaz",
							Code = "XAC"
						},
						new RegionModel
						{
							Name = "Xızı",
							Code = "XIZ"
						},
						new RegionModel
						{
							Name = "Xocalı",
							Code = "XCI"
						},
						new RegionModel
						{
							Name = "Xocavənd",
							Code = "XVD"
						},
						new RegionModel
						{
							Name = "Yardımlı",
							Code = "YAR"
						},
						new RegionModel
						{
							Name = "Yevlax",
							Code = "YEV"
						},
						new RegionModel
						{
							Name = "Zəngilan",
							Code = "ZAN"
						},
						new RegionModel
						{
							Name = "Zaqatala",
							Code = "ZAQ"
						},
						new RegionModel
						{
							Name = "Zərdab",
							Code = "ZAR"
						}
					}
				},

				#endregion

				#region B
				new CountryModel
				{
					Name = "Bahamas",
					Code = "BS",
					NativeName = "",
					PhoneCode = "+1 242",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Acklins Island",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Berry Islands",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Bimini",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Black Point",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Cat Island",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Central Abaco",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Crooked Island and Long Cay",
							Code = "28"
						},
						new RegionModel
						{
							Name = "East Grand Bahama",
							Code = "29"
						},
						new RegionModel
						{
							Name = "Exuma",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Freeport",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Fresh Creek",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Governor's Harbour",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Green Turtle Cay",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Harbour Island",
							Code = "09"
						},
						new RegionModel
						{
							Name = "High Rock",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Inagua",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Kemps Bay",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Long Island",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Marsh Harbour",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Mayaguana",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Moore’s Island",
							Code = "40"
						},
						new RegionModel
						{
							Name = "New Providence",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Nichollstown and Berry Islands",
							Code = "17"
						},
						new RegionModel
						{
							Name = "North Abaco",
							Code = "42"
						},
						new RegionModel
						{
							Name = "North Andros",
							Code = "41"
						},
						new RegionModel
						{
							Name = "North Eleuthera",
							Code = "33"
						},
						new RegionModel
						{
							Name = "Ragged Island",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Rock Sound",
							Code = "19"
						},
						new RegionModel
						{
							Name = "San Salvador and Rum Cay",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Sandy Point",
							Code = "21"
						},
						new RegionModel
						{
							Name = "South Abaco",
							Code = "35"
						},
						new RegionModel
						{
							Name = "South Andros",
							Code = "36"
						},
						new RegionModel
						{
							Name = "South Eleuthera",
							Code = "37"
						},
						new RegionModel
						{
							Name = "West Grand Bahama",
							Code = "39"
						}
					}
				},
				new CountryModel
				{
					Name = "Bahrain",
					Code = "BH",
					NativeName = "البحرين‎",
					PhoneCode = "+973",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Al Janūbīyah",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Al Manāmah",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Al Muḩarraq",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Al Wusţá",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Ash Shamālīyah",
							Code = "17"
						}
					}
				},
				new CountryModel
				{
					Name = "Bangladesh",
					Code = "BD",
					NativeName = "বাংলাদেশ",
					PhoneCode = "+880",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Barisal",
							Code = "A"
						},
						new RegionModel
						{
							Name = "Chittagong",
							Code = "B"
						},
						new RegionModel
						{
							Name = "Dhaka",
							Code = "C"
						},
						new RegionModel
						{
							Name = "Khulna",
							Code = "D"
						},
						new RegionModel
						{
							Name = "Mymensingh",
							Code = "M"
						},
						new RegionModel
						{
							Name = "Rajshahi",
							Code = "E"
						},
						new RegionModel
						{
							Name = "Rangpur",
							Code = "F"
						},
						new RegionModel
						{
							Name = "Sylhet",
							Code = "G"
						}
					}
				},
				new CountryModel
				{
					Name = "Barbados",
					Code = "BB",
					NativeName = "",
					PhoneCode = "+1 246",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Christ Church",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Saint Andrew",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Saint George",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Saint James",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Saint John",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Saint Joseph",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Saint Lucy",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Saint Michael",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Saint Peter",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Saint Philip",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Saint Thomas",
							Code = "11"
						}
					}
				},
				new CountryModel
				{
					Name = "Belarus",
					Code = "BY",
					NativeName = "Беларусь",
					PhoneCode = "+375",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Brest voblast",
							Code = "BR"
						},
						new RegionModel
						{
							Name = "Gorod Minsk",
							Code = "HM"
						},
						new RegionModel
						{
							Name = "Homiel voblast",
							Code = "HO"
						},
						new RegionModel
						{
							Name = "Hrodna voblast",
							Code = "HR"
						},
						new RegionModel
						{
							Name = "Mahilyow voblast",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Minsk voblast",
							Code = "MI"
						},
						new RegionModel
						{
							Name = "Vitsebsk voblast",
							Code = "VI"
						}
					}
				},
				new CountryModel
				{
					Name = "Belgium",
					Code = "BE",
					NativeName = "België , Belgique , Belgien",
					PhoneCode = "+32",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Brussels",
							Code = "BRU"
						},
						new RegionModel
						{
							Name = "Flanders",
							Code = "VLG"
						},
						new RegionModel
						{
							Name = "Wallonia",
							Code = "WAL"
						}
					}
				},
				new CountryModel
				{
					Name = "Belize",
					Code = "BZ",
					NativeName = "Belice",
					PhoneCode = "+501",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Belize District",
							Code = "BZ"
						},
						new RegionModel
						{
							Name = "Cayo District",
							Code = "CY"
						},
						new RegionModel
						{
							Name = "Corozal District",
							Code = "CZL"
						},
						new RegionModel
						{
							Name = "Orange Walk District",
							Code = "OW"
						},
						new RegionModel
						{
							Name = "Stann Creek District",
							Code = "SC"
						},
						new RegionModel
						{
							Name = "Toledo District",
							Code = "TOL"
						}
					}
				},
				new CountryModel
				{
					Name = "Benin",
					Code = "BJ",
					NativeName = "Bénin",
					PhoneCode = "+229",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Alibori",
							Code = "AL"
						},
						new RegionModel
						{
							Name = "Atakora",
							Code = "AK"
						},
						new RegionModel
						{
							Name = "Atlantique",
							Code = "AQ"
						},
						new RegionModel
						{
							Name = "Borgou",
							Code = "BO"
						},
						new RegionModel
						{
							Name = "Collines Department",
							Code = "CO"
						},
						new RegionModel
						{
							Name = "Donga",
							Code = "DO"
						},
						new RegionModel
						{
							Name = "Kouffo",
							Code = "KO"
						},
						new RegionModel
						{
							Name = "Littoral Department",
							Code = "LI"
						},
						new RegionModel
						{
							Name = "Mono Department",
							Code = "MO"
						},
						new RegionModel
						{
							Name = "Ouémé",
							Code = "OU"
						},
						new RegionModel
						{
							Name = "Plateau",
							Code = "PL"
						},
						new RegionModel
						{
							Name = "Zou",
							Code = "ZO"
						}
					}
				},
				new CountryModel
				{
					Name = "Bermuda",
					Code = "BM",
					NativeName = "",
					PhoneCode = "+1 441",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "City of Hamilton",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Devonshire Parish",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Hamilton Parish",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Paget Parish",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Pembroke Parish",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Sandys Parish",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Smith's Parish",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Southampton Parish",
							Code = "10"
						},
						new RegionModel
						{
							Name = "St. George's Parish",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Town of St. George",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Warwick Parish",
							Code = "11"
						}
					}
				},
				new CountryModel
				{
					Name = "Bhutan",
					Code = "BT",
					NativeName = "འབྲུག་ རྒྱལ་ཁབ་",
					PhoneCode = "+975",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bumthang",
							Code = "33"
						},
						new RegionModel
						{
							Name = "Chhukha",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Dagana",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Gasa",
							Code = "GA"
						},
						new RegionModel
						{
							Name = "Haa",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Lhuntse",
							Code = "44"
						},
						new RegionModel
						{
							Name = "Mongar",
							Code = "42"
						},
						new RegionModel
						{
							Name = "Paro",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Pemagatshel",
							Code = "43"
						},
						new RegionModel
						{
							Name = "Punakha",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Samdrup Jongkhar",
							Code = "45"
						},
						new RegionModel
						{
							Name = "Samtse",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Sarpang",
							Code = "31"
						},
						new RegionModel
						{
							Name = "Thimphu",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Trashigang",
							Code = "41"
						},
						new RegionModel
						{
							Name = "Trashiyangtse",
							Code = "TY"
						},
						new RegionModel
						{
							Name = "Trongsa",
							Code = "32"
						},
						new RegionModel
						{
							Name = "Tsirang",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Wangdue Phodrang",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Zhemgang",
							Code = "34"
						}
					}
				},
				new CountryModel
				{
					Name = "Bolivia",
					Code = "BO",
					NativeName = "Wuliwya , Buliwya , Volívia",
					PhoneCode = "+591",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Beni",
							Code = "BE"
						},
						new RegionModel
						{
							Name = "Chuquisaca",
							Code = "CH"
						},
						new RegionModel
						{
							Name = "Cochabamba",
							Code = "CB"
						},
						new RegionModel
						{
							Name = "La Paz",
							Code = "LP"
						},
						new RegionModel
						{
							Name = "Oruro",
							Code = "OR"
						},
						new RegionModel
						{
							Name = "Pando",
							Code = "PD"
						},
						new RegionModel
						{
							Name = "Potosí",
							Code = "PT"
						},
						new RegionModel
						{
							Name = "Santa Cruz",
							Code = "SC"
						},
						new RegionModel
						{
							Name = "Tarija",
							Code = "TJ"
						}
					}
				},
				new CountryModel
				{
					Name = "Caribbean Netherlands",
					Code = "BQ",
					NativeName = "Caribisch Nederland",
					PhoneCode = "+599",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bonaire",
							Code = "BO"
						},
						new RegionModel
						{
							Name = "Saba Isand",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "Sint Eustatius",
							Code = "SE"
						}
					}
				},
				new CountryModel
				{
					Name = "Bosnia and Herzegovina",
					Code = "BA",
					NativeName = "Босна и Херцеговина",
					PhoneCode = "+387",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Brčko Distrikt",
							Code = "BRC"
						},
						new RegionModel
						{
							Name = "Federacija Bosne i Hercegovine",
							Code = "BIH"
						},
						new RegionModel
						{
							Name = "Republika Srpska",
							Code = "SRP"
						}
					}
				},
				new CountryModel
				{
					Name = "Botswana",
					Code = "BW",
					NativeName = "",
					PhoneCode = "+267",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Central",
							Code = "CE"
						},
						new RegionModel
						{
							Name = "Ghanzi",
							Code = "GH"
						},
						new RegionModel
						{
							Name = "Kgalagadi",
							Code = "KG"
						},
						new RegionModel
						{
							Name = "Kgatleng",
							Code = "KL"
						},
						new RegionModel
						{
							Name = "Kweneng",
							Code = "KW"
						},
						new RegionModel
						{
							Name = "North West",
							Code = "NW"
						},
						new RegionModel
						{
							Name = "North-East",
							Code = "NE"
						},
						new RegionModel
						{
							Name = "South East",
							Code = "SE"
						},
						new RegionModel
						{
							Name = "Southern",
							Code = "SO"
						}
					}
				},
				new CountryModel
				{
					Name = "Bouvet Island",
					Code = "BV",
					NativeName = "Bouvetøya",
					PhoneCode = "+55",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bouvet Island",
							Code = "BV"
						}
					}
				},
				new CountryModel
				{
					Name = "Brazil",
					Code = "BR",
					NativeName = "Brasil",
					PhoneCode = "+55",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Acre",
							Code = "AC"
						},
						new RegionModel
						{
							Name = "Alagoas",
							Code = "AL"
						},
						new RegionModel
						{
							Name = "Amapá",
							Code = "AP"
						},
						new RegionModel
						{
							Name = "Amazonas",
							Code = "AM"
						},
						new RegionModel
						{
							Name = "Bahia",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Ceará",
							Code = "CE"
						},
						new RegionModel
						{
							Name = "Distrito Federal",
							Code = "DF"
						},
						new RegionModel
						{
							Name = "Espírito Santo",
							Code = "ES"
						},
						new RegionModel
						{
							Name = "Goiás",
							Code = "GO"
						},
						new RegionModel
						{
							Name = "Maranhão",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Mato Grosso",
							Code = "MT"
						},
						new RegionModel
						{
							Name = "Mato Grosso do Sul",
							Code = "MS"
						},
						new RegionModel
						{
							Name = "Minas Gerais",
							Code = "MG"
						},
						new RegionModel
						{
							Name = "Pará",
							Code = "PA"
						},
						new RegionModel
						{
							Name = "Paraíba",
							Code = "PB"
						},
						new RegionModel
						{
							Name = "Paraná",
							Code = "PR"
						},
						new RegionModel
						{
							Name = "Pernambuco",
							Code = "PE"
						},
						new RegionModel
						{
							Name = "Piauí",
							Code = "PI"
						},
						new RegionModel
						{
							Name = "Rio de Janeiro",
							Code = "RJ"
						},
						new RegionModel
						{
							Name = "Rio Grande do Norte",
							Code = "RN"
						},
						new RegionModel
						{
							Name = "Rio Grande do Sul",
							Code = "RS"
						},
						new RegionModel
						{
							Name = "Rondônia",
							Code = "RO"
						},
						new RegionModel
						{
							Name = "Roraima",
							Code = "RR"
						},
						new RegionModel
						{
							Name = "Santa Catarina",
							Code = "SC"
						},
						new RegionModel
						{
							Name = "São Paulo",
							Code = "SP"
						},
						new RegionModel
						{
							Name = "Sergipe",
							Code = "SE"
						},
						new RegionModel
						{
							Name = "Tocantins",
							Code = "TO"
						}
					}
				},
				new CountryModel
				{
					Name = "British Indian Ocean Territory",
					Code = "IO",
					NativeName = "",
					PhoneCode = "+246",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "British Indian Ocean Territory",
							Code = "IO"
						}
					}
				},
				new CountryModel
				{
					Name = "Brunei",
					Code = "BN",
					NativeName = "بروني دارالسلام",
					PhoneCode = "+673",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Belait",
							Code = "BE"
						},
						new RegionModel
						{
							Name = "Brunei Muara",
							Code = "BM"
						},
						new RegionModel
						{
							Name = "Temburong",
							Code = "TE"
						},
						new RegionModel
						{
							Name = "Tutong",
							Code = "TU"
						}
					}
				},
				new CountryModel
				{
					Name = "Bulgaria",
					Code = "BG",
					NativeName = "България",
					PhoneCode = "+359",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Blagoevgrad",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Burgas",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Dobrich",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Gabrovo",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Jambol",
							Code = "28"
						},
						new RegionModel
						{
							Name = "Khaskovo",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Kjustendil",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Kurdzhali",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Lovech",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Montana",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Pazardzhik",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Pernik",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Pleven",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Plovdiv",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Razgrad",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Ruse",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Shumen",
							Code = "27"
						},
						new RegionModel
						{
							Name = "Silistra",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Sliven",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Smoljan",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Sofija",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Sofija-Grad",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Stara Zagora",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Turgovishhe",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Varna",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Veliko Turnovo",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Vidin",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Vraca",
							Code = "06"
						}
					}
				},
				new CountryModel
				{
					Name = "Burkina Faso",
					Code = "BF",
					NativeName = "",
					PhoneCode = "+226",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Balé",
							Code = "BAL"
						},
						new RegionModel
						{
							Name = "Bam/Lake Bam",
							Code = "BAM"
						},
						new RegionModel
						{
							Name = "Banwa Province",
							Code = "BAN"
						},
						new RegionModel
						{
							Name = "Bazèga",
							Code = "BAZ"
						},
						new RegionModel
						{
							Name = "Bougouriba",
							Code = "BGR"
						},
						new RegionModel
						{
							Name = "Boulgou Province",
							Code = "BLG"
						},
						new RegionModel
						{
							Name = "Boulkiemdé",
							Code = "BLK"
						},
						new RegionModel
						{
							Name = "Comoé/Komoe",
							Code = "COM"
						},
						new RegionModel
						{
							Name = "Ganzourgou Province",
							Code = "GAN"
						},
						new RegionModel
						{
							Name = "Gnagna",
							Code = "GNA"
						},
						new RegionModel
						{
							Name = "Gourma Province",
							Code = "GOU"
						},
						new RegionModel
						{
							Name = "Houet",
							Code = "HOU"
						},
						new RegionModel
						{
							Name = "Ioba",
							Code = "IOB"
						},
						new RegionModel
						{
							Name = "Kadiogo",
							Code = "KAD"
						},
						new RegionModel
						{
							Name = "Kénédougou",
							Code = "KEN"
						},
						new RegionModel
						{
							Name = "Komondjari",
							Code = "KMD"
						},
						new RegionModel
						{
							Name = "Kompienga",
							Code = "KMP"
						},
						new RegionModel
						{
							Name = "Kossi Province",
							Code = "KOS"
						},
						new RegionModel
						{
							Name = "Koulpélogo",
							Code = "KOP"
						},
						new RegionModel
						{
							Name = "Kouritenga",
							Code = "KOT"
						},
						new RegionModel
						{
							Name = "Kourwéogo",
							Code = "KOW"
						},
						new RegionModel
						{
							Name = "Léraba",
							Code = "LER"
						},
						new RegionModel
						{
							Name = "Loroum",
							Code = "LOR"
						},
						new RegionModel
						{
							Name = "Mouhoun",
							Code = "MOU"
						},
						new RegionModel
						{
							Name = "Namentenga",
							Code = "NAM"
						},
						new RegionModel
						{
							Name = "Naouri/Nahouri",
							Code = "NAO"
						},
						new RegionModel
						{
							Name = "Nayala",
							Code = "NAY"
						},
						new RegionModel
						{
							Name = "Noumbiel",
							Code = "NOU"
						},
						new RegionModel
						{
							Name = "Oubritenga",
							Code = "OUB"
						},
						new RegionModel
						{
							Name = "Oudalan",
							Code = "OUD"
						},
						new RegionModel
						{
							Name = "Passoré",
							Code = "PAS"
						},
						new RegionModel
						{
							Name = "Poni",
							Code = "PON"
						},
						new RegionModel
						{
							Name = "Sanguié",
							Code = "SNG"
						},
						new RegionModel
						{
							Name = "Sanmatenga",
							Code = "SMT"
						},
						new RegionModel
						{
							Name = "Séno",
							Code = "SEN"
						},
						new RegionModel
						{
							Name = "Sissili",
							Code = "SIS"
						},
						new RegionModel
						{
							Name = "Soum",
							Code = "SOM"
						},
						new RegionModel
						{
							Name = "Sourou",
							Code = "SOR"
						},
						new RegionModel
						{
							Name = "Tapoa",
							Code = "TAP"
						},
						new RegionModel
						{
							Name = "Tui/Tuy",
							Code = "TUI"
						},
						new RegionModel
						{
							Name = "Yagha",
							Code = "YAG"
						},
						new RegionModel
						{
							Name = "Yatenga",
							Code = "YAT"
						},
						new RegionModel
						{
							Name = "Ziro",
							Code = "ZIR"
						},
						new RegionModel
						{
							Name = "Zondoma",
							Code = "ZON"
						},
						new RegionModel
						{
							Name = "Zoundwéogo",
							Code = "ZOU"
						}
					}
				},
				new CountryModel
				{
					Name = "Burundi",
					Code = "BI",
					NativeName = "",
					PhoneCode = "+257",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bubanza",
							Code = "BB"
						},
						new RegionModel
						{
							Name = "Bujumbura Mairie",
							Code = "BM"
						},
						new RegionModel
						{
							Name = "Bujumbura Rural",
							Code = "BL"
						},
						new RegionModel
						{
							Name = "Bururi",
							Code = "BR"
						},
						new RegionModel
						{
							Name = "Cankuzo",
							Code = "CA"
						},
						new RegionModel
						{
							Name = "Cibitoke",
							Code = "CI"
						},
						new RegionModel
						{
							Name = "Gitega",
							Code = "GI"
						},
						new RegionModel
						{
							Name = "Karuzi",
							Code = "KR"
						},
						new RegionModel
						{
							Name = "Kayanza",
							Code = "KY"
						},
						new RegionModel
						{
							Name = "Kirundo",
							Code = "KI"
						},
						new RegionModel
						{
							Name = "Makamba",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Muramvya",
							Code = "MU"
						},
						new RegionModel
						{
							Name = "Muyinga",
							Code = "MY"
						},
						new RegionModel
						{
							Name = "Mwaro",
							Code = "MW"
						},
						new RegionModel
						{
							Name = "Ngozi",
							Code = "NG"
						},
						new RegionModel
						{
							Name = "Rutana",
							Code = "RT"
						},
						new RegionModel
						{
							Name = "Ruyigi",
							Code = "RY"
						}
					}
				},
				#endregion

				#region C
				new CountryModel
				{
					Name = "Cambodia",
					Code = "KH",
					NativeName = "ព្រះរាជាណាចក្រកម្ពុជា",
					PhoneCode = "+855",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Baat Dambang",
							Code = "2"
						},
						new RegionModel
						{
							Name = "Banteay Mean Chey",
							Code = "1"
						},
						new RegionModel
						{
							Name = "Kampong Chaam",
							Code = "3"
						},
						new RegionModel
						{
							Name = "Kampong Chhnang",
							Code = "4"
						},
						new RegionModel
						{
							Name = "Kampong Spueu",
							Code = "5"
						},
						new RegionModel
						{
							Name = "Kampong Thum",
							Code = "6"
						},
						new RegionModel
						{
							Name = "Kampot",
							Code = "7"
						},
						new RegionModel
						{
							Name = "Kandaal",
							Code = "8"
						},
						new RegionModel
						{
							Name = "Kaoh Kong",
							Code = "9"
						},
						new RegionModel
						{
							Name = "Kracheh",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Krong Kaeb",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Krong Pailin",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Krong Preah Sihanouk",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Mondol Kiri",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Otdar Mean Chey",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Phnom Penh",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Pousaat",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Preah Vihear",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Prey Veaeng",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Rotanah Kiri",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Siem Reab",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Stueng Treng",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Svaay Rieng",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Taakaev",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Tbong Khmum",
							Code = "25"
						}
					}
				},
				new CountryModel
				{
					Name = "Cameroon",
					Code = "CM",
					NativeName = "Cameroun",
					PhoneCode = "+237",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Adamaoua",
							Code = "AD"
						},
						new RegionModel
						{
							Name = "Centre",
							Code = "CE"
						},
						new RegionModel
						{
							Name = "Est",
							Code = "ES"
						},
						new RegionModel
						{
							Name = "Extrême-Nord",
							Code = "EN"
						},
						new RegionModel
						{
							Name = "Littoral",
							Code = "LT"
						},
						new RegionModel
						{
							Name = "Nord",
							Code = "NO"
						},
						new RegionModel
						{
							Name = "Nord-Ouest",
							Code = "NW"
						},
						new RegionModel
						{
							Name = "Ouest",
							Code = "OU"
						},
						new RegionModel
						{
							Name = "Sud",
							Code = "SU"
						},
						new RegionModel
						{
							Name = "Sud-Ouest",
							Code = "SW"
						}
					}
				},
				new CountryModel
				{
					Name = "Canada",
					Code = "CA",
					NativeName = "",
					PhoneCode = "+1",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Alberta",
							Code = "AB"
						},
						new RegionModel
						{
							Name = "British Columbia",
							Code = "BC"
						},
						new RegionModel
						{
							Name = "Manitoba",
							Code = "MB"
						},
						new RegionModel
						{
							Name = "New Brunswick",
							Code = "NB"
						},
						new RegionModel
						{
							Name = "Newfoundland and Labrador",
							Code = "NL"
						},
						new RegionModel
						{
							Name = "Northwest Territories",
							Code = "NT"
						},
						new RegionModel
						{
							Name = "Nova Scotia",
							Code = "NS"
						},
						new RegionModel
						{
							Name = "Nunavut",
							Code = "NU"
						},
						new RegionModel
						{
							Name = "Ontario",
							Code = "ON"
						},
						new RegionModel
						{
							Name = "Prince Edward Island",
							Code = "PE"
						},
						new RegionModel
						{
							Name = "Quebec",
							Code = "QC"
						},
						new RegionModel
						{
							Name = "Saskatchewan",
							Code = "SK"
						},
						new RegionModel
						{
							Name = "Yukon",
							Code = "YT"
						}
					}
				},
				new CountryModel
				{
					Name = "Cape Verde",
					Code = "CV",
					NativeName = "Cabo Verde , Kabu Verdi",
					PhoneCode = "+238",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Boa Vista",
							Code = "BV"
						},
						new RegionModel
						{
							Name = "Brava",
							Code = "BR"
						},
						new RegionModel
						{
							Name = "Calheta de São Miguel",
							Code = "CS"
						},
						new RegionModel
						{
							Name = "Maio",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Mosteiros",
							Code = "MO"
						},
						new RegionModel
						{
							Name = "Paúl",
							Code = "PA"
						},
						new RegionModel
						{
							Name = "Porto Novo",
							Code = "PN"
						},
						new RegionModel
						{
							Name = "Praia",
							Code = "PR"
						},
						new RegionModel
						{
							Name = "Ribeira Brava",
							Code = "RB"
						},
						new RegionModel
						{
							Name = "Ribeira Grande",
							Code = "RG"
						},
						new RegionModel
						{
							Name = "Sal",
							Code = "SL"
						},
						new RegionModel
						{
							Name = "Santa Catarina",
							Code = "CA"
						},
						new RegionModel
						{
							Name = "Santa Cruz",
							Code = "CR"
						},
						new RegionModel
						{
							Name = "São Domingos",
							Code = "SD"
						},
						new RegionModel
						{
							Name = "São Filipe",
							Code = "SF"
						},
						new RegionModel
						{
							Name = "São Nicolau",
							Code = "SN"
						},
						new RegionModel
						{
							Name = "São Vicente",
							Code = "SV"
						},
						new RegionModel
						{
							Name = "Tarrafal",
							Code = "TA"
						},
						new RegionModel
						{
							Name = "Tarrafal de São Nicolau",
							Code = "TS"
						}
					}
				},
				new CountryModel
				{
					Name = "Cayman Islands",
					Code = "KY",
					NativeName = "",
					PhoneCode = "+1",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Creek",
							Code = null
						},
						new RegionModel
						{
							Name = "Eastern",
							Code = null
						},
						new RegionModel
						{
							Name = "Midland",
							Code = null
						},
						new RegionModel
						{
							Name = "South Town",
							Code = null
						},
						new RegionModel
						{
							Name = "Spot Bay",
							Code = null
						},
						new RegionModel
						{
							Name = "Stake Bay",
							Code = null
						},
						new RegionModel
						{
							Name = "West End",
							Code = null
						},
						new RegionModel
						{
							Name = "Western",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Central African Republic",
					Code = "CF",
					NativeName = "Ködörösêse tî Bêafrîka , République centrafricaine",
					PhoneCode = "+236",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bamingui-Bangoran",
							Code = "BB"
						},
						new RegionModel
						{
							Name = "Bangui",
							Code = "BGF"
						},
						new RegionModel
						{
							Name = "Basse-Kotto",
							Code = "BK"
						},
						new RegionModel
						{
							Name = "Haute-Kotto",
							Code = "HK"
						},
						new RegionModel
						{
							Name = "Haut-Mbomou",
							Code = "HM"
						},
						new RegionModel
						{
							Name = "Kémo",
							Code = "KG"
						},
						new RegionModel
						{
							Name = "Lobaye",
							Code = "LB"
						},
						new RegionModel
						{
							Name = "Mambéré-Kadéï",
							Code = "HS"
						},
						new RegionModel
						{
							Name = "Mbomou",
							Code = "MB"
						},
						new RegionModel
						{
							Name = "Nana-Grebizi",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Nana-Mambéré",
							Code = "NM"
						},
						new RegionModel
						{
							Name = "Ombella-M'Poko",
							Code = "MP"
						},
						new RegionModel
						{
							Name = "Ouaka",
							Code = "UK"
						},
						new RegionModel
						{
							Name = "Ouham",
							Code = "AC"
						},
						new RegionModel
						{
							Name = "Ouham Péndé",
							Code = "OP"
						},
						new RegionModel
						{
							Name = "Sangha-Mbaéré",
							Code = "SE"
						},
						new RegionModel
						{
							Name = "Vakaga",
							Code = "VK"
						}
					}
				},
				new CountryModel
				{
					Name = "Chad",
					Code = "TD",
					NativeName = "Tchad , جمهورية تشاد ",
					PhoneCode = "+235",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bahr el Ghazal",
							Code = "BG"
						},
						new RegionModel
						{
							Name = "Batha",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Borkou",
							Code = "BO"
						},
						new RegionModel
						{
							Name = "Chari-Baguirmi",
							Code = "CB"
						},
						new RegionModel
						{
							Name = "Ennedi-Est",
							Code = "EE"
						},
						new RegionModel
						{
							Name = "Ennedi-Ouest",
							Code = "EO"
						},
						new RegionModel
						{
							Name = "Guéra",
							Code = "GR"
						},
						new RegionModel
						{
							Name = "Hadjer Lamis",
							Code = "HL"
						},
						new RegionModel
						{
							Name = "Kanem",
							Code = "KA"
						},
						new RegionModel
						{
							Name = "Lac",
							Code = "LC"
						},
						new RegionModel
						{
							Name = "Logone Occidental",
							Code = "LO"
						},
						new RegionModel
						{
							Name = "Logone Oriental",
							Code = "LR"
						},
						new RegionModel
						{
							Name = "Mondoul",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Mayo-Kébbi-Est",
							Code = "ME"
						},
						new RegionModel
						{
							Name = "Moyen-Chari",
							Code = "MC"
						},
						new RegionModel
						{
							Name = "Ouaddai",
							Code = "OD"
						},
						new RegionModel
						{
							Name = "Salamat",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "Sila",
							Code = "SI"
						},
						new RegionModel
						{
							Name = "Tandjilé",
							Code = "TA"
						},
						new RegionModel
						{
							Name = "Tibesti",
							Code = "TI"
						},
						new RegionModel
						{
							Name = "Ville de Ndjamena",
							Code = "ND"
						},
						new RegionModel
						{
							Name = "Wadi Fira",
							Code = "WF"
						}
					}
				},
				new CountryModel
				{
					Name = "Chile",
					Code = "CL",
					NativeName = "",
					PhoneCode = "+56",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aisén del General Carlos Ibáñez del Campo",
							Code = "AI"
						},
						new RegionModel
						{
							Name = "Antofagasta",
							Code = "AN"
						},
						new RegionModel
						{
							Name = "Araucanía",
							Code = "AR"
						},
						new RegionModel
						{
							Name = "Arica y Parinacota",
							Code = "AP"
						},
						new RegionModel
						{
							Name = "Atacama",
							Code = "AT"
						},
						new RegionModel
						{
							Name = "Bío-Bío",
							Code = "BI"
						},
						new RegionModel
						{
							Name = "Coquimbo",
							Code = "CO"
						},
						new RegionModel
						{
							Name = "Libertador General Bernardo O'Higgins",
							Code = "LI"
						},
						new RegionModel
						{
							Name = "Los Lagos",
							Code = "LL"
						},
						new RegionModel
						{
							Name = "Los Ríos",
							Code = "LR"
						},
						new RegionModel
						{
							Name = "Magallanes y Antartica Chilena",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Marga-Marga",
							Code = ""
						},
						new RegionModel
						{
							Name = "Maule",
							Code = "ML"
						},
						new RegionModel
						{
							Name = "Ñuble",
							Code = "NB"
						},
						new RegionModel
						{
							Name = "Región Metropolitana de Santiago",
							Code = "RM"
						},
						new RegionModel
						{
							Name = "Tarapacá",
							Code = "TA"
						},
						new RegionModel
						{
							Name = "Valparaíso",
							Code = "VS"
						}
					}
				},
				new CountryModel
				{
					Name = "China",
					Code = "CN",
					NativeName = "中华人民共和国",
					PhoneCode = "+86",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Anhui",
							Code = "AH"
						},
						new RegionModel
						{
							Name = "Beijing",
							Code = "BJ"
						},
						new RegionModel
						{
							Name = "Chongqing",
							Code = "CQ"
						},
						new RegionModel
						{
							Name = "Fujian",
							Code = "FJ"
						},
						new RegionModel
						{
							Name = "Gansu",
							Code = "GS"
						},
						new RegionModel
						{
							Name = "Guangdong",
							Code = "GD"
						},
						new RegionModel
						{
							Name = "Guangxi",
							Code = "GX"
						},
						new RegionModel
						{
							Name = "Guizhou",
							Code = "GZ"
						},
						new RegionModel
						{
							Name = "Hainan",
							Code = "HI"
						},
						new RegionModel
						{
							Name = "Hebei",
							Code = "HE"
						},
						new RegionModel
						{
							Name = "Heilongjiang",
							Code = "HL"
						},
						new RegionModel
						{
							Name = "Henan",
							Code = "HA"
						},
						new RegionModel
						{
							Name = "Hong Kong",
							Code = "HK"
						},
						new RegionModel
						{
							Name = "Hubei",
							Code = "HB"
						},
						new RegionModel
						{
							Name = "Hunan",
							Code = "HN"
						},
						new RegionModel
						{
							Name = "Inner Mongolia",
							Code = "NM"
						},
						new RegionModel
						{
							Name = "Jiangsu",
							Code = "JS"
						},
						new RegionModel
						{
							Name = "Jiangxi",
							Code = "JX"
						},
						new RegionModel
						{
							Name = "Jilin",
							Code = "JL"
						},
						new RegionModel
						{
							Name = "Liaoning",
							Code = "LN"
						},
						new RegionModel
						{
							Name = "Macau",
							Code = "MO"
						},
						new RegionModel
						{
							Name = "Ningxia",
							Code = "NX"
						},
						new RegionModel
						{
							Name = "Qinghai",
							Code = "QH"
						},
						new RegionModel
						{
							Name = "Shaanxi",
							Code = "SN"
						},
						new RegionModel
						{
							Name = "Shandong",
							Code = "SD"
						},
						new RegionModel
						{
							Name = "Shanghai",
							Code = "SH"
						},
						new RegionModel
						{
							Name = "Shanxi",
							Code = "SX"
						},
						new RegionModel
						{
							Name = "Sichuan",
							Code = "SC"
						},
						new RegionModel
						{
							Name = "Tianjin",
							Code = "TJ"
						},
						new RegionModel
						{
							Name = "Tibet",
							Code = "XZ"
						},
						new RegionModel
						{
							Name = "Xinjiang",
							Code = "XJ"
						},
						new RegionModel
						{
							Name = "Yunnan",
							Code = "YN"
						},
						new RegionModel
						{
							Name = "Zhejiang",
							Code = "ZJ"
						}
					}
				},
				new CountryModel
				{
					Name = "Christmas Island",
					Code = "CX",
					NativeName = "",
					PhoneCode = "+61",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Christmas Island",
							Code = "CX"
						}
					}
				},
				new CountryModel
				{
					Name = "Cocos (Keeling) Islands",
					Code = "CC",
					NativeName = "Pulu Kokos (Keeling) , Wilayah Kepulauan Cocos (Keeling)",
					PhoneCode = "+851",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Direction Island",
							Code = "DI"
						},
						new RegionModel
						{
							Name = "Home Island",
							Code = "HM"
						},
						new RegionModel
						{
							Name = "Horsburgh Island",
							Code = "HR"
						},
						new RegionModel
						{
							Name = "North Keeling Island",
							Code = "NK"
						},
						new RegionModel
						{
							Name = "South Island",
							Code = "SI"
						},
						new RegionModel
						{
							Name = "West Island",
							Code = "WI"
						}
					}
				},
				new CountryModel
				{
					Name = "Cocos (Keeling) Islands",
					Code = "CC",
					NativeName = "Pulu Kokos (Keeling) , Wilayah Kepulauan Cocos (Keeling)",
					PhoneCode = "+891",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Direction Island",
							Code = "DI"
						},
						new RegionModel
						{
							Name = "Home Island",
							Code = "HM"
						},
						new RegionModel
						{
							Name = "Horsburgh Island",
							Code = "HR"
						},
						new RegionModel
						{
							Name = "North Keeling Island",
							Code = "NK"
						},
						new RegionModel
						{
							Name = "South Island",
							Code = "SI"
						},
						new RegionModel
						{
							Name = "West Island",
							Code = "WI"
						}
					}
				},
				new CountryModel
				{
					Name = "Colombia",
					Code = "CO",
					NativeName = "",
					PhoneCode = "+57",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Amazonas",
							Code = "AMA"
						},
						new RegionModel
						{
							Name = "Antioquia",
							Code = "ANT"
						},
						new RegionModel
						{
							Name = "Arauca",
							Code = "ARA"
						},
						new RegionModel
						{
							Name = "Archipiélago de San Andrés",
							Code = "SAP"
						},
						new RegionModel
						{
							Name = "Atlántico",
							Code = "ATL"
						},
						new RegionModel
						{
							Name = "Bogotá D.C.",
							Code = "DC"
						},
						new RegionModel
						{
							Name = "Bolívar",
							Code = "BOL"
						},
						new RegionModel
						{
							Name = "Boyacá",
							Code = "BOY"
						},
						new RegionModel
						{
							Name = "Caldas",
							Code = "CAL"
						},
						new RegionModel
						{
							Name = "Caquetá",
							Code = "CAQ"
						},
						new RegionModel
						{
							Name = "Casanare",
							Code = "CAS"
						},
						new RegionModel
						{
							Name = "Cauca",
							Code = "CAU"
						},
						new RegionModel
						{
							Name = "Cesar",
							Code = "CES"
						},
						new RegionModel
						{
							Name = "Chocó",
							Code = "CHO"
						},
						new RegionModel
						{
							Name = "Córdoba",
							Code = "COR"
						},
						new RegionModel
						{
							Name = "Cundinamarca",
							Code = "CUN"
						},
						new RegionModel
						{
							Name = "Guainía",
							Code = "GUA"
						},
						new RegionModel
						{
							Name = "Guaviare",
							Code = "GUV"
						},
						new RegionModel
						{
							Name = "Huila",
							Code = "HUI"
						},
						new RegionModel
						{
							Name = "La Guajira",
							Code = "LAG"
						},
						new RegionModel
						{
							Name = "Magdalena",
							Code = "MAG"
						},
						new RegionModel
						{
							Name = "Meta",
							Code = "MET"
						},
						new RegionModel
						{
							Name = "Nariño",
							Code = "NAR"
						},
						new RegionModel
						{
							Name = "Norte de Santander",
							Code = "NSA"
						},
						new RegionModel
						{
							Name = "Putumayo",
							Code = "PUT"
						},
						new RegionModel
						{
							Name = "Quindío",
							Code = "QUI"
						},
						new RegionModel
						{
							Name = "Risaralda",
							Code = "RIS"
						},
						new RegionModel
						{
							Name = "Santander",
							Code = "SAN"
						},
						new RegionModel
						{
							Name = "Sucre",
							Code = "SUC"
						},
						new RegionModel
						{
							Name = "Tolima",
							Code = "TOL"
						},
						new RegionModel
						{
							Name = "Valle del Cauca",
							Code = "VAC"
						},
						new RegionModel
						{
							Name = "Vaupés",
							Code = "VAU"
						},
						new RegionModel
						{
							Name = "Vichada",
							Code = "VID"
						}
					}
				},
				new CountryModel
				{
					Name = "Comoros",
					Code = "KM",
					NativeName = "Komori , Comores , الاتحاد القمري ",
					PhoneCode = "+269",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Andjazîdja",
							Code = "G"
						},
						new RegionModel
						{
							Name = "Andjouân",
							Code = "A"
						},
						new RegionModel
						{
							Name = "Moûhîlî",
							Code = "M"
						}
					}
				},
				new CountryModel
				{
					Name = "Congo, Republic of the (Brazzaville)",
					Code = "CG",
					NativeName = "",
					PhoneCode = "+242",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bouenza",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Brazzaville",
							Code = "BZV"
						},
						new RegionModel
						{
							Name = "Cuvette",
							Code = "8"
						},
						new RegionModel
						{
							Name = "Cuvette-Ouest",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Kouilou",
							Code = "5"
						},
						new RegionModel
						{
							Name = "Lékoumou",
							Code = "2"
						},
						new RegionModel
						{
							Name = "Likouala",
							Code = "7"
						},
						new RegionModel
						{
							Name = "Niari",
							Code = "9"
						},
						new RegionModel
						{
							Name = "Plateaux",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Pointe-Noire",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Pool",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Sangha",
							Code = "13"
						}
					}
				},
				new CountryModel
				{
					Name = "Congo, the Democratic Republic of the (Kinshasa)",
					Code = "CD",
					NativeName = "République démocratique du Congo , Repubilika ya Kôngo ya Dimokalasi , Republiki ya Kɔ́ngɔ Demokratiki , Jamhuri ya Kidemokrasia ya Kongo , Ditunga dia Kongu wa Mungalaata",
					PhoneCode = "+243",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bandundu",
							Code = "BN"
						},
						new RegionModel
						{
							Name = "Bas-Congo",
							Code = "BC"
						},
						new RegionModel
						{
							Name = "Équateur",
							Code = "EQ"
						},
						new RegionModel
						{
							Name = "Kasaï-Occidental",
							Code = "KE"
						},
						new RegionModel
						{
							Name = "Kasaï-Oriental",
							Code = "KW"
						},
						new RegionModel
						{
							Name = "Katanga",
							Code = "KA"
						},
						new RegionModel
						{
							Name = "Kinshasa",
							Code = "KN"
						},
						new RegionModel
						{
							Name = "Maniema",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Nord-Kivu",
							Code = "NK"
						},
						new RegionModel
						{
							Name = "Orientale",
							Code = "OR"
						},
						new RegionModel
						{
							Name = "Sud-Kivu",
							Code = "SK"
						}
					}
				},
				new CountryModel
				{
					Name = "Cook Islands",
					Code = "CK",
					NativeName = "Kuki ’Āirani",
					PhoneCode = "+682",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aitutaki",
							Code = null
						},
						new RegionModel
						{
							Name = "Atiu",
							Code = null
						},
						new RegionModel
						{
							Name = "Avarua",
							Code = null
						},
						new RegionModel
						{
							Name = "Mangaia",
							Code = null
						},
						new RegionModel
						{
							Name = "Manihiki",
							Code = null
						},
						new RegionModel
						{
							Name = "Ma'uke",
							Code = null
						},
						new RegionModel
						{
							Name = "Mitiaro",
							Code = null
						},
						new RegionModel
						{
							Name = "Nassau",
							Code = null
						},
						new RegionModel
						{
							Name = "Palmerston",
							Code = null
						},
						new RegionModel
						{
							Name = "Penrhyn",
							Code = null
						},
						new RegionModel
						{
							Name = "Pukapuka",
							Code = null
						},
						new RegionModel
						{
							Name = "Rakahanga",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Costa Rica",
					Code = "CR",
					NativeName = "",
					PhoneCode = "+506",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Alajuela",
							Code = "2"
						},
						new RegionModel
						{
							Name = "Cartago",
							Code = "3"
						},
						new RegionModel
						{
							Name = "Guanacaste",
							Code = "5"
						},
						new RegionModel
						{
							Name = "Heredia",
							Code = "4"
						},
						new RegionModel
						{
							Name = "Limón",
							Code = "7"
						},
						new RegionModel
						{
							Name = "Puntarenas",
							Code = "6"
						},
						new RegionModel
						{
							Name = "San José",
							Code = "1"
						}
					}
				},
				new CountryModel
				{
					Name = "Cote d'Ivoire",
					Code = "CI",
					NativeName = "Côte d’Ivoire",
					PhoneCode = "+225",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Agnéby",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Bafing",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Bas-Sassandra",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Denguélé",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Dix-Huit Montagnes",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Fromager",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Haut-Sassandra",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Lacs",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Lagunes",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Marahoué",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Moyen-Cavally",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Moyen-Comoé",
							Code = "05"
						},
						new RegionModel
						{
							Name = "N'zi-Comoé",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Savanes",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Sud-Bandama",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Sud-Comoé",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Vallée du Bandama",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Worodougou",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Zanzan",
							Code = "08"
						}
					}
				},
				new CountryModel
				{
					Name = "Croatia",
					Code = "HR",
					NativeName = "Hrvatska",
					PhoneCode = "+385",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bjelovarsko-bilogorska županija",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Brodsko-posavska županija",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Dubrovačko-neretvanska županija",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Grad Zagreb",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Istarska županija",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Karlovačka županija",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Koprivničko-križevačka županija",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Krapinsko-zagorska županija",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Ličko-senjska županija",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Međimurska županija",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Osječko-baranjska županija",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Požeško-slavonska županija",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Primorsko-goranska županija",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Sisačko-moslavačka županija",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Splitsko-dalmatinska županija",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Šibensko-kninska županija",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Varaždinska županija",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Virovitičko-podravska županija",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Vukovarsko-srijemska županija",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Zadarska županija",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Zagrebačka županija",
							Code = "01"
						}
					}
				},
				new CountryModel
				{
					Name = "Cuba",
					Code = "CU",
					NativeName = "",
					PhoneCode = "+53",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Artemisa",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Camagüey",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Ciego de Ávila",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Cienfuegos",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Granma",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Guantánamo",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Holguín",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Isla de la Juventud",
							Code = "99"
						},
						new RegionModel
						{
							Name = "La Habana",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Las Tunas",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Matanzas",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Mayabeque",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Pinar del Río",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Sancti Spíritus",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Santiago de Cuba",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Villa Clara",
							Code = "05"
						}
					}
				},
				new CountryModel
				{
					Name = "Curaçao",
					Code = "CW",
					NativeName = "Curazao , Curaçao",
					PhoneCode = "+599",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Curaçao",
							Code = "CW"
						}
					}
				},
				new CountryModel
				{
					Name = "Cyprus",
					Code = "CY",
					NativeName = "Κύπρος , Kıbrıs",
					PhoneCode = "+357",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ammochostos",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Keryneia",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Larnaka",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Lefkosia",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Lemesos",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Pafos",
							Code = "05"
						}
					}
				},
				new CountryModel
				{
					Name = "Czech Republic",
					Code = "CZ",
					NativeName = "Česká republika",
					PhoneCode = "+420",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Hlavní město Praha",
							Code = "PR"
						},
						new RegionModel
						{
							Name = "Jihočeský kraj",
							Code = "JC"
						},
						new RegionModel
						{
							Name = "Jihomoravský kraj",
							Code = "JM"
						},
						new RegionModel
						{
							Name = "Karlovarský kraj",
							Code = "KA"
						},
						new RegionModel
						{
							Name = "Královéhradecký kraj",
							Code = "KR"
						},
						new RegionModel
						{
							Name = "Liberecký kraj",
							Code = "LI"
						},
						new RegionModel
						{
							Name = "Moravskoslezský kraj",
							Code = "MO"
						},
						new RegionModel
						{
							Name = "Olomoucký kraj",
							Code = "OL"
						},
						new RegionModel
						{
							Name = "Pardubický kraj",
							Code = "PA"
						},
						new RegionModel
						{
							Name = "Plzeňský kraj",
							Code = "PL"
						},
						new RegionModel
						{
							Name = "Středočeský kraj",
							Code = "ST"
						},
						new RegionModel
						{
							Name = "Ústecký kraj",
							Code = "US"
						},
						new RegionModel
						{
							Name = "Vysočina",
							Code = "VY"
						},
						new RegionModel
						{
							Name = "Zlínský kraj",
							Code = "ZL"
						}
					}
				},
				#endregion
				
				#region D
				new CountryModel
				{
					Name = "Denmark",
					Code = "DK",
					NativeName = "Danmark",
					PhoneCode = "+45",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Hovedstaden",
							Code = "84"
						},
						new RegionModel
						{
							Name = "Kujalleq",
							Code = "GL-KU"
						},
						new RegionModel
						{
							Name = "Midtjylland",
							Code = "82"
						},
						new RegionModel
						{
							Name = "Norderøerne",
							Code = "FO-01"
						},
						new RegionModel
						{
							Name = "Nordjylland",
							Code = "81"
						},
						new RegionModel
						{
							Name = "Østerø",
							Code = "FO-06"
						},
						new RegionModel
						{
							Name = "Qaasuitsup",
							Code = "GL-QA"
						},
						new RegionModel
						{
							Name = "Qeqqata",
							Code = "GL-QE"
						},
						new RegionModel
						{
							Name = "Sandø",
							Code = "FO-02"
						},
						new RegionModel
						{
							Name = "Sermersooq",
							Code = "GL-SM"
						},
						new RegionModel
						{
							Name = "Sjælland",
							Code = "85"
						},
						new RegionModel
						{
							Name = "Strømø",
							Code = "FO-03"
						},
						new RegionModel
						{
							Name = "Suderø",
							Code = "FO-04"
						},
						new RegionModel
						{
							Name = "Syddanmark",
							Code = "83"
						},
						new RegionModel
						{
							Name = "Vågø",
							Code = "FO-05"
						}
					}
				},
				new CountryModel
				{
					Name = "Djibouti",
					Code = "DJ",
					NativeName = "Gabuutih Ummuuno , Jabuuti , جمهورية جيبوتي ",
					PhoneCode = "+253",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ali Sabieh",
							Code = "AS"
						},
						new RegionModel
						{
							Name = "Arta",
							Code = "AR"
						},
						new RegionModel
						{
							Name = "Dikhil",
							Code = "DI"
						},
						new RegionModel
						{
							Name = "Obock",
							Code = "OB"
						},
						new RegionModel
						{
							Name = "Tadjourah",
							Code = "TA"
						}
					}
				},
				new CountryModel
				{
					Name = "Dominica",
					Code = "DM",
					NativeName = "",
					PhoneCode = "+1",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Saint Andrew Parish",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Saint David Parish",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Saint George Parish",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Saint John Parish",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Saint Joseph Parish",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Saint Luke Parish",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Saint Mark Parish",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Saint Patrick Parish",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Saint Paul Parish",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Saint Peter Parish",
							Code = "11"
						}
					}
				},
				new CountryModel
				{
					Name = "Dominican Republic",
					Code = "DO",
					NativeName = "República Dominicana",
					PhoneCode = "+1",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Cibao Central",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Del Valle",
							Code = "37"
						},
						new RegionModel
						{
							Name = "Distrito Nacional",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Enriquillo",
							Code = "38"
						},
						new RegionModel
						{
							Name = "Norcentral",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Nordeste",
							Code = "33"
						},
						new RegionModel
						{
							Name = "Noroeste",
							Code = "34"
						},
						new RegionModel
						{
							Name = "Norte",
							Code = "35"
						},
						new RegionModel
						{
							Name = "Valdesia",
							Code = "42"
						}
					}
				},
				#endregion
				
				#region E
				new CountryModel
				{
					Name = "Ecuador",
					Code = "EC",
					NativeName = "",
					PhoneCode = "+593",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Azuay",
							Code = "A"
						},
						new RegionModel
						{
							Name = "Bolívar",
							Code = "B"
						},
						new RegionModel
						{
							Name = "Cañar",
							Code = "F"
						},
						new RegionModel
						{
							Name = "Carchi",
							Code = "C"
						},
						new RegionModel
						{
							Name = "Chimborazo",
							Code = "H"
						},
						new RegionModel
						{
							Name = "Cotopaxi",
							Code = "X"
						},
						new RegionModel
						{
							Name = "El Oro",
							Code = "O"
						},
						new RegionModel
						{
							Name = "Esmeraldas",
							Code = "E"
						},
						new RegionModel
						{
							Name = "Galápagos",
							Code = "W"
						},
						new RegionModel
						{
							Name = "Guayas",
							Code = "G"
						},
						new RegionModel
						{
							Name = "Imbabura",
							Code = "I"
						},
						new RegionModel
						{
							Name = "Loja",
							Code = "L"
						},
						new RegionModel
						{
							Name = "Los Ríos",
							Code = "R"
						},
						new RegionModel
						{
							Name = "Manabí",
							Code = "M"
						},
						new RegionModel
						{
							Name = "Morona-Santiago",
							Code = "S"
						},
						new RegionModel
						{
							Name = "Napo",
							Code = "N"
						},
						new RegionModel
						{
							Name = "Orellana",
							Code = "D"
						},
						new RegionModel
						{
							Name = "Pastaza",
							Code = "Y"
						},
						new RegionModel
						{
							Name = "Pichincha",
							Code = "P"
						},
						new RegionModel
						{
							Name = "Santa Elena",
							Code = "SE"
						},
						new RegionModel
						{
							Name = "Santo Domingo de los Tsáchilas",
							Code = "SD"
						},
						new RegionModel
						{
							Name = "Sucumbíos",
							Code = "U"
						},
						new RegionModel
						{
							Name = "Tungurahua",
							Code = "T"
						},
						new RegionModel
						{
							Name = "Zamora-Chinchipe",
							Code = "Z"
						}
					}
				},
				new CountryModel
				{
					Name = "Egypt",
					Code = "EG",
					NativeName = "‎ مِصر ",
					PhoneCode = "+20",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Alexandria",
							Code = "ALX"
						},
						new RegionModel
						{
							Name = "Aswan",
							Code = "ASN"
						},
						new RegionModel
						{
							Name = "Asyout",
							Code = "AST"
						},
						new RegionModel
						{
							Name = "Bani Sueif",
							Code = "BNS"
						},
						new RegionModel
						{
							Name = "Beheira",
							Code = "BH"
						},
						new RegionModel
						{
							Name = "Cairo",
							Code = "C"
						},
						new RegionModel
						{
							Name = "Daqahlia",
							Code = "DK"
						},
						new RegionModel
						{
							Name = "Dumiat",
							Code = "DT"
						},
						new RegionModel
						{
							Name = "El Bahr El Ahmar",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "El Ismailia",
							Code = "IS"
						},
						new RegionModel
						{
							Name = "El Suez",
							Code = "SUZ"
						},
						new RegionModel
						{
							Name = "El Wadi El Gedeed",
							Code = "WAD"
						},
						new RegionModel
						{
							Name = "Fayoum",
							Code = "FYM"
						},
						new RegionModel
						{
							Name = "Gharbia",
							Code = "GH"
						},
						new RegionModel
						{
							Name = "Giza",
							Code = "GZ"
						},
						new RegionModel
						{
							Name = "Helwan",
							Code = "HU"
						},
						new RegionModel
						{
							Name = "Kafr El Sheikh",
							Code = "KFS"
						},
						new RegionModel
						{
							Name = "Luxor",
							Code = "LX"
						},
						new RegionModel
						{
							Name = "Matrouh",
							Code = "MT"
						},
						new RegionModel
						{
							Name = "Menia",
							Code = "MN"
						},
						new RegionModel
						{
							Name = "Menofia",
							Code = "MNF"
						},
						new RegionModel
						{
							Name = "North Sinai",
							Code = "SIN"
						},
						new RegionModel
						{
							Name = "Port Said",
							Code = "PTS"
						},
						new RegionModel
						{
							Name = "Qalubia",
							Code = "KB"
						},
						new RegionModel
						{
							Name = "Qena",
							Code = "KN"
						},
						new RegionModel
						{
							Name = "Sharqia",
							Code = "SHR"
						},
						new RegionModel
						{
							Name = "Sixth of October",
							Code = "SU"
						},
						new RegionModel
						{
							Name = "Sohag",
							Code = "SHG"
						},
						new RegionModel
						{
							Name = "South Sinai",
							Code = "JS"
						}
					}
				},
				new CountryModel
				{
					Name = "El Salvador",
					Code = "SV",
					NativeName = "",
					PhoneCode = "+503",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ahuachapán",
							Code = "AH"
						},
						new RegionModel
						{
							Name = "Cabañas",
							Code = "CA"
						},
						new RegionModel
						{
							Name = "Cuscatlán",
							Code = "CU"
						},
						new RegionModel
						{
							Name = "Chalatenango",
							Code = "CH"
						},
						new RegionModel
						{
							Name = "La Libertad",
							Code = "LI"
						},
						new RegionModel
						{
							Name = "La Paz",
							Code = "PA"
						},
						new RegionModel
						{
							Name = "La Unión",
							Code = "UN"
						},
						new RegionModel
						{
							Name = "Morazán",
							Code = "MO"
						},
						new RegionModel
						{
							Name = "San Miguel",
							Code = "SM"
						},
						new RegionModel
						{
							Name = "San Salvador",
							Code = "SS"
						},
						new RegionModel
						{
							Name = "Santa Ana",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "San Vicente",
							Code = "SV"
						},
						new RegionModel
						{
							Name = "Sonsonate",
							Code = "SO"
						},
						new RegionModel
						{
							Name = "Usulután",
							Code = "US"
						}
					}
				},
				new CountryModel
				{
					Name = "Equatorial Guinea",
					Code = "GQ",
					NativeName = "Guinée équatoriale , Guiné Equatorial",
					PhoneCode = "+240",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Annobón",
							Code = "AN"
						},
						new RegionModel
						{
							Name = "Bioko Norte",
							Code = "BN"
						},
						new RegionModel
						{
							Name = "Bioko Sur",
							Code = "BS"
						},
						new RegionModel
						{
							Name = "Centro Sur",
							Code = "CS"
						},
						new RegionModel
						{
							Name = "Kié-Ntem",
							Code = "KN"
						},
						new RegionModel
						{
							Name = "Litoral",
							Code = "LI"
						},
						new RegionModel
						{
							Name = "Wele-Nzas",
							Code = "WN"
						}
					}
				},
				new CountryModel
				{
					Name = "Eritrea",
					Code = "ER",
					NativeName = "ሃገረ ኤርትራ , دولة إرتريا  ",
					PhoneCode = "+291",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Anseba",
							Code = "AN"
						},
						new RegionModel
						{
							Name = "Debub",
							Code = "DU"
						},
						new RegionModel
						{
							Name = "Debub-Keih-Bahri",
							Code = "DK"
						},
						new RegionModel
						{
							Name = "Gash-Barka",
							Code = "GB"
						},
						new RegionModel
						{
							Name = "Maekel",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Semien-Keih-Bahri",
							Code = "SK"
						}
					}
				},
				new CountryModel
				{
					Name = "Estonia",
					Code = "EE",
					NativeName = "Eesti Vabariik",
					PhoneCode = "+372",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Harjumaa (Tallinn)",
							Code = "37"
						},
						new RegionModel
						{
							Name = "Hiiumaa (Kardla)",
							Code = "39"
						},
						new RegionModel
						{
							Name = "Ida-Virumaa (Johvi)",
							Code = "44"
						},
						new RegionModel
						{
							Name = "Järvamaa (Paide)",
							Code = "41"
						},
						new RegionModel
						{
							Name = "Jõgevamaa (Jogeva)",
							Code = "49"
						},
						new RegionModel
						{
							Name = "Läänemaa",
							Code = "57"
						},
						new RegionModel
						{
							Name = "Lääne-Virumaa (Rakvere)",
							Code = "59"
						},
						new RegionModel
						{
							Name = "Pärnumaa (Parnu)",
							Code = "67"
						},
						new RegionModel
						{
							Name = "Põlvamaa (Polva)",
							Code = "65"
						},
						new RegionModel
						{
							Name = "Raplamaa (Rapla)",
							Code = "70"
						},
						new RegionModel
						{
							Name = "Saaremaa (Kuessaare)",
							Code = "74"
						},
						new RegionModel
						{
							Name = "Tartumaa (Tartu)",
							Code = "78"
						},
						new RegionModel
						{
							Name = "Valgamaa (Valga)",
							Code = "82"
						},
						new RegionModel
						{
							Name = "Viljandimaa (Viljandi)",
							Code = "84"
						},
						new RegionModel
						{
							Name = "Võrumaa (Voru)",
							Code = "86"
						}
					}
				},
				new CountryModel
				{
					Name = "Ethiopia",
					Code = "ET",
					NativeName = "የኢትዮጵያ ፌዴራላዊ ዴሞክራሲያዊ ሪፐብሊክ",
					PhoneCode = "+251",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Addis Ababa",
							Code = "AA"
						},
						new RegionModel
						{
							Name = "Afar",
							Code = "AF"
						},
						new RegionModel
						{
							Name = "Amhara",
							Code = "AM"
						},
						new RegionModel
						{
							Name = "Benshangul-Gumaz",
							Code = "BE"
						},
						new RegionModel
						{
							Name = "Dire Dawa",
							Code = "DD"
						},
						new RegionModel
						{
							Name = "Gambela",
							Code = "GA"
						},
						new RegionModel
						{
							Name = "Harari",
							Code = "HA"
						},
						new RegionModel
						{
							Name = "Oromia",
							Code = "OR"
						},
						new RegionModel
						{
							Name = "Somali",
							Code = "SO"
						},
						new RegionModel
						{
							Name = "Southern Nations Nationalities and People's Region",
							Code = "SN"
						},
						new RegionModel
						{
							Name = "Tigray",
							Code = "TI"
						}
					}
				},
				#endregion
				
				#region F
				new CountryModel
				{
					Name = "Falkland Islands (Islas Malvinas)",
					Code = "FK",
					NativeName = "",
					PhoneCode = "+500",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Falkland Islands (Islas Malvinas)",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Faroe Islands",
					Code = "FO",
					NativeName = "Færøerne , Føroyar",
					PhoneCode = "+298",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bordoy",
							Code = null
						},
						new RegionModel
						{
							Name = "Eysturoy",
							Code = null
						},
						new RegionModel
						{
							Name = "Mykines",
							Code = null
						},
						new RegionModel
						{
							Name = "Sandoy",
							Code = null
						},
						new RegionModel
						{
							Name = "Skuvoy",
							Code = null
						},
						new RegionModel
						{
							Name = "Streymoy",
							Code = null
						},
						new RegionModel
						{
							Name = "Suduroy",
							Code = null
						},
						new RegionModel
						{
							Name = "Tvoroyri",
							Code = null
						},
						new RegionModel
						{
							Name = "Vagar",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Fiji",
					Code = "FJ",
					NativeName = "Matanitu Tugalala o Viti , फ़िजी गणराज्य",
					PhoneCode = "+679",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ba",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Bua",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Cakaudrove",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Kadavu",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Lau",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Lomaiviti",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Macuata",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Nadroga and Navosa",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Naitasiri",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Namosi",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Ra",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Rewa",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Rotuma",
							Code = "R"
						},
						new RegionModel
						{
							Name = "Serua",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Tailevu",
							Code = "14"
						}
					}
				},
				new CountryModel
				{
					Name = "Finland",
					Code = "FI",
					NativeName = "Suomen ",
					PhoneCode = "+358",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ahvenanmaan maakunta",
							Code = "FI-01"
						},
						new RegionModel
						{
							Name = "Etelä-Karjala",
							Code = "FI-02"
						},
						new RegionModel
						{
							Name = "Etelä-Pohjanmaa",
							Code = "FI-03"
						},
						new RegionModel
						{
							Name = "Etelä-Savo",
							Code = "FI-04"
						},
						new RegionModel
						{
							Name = "Kainuu",
							Code = "FI-05"
						},
						new RegionModel
						{
							Name = "Kanta-Häme",
							Code = "FI-06"
						},
						new RegionModel
						{
							Name = "Keski-Pohjanmaa",
							Code = "FI-07"
						},
						new RegionModel
						{
							Name = "Keski-Suomi",
							Code = "FI-08"
						},
						new RegionModel
						{
							Name = "Kymenlaakso",
							Code = "FI-09"
						},
						new RegionModel
						{
							Name = "Lappi",
							Code = "FI-10"
						},
						new RegionModel
						{
							Name = "Pirkanmaa",
							Code = "FI-11"
						},
						new RegionModel
						{
							Name = "Pohjanmaa",
							Code = "FI-12"
						},
						new RegionModel
						{
							Name = "Pohjois-Karjala",
							Code = "FI-13"
						},
						new RegionModel
						{
							Name = "Pohjois-Pohjanmaa",
							Code = "FI-14"
						},
						new RegionModel
						{
							Name = "Pohjois-Savo",
							Code = "FI-15"
						},
						new RegionModel
						{
							Name = "Päijät-Häme",
							Code = "FI-16"
						},
						new RegionModel
						{
							Name = "Satakunta",
							Code = "FI-17"
						},
						new RegionModel
						{
							Name = "Uusimaa",
							Code = "FI-18"
						},
						new RegionModel
						{
							Name = "Varsinais-Suomi",
							Code = "FI-19"
						}
					}
				},
				new CountryModel
				{
					Name = "France",
					Code = "FR",
					NativeName = "",
					PhoneCode = "+33",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Auvergne-Rhône-Alpes",
							Code = "ARA"
						},
						new RegionModel
						{
							Name = "Bourgogne-Franche-Comté",
							Code = "BFC"
						},
						new RegionModel
						{
							Name = "Bretagne",
							Code = "BRE"
						},
						new RegionModel
						{
							Name = "Centre-Val de Loire",
							Code = "CVL"
						},
						new RegionModel
						{
							Name = "Corse",
							Code = "COR"
						},
						new RegionModel
						{
							Name = "Grand Est",
							Code = "GES"
						},
						new RegionModel
						{
							Name = "Hauts-de-France",
							Code = "HDF"
						},
						new RegionModel
						{
							Name = "Île-de-France",
							Code = "IDF"
						},
						new RegionModel
						{
							Name = "Normandie",
							Code = "NOR"
						},
						new RegionModel
						{
							Name = "Nouvelle-Aquitaine",
							Code = "NAQ"
						},
						new RegionModel
						{
							Name = "Occitanie",
							Code = "OCC"
						},
						new RegionModel
						{
							Name = "Pays de la Loire",
							Code = "PDL"
						},
						new RegionModel
						{
							Name = "Provence-Alpes-Cote d'Azur",
							Code = "PAC"
						},
						new RegionModel
						{
							Name = "Clipperton",
							Code = "CP"
						},
						new RegionModel
						{
							Name = "Guadeloupe",
							Code = "GP"
						},
						new RegionModel
						{
							Name = "Guyane",
							Code = "GF"
						},
						new RegionModel
						{
							Name = "Martinique",
							Code = "MQ"
						},
						new RegionModel
						{
							Name = "Mayotte",
							Code = "YT"
						},
						new RegionModel
						{
							Name = "Nouvelle-Calédonie",
							Code = "NC"
						},
						new RegionModel
						{
							Name = "Polynésie",
							Code = "PF"
						},
						new RegionModel
						{
							Name = "Saint-Pierre-et-Miquelon",
							Code = "PM"
						},
						new RegionModel
						{
							Name = "Saint Barthélemy",
							Code = "BL"
						},
						new RegionModel
						{
							Name = "Saint Martin",
							Code = "MF"
						},
						new RegionModel
						{
							Name = "Réunion",
							Code = "RE"
						},
						new RegionModel
						{
							Name = "Terres Australes Françaises",
							Code = "TF"
						},
						new RegionModel
						{
							Name = "Wallis-et-Futuna",
							Code = "WF"
						}
					}
				},
				new CountryModel
				{
					Name = "French Guiana",
					Code = "GF",
					NativeName = "Guyane Française",
					PhoneCode = "+594",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "French Guiana",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "French Polynesia",
					Code = "PF",
					NativeName = "Polynésie Française , Porinetia Farani",
					PhoneCode = "+689",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Archipel des Marquises",
							Code = null
						},
						new RegionModel
						{
							Name = "Archipel des Tuamotu",
							Code = null
						},
						new RegionModel
						{
							Name = "Archipel des Tubuai",
							Code = null
						},
						new RegionModel
						{
							Name = "Iles du Vent",
							Code = null
						},
						new RegionModel
						{
							Name = "Iles Sous-le-Vent",
							Code = null
						}
					}
				},
				#endregion
				
				#region G
				new CountryModel
				{
					Name = "Gabon",
					Code = "GA",
					NativeName = "",
					PhoneCode = "+241",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Estuaire",
							Code = "1"
						},
						new RegionModel
						{
							Name = "Haut-Ogooué",
							Code = "2"
						},
						new RegionModel
						{
							Name = "Moyen-Ogooué",
							Code = "3"
						},
						new RegionModel
						{
							Name = "Ngounié",
							Code = "4"
						},
						new RegionModel
						{
							Name = "Nyanga",
							Code = "5"
						},
						new RegionModel
						{
							Name = "Ogooué-Ivindo",
							Code = "6"
						},
						new RegionModel
						{
							Name = "Ogooué-Lolo",
							Code = "7"
						},
						new RegionModel
						{
							Name = "Ogooué-Maritime",
							Code = "8"
						},
						new RegionModel
						{
							Name = "Woleu-Ntem",
							Code = "9"
						}
					}
				},
				new CountryModel
				{
					Name = "Gambia",
					Code = "GM",
					NativeName = "",
					PhoneCode = "+220",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Banjul",
							Code = "B"
						},
						new RegionModel
						{
							Name = "Central River",
							Code = "M"
						},
						new RegionModel
						{
							Name = "Lower River",
							Code = "L"
						},
						new RegionModel
						{
							Name = "North Bank",
							Code = "N"
						},
						new RegionModel
						{
							Name = "Upper River",
							Code = "U"
						},
						new RegionModel
						{
							Name = "Western",
							Code = "W"
						}
					}
				},
				new CountryModel
				{
					Name = "Georgia",
					Code = "GE",
					NativeName = "საქართველო",
					PhoneCode = "+995",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Abkhazia (Sokhumi)",
							Code = "AB"
						},
						new RegionModel
						{
							Name = "Ajaria (Bat'umi)",
							Code = "AJ"
						},
						new RegionModel
						{
							Name = "Guria",
							Code = "GU"
						},
						new RegionModel
						{
							Name = "Imereti",
							Code = "IM"
						},
						new RegionModel
						{
							Name = "K'akheti",
							Code = "KA"
						},
						new RegionModel
						{
							Name = "Kvemo Kartli",
							Code = "KK"
						},
						new RegionModel
						{
							Name = "Mtshkheta-Mtianeti",
							Code = "MM"
						},
						new RegionModel
						{
							Name = "Rach'a-Lexhkumi-KvemoSvaneti",
							Code = "RL"
						},
						new RegionModel
						{
							Name = "Samegrelo-Zemo Svaneti",
							Code = "SZ"
						},
						new RegionModel
						{
							Name = "Samtskhe-Javakheti",
							Code = "SJ"
						},
						new RegionModel
						{
							Name = "Shida Kartli",
							Code = "SK"
						},
						new RegionModel
						{
							Name = "Tbilisi",
							Code = "TB"
						}
					}
				},
				new CountryModel
				{
					Name = "Germany",
					Code = "DE",
					NativeName = "Deutschland",
					PhoneCode = "+49",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Baden-Württemberg",
							Code = "BW"
						},
						new RegionModel
						{
							Name = "Bayern",
							Code = "BY"
						},
						new RegionModel
						{
							Name = "Berlin",
							Code = "BE"
						},
						new RegionModel
						{
							Name = "Brandenburg",
							Code = "BB"
						},
						new RegionModel
						{
							Name = "Bremen",
							Code = "HB"
						},
						new RegionModel
						{
							Name = "Hamburg",
							Code = "HH"
						},
						new RegionModel
						{
							Name = "Hessen",
							Code = "HE"
						},
						new RegionModel
						{
							Name = "Mecklenburg-Vorpommern",
							Code = "MV"
						},
						new RegionModel
						{
							Name = "Niedersachsen",
							Code = "NI"
						},
						new RegionModel
						{
							Name = "Nordrhein-Westfalen",
							Code = "NW"
						},
						new RegionModel
						{
							Name = "Rheinland-Pfalz",
							Code = "RP"
						},
						new RegionModel
						{
							Name = "Saarland",
							Code = "SL"
						},
						new RegionModel
						{
							Name = "Sachsen",
							Code = "SN"
						},
						new RegionModel
						{
							Name = "Sachsen-Anhalt",
							Code = "ST"
						},
						new RegionModel
						{
							Name = "Schleswig-Holstein",
							Code = "SH"
						},
						new RegionModel
						{
							Name = "Thüringen",
							Code = "TH"
						}
					}
				},
				new CountryModel
				{
					Name = "Ghana",
					Code = "GH",
					NativeName = "",
					PhoneCode = "+233",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ahafo",
							Code = null
						},
						new RegionModel
						{
							Name = "Ashanti",
							Code = "AH"
						},
						new RegionModel
						{
							Name = "Bono",
							Code = null
						},
						new RegionModel
						{
							Name = "Bono East",
							Code = null
						},
						new RegionModel
						{
							Name = "Central",
							Code = "CP"
						},
						new RegionModel
						{
							Name = "Eastern",
							Code = "EP"
						},
						new RegionModel
						{
							Name = "Greater Accra",
							Code = "AA"
						},
						new RegionModel
						{
							Name = "Northern",
							Code = "NP"
						},
						new RegionModel
						{
							Name = "North East",
							Code = null
						},
						new RegionModel
						{
							Name = "Oti",
							Code = null
						},
						new RegionModel
						{
							Name = "Savannah",
							Code = null
						},
						new RegionModel
						{
							Name = "Upper East",
							Code = "UE"
						},
						new RegionModel
						{
							Name = "Upper West",
							Code = "UW"
						},
						new RegionModel
						{
							Name = "Volta",
							Code = "TV"
						},
						new RegionModel
						{
							Name = "Western",
							Code = "WP"
						},
						new RegionModel
						{
							Name = "Western North",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Gibraltar",
					Code = "GI",
					NativeName = "",
					PhoneCode = "+350",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Gibraltar",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Greece",
					Code = "GR",
					NativeName = "Ελλάδα",
					PhoneCode = "+30",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Anatolikí Makedonía kai Thráki",
							Code = "A"
						},
						new RegionModel
						{
							Name = "Attikḯ",
							Code = "I"
						},
						new RegionModel
						{
							Name = "Dytikí Elláda",
							Code = "G"
						},
						new RegionModel
						{
							Name = "Dytikí Makedonía",
							Code = "C"
						},
						new RegionModel
						{
							Name = "Ionía Nísia",
							Code = "F"
						},
						new RegionModel
						{
							Name = "Kentrikí Makedonía",
							Code = "B"
						},
						new RegionModel
						{
							Name = "Krítí",
							Code = "M"
						},
						new RegionModel
						{
							Name = "Notío Aigaío",
							Code = "L"
						},
						new RegionModel
						{
							Name = "Peloponnísos",
							Code = "J"
						},
						new RegionModel
						{
							Name = "Stereá Elláda",
							Code = "H"
						},
						new RegionModel
						{
							Name = "Thessalía",
							Code = "E"
						},
						new RegionModel
						{
							Name = "Voreío Aigaío",
							Code = "K"
						},
						new RegionModel
						{
							Name = "Ípeiros",
							Code = "D"
						},
						new RegionModel
						{
							Name = "Ágion Óros",
							Code = "69"
						}
					}
				},
				new CountryModel
				{
					Name = "Greenland",
					Code = "GL",
					NativeName = "Kalaallit Nunaat",
					PhoneCode = "+299",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Kommune Kujalleq",
							Code = "KU"
						},
						new RegionModel
						{
							Name = "Kommuneqarfik Sermersooq",
							Code = "SM"
						},
						new RegionModel
						{
							Name = "Qaasuitsup Kommunia",
							Code = "QA"
						},
						new RegionModel
						{
							Name = "Qeqqata Kommunia",
							Code = "QE"
						}
					}
				},
				new CountryModel
				{
					Name = "Grenada",
					Code = "GD",
					NativeName = "",
					PhoneCode = "+1 473",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Saint Andrew",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Saint David",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Saint George",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Saint John",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Saint Mark",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Saint Patrick",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Southern Grenadine Islands",
							Code = "10"
						}
					}
				},
				new CountryModel
				{
					Name = "Guadeloupe",
					Code = "GP",
					NativeName = "",
					PhoneCode = "+590",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Guadeloupe",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Guam",
					Code = "GU",
					NativeName = "Guåhån",
					PhoneCode = "+1 671",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Guam",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Guatemala",
					Code = "GT",
					NativeName = "",
					PhoneCode = "+502",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Alta Verapaz",
							Code = "AV"
						},
						new RegionModel
						{
							Name = "Baja Verapaz",
							Code = "BV"
						},
						new RegionModel
						{
							Name = "Chimaltenango",
							Code = "CM"
						},
						new RegionModel
						{
							Name = "Chiquimula",
							Code = "CQ"
						},
						new RegionModel
						{
							Name = "El Progreso",
							Code = "PR"
						},
						new RegionModel
						{
							Name = "Escuintla",
							Code = "ES"
						},
						new RegionModel
						{
							Name = "Guatemala",
							Code = "GU"
						},
						new RegionModel
						{
							Name = "Huehuetenango",
							Code = "HU"
						},
						new RegionModel
						{
							Name = "Izabal",
							Code = "IZ"
						},
						new RegionModel
						{
							Name = "Jalapa",
							Code = "JA"
						},
						new RegionModel
						{
							Name = "Jutiapa",
							Code = "JU"
						},
						new RegionModel
						{
							Name = "Petén",
							Code = "PE"
						},
						new RegionModel
						{
							Name = "Quetzaltenango",
							Code = "QZ"
						},
						new RegionModel
						{
							Name = "Quiché",
							Code = "QC"
						},
						new RegionModel
						{
							Name = "Retalhuleu",
							Code = "Re"
						},
						new RegionModel
						{
							Name = "Sacatepéquez",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "San Marcos",
							Code = "SM"
						},
						new RegionModel
						{
							Name = "Santa Rosa",
							Code = "SR"
						},
						new RegionModel
						{
							Name = "Sololá",
							Code = "SO"
						},
						new RegionModel
						{
							Name = "Suchitepéquez",
							Code = "SU"
						},
						new RegionModel
						{
							Name = "Totonicapán",
							Code = "TO"
						},
						new RegionModel
						{
							Name = "Zacapa",
							Code = "ZA"
						}
					}
				},
				new CountryModel
				{
					Name = "Guernsey",
					Code = "GG",
					NativeName = "",
					PhoneCode = "+44",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Castel",
							Code = null
						},
						new RegionModel
						{
							Name = "Forest",
							Code = null
						},
						new RegionModel
						{
							Name = "St. Andrew",
							Code = null
						},
						new RegionModel
						{
							Name = "St. Martin",
							Code = null
						},
						new RegionModel
						{
							Name = "St. Peter Port",
							Code = null
						},
						new RegionModel
						{
							Name = "St. Pierre du Bois",
							Code = null
						},
						new RegionModel
						{
							Name = "St. Sampson",
							Code = null
						},
						new RegionModel
						{
							Name = "St. Saviour",
							Code = null
						},
						new RegionModel
						{
							Name = "Torteval",
							Code = null
						},
						new RegionModel
						{
							Name = "Vale",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Guinea",
					Code = "GN",
					NativeName = "Guinée",
					PhoneCode = "+224",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Boké",
							Code = "B"
						},
						new RegionModel
						{
							Name = "Conakry",
							Code = "C"
						},
						new RegionModel
						{
							Name = "Faranah",
							Code = "F"
						},
						new RegionModel
						{
							Name = "Kankan",
							Code = "K"
						},
						new RegionModel
						{
							Name = "Kindia",
							Code = "D"
						},
						new RegionModel
						{
							Name = "Labé",
							Code = "L"
						},
						new RegionModel
						{
							Name = "Mamou",
							Code = "M"
						},
						new RegionModel
						{
							Name = "Nzérékoré",
							Code = "N"
						}
					}
				},
				new CountryModel
				{
					Name = "Guinea-Bissau",
					Code = "GW",
					NativeName = "Guiné-Bissau",
					PhoneCode = "+245",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bafatá",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Biombo",
							Code = "BM"
						},
						new RegionModel
						{
							Name = "Bissau",
							Code = "BS"
						},
						new RegionModel
						{
							Name = "Bolama-Bijagos",
							Code = "BL"
						},
						new RegionModel
						{
							Name = "Cacheu",
							Code = "CA"
						},
						new RegionModel
						{
							Name = "Gabú",
							Code = "GA"
						},
						new RegionModel
						{
							Name = "Oio",
							Code = "OI"
						},
						new RegionModel
						{
							Name = "Quinara",
							Code = "QU"
						},
						new RegionModel
						{
							Name = "Tombali",
							Code = "TO"
						}
					}
				},
				new CountryModel
				{
					Name = "Guyana",
					Code = "GY",
					NativeName = "",
					PhoneCode = "+592",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Barima-Waini",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Cuyuni-Mazaruni",
							Code = "CU"
						},
						new RegionModel
						{
							Name = "Demerara-Mahaica",
							Code = "DE"
						},
						new RegionModel
						{
							Name = "East Berbice-Corentyne",
							Code = "EB"
						},
						new RegionModel
						{
							Name = "Essequibo Islands-West Demerara",
							Code = "ES"
						},
						new RegionModel
						{
							Name = "Mahaica-Berbice",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Pomeroon-Supenaam",
							Code = "PM"
						},
						new RegionModel
						{
							Name = "Potaro-Siparuni",
							Code = "PT"
						},
						new RegionModel
						{
							Name = "Upper Demerara-Berbice",
							Code = "UD"
						},
						new RegionModel
						{
							Name = "Upper Takutu-Upper Essequibo",
							Code = "UT"
						}
					}
				},
				#endregion

				#region H
				new CountryModel
				{
					Name = "Haiti",
					Code = "HT",
					NativeName = "Haïti , Ayiti",
					PhoneCode = "+509",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Artibonite",
							Code = "AR"
						},
						new RegionModel
						{
							Name = "Centre",
							Code = "CE"
						},
						new RegionModel
						{
							Name = "Grand'Anse",
							Code = "GA"
						},
						new RegionModel
						{
							Name = "Nippes",
							Code = "NI"
						},
						new RegionModel
						{
							Name = "Nord",
							Code = "ND"
						},
						new RegionModel
						{
							Name = "Nord-Est",
							Code = "NE"
						},
						new RegionModel
						{
							Name = "Nord-Ouest",
							Code = "NO"
						},
						new RegionModel
						{
							Name = "Ouest",
							Code = "OU"
						},
						new RegionModel
						{
							Name = "Sud",
							Code = "SD"
						},
						new RegionModel
						{
							Name = "Sud-Est",
							Code = "SE"
						}
					}
				},
				new CountryModel
				{
					Name = "Honduras",
					Code = "HN",
					NativeName = "",
					PhoneCode = "+504",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Atlántida",
							Code = "AT"
						},
						new RegionModel
						{
							Name = "Choluteca",
							Code = "CH"
						},
						new RegionModel
						{
							Name = "Colón",
							Code = "CL"
						},
						new RegionModel
						{
							Name = "Comayagua",
							Code = "CM"
						},
						new RegionModel
						{
							Name = "Copán",
							Code = "CP"
						},
						new RegionModel
						{
							Name = "Cortés",
							Code = "CR"
						},
						new RegionModel
						{
							Name = "El Paraíso",
							Code = "EP"
						},
						new RegionModel
						{
							Name = "Francisco Morazán",
							Code = "FM"
						},
						new RegionModel
						{
							Name = "Gracias a Dios",
							Code = "GD"
						},
						new RegionModel
						{
							Name = "Intibucá",
							Code = "IN"
						},
						new RegionModel
						{
							Name = "Islas de la Bahía",
							Code = "IB"
						},
						new RegionModel
						{
							Name = "La Paz",
							Code = "LP"
						},
						new RegionModel
						{
							Name = "Lempira",
							Code = "LE"
						},
						new RegionModel
						{
							Name = "Ocotepeque",
							Code = "OC"
						},
						new RegionModel
						{
							Name = "Olancho",
							Code = "OL"
						},
						new RegionModel
						{
							Name = "Santa Bárbara",
							Code = "SB"
						},
						new RegionModel
						{
							Name = "Valle",
							Code = "VA"
						},
						new RegionModel
						{
							Name = "Yoro",
							Code = "YO"
						}
					}
				},
				new CountryModel
				{
					Name = "Hong Kong",
					Code = "HK",
					NativeName = "香港",
					PhoneCode = "+852",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Hong Kong",
							Code = "HK"
						}
					}
				},
				new CountryModel
				{
					Name = "Hungary",
					Code = "HU",
					NativeName = "Magyarország",
					PhoneCode = "+36",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bács-Kiskun",
							Code = "BK"
						},
						new RegionModel
						{
							Name = "Baranya",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Békés",
							Code = "BE"
						},
						new RegionModel
						{
							Name = "Békéscsaba",
							Code = "BC"
						},
						new RegionModel
						{
							Name = "Borsod-Abauj-Zemplen",
							Code = "BZ"
						},
						new RegionModel
						{
							Name = "Budapest",
							Code = "BU"
						},
						new RegionModel
						{
							Name = "Csongrád",
							Code = "CS"
						},
						new RegionModel
						{
							Name = "Debrecen",
							Code = "DE"
						},
						new RegionModel
						{
							Name = "Dunaújváros",
							Code = "DU"
						},
						new RegionModel
						{
							Name = "Eger",
							Code = "EG"
						},
						new RegionModel
						{
							Name = "Érd",
							Code = "ER"
						},
						new RegionModel
						{
							Name = "Fejér",
							Code = "FE"
						},
						new RegionModel
						{
							Name = "Győr",
							Code = "GY"
						},
						new RegionModel
						{
							Name = "Győr-Moson-Sopron",
							Code = "GS"
						},
						new RegionModel
						{
							Name = "Hajdú-Bihar",
							Code = "HB"
						},
						new RegionModel
						{
							Name = "Heves",
							Code = "HE"
						},
						new RegionModel
						{
							Name = "Hódmezővásárhely",
							Code = "HV"
						},
						new RegionModel
						{
							Name = "Jász-Nagykun-Szolnok",
							Code = "N"
						},
						new RegionModel
						{
							Name = "Kaposvár",
							Code = "KV"
						},
						new RegionModel
						{
							Name = "Kecskemét",
							Code = "KM"
						},
						new RegionModel
						{
							Name = "Komárom-Esztergom",
							Code = "KE"
						},
						new RegionModel
						{
							Name = "Miskolc",
							Code = "MI"
						},
						new RegionModel
						{
							Name = "Nagykanizsa",
							Code = "NK"
						},
						new RegionModel
						{
							Name = "Nógrád",
							Code = "NO"
						},
						new RegionModel
						{
							Name = "Nyíregyháza",
							Code = "NY"
						},
						new RegionModel
						{
							Name = "Pécs",
							Code = "PS"
						},
						new RegionModel
						{
							Name = "Pest",
							Code = "PE"
						},
						new RegionModel
						{
							Name = "Salgótarján",
							Code = "ST"
						},
						new RegionModel
						{
							Name = "Somogy",
							Code = "SO"
						},
						new RegionModel
						{
							Name = "Sopron",
							Code = "SN"
						},
						new RegionModel
						{
							Name = "Szabolcs-á-Bereg",
							Code = "SZ"
						},
						new RegionModel
						{
							Name = "Szeged",
							Code = "SD"
						},
						new RegionModel
						{
							Name = "Székesfehérvár",
							Code = "SF"
						},
						new RegionModel
						{
							Name = "Szekszárd",
							Code = "SS"
						},
						new RegionModel
						{
							Name = "Szolnok",
							Code = "SK"
						},
						new RegionModel
						{
							Name = "Szombathely",
							Code = "SH"
						},
						new RegionModel
						{
							Name = "Tatabánya",
							Code = "TB"
						},
						new RegionModel
						{
							Name = "Tolna",
							Code = "TO"
						},
						new RegionModel
						{
							Name = "Vas",
							Code = "VA"
						},
						new RegionModel
						{
							Name = "Veszprém",
							Code = "VE"
						},
						new RegionModel
						{
							Name = "Veszprém (City)",
							Code = "VM"
						},
						new RegionModel
						{
							Name = "Zala",
							Code = "ZA"
						},
						new RegionModel
						{
							Name = "Zalaegerszeg",
							Code = "ZE"
						}
					}
				},
				#endregion
				
				#region I
				new CountryModel
				{
					Name = "Iceland",
					Code = "IS",
					NativeName = "Ísland",
					PhoneCode = "+354",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Austurland",
							Code = "7"
						},
						new RegionModel
						{
							Name = "Höfuðborgarsvæði",
							Code = "1"
						},
						new RegionModel
						{
							Name = "Norðurland eystra",
							Code = "6"
						},
						new RegionModel
						{
							Name = "Norðurland vestra",
							Code = "5"
						},
						new RegionModel
						{
							Name = "Suðurland",
							Code = "8"
						},
						new RegionModel
						{
							Name = "Suðurnes",
							Code = "2"
						},
						new RegionModel
						{
							Name = "Vestfirðir",
							Code = "4"
						},
						new RegionModel
						{
							Name = "Vesturland",
							Code = "3"
						}
					}
				},
				new CountryModel
				{
					Name = "India",
					Code = "IN",
					NativeName = "भारत गणराज्य",
					PhoneCode = "+91",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Andaman and Nicobar Islands",
							Code = "AN"
						},
						new RegionModel
						{
							Name = "Andhra Pradesh",
							Code = "AP"
						},
						new RegionModel
						{
							Name = "Arunachal Pradesh",
							Code = "AR"
						},
						new RegionModel
						{
							Name = "Assam",
							Code = "AS"
						},
						new RegionModel
						{
							Name = "Bihar",
							Code = "BR"
						},
						new RegionModel
						{
							Name = "Chandigarh",
							Code = "CH"
						},
						new RegionModel
						{
							Name = "Chhattisgarh",
							Code = "CT"
						},
						new RegionModel
						{
							Name = "Dadra and Nagar Haveli and Daman and Diu",
							Code = "DH"
						},
						new RegionModel
						{
							Name = "Delhi",
							Code = "DL"
						},
						new RegionModel
						{
							Name = "Goa",
							Code = "GA"
						},
						new RegionModel
						{
							Name = "Gujarat",
							Code = "GJ"
						},
						new RegionModel
						{
							Name = "Haryana",
							Code = "HR"
						},
						new RegionModel
						{
							Name = "Himachal Pradesh",
							Code = "HP"
						},
						new RegionModel
						{
							Name = "Jammu and Kashmir",
							Code = "JK"
						},
						new RegionModel
						{
							Name = "Jharkhand",
							Code = "JH"
						},
						new RegionModel
						{
							Name = "Karnataka",
							Code = "KA"
						},
						new RegionModel
						{
							Name = "Kerala",
							Code = "KL"
						},
						new RegionModel
						{
							Name = "Ladakh",
							Code = "LA"
						},
						new RegionModel
						{
							Name = "Lakshadweep",
							Code = "LD"
						},
						new RegionModel
						{
							Name = "Madhya Pradesh",
							Code = "MP"
						},
						new RegionModel
						{
							Name = "Maharashtra",
							Code = "MH"
						},
						new RegionModel
						{
							Name = "Manipur",
							Code = "MN"
						},
						new RegionModel
						{
							Name = "Meghalaya",
							Code = "ML"
						},
						new RegionModel
						{
							Name = "Mizoram",
							Code = "MZ"
						},
						new RegionModel
						{
							Name = "Nagaland",
							Code = "NL"
						},
						new RegionModel
						{
							Name = "Odisha",
							Code = "OR"
						},
						new RegionModel
						{
							Name = "Puducherry",
							Code = "PY"
						},
						new RegionModel
						{
							Name = "Punjab",
							Code = "PB"
						},
						new RegionModel
						{
							Name = "Rajasthan",
							Code = "RJ"
						},
						new RegionModel
						{
							Name = "Sikkim",
							Code = "SK"
						},
						new RegionModel
						{
							Name = "Tamil Nadu",
							Code = "TN"
						},
						new RegionModel
						{
							Name = "Telangana",
							Code = "TG"
						},
						new RegionModel
						{
							Name = "Tripura",
							Code = "TR"
						},
						new RegionModel
						{
							Name = "Uttarakhand",
							Code = "UT"
						},
						new RegionModel
						{
							Name = "Uttar Pradesh",
							Code = "UP"
						},
						new RegionModel
						{
							Name = "West Bengal",
							Code = "WB"
						}
					}
				},
				new CountryModel
				{
					Name = "Indonesia",
					Code = "ID",
					NativeName = "",
					PhoneCode = "+62",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aceh",
							Code = "AC"
						},
						new RegionModel
						{
							Name = "Bali",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Bangka Belitung",
							Code = "BB"
						},
						new RegionModel
						{
							Name = "Banten",
							Code = "BT"
						},
						new RegionModel
						{
							Name = "Bengkulu",
							Code = "BE"
						},
						new RegionModel
						{
							Name = "Gorontalo",
							Code = "GO"
						},
						new RegionModel
						{
							Name = "Jakarta Raya",
							Code = "JK"
						},
						new RegionModel
						{
							Name = "Jambi",
							Code = "JA"
						},
						new RegionModel
						{
						Name = "Jawa Barat",
							Code = "JB"
						},
						new RegionModel
						{
							Name = "Jawa Tengah",
							Code = "JT"
						},
						new RegionModel
						{
							Name = "Jawa Timur",
							Code = "JI"
						},
						new RegionModel
						{
							Name = "Kalimantan Barat",
							Code = "KB"
						},
						new RegionModel
						{
							Name = "Kalimantan Selatan",
							Code = "KS"
						},
						new RegionModel
						{
							Name = "Kalimantan Tengah",
							Code = "KT"
						},
						new RegionModel
						{
							Name = "Kalimantan Timur",
							Code = "KI"
						},
						new RegionModel
						{
							Name = "Kalimantan Utara",
							Code = "KU"
						},
						new RegionModel
						{
							Name = "Kepulauan Riau",
							Code = "KR"
						},
						new RegionModel
						{
							Name = "Lampung",
							Code = "LA"
						},
						new RegionModel
						{
							Name = "Maluku",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Maluku Utara",
							Code = "MU"
						},
						new RegionModel
						{
							Name = "Nusa Tenggara Barat",
							Code = "NB"
						},
						new RegionModel
						{
							Name = "Nusa Tenggara Timur",
							Code = "NT"
						},
						new RegionModel
						{
							Name = "Papua",
							Code = "PA"
						},
						new RegionModel
						{
							Name = "Papua Barat",
							Code = "PB"
						},
						new RegionModel
						{
							Name = "Riau",
							Code = "RI"
						},
						new RegionModel
						{
							Name = "Sulawesi Selatan",
							Code = "SR"
						},
						new RegionModel
						{
							Name = "Sulawesi Tengah",
							Code = "ST"
						},
						new RegionModel
						{
							Name = "Sulawesi Tenggara",
							Code = "SG"
						},
						new RegionModel
						{
							Name = "Sulawesi Utara",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "Sumatera Barat",
							Code = "SB"
						},
						new RegionModel
						{
							Name = "Sumatera Selatan",
							Code = "SS"
						},
						new RegionModel
						{
							Name = "Sumatera Utara",
							Code = "SU"
						},
						new RegionModel
						{
							Name = "Yogyakarta",
							Code = "YO"
						}
					}
				},
				new CountryModel
				{
					Name = "Iran",
					Code = "IR",
					NativeName = "جمهوری اسلامی ایران",
					PhoneCode = "+98",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Alborz",
							Code = "32"
						},
						new RegionModel
						{
							Name = "Ardabīl",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Āz̄arbāyjān-e Gharbī",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Āz̄arbāyjān-e Sharqī",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Būshehr",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Chahār Maḩāl va Bakhtīārī",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Eşfahān",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Fārs",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Gīlān",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Golestān",
							Code = "27"
						},
						new RegionModel
						{
							Name = "Hamadān",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Hormozgān",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Īlām",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Kermān",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Kermānshāh",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Khorāsān-e Jonūbī",
							Code = "29"
						},
						new RegionModel
						{
							Name = "Khorāsān-e Raẕavī",
							Code = "30"
						},
						new RegionModel
						{
							Name = "Khorāsān-e Shomālī",
							Code = "61"
						},
						new RegionModel
						{
							Name = "Khūzestān",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Kohgīlūyeh va Bowyer Aḩmad",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Kordestān",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Lorestān",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Markazi",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Māzandarān",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Qazvīn",
							Code = "28"
						},
						new RegionModel
						{
							Name = "Qom",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Semnān",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Sīstān va Balūchestān",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Tehrān",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Yazd",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Zanjān",
							Code = "11"
						}
					}
				},
				new CountryModel
				{
					Name = "Iraq",
					Code = "IQ",
					NativeName = "جمهورية ألعراق , كۆماريى عێراق",
					PhoneCode = "+964",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Al Anbār",
							Code = "AN"
						},
						new RegionModel
						{
							Name = "Al Başrah",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Al Muthanná",
							Code = "MU"
						},
						new RegionModel
						{
							Name = "Al Qādisīyah",
							Code = "QA"
						},
						new RegionModel
						{
							Name = "An Najaf",
							Code = "NA"
						},
						new RegionModel
						{
							Name = "Arbīl",
							Code = "AR"
						},
						new RegionModel
						{
							Name = "As Sulaymānīyah",
							Code = "SU"
						},
						new RegionModel
						{
							Name = "Bābil",
							Code = "BB"
						},
						new RegionModel
						{
							Name = "Baghdād",
							Code = "BG"
						},
						new RegionModel
						{
							Name = "Dohuk",
							Code = "DA"
						},
						new RegionModel
						{
							Name = "Dhī Qār",
							Code = "DQ"
						},
						new RegionModel
						{
							Name = "Diyālá",
							Code = "DI"
						},
						new RegionModel
						{
							Name = "Karbalā'",
							Code = "KA"
						},
						new RegionModel
						{
							Name = "Kirkuk",
							Code = "KI"
						},
						new RegionModel
						{
							Name = "Maysān",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Nīnawá",
							Code = "NI"
						},
						new RegionModel
						{
							Name = "Şalāḩ ad Dīn",
							Code = "SD"
						},
						new RegionModel
						{
							Name = "Wāsiţ",
							Code = "WA"
						}
					}
				},
				new CountryModel
				{
					Name = "Ireland",
					Code = "IE",
					NativeName = "Éire",
					PhoneCode = "+353",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Carlow",
							Code = "CW"
						},
						new RegionModel
						{
							Name = "Cavan",
							Code = "CN"
						},
						new RegionModel
						{
							Name = "Clare",
							Code = "CE"
						},
						new RegionModel
						{
							Name = "Cork",
							Code = "CO"
						},
						new RegionModel
						{
							Name = "Donegal",
							Code = "DL"
						},
						new RegionModel
						{
							Name = "Dublin",
							Code = "D"
						},
						new RegionModel
						{
							Name = "Galway",
							Code = "G"
						},
						new RegionModel
						{
							Name = "Kerry",
							Code = "KY"
						},
						new RegionModel
						{
							Name = "Kildare",
							Code = "KE"
						},
						new RegionModel
						{
							Name = "Kilkenny",
							Code = "KK"
						},
						new RegionModel
						{
							Name = "Laois",
							Code = "LS"
						},
						new RegionModel
						{
							Name = "Leitrim",
							Code = "LM"
						},
						new RegionModel
						{
							Name = "Limerick",
							Code = "LK"
						},
						new RegionModel
						{
							Name = "Longford",
							Code = "LD"
						},
						new RegionModel
						{
							Name = "Louth",
							Code = "LH"
						},
						new RegionModel
						{
							Name = "Mayo",
							Code = "MO"
						},
						new RegionModel
						{
							Name = "Meath",
							Code = "MH"
						},
						new RegionModel
						{
							Name = "Monaghan",
							Code = "MN"
						},
						new RegionModel
						{
							Name = "Offaly",
							Code = "OY"
						},
						new RegionModel
						{
							Name = "Roscommon",
							Code = "RN"
						},
						new RegionModel
						{
							Name = "Sligo",
							Code = "SO"
						},
						new RegionModel
						{
							Name = "Tipperary",
							Code = "TA"
						},
						new RegionModel
						{
							Name = "Waterford",
							Code = "WD"
						},
						new RegionModel
						{
							Name = "Westmeath",
							Code = "WH"
						},
						new RegionModel
						{
							Name = "Wexford",
							Code = "WX"
						},
						new RegionModel
						{
							Name = "Wicklow",
							Code = "WW"
						}
					}
				},
				new CountryModel
				{
					Name = "Isle of Man",
					Code = "IM",
					NativeName = "Ellan Vannin , Ellan Mannin",
					PhoneCode = "+44",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Isle of Man",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Israel",
					Code = "IL",
					NativeName = "מדינת ישראל , دولة إسرائيل",
					PhoneCode = "+972",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "HaDarom",
							Code = "D"
						},
						new RegionModel
						{
							Name = "HaMerkaz",
							Code = "M"
						},
						new RegionModel
						{
							Name = "HaTsafon",
							Code = "Z"
						},
						new RegionModel
						{
							Name = "H̱efa",
							Code = "HA"
						},
						new RegionModel
						{
							Name = "Tel-Aviv",
							Code = "TA"
						},
						new RegionModel
						{
							Name = "Yerushalayim",
							Code = "JM"
						}
					}
				},
				new CountryModel
				{
					Name = "Italy",
					Code = "IT",
					NativeName = "",
					PhoneCode = "+39",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Abruzzo",
							Code = "65"
						},
						new RegionModel
						{
							Name = "Basilicata",
							Code = "77"
						},
						new RegionModel
						{
							Name = "Calabria",
							Code = "78"
						},
						new RegionModel
						{
							Name = "Campania",
							Code = "72"
						},
						new RegionModel
						{
							Name = "Emilia-Romagna",
							Code = "45"
						},
						new RegionModel
						{
							Name = "Friuli-Venezia Giulia",
							Code = "36"
						},
						new RegionModel
						{
							Name = "Lazio",
							Code = "62"
						},
						new RegionModel
						{
							Name = "Liguria",
							Code = "42"
						},
						new RegionModel
						{
							Name = "Lombardia",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Marche",
							Code = "57"
						},
						new RegionModel
						{
							Name = "Molise",
							Code = "67"
						},
						new RegionModel
						{
							Name = "Piemonte",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Puglia",
							Code = "75"
						},
						new RegionModel
						{
							Name = "Sardegna",
							Code = "88"
						},
						new RegionModel
						{
							Name = "Sicilia",
							Code = "82"
						},
						new RegionModel
						{
							Name = "Toscana",
							Code = "52"
						},
						new RegionModel
						{
							Name = "Trentino-Alto Adige",
							Code = "32"
						},
						new RegionModel
						{
							Name = "Umbria",
							Code = "55"
						},
						new RegionModel
						{
							Name = "Valle d'Aosta",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Veneto",
							Code = "34"
						}
					}
				},
				#endregion
				
				#region	J
				new CountryModel
				{
					Name = "Jamaica",
					Code = "JM",
					NativeName = "Jumieka",
					PhoneCode = "+1",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Clarendon",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Hanover",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Kingston",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Manchester",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Portland",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Saint Andrew",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Saint Ann",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Saint Catherine",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Saint Elizabeth",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Saint James",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Saint Mary",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Saint Thomas",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Trelawny",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Westmoreland",
							Code = "10"
						}
					}
				},
				new CountryModel
				{
					Name = "Japan",
					Code = "JP",
					NativeName = "日本国",
					PhoneCode = "+81",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aichi",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Akita",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Aomori",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Chiba",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Ehime",
							Code = "38"
						},
						new RegionModel
						{
							Name = "Fukui",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Fukuoka",
							Code = "40"
						},
						new RegionModel
						{
							Name = "Fukushima",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Gifu",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Gunma",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Hiroshima",
							Code = "34"
						},
						new RegionModel
						{
							Name = "Hokkaido",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Hyogo",
							Code = "28"
						},
						new RegionModel
						{
							Name = "Ibaraki",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Ishikawa",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Iwate",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Kagawa",
							Code = "37"
						},
						new RegionModel
						{
							Name = "Kagoshima",
							Code = "46"
						},
						new RegionModel
						{
							Name = "Kanagawa",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Kochi",
							Code = "39"
						},
						new RegionModel
						{
							Name = "Kumamoto",
							Code = "43"
						},
						new RegionModel
						{
							Name = "Kyoto",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Mie",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Miyagi",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Miyazaki",
							Code = "45"
						},
						new RegionModel
						{
							Name = "Nagano",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Nagasaki",
							Code = "42"
						},
						new RegionModel
						{
							Name = "Nara",
							Code = "29"
						},
						new RegionModel
						{
							Name = "Niigata",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Oita",
							Code = "44"
						},
						new RegionModel
						{
							Name = "Okayama",
							Code = "33"
						},
						new RegionModel
						{
							Name = "Okinawa",
							Code = "47"
						},
						new RegionModel
						{
							Name = "Osaka",
							Code = "27"
						},
						new RegionModel
						{
							Name = "Saga",
							Code = "41"
						},
						new RegionModel
						{
							Name = "Saitama",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Shiga",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Shimane",
							Code = "32"
						},
						new RegionModel
						{
							Name = "Shizuoka",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Tochigi",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Tokushima",
							Code = "36"
						},
						new RegionModel
						{
							Name = "Tokyo",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Tottori",
							Code = "31"
						},
						new RegionModel
						{
							Name = "Toyama",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Wakayama",
							Code = "30"
						},
						new RegionModel
						{
							Name = "Yamagata",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Yamaguchi",
							Code = "35"
						},
						new RegionModel
						{
							Name = "Yamanashi",
							Code = "19"
						}
					}
				},
				new CountryModel
				{
					Name = "Jersey",
					Code = "JE",
					NativeName = "Jèrri",
					PhoneCode = "+44",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Jersey",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Jordan",
					Code = "JO",
					NativeName = "المملكة الأردنّيّة الهاشميّة",
					PhoneCode = "+962",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "‘Ajlūn",
							Code = "AJ"
						},
						new RegionModel
						{
							Name = "Al 'Aqabah",
							Code = "AQ"
						},
						new RegionModel
						{
							Name = "Al Balqā’",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Al Karak",
							Code = "KA"
						},
						new RegionModel
						{
							Name = "Al Mafraq",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Al ‘A̅şimah",
							Code = "AM"
						},
						new RegionModel
						{
							Name = "Aţ Ţafīlah",
							Code = "AT"
						},
						new RegionModel
						{
							Name = "Az Zarqā’",
							Code = "AZ"
						},
						new RegionModel
						{
							Name = "Irbid",
							Code = "IR"
						},
						new RegionModel
						{
							Name = "Jarash",
							Code = "JA"
						},
						new RegionModel
						{
							Name = "Ma‘ān",
							Code = "MN"
						},
						new RegionModel
						{
							Name = "Mādabā",
							Code = "MD"
						}
					}
				},
				#endregion
				
				#region K
				new CountryModel
				{
					Name = "Kazakhstan",
					Code = "KZ",
					NativeName = "Қазақстан Республикасы , Республика Казахстан",
					PhoneCode = "+7",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Almaty",
							Code = "ALA"
						},
						new RegionModel
						{
							Name = "Aqmola",
							Code = "AKM"
						},
						new RegionModel
						{
							Name = "Aqtobe",
							Code = "AKT"
						},
						new RegionModel
						{
							Name = "Astana",
							Code = "AST"
						},
						new RegionModel
						{
							Name = "Atyrau",
							Code = "ATY"
						},
						new RegionModel
						{
							Name = "Batys Qazaqstan",
							Code = "ZAP"
						},
						new RegionModel
						{
							Name = "Bayqongyr",
							Code = null
						},
						new RegionModel
						{
							Name = "Mangghystau",
							Code = "MAN"
						},
						new RegionModel
						{
							Name = "Ongtustik Qazaqstan",
							Code = "YUZ"
						},
						new RegionModel
						{
							Name = "Pavlodar",
							Code = "PAV"
						},
						new RegionModel
						{
							Name = "Qaraghandy",
							Code = "KAR"
						},
						new RegionModel
						{
							Name = "Qostanay",
							Code = "KUS"
						},
						new RegionModel
						{
							Name = "Qyzylorda",
							Code = "KZY"
						},
						new RegionModel
						{
							Name = "Shyghys Qazaqstan",
							Code = "VOS"
						},
						new RegionModel
						{
							Name = "Soltustik Qazaqstan",
							Code = "SEV"
						},
						new RegionModel
						{
							Name = "Zhambyl",
							Code = "ZHA"
						}
					}
				},
				new CountryModel
				{
					Name = "Kenya",
					Code = "KE",
					NativeName = "Kenya",
					PhoneCode = "+254",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Baringo",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Bomet",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Bungoma",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Busia",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Eleyo/Marakwet",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Embu",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Garissa",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Homa Bay",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Isiolo",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Kajiado",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Kakamega",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Kericho",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Kiambu",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Kilifi",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Kirinyaga",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Kisii",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Kisumu",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Kitui",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Kwale",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Laikipia",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Lamu",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Machakos",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Makueni",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Mandera",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Marsabit",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Meru",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Migori",
							Code = "27"
						},
						new RegionModel
						{
							Name = "Mombasa",
							Code = "28"
						},
						new RegionModel
						{
							Name = "Murang'a",
							Code = "29"
						},
						new RegionModel
						{
							Name = "Nairobi City",
							Code = "30"
						},
						new RegionModel
						{
							Name = "Nakuru",
							Code = "31"
						},
						new RegionModel
						{
							Name = "Nandi",
							Code = "32"
						},
						new RegionModel
						{
							Name = "Narok",
							Code = "33"
						},
						new RegionModel
						{
							Name = "Nyamira",
							Code = "34"
						},
						new RegionModel
						{
							Name = "Nyandarua",
							Code = "35"
						},
						new RegionModel
						{
							Name = "Nyeri",
							Code = "36"
						},
						new RegionModel
						{
							Name = "Samburu",
							Code = "37"
						},
						new RegionModel
						{
							Name = "Siaya",
							Code = "38"
						},
						new RegionModel
						{
							Name = "Taita/Taveta",
							Code = "39"
						},
						new RegionModel
						{
							Name = "Tana River",
							Code = "40"
						},
						new RegionModel
						{
							Name = "Tharaka-Nithi",
							Code = "41"
						},
						new RegionModel
						{
							Name = "Trans Nzoia",
							Code = "42"
						},
						new RegionModel
						{
							Name = "Turkana",
							Code = "43"
						},
						new RegionModel
						{
							Name = "Uasin Gishu",
							Code = "44"
						},
						new RegionModel
						{
							Name = "Vihiga",
							Code = "45"
						},
						new RegionModel
						{
							Name = "Wajir",
							Code = "46"
						},
						new RegionModel
						{
							Name = "West Pokot",
							Code = "47"
						}
					}
				},
				new CountryModel
				{
					Name = "Kiribati",
					Code = "KI",
					NativeName = "Kiribati",
					PhoneCode = "+686",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Abaiang",
							Code = null
						},
						new RegionModel
						{
							Name = "Abemama",
							Code = null
						},
						new RegionModel
						{
							Name = "Aranuka",
							Code = null
						},
						new RegionModel
						{
							Name = "Arorae",
							Code = null
						},
						new RegionModel
						{
							Name = "Banaba",
							Code = null
						},
						new RegionModel
						{
							Name = "Beru",
							Code = null
						},
						new RegionModel
						{
							Name = "Butaritari",
							Code = null
						},
						new RegionModel
						{
							Name = "Central Gilberts",
							Code = null
						},
						new RegionModel
						{
							Name = "Gilbert Islands",
							Code = "G"
						},
						new RegionModel
						{
							Name = "Kanton",
							Code = null
						},
						new RegionModel
						{
							Name = "Kiritimati",
							Code = null
						},
						new RegionModel
						{
							Name = "Kuria",
							Code = null
						},
						new RegionModel
						{
							Name = "Line Islands",
							Code = "L"
						},
						new RegionModel
						{
							Name = "Maiana",
							Code = null
						},
						new RegionModel
						{
							Name = "Makin",
							Code = null
						},
						new RegionModel
						{
							Name = "Marakei",
							Code = null
						},
						new RegionModel
						{
							Name = "Nikunau",
							Code = null
						},
						new RegionModel
						{
							Name = "Nonouti",
							Code = null
						},
						new RegionModel
						{
							Name = "Northern Gilberts",
							Code = null
						},
						new RegionModel
						{
							Name = "Onotoa",
							Code = null
						},
						new RegionModel
						{
							Name = "Phoenix Islands",
							Code = "P"
						},
						new RegionModel
						{
							Name = "Southern Gilberts",
							Code = null
						},
						new RegionModel
						{
							Name = "Tabiteuea",
							Code = null
						},
						new RegionModel
						{
							Name = "Tabuaeran",
							Code = null
						},
						new RegionModel
						{
							Name = "Tamana",
							Code = null
						},
						new RegionModel
						{
							Name = "Tarawa",
							Code = null
						},
						new RegionModel
						{
							Name = "Teraina",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Korea",
					Code = "KR",
					NativeName = "대한민국 , 大韓民國",
					PhoneCode = "+82",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ch'ungch'ongbuk-do",
							Code = "43"
						},
						new RegionModel
						{
							Name = "Ch'ungch'ongnam-do",
							Code = "44"
						},
						new RegionModel
						{
							Name = "Cheju-do",
							Code = "49"
						},
						new RegionModel
						{
							Name = "Chollabuk-do",
							Code = "45"
						},
						new RegionModel
						{
							Name = "Chollanam-do",
							Code = "46"
						},
						new RegionModel
						{
							Name = "Inch'on-Kwangyokhi",
							Code = "28"
						},
						new RegionModel
						{
							Name = "Kang-won-do",
							Code = "42"
						},
						new RegionModel
						{
							Name = "Kwangju-Kwangyokshi",
							Code = "29"
						},
						new RegionModel
						{
							Name = "Kyonggi-do",
							Code = "41"
						},
						new RegionModel
						{
							Name = "Kyongsangbuk-do",
							Code = "47"
						},
						new RegionModel
						{
							Name = "Kyongsangnam-do",
							Code = "48"
						},
						new RegionModel
						{
							Name = "Pusan-Kwangyokshi",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Seoul-T'ukpyolshi",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Sejong",
							Code = "50"
						},
						new RegionModel
						{
							Name = "Taegu-Kwangyokshi",
							Code = "27"
						},
						new RegionModel
						{
							Name = "Taejon-Kwangyokshi",
							Code = "30"
						},
						new RegionModel
						{
							Name = "Ulsan-Kwangyokshi",
							Code = "31"
						}
					}
				},
				new CountryModel
				{
					Name = "Kuwait",
					Code = "KW",
					NativeName = " دولة الكويت ",
					PhoneCode = "+965",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Al Aḩmadi",
							Code = "AH"
						},
						new RegionModel
						{
							Name = "Al Farwānīyah",
							Code = "FA"
						},
						new RegionModel
						{
							Name = "Al Jahrā’",
							Code = "JA"
						},
						new RegionModel
						{
							Name = "Al ‘Āşimah",
							Code = "KU"
						},
						new RegionModel
						{
							Name = "Ḩawallī",
							Code = "HA"
						},
						new RegionModel
						{
							Name = "Mubārak al Kabir",
							Code = "MU"
						}
					}
				},
				new CountryModel
				{
					Name = "Kyrgyzstan",
					Code = "KG",
					NativeName = "Кыргыз Республикасы , Кыргызская Республика",
					PhoneCode = "+996",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Batken Oblasty",
							Code = "B"
						},
						new RegionModel
						{
							Name = "Bishkek Shaary",
							Code = "GB"
						},
						new RegionModel
						{
							Name = "Chuy Oblasty (Bishkek)",
							Code = "C"
						},
						new RegionModel
						{
							Name = "Jalal-Abad Oblasty",
							Code = "J"
						},
						new RegionModel
						{
							Name = "Naryn Oblasty",
							Code = "N"
						},
						new RegionModel
						{
							Name = "Osh Oblasty",
							Code = "O"
						},
						new RegionModel
						{
							Name = "Talas Oblasty",
							Code = "T"
						},
						new RegionModel
						{
							Name = "Ysyk-Kol Oblasty (Karakol)",
							Code = "Y"
						}
					}
				},
				#endregion

				#region L
				new CountryModel
				{
					Name = "Laos",
					Code = "LA",
					NativeName = "ສາທາລະນະລັດປະຊາທິປະໄຕ ປະຊາຊົນລາວ",
					PhoneCode = "+856",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Attapu",
							Code = "AT"
						},
						new RegionModel
						{
							Name = "Bokèo",
							Code = "BK"
						},
						new RegionModel
						{
							Name = "Bolikhamxai",
							Code = "BL"
						},
						new RegionModel
						{
							Name = "Champasak",
							Code = "CH"
						},
						new RegionModel
						{
							Name = "Houaphan",
							Code = "HO"
						},
						new RegionModel
						{
							Name = "Khammouan",
							Code = "KH"
						},
						new RegionModel
						{
							Name = "Louang Namtha",
							Code = "LM"
						},
						new RegionModel
						{
							Name = "Louangphabang",
							Code = "LP"
						},
						new RegionModel
						{
							Name = "Oudômxai",
							Code = "OU"
						},
						new RegionModel
						{
							Name = "Phôngsali",
							Code = "PH"
						},
						new RegionModel
						{
							Name = "Salavan",
							Code = "SL"
						},
						new RegionModel
						{
							Name = "Savannakhét",
							Code = "SV"
						},
						new RegionModel
						{
							Name = "Vientiane",
							Code = "VI"
						},
						new RegionModel
						{
							Name = "Xaignabouli",
							Code = "XA"
						},
						new RegionModel
						{
							Name = "Xékong",
							Code = "XE"
						},
						new RegionModel
						{
							Name = "Xaisomboun",
							Code = "XS"
						},
						new RegionModel
						{
							Name = "Xiangkhouang",
							Code = "XI"
						}
					}
				},
				new CountryModel
				{
					Name = "Latvia",
					Code = "LV",
					NativeName = "Latvijas Republika",
					PhoneCode = "+371",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aglona",
							Code = "001"
						},
						new RegionModel
						{
							Name = "Aizkraukle",
							Code = "002"
						},
						new RegionModel
						{
							Name = "Aizpute",
							Code = "003"
						},
						new RegionModel
						{
							Name = "Aknīste",
							Code = "004"
						},
						new RegionModel
						{
							Name = "Aloja",
							Code = "005"
						},
						new RegionModel
						{
							Name = "Alsunga",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Alūksne",
							Code = "007"
						},
						new RegionModel
						{
							Name = "Amata",
							Code = "008"
						},
						new RegionModel
						{
							Name = "Ape",
							Code = "009"
						},
						new RegionModel
						{
							Name = "Auce",
							Code = "010"
						},
						new RegionModel
						{
							Name = "Ādaži",
							Code = "011"
						},
						new RegionModel
						{
							Name = "Babīte",
							Code = "012"
						},
						new RegionModel
						{
							Name = "Baldone",
							Code = "013"
						},
						new RegionModel
						{
							Name = "Baltinava",
							Code = "014"
						},
						new RegionModel
						{
							Name = "Balvi",
							Code = "015"
						},
						new RegionModel
						{
							Name = "Bauska",
							Code = "016"
						},
						new RegionModel
						{
							Name = "Beverīna",
							Code = "017"
						},
						new RegionModel
						{
							Name = "Brocēni",
							Code = "018"
						},
						new RegionModel
						{
							Name = "Burtnieki",
							Code = "019"
						},
						new RegionModel
						{
							Name = "Carnikava",
							Code = "020"
						},
						new RegionModel
						{
							Name = "Cesvaine",
							Code = "021"
						},
						new RegionModel
						{
							Name = "Cēsis",
							Code = "022"
						},
						new RegionModel
						{
							Name = "Cibla",
							Code = "023"
						},
						new RegionModel
						{
							Name = "Dagda",
							Code = "024"
						},
						new RegionModel
						{
							Name = "Daugavpils",
							Code = "025"
						},
						new RegionModel
						{
							Name = "Daugavpils (City)",
							Code = "DGV"
						},
						new RegionModel
						{
							Name = "Dobele",
							Code = "026"
						},
						new RegionModel
						{
							Name = "Dundaga",
							Code = "027"
						},
						new RegionModel
						{
							Name = "Durbe",
							Code = "028"
						},
						new RegionModel
						{
							Name = "Engure",
							Code = "029"
						},
						new RegionModel
						{
							Name = "Ērgļi",
							Code = "030"
						},
						new RegionModel
						{
							Name = "Garkalne",
							Code = "031"
						},
						new RegionModel
						{
							Name = "Grobiņa",
							Code = "032"
						},
						new RegionModel
						{
							Name = "Gulbene",
							Code = "033"
						},
						new RegionModel
						{
							Name = "Iecava",
							Code = "034"
						},
						new RegionModel
						{
							Name = "Ikšķile",
							Code = "035"
						},
						new RegionModel
						{
							Name = "Ilūkste",
							Code = "036"
						},
						new RegionModel
						{
							Name = "Inčukalns",
							Code = "037"
						},
						new RegionModel
						{
							Name = "Jaunjelgava",
							Code = "038"
						},
						new RegionModel
						{
							Name = "Jaunpiebalga",
							Code = "039"
						},
						new RegionModel
						{
							Name = "Jaunpils",
							Code = "040"
						},
						new RegionModel
						{
							Name = "Jelgava",
							Code = "041"
						},
						new RegionModel
						{
							Name = "Jelgava (City)",
							Code = "JEL"
						},
						new RegionModel
						{
							Name = "Jēkabpils",
							Code = "042"
						},
						new RegionModel
						{
							Name = "Jēkabpils (City)",
							Code = "JKB"
						},
						new RegionModel
						{
							Name = "Jūrmala (City)",
							Code = "JUR"
						},
						new RegionModel
						{
							Name = "Kandava",
							Code = "043"
						},
						new RegionModel
						{
							Name = "Kārsava",
							Code = "044"
						},
						new RegionModel
						{
							Name = "Kocēni",
							Code = "045"
						},
						new RegionModel
						{
							Name = "Koknese",
							Code = "046"
						},
						new RegionModel
						{
							Name = "Krāslava",
							Code = "047"
						},
						new RegionModel
						{
							Name = "Krimulda",
							Code = "048"
						},
						new RegionModel
						{
							Name = "Krustpils",
							Code = "049"
						},
						new RegionModel
						{
							Name = "Kuldīga",
							Code = "050"
						},
						new RegionModel
						{
							Name = "Ķegums",
							Code = "051"
						},
						new RegionModel
						{
							Name = "Ķekava",
							Code = "052"
						},
						new RegionModel
						{
							Name = "Lielvārde",
							Code = "053"
						},
						new RegionModel
						{
							Name = "Liepāja",
							Code = "LPX"
						},
						new RegionModel
						{
							Name = "Limbaži",
							Code = "054"
						},
						new RegionModel
						{
							Name = "Līgatne",
							Code = "055"
						},
						new RegionModel
						{
							Name = "Līvāni",
							Code = "056"
						},
						new RegionModel
						{
							Name = "Lubāna",
							Code = "057"
						},
						new RegionModel
						{
							Name = "Ludza",
							Code = "058"
						},
						new RegionModel
						{
							Name = "Madona",
							Code = "059"
						},
						new RegionModel
						{
							Name = "Mazsalaca",
							Code = "060"
						},
						new RegionModel
						{
							Name = "Mālpils",
							Code = "061"
						},
						new RegionModel
						{
							Name = "Mārupe",
							Code = "062"
						},
						new RegionModel
						{
							Name = "Mērsrags",
							Code = "063"
						},
						new RegionModel
						{
							Name = "Naukšēni",
							Code = "064"
						},
						new RegionModel
						{
							Name = "Nereta",
							Code = "065"
						},
						new RegionModel
						{
							Name = "Nīca",
							Code = "066"
						},
						new RegionModel
						{
							Name = "Ogre",
							Code = "067"
						},
						new RegionModel
						{
							Name = "Olaine",
							Code = "068"
						},
						new RegionModel
						{
							Name = "Ozolnieki",
							Code = "069"
						},
						new RegionModel
						{
							Name = "Pārgauja",
							Code = "070"
						},
						new RegionModel
						{
							Name = "Pāvilosta",
							Code = "071"
						},
						new RegionModel
						{
							Name = "Pļaviņas",
							Code = "072"
						},
						new RegionModel
						{
							Name = "Preiļi",
							Code = "073"
						},
						new RegionModel
						{
							Name = "Priekule",
							Code = "074"
						},
						new RegionModel
						{
							Name = "Priekuļi",
							Code = "075"
						},
						new RegionModel
						{
							Name = "Rauna",
							Code = "076"
						},
						new RegionModel
						{
							Name = "Rēzekne",
							Code = "077"
						},
						new RegionModel
						{
							Name = "Rēzekne (City)",
							Code = "REZ"
						},
						new RegionModel
						{
							Name = "Riebiņi",
							Code = "078"
						},
						new RegionModel
						{
							Name = "Rīga",
							Code = "RIX"
						},
						new RegionModel
						{
							Name = "Roja",
							Code = "079"
						},
						new RegionModel
						{
							Name = "Ropaži",
							Code = "080"
						},
						new RegionModel
						{
							Name = "Rucava",
							Code = "081"
						},
						new RegionModel
						{
							Name = "Rugāji",
							Code = "082"
						},
						new RegionModel
						{
							Name = "Rundāle",
							Code = "083"
						},
						new RegionModel
						{
							Name = "Rūjiena",
							Code = "084"
						},
						new RegionModel
						{
							Name = "Sala",
							Code = "085"
						},
						new RegionModel
						{
							Name = "Salacgrīva",
							Code = "086"
						},
						new RegionModel
						{
							Name = "Salaspils",
							Code = "087"
						},
						new RegionModel
						{
							Name = "Saldus",
							Code = "088"
						},
						new RegionModel
						{
							Name = "Saulkrasti",
							Code = "089"
						},
						new RegionModel
						{
							Name = "Sēja",
							Code = "090"
						},
						new RegionModel
						{
							Name = "Sigulda",
							Code = "091"
						},
						new RegionModel
						{
							Name = "Skrīveri",
							Code = "092"
						},
						new RegionModel
						{
							Name = "Skrunda",
							Code = "093"
						},
						new RegionModel
						{
							Name = "Smiltene",
							Code = "094"
						},
						new RegionModel
						{
							Name = "Stopiņi",
							Code = "095"
						},
						new RegionModel
						{
							Name = "Strenči",
							Code = "096"
						},
						new RegionModel
						{
							Name = "Talsi",
							Code = "097"
						},
						new RegionModel
						{
							Name = "Tērvete",
							Code = "098"
						},
						new RegionModel
						{
							Name = "Tukums",
							Code = "099"
						},
						new RegionModel
						{
							Name = "Vaiņode",
							Code = "100"
						},
						new RegionModel
						{
							Name = "Valka",
							Code = "101"
						},
						new RegionModel
						{
							Name = "Valmiera",
							Code = "VMR"
						},
						new RegionModel
						{
							Name = "Varakļāni",
							Code = "102"
						},
						new RegionModel
						{
							Name = "Vārkava",
							Code = "103"
						},
						new RegionModel
						{
							Name = "Vecpiebalga",
							Code = "104"
						},
						new RegionModel
						{
							Name = "Vecumnieki",
							Code = "105"
						},
						new RegionModel
						{
							Name = "Ventspils",
							Code = "106"
						},
						new RegionModel
						{
							Name = "Ventspils (City)",
							Code = "VEN"
						},
						new RegionModel
						{
							Name = "Viesīte",
							Code = "107"
						},
						new RegionModel
						{
							Name = "Viļaka",
							Code = "108"
						},
						new RegionModel
						{
							Name = "Viļāni",
							Code = "109"
						},
						new RegionModel
						{
							Name = "Zilupe",
							Code = "110"
						}
					}
				},
				new CountryModel
				{
					Name = "Lebanon",
					Code = "LB",
					NativeName = "République libanaise , الجمهورية اللبنانية",
					PhoneCode = "+961",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aakkâr",
							Code = "AK"
						},
						new RegionModel
						{
							Name = "Baalbelk-Hermel",
							Code = "BH"
						},
						new RegionModel
						{
							Name = "Béqaa",
							Code = "BI"
						},
						new RegionModel
						{
							Name = "Beyrouth",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Liban-Nord",
							Code = "AS"
						},
						new RegionModel
						{
							Name = "Liban-Sud",
							Code = "JA"
						},
						new RegionModel
						{
							Name = "Mont-Liban",
							Code = "JL"
						},
						new RegionModel
						{
							Name = "Nabatîyé",
							Code = "NA"
						}
					}
				},
				new CountryModel
				{
					Name = "Lesotho",
					Code = "LS",
					NativeName = "",
					PhoneCode = "+266",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Berea",
							Code = "D"
						},
						new RegionModel
						{
							Name = "Butha-Buthe",
							Code = "B"
						},
						new RegionModel
						{
							Name = "Leribe",
							Code = "C"
						},
						new RegionModel
						{
							Name = "Mafeteng",
							Code = "E"
						},
						new RegionModel
						{
							Name = "Maseru",
							Code = "A"
						},
						new RegionModel
						{
							Name = "Mohales Hoek",
							Code = "F"
						},
						new RegionModel
						{
							Name = "Mokhotlong",
							Code = "J"
						},
						new RegionModel
						{
							Name = "Qacha's Nek",
							Code = "H"
						},
						new RegionModel
						{
							Name = "Quthing",
							Code = "G"
						},
						new RegionModel
						{
							Name = "Thaba-Tseka",
							Code = "K"
						}
					}
				},
				new CountryModel
				{
					Name = "Liberia",
					Code = "LR",
					NativeName = "",
					PhoneCode = "+231",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bomi",
							Code = "BM"
						},
						new RegionModel
						{
							Name = "Bong",
							Code = "BG"
						},
						new RegionModel
						{
							Name = "Gbarpolu",
							Code = "GP"
						},
						new RegionModel
						{
							Name = "Grand Bassa",
							Code = "GB"
						},
						new RegionModel
						{
							Name = "Grand Cape Mount",
							Code = "CM"
						},
						new RegionModel
						{
							Name = "Grand Gedeh",
							Code = "GG"
						},
						new RegionModel
						{
							Name = "Grand Kru",
							Code = "GK"
						},
						new RegionModel
						{
							Name = "Lofa",
							Code = "LO"
						},
						new RegionModel
						{
							Name = "Margibi",
							Code = "MG"
						},
						new RegionModel
						{
							Name = "Maryland",
							Code = "MY"
						},
						new RegionModel
						{
							Name = "Montserrado",
							Code = "MO"
						},
						new RegionModel
						{
							Name = "Nimba",
							Code = "NI"
						},
						new RegionModel
						{
							Name = "River Cess",
							Code = "RI"
						},
						new RegionModel
						{
							Name = "River Geee",
							Code = "RG"
						},
						new RegionModel
						{
							Name = "Sinoe",
							Code = "SI"
						}
					}
				},
				new CountryModel
				{
					Name = "Libya",
					Code = "LY",
					NativeName = "Awanak en Libu , دولة ليبيا",
					PhoneCode = "+218",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Al Buţnān",
							Code = "BU"
						},
						new RegionModel
						{
							Name = "Al Jabal al Akhḑar",
							Code = "JA"
						},
						new RegionModel
						{
							Name = "Al Jabal al Gharbī",
							Code = "JG"
						},
						new RegionModel
						{
							Name = "Al Jafārah",
							Code = "JI"
						},
						new RegionModel
						{
							Name = "Al Jufrah",
							Code = "JU"
						},
						new RegionModel
						{
							Name = "Al Kufrah",
							Code = "FK"
						},
						new RegionModel
						{
							Name = "Al Marj",
							Code = "MJ"
						},
						new RegionModel
						{
							Name = "Al Marquab",
							Code = "MB"
						},
						new RegionModel
						{
							Name = "Al Wāḩāt",
							Code = "WA"
						},
						new RegionModel
						{
							Name = "An Nuqaţ al Khams",
							Code = "NQ"
						},
						new RegionModel
						{
							Name = "Az Zāwiyah",
							Code = "ZA"
						},
						new RegionModel
						{
							Name = "Banghāzī",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Darnah",
							Code = "DR"
						},
						new RegionModel
						{
							Name = "Ghāt",
							Code = "GH"
						},
						new RegionModel
						{
							Name = "Mişrātah",
							Code = "MI"
						},
						new RegionModel
						{
							Name = "Murzuq",
							Code = "MQ"
						},
						new RegionModel
						{
							Name = "Nālūt",
							Code = "NL"
						},
						new RegionModel
						{
							Name = "Sabhā",
							Code = "SB"
						},
						new RegionModel
						{
							Name = "Surt",
							Code = "SR"
						},
						new RegionModel
						{
							Name = "Ţarābulus",
							Code = "TB"
						},
						new RegionModel
						{
							Name = "Yafran",
							Code = "WD"
						},
						new RegionModel
						{
							Name = "Wādī ash Shāţiʾ",
							Code = "WS"
						}
					}
				},
				new CountryModel
				{
					Name = "Liechtenstein",
					Code = "LI",
					NativeName = "",
					PhoneCode = "+423",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Balzers",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Eschen",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Gamprin",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Mauren",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Planken",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Ruggell",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Schaan",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Schellenberg",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Triesen",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Triesenberg",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Vaduz",
							Code = "11"
						}
					}
				},
				new CountryModel
				{
					Name = "Lithuania",
					Code = "LT",
					NativeName = "Lietuva",
					PhoneCode = "+370",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Alytaus",
							Code = "AL"
						},
						new RegionModel
						{
							Name = "Kauno",
							Code = "KU"
						},
						new RegionModel
						{
							Name = "Klaipėdos",
							Code = "KL"
						},
						new RegionModel
						{
							Name = "Marijampolės",
							Code = "MR"
						},
						new RegionModel
						{
							Name = "Panevėžio",
							Code = "PN"
						},
						new RegionModel
						{
							Name = "Šiaulių",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "Tauragės",
							Code = "TA"
						},
						new RegionModel
						{
							Name = "Telšių",
							Code = "TE"
						},
						new RegionModel
						{
							Name = "Utenos",
							Code = "UT"
						},
						new RegionModel
						{
							Name = "Vilniaus",
							Code = "VL"
						}
					}
				},
				new CountryModel
				{
					Name = "Luxembourg",
					Code = "LU",
					NativeName = "Lëtzebuerg , Luxemburg",
					PhoneCode = "+352",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Capellen",
							Code = "CA"
						},
						new RegionModel
						{
							Name = "Clevaux",
							Code = "CL"
						},
						new RegionModel
						{
							Name = "Diekirch",
							Code = "DI"
						},
						new RegionModel
						{
							Name = "Echternach",
							Code = "EC"
						},
						new RegionModel
						{
							Name = "Esch-sur-Alzette",
							Code = "ES"
						},
						new RegionModel
						{
							Name = "Grevenmacher",
							Code = "GR"
						},
						new RegionModel
						{
							Name = "Luxembourg",
							Code = "LU"
						},
						new RegionModel
						{
							Name = "Mersch",
							Code = "ME"
						},
						new RegionModel
						{
							Name = "Redange",
							Code = "RD"
						},
						new RegionModel
						{
							Name = "Remich",
							Code = "RM"
						},
						new RegionModel
						{
							Name = "Vianden",
							Code = "VD"
						},
						new RegionModel
						{
							Name = "Wiltz",
							Code = "WI"
						}
					}
				},
				#endregion
				
				#region M
				new CountryModel
				{
					Name = "Macao",
					Code = "MO",
					NativeName = "澳門 , 澳门 , Macau",
					PhoneCode = "+853",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Macao",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Macedonia (FYROM)",
					Code = "MK",
					NativeName = "Северна Македонија , Maqedonisë së Veriut",
					PhoneCode = "+389",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aračinovo",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Berovo",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Bitola",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Bogdanci",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Bogovinje",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Bosilovo",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Brvenica",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Centar Župa",
							Code = "78"
						},
						new RegionModel
						{
							Name = "Čaška",
							Code = "80"
						},
						new RegionModel
						{
							Name = "Češinovo-Obleševo",
							Code = "81"
						},
						new RegionModel
						{
							Name = "Čučer Sandevo",
							Code = "82"
						},
						new RegionModel
						{
							Name = "Debar",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Debarca",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Delčevo",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Demir Hisar",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Demir Kapija",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Doran",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Dolneni",
							Code = "27"
						},
						new RegionModel
						{
							Name = "Gevgelija",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Gostivar",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Gradsko",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Ilinden",
							Code = "34"
						},
						new RegionModel
						{
							Name = "Jegunovce",
							Code = "35"
						},
						new RegionModel
						{
							Name = "Karbinci",
							Code = "37"
						},
						new RegionModel
						{
							Name = "Kavadarci",
							Code = "36"
						},
						new RegionModel
						{
							Name = "Kičevo",
							Code = "40"
						},
						new RegionModel
						{
							Name = "Kočani",
							Code = "42"
						},
						new RegionModel
						{
							Name = "Konče",
							Code = "41"
						},
						new RegionModel
						{
							Name = "Kratovo",
							Code = "43"
						},
						new RegionModel
						{
							Name = "Kriva Palanka",
							Code = "44"
						},
						new RegionModel
						{
							Name = "Krivogaštani",
							Code = "45"
						},
						new RegionModel
						{
							Name = "Kruševo",
							Code = "46"
						},
						new RegionModel
						{
							Name = "Kumanovo",
							Code = "47"
						},
						new RegionModel
						{
							Name = "Lipkovo",
							Code = "48"
						},
						new RegionModel
						{
							Name = "Lozovo",
							Code = "49"
						},
						new RegionModel
						{
							Name = "Makedonska Kamenica",
							Code = "51"
						},
						new RegionModel
						{
							Name = "Makedonski Brod",
							Code = "52"
						},
						new RegionModel
						{
							Name = "Mavrovo i Rostuša",
							Code = "50"
						},
						new RegionModel
						{
							Name = "Mogila",
							Code = "53"
						},
						new RegionModel
						{
							Name = "Negotino",
							Code = "54"
						},
						new RegionModel
						{
							Name = "Novaci",
							Code = "55"
						},
						new RegionModel
						{
							Name = "Novo Selo",
							Code = "56"
						},
						new RegionModel
						{
							Name = "Ohrid",
							Code = "58"
						},
						new RegionModel
						{
							Name = "Pehčevo",
							Code = "60"
						},
						new RegionModel
						{
							Name = "Petrovec",
							Code = "59"
						},
						new RegionModel
						{
							Name = "Plasnica",
							Code = "61"
						},
						new RegionModel
						{
							Name = "Prilep",
							Code = "62"
						},
						new RegionModel
						{
							Name = "Probištip",
							Code = "63"
						},
						new RegionModel
						{
							Name = "Radoviš",
							Code = ""
						},
						new RegionModel
						{
							Name = "Rankovce",
							Code = "65"
						},
						new RegionModel
						{
							Name = "Resen",
							Code = "66"
						},
						new RegionModel
						{
							Name = "Rosoman",
							Code = "67"
						},
						new RegionModel
						{
							Name = "Skopje",
							Code = "85"
						},
						new RegionModel
						{
							Name = "Sopište",
							Code = "70"
						},
						new RegionModel
						{
							Name = "Staro Nagoričane",
							Code = "71"
						},
						new RegionModel
						{
							Name = "Struga",
							Code = "72"
						},
						new RegionModel
						{
							Name = "Strumica",
							Code = "73"
						},
						new RegionModel
						{
							Name = "Studeničani",
							Code = "74"
						},
						new RegionModel
						{
							Name = "Sveti Nikole",
							Code = "69"
						},
						new RegionModel
						{
							Name = "Štip",
							Code = "83"
						},
						new RegionModel
						{
							Name = "Tearce",
							Code = "75"
						},
						new RegionModel
						{
							Name = "Tetovo",
							Code = "76"
						},
						new RegionModel
						{
							Name = "Valandovo",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Vasilevo",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Veles",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Vevčani",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Vinica",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Vrapčište",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Zelenikovo",
							Code = "32"
						},
						new RegionModel
						{
							Name = "Zrnovci",
							Code = "33"
						},
						new RegionModel
						{
							Name = "Želino",
							Code = "30"
						}
					}
				},
				new CountryModel
				{
					Name = "Madagascar",
					Code = "MG",
					NativeName = "Madagasikara",
					PhoneCode = "+261",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Antananarivo",
							Code = "T"
						},
						new RegionModel
						{
							Name = "Antsiranana",
							Code = "D"
						},
						new RegionModel
						{
							Name = "Fianarantsoa",
							Code = "F"
						},
						new RegionModel
						{
							Name = "Mahajanga",
							Code = "M"
						},
						new RegionModel
						{
							Name = "Toamasina",
							Code = "A"
						},
						new RegionModel
						{
							Name = "Toliara",
							Code = "U"
						}
					}
				},
				new CountryModel
				{
					Name = "Malawi",
					Code = "MW",
					NativeName = "Malaŵi",
					PhoneCode = "+265",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Balaka",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Blantyre",
							Code = "BL"
						},
						new RegionModel
						{
							Name = "Chikwawa",
							Code = "CK"
						},
						new RegionModel
						{
							Name = "Chiradzulu",
							Code = "CR"
						},
						new RegionModel
						{
							Name = "Chitipa",
							Code = "CT"
						},
						new RegionModel
						{
							Name = "Dedza",
							Code = "DE"
						},
						new RegionModel
						{
							Name = "Dowa",
							Code = "DO"
						},
						new RegionModel
						{
							Name = "Karonga",
							Code = "KR"
						},
						new RegionModel
						{
							Name = "Kasungu",
							Code = "KS"
						},
						new RegionModel
						{
							Name = "Likoma",
							Code = "LK"
						},
						new RegionModel
						{
							Name = "Lilongwe",
							Code = "LI"
						},
						new RegionModel
						{
							Name = "Machinga",
							Code = "MH"
						},
						new RegionModel
						{
							Name = "Mangochi",
							Code = "MG"
						},
						new RegionModel
						{
							Name = "Mchinji",
							Code = "MC"
						},
						new RegionModel
						{
							Name = "Mulanje",
							Code = "MU"
						},
						new RegionModel
						{
							Name = "Mwanza",
							Code = "MW"
						},
						new RegionModel
						{
							Name = "Mzimba",
							Code = "MZ"
						},
						new RegionModel
						{
							Name = "Nkhata Bay",
							Code = "NE"
						},
						new RegionModel
						{
							Name = "Nkhotakota",
							Code = "NB"
						},
						new RegionModel
						{
							Name = "Nsanje",
							Code = "NS"
						},
						new RegionModel
						{
							Name = "Ntcheu",
							Code = "NU"
						},
						new RegionModel
						{
							Name = "Ntchisi",
							Code = "NI"
						},
						new RegionModel
						{
							Name = "Phalombe",
							Code = "PH"
						},
						new RegionModel
						{
							Name = "Rumphi",
							Code = "RU"
						},
						new RegionModel
						{
							Name = "Salima",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "Thyolo",
							Code = "TH"
						},
						new RegionModel
						{
							Name = "Zomba",
							Code = "ZO"
						}
					}
				},
				new CountryModel
				{
					Name = "Malaysia",
					Code = "MY",
					NativeName = "مليسيا",
					PhoneCode = "+60",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Johor",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Kedah",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Kelantan",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Melaka",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Negeri Sembilan",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Pahang",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Perak",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Perlis",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Pulau Pinang",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Sabah",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Sarawak",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Selangor",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Terengganu",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Wilayah Persekutuan (Kuala Lumpur)",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Wilayah Persekutuan (Labuan)",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Wilayah Persekutuan (Putrajaya)",
							Code = "16"
						}
					}
				},
				new CountryModel
				{
					Name = "Maldives",
					Code = "MV",
					NativeName = "ދިވެހިރާއްޖޭގެ ޖުމުހޫރިއްޔާ",
					PhoneCode = "+960",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Alifu Alifu",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Alifu Dhaalu",
							Code = "00"
						},
						new RegionModel
						{
							Name = "Baa",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Dhaalu",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Faafu",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Gaafu Alifu",
							Code = "27"
						},
						new RegionModel
						{
							Name = "Gaafu Dhaalu",
							Code = "28"
						},
						new RegionModel
						{
							Name = "Gnaviyani",
							Code = "29"
						},
						new RegionModel
						{
							Name = "Haa Alifu",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Haa Dhaalu",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Kaafu",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Laamu",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Lhaviyani",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Malé",
							Code = "MLE"
						},
						new RegionModel
						{
							Name = "Meemu",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Noonu",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Raa",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Seenu",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Shaviyani",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Thaa",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Vaavu",
							Code = "04"
						}
					}
				},
				new CountryModel
				{
					Name = "Mali",
					Code = "ML",
					NativeName = "",
					PhoneCode = "+223",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bamako",
							Code = "BKO"
						},
						new RegionModel
						{
							Name = "Gao",
							Code = "7"
						},
						new RegionModel
						{
							Name = "Kayes",
							Code = "1"
						},
						new RegionModel
						{
							Name = "Kidal",
							Code = "8"
						},
						new RegionModel
						{
							Name = "Koulikoro",
							Code = "2"
						},
						new RegionModel
						{
							Name = "Mopti",
							Code = "5"
						},
						new RegionModel
						{
							Name = "Segou",
							Code = "4"
						},
						new RegionModel
						{
							Name = "Sikasso",
							Code = "3"
						},
						new RegionModel
						{
							Name = "Tombouctou",
							Code = "6"
						},
						new RegionModel
						{
							Name = "Taoudénit",
							Code = "9"
						},
						new RegionModel
						{
							Name = "Ménaka",
							Code = "10"
						}
					}
				},
				new CountryModel
				{
					Name = "Malta",
					Code = "MT",
					NativeName = "",
					PhoneCode = "+356",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Attard",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Balzan",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Birgu",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Birkirkara",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Birżebbuġa",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Bormla",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Dingli",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Fgura",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Floriana",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Fontana",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Guda",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Gżira",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Għajnsielem",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Għarb",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Għargħur",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Għasri",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Għaxaq",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Ħamrun",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Iklin",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Isla",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Kalkara",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Kerċem",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Kirkop",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Lija",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Luqa",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Marsa",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Marsaskala",
							Code = "27"
						},
						new RegionModel
						{
							Name = "Marsaxlokk",
							Code = "28"
						},
						new RegionModel
						{
							Name = "Mdina",
							Code = "29"
						},
						new RegionModel
						{
							Name = "Mellieħa",
							Code = "30"
						},
						new RegionModel
						{
							Name = "Mġarr",
							Code = "31"
						},
						new RegionModel
						{
							Name = "Mosta",
							Code = "32"
						},
						new RegionModel
						{
							Name = "Mqabba",
							Code = "33"
						},
						new RegionModel
						{
							Name = "Msida",
							Code = "34"
						},
						new RegionModel
						{
							Name = "Mtarfa",
							Code = "35"
						},
						new RegionModel
						{
							Name = "Munxar",
							Code = "36"
						},
						new RegionModel
						{
							Name = "Nadur",
							Code = "37"
						},
						new RegionModel
						{
							Name = "Naxxar",
							Code = "38"
						},
						new RegionModel
						{
							Name = "Paola",
							Code = "39"
						},
						new RegionModel
						{
							Name = "Pembroke",
							Code = "40"
						},
						new RegionModel
						{
							Name = "Pietà",
							Code = "41"
						},
						new RegionModel
						{
							Name = "Qala",
							Code = "42"
						},
						new RegionModel
						{
							Name = "Qormi",
							Code = "43"
						},
						new RegionModel
						{
							Name = "Qrendi",
							Code = "44"
						},
						new RegionModel
						{
							Name = "Rabat Għawdex",
							Code = "45"
						},
						new RegionModel
						{
							Name = "Rabat Malta",
							Code = "46"
						},
						new RegionModel
						{
							Name = "Safi",
							Code = "47"
						},
						new RegionModel
						{
							Name = "San Ġiljan",
							Code = "48"
						},
						new RegionModel
						{
							Name = "San Ġwann",
							Code = "49"
						},
						new RegionModel
						{
							Name = "San Lawrenz",
							Code = "50"
						},
						new RegionModel
						{
							Name = "San Pawl il-Baħar",
							Code = "51"
						},
						new RegionModel
						{
							Name = "Sannat",
							Code = "52"
						},
						new RegionModel
						{
							Name = "Santa Luċija",
							Code = "53"
						},
						new RegionModel
						{
							Name = "Santa Venera",
							Code = "54"
						},
						new RegionModel
						{
							Name = "Siġġiewi",
							Code = "55"
						},
						new RegionModel
						{
							Name = "Sliema",
							Code = "56"
						},
						new RegionModel
						{
							Name = "Swieqi",
							Code = "57"
						},
						new RegionModel
						{
							Name = "Tai Xbiex",
							Code = "58"
						},
						new RegionModel
						{
							Name = "Tarzien",
							Code = "59"
						},
						new RegionModel
						{
							Name = "Valletta",
							Code = "60"
						},
						new RegionModel
						{
							Name = "Xagħra",
							Code = "61"
						},
						new RegionModel
						{
							Name = "Xewkija",
							Code = "62"
						},
						new RegionModel
						{
							Name = "Xgħajra",
							Code = "63"
						},
						new RegionModel
						{
							Name = "Żabbar",
							Code = "64"
						},
						new RegionModel
						{
							Name = "Żebbuġ Għawde",
							Code = "65"
						},
						new RegionModel
						{
							Name = "Żebbuġ Malta",
							Code = "66"
						},
						new RegionModel
						{
							Name = "Żejtun",
							Code = "67"
						},
						new RegionModel
						{
							Name = "Żurrieq",
							Code = "68"
						}
					}
				},
				new CountryModel
				{
					Name = "Marshall Islands",
					Code = "MH",
					NativeName = "Aolepān Aorōkin M̧ajeļ",
					PhoneCode = "+692",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ailinglaplap",
							Code = "ALL"
						},
						new RegionModel
						{
							Name = "Ailuk",
							Code = "ALK"
						},
						new RegionModel
						{
							Name = "Arno",
							Code = "ARN"
						},
						new RegionModel
						{
							Name = "Aur",
							Code = "AUR"
						},
						new RegionModel
						{
							Name = "Bikini and Kili",
							Code = "KIL"
						},
						new RegionModel
						{
							Name = "Ebon",
							Code = "EBO"
						},
						new RegionModel
						{
							Name = "Jabat",
							Code = "JAB"
						},
						new RegionModel
						{
							Name = "Jaluit",
							Code = "JAL"
						},
						new RegionModel
						{
							Name = "Kwajalein",
							Code = "KWA"
						},
						new RegionModel
						{
							Name = "Lae",
							Code = "LAE"
						},
						new RegionModel
						{
							Name = "Lib",
							Code = "LIB"
						},
						new RegionModel
						{
							Name = "Likiep",
							Code = "LIK"
						},
						new RegionModel
						{
							Name = "Majuro",
							Code = "MAJ"
						},
						new RegionModel
						{
							Name = "Maloelap",
							Code = "MAL"
						},
						new RegionModel
						{
							Name = "Mejit",
							Code = "MEJ"
						},
						new RegionModel
						{
							Name = "Namdrik",
							Code = "NMK"
						},
						new RegionModel
						{
							Name = "Namu",
							Code = "NMU"
						},
						new RegionModel
						{
							Name = "Rongelap",
							Code = "RON"
						},
						new RegionModel
						{
							Name = "Ujae",
							Code = "UJA"
						},
						new RegionModel
						{
							Name = "Utrik",
							Code = "UTI"
						},
						new RegionModel
						{
							Name = "Wotho",
							Code = "WTH"
						},
						new RegionModel
						{
							Name = "Wotje",
							Code = "WTJ"
						}
					}
				},
				new CountryModel
				{
					Name = "Martinique",
					Code = "MQ",
					NativeName = "Matinik ",
					PhoneCode = "+596",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Martinique",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Mauritania",
					Code = "MR",
					NativeName = "الجمهورية الإسلامية الموريتانية , Mauritanie",
					PhoneCode = "+222",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Adrar",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Assaba",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Brakna",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Dakhlet Nouadhibou",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Gorgol",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Guidimaka",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Hodh Ech Chargui",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Hodh El Gharbi",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Inchiri",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Nouakchott Nord",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Nouakchott Ouest",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Nouakchott Sud",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Tagant",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Tiris Zemmour",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Trarza",
							Code = "06"
						}
					}
				},
				new CountryModel
				{
					Name = "Mauritius",
					Code = "MU",
					NativeName = "Maurice , Moris",
					PhoneCode = "+230",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Agalega Islands",
							Code = "AG"
						},
						new RegionModel
						{
							Name = "Beau Bassin-Rose Hill",
							Code = "BR"
						},
						new RegionModel
						{
							Name = "Black River",
							Code = "BL"
						},
						new RegionModel
						{
							Name = "Cargados Carajos Shoals",
							Code = "CC"
						},
						new RegionModel
						{
							Name = "Curepipe",
							Code = "CU"
						},
						new RegionModel
						{
							Name = "Flacq",
							Code = "FL"
						},
						new RegionModel
						{
							Name = "Grand Port",
							Code = "GP"
						},
						new RegionModel
						{
							Name = "Moka",
							Code = "MO"
						},
						new RegionModel
						{
							Name = "Pamplemousses",
							Code = "PA"
						},
						new RegionModel
						{
							Name = "Plaines Wilhems",
							Code = "PW"
						},
						new RegionModel
						{
							Name = "Port Louis (City)",
							Code = "PU"
						},
						new RegionModel
						{
							Name = "Port Louis",
							Code = "PL"
						},
						new RegionModel
						{
							Name = "Riviere du Rempart",
							Code = "RR"
						},
						new RegionModel
						{
							Name = "Rodrigues Island",
							Code = "RO"
						},
						new RegionModel
						{
							Name = "Savanne",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "Vacoas-Phoenix",
							Code = "CP"
						}
					}
				},
				new CountryModel
				{
					Name = "Mayotte",
					Code = "YT",
					NativeName = "",
					PhoneCode = "+262",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Dzaoudzi",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Pamandzi",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Mamoudzou",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Dembeni",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Bandrélé",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Kani-Kéli",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Bouéni",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Chirongui",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Sada",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Ouangani",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Chiconi",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Tsingoni",
							Code = "12"
						},
						new RegionModel
						{
							Name = "M'Tsangamouji",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Acoua",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Mtsamboro",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Bandraboua",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Koungou",
							Code = "17"
						}
					}
				},
				new CountryModel
				{
					Name = "Mexico",
					Code = "MX",
					NativeName = "México",
					PhoneCode = "+52",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aguascalientes",
							Code = "AGU"
						},
						new RegionModel
						{
							Name = "Baja California",
							Code = "BCN"
						},
						new RegionModel
						{
							Name = "Baja California Sur",
							Code = "BCS"
						},
						new RegionModel
						{
							Name = "Campeche",
							Code = "CAM"
						},
						new RegionModel
						{
							Name = "Ciudad de México",
							Code = "DIF"
						},
						new RegionModel
						{
							Name = "Chiapas",
							Code = "CHP"
						},
						new RegionModel
						{
							Name = "Chihuahua",
							Code = "CHH"
						},
						new RegionModel
						{
							Name = "Coahuila de Zaragoza",
							Code = "COA"
						},
						new RegionModel
						{
							Name = "Colima",
							Code = "COL"
						},
						new RegionModel
						{
							Name = "Durango",
							Code = "DUR"
						},
						new RegionModel
						{
							Name = "Estado de México",
							Code = "MEX"
						},
						new RegionModel
						{
							Name = "Guanajuato",
							Code = "GUA"
						},
						new RegionModel
						{
							Name = "Guerrero",
							Code = "GRO"
						},
						new RegionModel
						{
							Name = "Hidalgo",
							Code = "HID"
						},
						new RegionModel
						{
							Name = "Jalisco",
							Code = "JAL"
						},
						new RegionModel
						{
							Name = "Michoacán de Ocampo",
							Code = "MIC"
						},
						new RegionModel
						{
							Name = "Morelos",
							Code = "MOR"
						},
						new RegionModel
						{
							Name = "Nayarit",
							Code = "NAY"
						},
						new RegionModel
						{
							Name = "Nuevo León",
							Code = "NLE"
						},
						new RegionModel
						{
							Name = "Oaxaca",
							Code = "OAX"
						},
						new RegionModel
						{
							Name = "Puebla",
							Code = "PUE"
						},
						new RegionModel
						{
							Name = "Querétaro de Arteaga",
							Code = "QUE"
						},
						new RegionModel
						{
							Name = "Quintana Roo",
							Code = "ROO"
						},
						new RegionModel
						{
							Name = "San Luis Potosí",
							Code = "SLP"
						},
						new RegionModel
						{
							Name = "Sinaloa",
							Code = "SIN"
						},
						new RegionModel
						{
							Name = "Sonora",
							Code = "SON"
						},
						new RegionModel
						{
							Name = "Tabasco",
							Code = "TAB"
						},
						new RegionModel
						{
							Name = "Tamaulipas",
							Code = "TAM"
						},
						new RegionModel
						{
							Name = "Tlaxcala",
							Code = "TLA"
						},
						new RegionModel
						{
							Name = "Veracruz",
							Code = "VER"
						},
						new RegionModel
						{
							Name = "Yucatán",
							Code = "YUC"
						},
						new RegionModel
						{
							Name = "Zacatecas",
							Code = "ZAC"
						}
					}
				},
				new CountryModel
				{
					Name = "Micronesia, Federated States of",
					Code = "FM",
					NativeName = "ミクロネシア",
					PhoneCode = "+691",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Chuuk (Truk)",
							Code = "TRK"
						},
						new RegionModel
						{
							Name = "Kosrae",
							Code = "KSA"
						},
						new RegionModel
						{
							Name = "Pohnpei",
							Code = "PNI"
						},
						new RegionModel
						{
							Name = "Yap",
							Code = "YAP"
						}
					}
				},
				new CountryModel
				{
					Name = "Moldova",
					Code = "MD",
					NativeName = "",
					PhoneCode = "+373",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aenii Noi",
							Code = "AN"
						},
						new RegionModel
						{
							Name = "Basarabeasca",
							Code = "BS"
						},
						new RegionModel
						{
							Name = "Bălți",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Bender",
							Code = "BD"
						},
						new RegionModel
						{
							Name = "Briceni",
							Code = "BR"
						},
						new RegionModel
						{
							Name = "Cahul",
							Code = "CA"
						},
						new RegionModel
						{
							Name = "Cantemir",
							Code = "CT"
						},
						new RegionModel
						{
							Name = "Călărași",
							Code = "CL"
						},
						new RegionModel
						{
							Name = "Căușeni",
							Code = "CS"
						},
						new RegionModel
						{
							Name = "Chișinău",
							Code = "CU"
						},
						new RegionModel
						{
							Name = "Cimișlia",
							Code = "CM"
						},
						new RegionModel
						{
							Name = "Criuleni",
							Code = "CR"
						},
						new RegionModel
						{
							Name = "Dondușeni",
							Code = "DO"
						},
						new RegionModel
						{
							Name = "Drochia",
							Code = "DR"
						},
						new RegionModel
						{
							Name = "Dubăsari",
							Code = "DU"
						},
						new RegionModel
						{
							Name = "Edineț",
							Code = "ED"
						},
						new RegionModel
						{
							Name = "Fălești",
							Code = "FA"
						},
						new RegionModel
						{
							Name = "Florești",
							Code = "FL"
						},
						new RegionModel
						{
							Name = "Găgăuzia",
							Code = "GA"
						},
						new RegionModel
						{
							Name = "Glodeni",
							Code = "GL"
						},
						new RegionModel
						{
							Name = "Hîncești",
							Code = "HI"
						},
						new RegionModel
						{
							Name = "Ialoveni",
							Code = "IA"
						},
						new RegionModel
						{
							Name = "Leova",
							Code = "LE"
						},
						new RegionModel
						{
							Name = "Nisporeni",
							Code = "NI"
						},
						new RegionModel
						{
							Name = "Ocnița",
							Code = "OC"
						},
						new RegionModel
						{
							Name = "Orhei",
							Code = "OR"
						},
						new RegionModel
						{
							Name = "Rezina",
							Code = "RE"
						},
						new RegionModel
						{
							Name = "Rîșcani",
							Code = "RI"
						},
						new RegionModel
						{
							Name = "Sîngerei",
							Code = "SI"
						},
						new RegionModel
						{
							Name = "Soroca",
							Code = "SO"
						},
						new RegionModel
						{
							Name = "Stânga Nistrului",
							Code = "SN"
						},
						new RegionModel
						{
							Name = "Strășeni",
							Code = "ST"
						},
						new RegionModel
						{
							Name = "Șoldănești",
							Code = "SD"
						},
						new RegionModel
						{
							Name = "Ștefan Vodă",
							Code = "SV"
						},
						new RegionModel
						{
							Name = "Taraclia",
							Code = "TA"
						},
						new RegionModel
						{
							Name = "Telenești",
							Code = "TE"
						},
						new RegionModel
						{
							Name = "Ungheni",
							Code = "UN"
						}
					}
				},
				new CountryModel
				{
					Name = "Monaco",
					Code = "MC",
					NativeName = "Mu̍negu , Mónegue",
					PhoneCode = "+377",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Colle",
							Code = "CL"
						},
						new RegionModel
						{
							Name = "Condamine",
							Code = "CO"
						},
						new RegionModel
						{
							Name = "Fontvieille",
							Code = "FO"
						},
						new RegionModel
						{
							Name = "Gare",
							Code = "GA"
						},
						new RegionModel
						{
							Name = "Jardin Exotique",
							Code = "JE"
						},
						new RegionModel
						{
							Name = "Larvotto",
							Code = "LA"
						},
						new RegionModel
						{
							Name = "Malbousquet",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Monaco-Ville",
							Code = "MO"
						},
						new RegionModel
						{
							Name = "Moneghetti",
							Code = "MG"
						},
						new RegionModel
						{
							Name = "Monte-Carlo",
							Code = "MC"
						},
						new RegionModel
						{
							Name = "Moulins",
							Code = "MU"
						},
						new RegionModel
						{
							Name = "Port-Hercule",
							Code = "PH"
						},
						new RegionModel
						{
							Name = "Saint-Roman",
							Code = "SR"
						},
						new RegionModel
						{
							Name = "Sainte-Dévote",
							Code = "SD"
						},
						new RegionModel
						{
							Name = "Source",
							Code = "SO"
						},
						new RegionModel
						{
							Name = "Spélugues",
							Code = "SP"
						},
						new RegionModel
						{
							Name = "Vallon de la Rousse",
							Code = "VR"
						}
					}
				},
				new CountryModel
				{
					Name = "Mongolia",
					Code = "MN",
					NativeName = "ᠮᠣᠩᠭ᠋ᠣᠯᠤᠯᠤᠰ",
					PhoneCode = "+976",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Arhangay",
							Code = "073"
						},
						new RegionModel
						{
							Name = "Bayan-Olgiy",
							Code = "071"
						},
						new RegionModel
						{
							Name = "Bayanhongor",
							Code = "069"
						},
						new RegionModel
						{
							Name = "Bulgan",
							Code = "067"
						},
						new RegionModel
						{
							Name = "Darhan",
							Code = "037"
						},
						new RegionModel
						{
							Name = "Dornod",
							Code = "061"
						},
						new RegionModel
						{
							Name = "Dornogovi",
							Code = "063"
						},
						new RegionModel
						{
							Name = "Dundgovi",
							Code = "059"
						},
						new RegionModel
						{
							Name = "Dzavhan",
							Code = "057"
						},
						new RegionModel
						{
							Name = "Govi-Altay",
							Code = "065"
						},
						new RegionModel
						{
							Name = "Govi-Sumber",
							Code = "064"
						},
						new RegionModel
						{
							Name = "Hovd",
							Code = "043"
						},
						new RegionModel
						{
							Name = "Hovsgol",
							Code = "041"
						},
						new RegionModel
						{
							Name = "Omnogovi",
							Code = "053"
						},
						new RegionModel
						{
							Name = "Ovorhangay",
							Code = "055"
						},
						new RegionModel
						{
							Name = "Selenge",
							Code = "049"
						},
						new RegionModel
						{
							Name = "Suhbaatar",
							Code = "051"
						},
						new RegionModel
						{
							Name = "Tov",
							Code = "047"
						},
						new RegionModel
						{
							Name = "Ulaanbaatar",
							Code = "1"
						},
						new RegionModel
						{
							Name = "Uvs",
							Code = "046"
						},
						new RegionModel
						{
							Name = "Erdenet",
							Code = "074"
						}
					}
				},
				new CountryModel
				{
					Name = "Montenegro",
					Code = "ME",
					NativeName = "Црна Гора , Crna Gora",
					PhoneCode = "+382",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Andrijevica",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Bar",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Berane",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Bijelo Polje",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Budva",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Cetinje",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Danilovgrad",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Gusinje",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Herceg Novi",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Kolašin",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Kotor",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Mojkovac",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Nikšić",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Petnica",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Plav",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Plužine",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Pljevlja",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Podgorica",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Rožaje",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Šavnik",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Tivat",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Ulcinj",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Žabljak",
							Code = "21"
						}
					}
				},
				new CountryModel
				{
					Name = "Montserrat",
					Code = "MS",
					NativeName = "",
					PhoneCode = "+1664",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Saint Anthony",
							Code = null
						},
						new RegionModel
						{
							Name = "Saint Georges",
							Code = null
						},
						new RegionModel
						{
							Name = "Saint Peter's",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Morocco",
					Code = "MA",
					NativeName = "ⵎⵓⵔⴰⴽⵓⵛ , المغرب‎",
					PhoneCode = "+212",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Tanger-Tétouan-Al Hoceïma",
							Code = "MA-01"
						},
						new RegionModel
						{
							Name = "L'Oriental",
							Code = "MA-02"
						},
						new RegionModel
						{
							Name = "Fès-Meknès",
							Code = "MA-03"
						},
						new RegionModel
						{
							Name = "Rabat-Salé-Kénitra",
							Code = "MA-04"
						},
						new RegionModel
						{
							Name = "Béni Mellal-Khénifra",
							Code = "MA-05"
						},
						new RegionModel
						{
							Name = "Casablanca-Settat",
							Code = "MA-06"
						},
						new RegionModel
						{
							Name = "Marrakech-Safi",
							Code = "MA-07"
						},
						new RegionModel
						{
							Name = "Drâa-Tafilalet",
							Code = "MA-08"
						},
						new RegionModel
						{
							Name = "Souss-Massa",
							Code = "MA-09"
						},
						new RegionModel
						{
							Name = "Guelmim-Oued Noun",
							Code = "MA-10"
						},
						new RegionModel
						{
							Name = "Laâyoune-Sakia El Hamra",
							Code = "MA-11"
						},
						new RegionModel
						{
							Name = "Dakhla-Oued Ed-Dahab",
							Code = "MA-12"
						}
					}
				},
				new CountryModel
				{
					Name = "Mozambique",
					Code = "MZ",
					NativeName = "Moçambique",
					PhoneCode = "+258",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Cabo Delgado",
							Code = "P"
						},
						new RegionModel
						{
							Name = "Gaza",
							Code = "G"
						},
						new RegionModel
						{
							Name = "Inhambane",
							Code = "I"
						},
						new RegionModel
						{
							Name = "Manica",
							Code = "B"
						},
						new RegionModel
						{
							Name = "Maputo",
							Code = "L"
						},
						new RegionModel
						{
							Name = "Maputo (City)",
							Code = "MPM"
						},
						new RegionModel
						{
							Name = "Nampula",
							Code = "N"
						},
						new RegionModel
						{
							Name = "Niassa",
							Code = "A"
						},
						new RegionModel
						{
							Name = "Sofala",
							Code = "S"
						},
						new RegionModel
						{
							Name = "Tete",
							Code = "T"
						},
						new RegionModel
						{
							Name = "Zambezia",
							Code = "Q"
						}
					}
				},
				new CountryModel
				{
					Name = "Myanmar",
					Code = "MM",
					NativeName = "ပြည်ထောင်စုသမ္မတမြန်မာနိုင်ငံ",
					PhoneCode = "+95",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ayeyarwady",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Bago",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Chin",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Kachin",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Kayah",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Kayin",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Magway",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Mandalay",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Mon",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Nay Pyi Taw",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Rakhine",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Sagaing",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Shan",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Tanintharyi",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Yangon",
							Code = "06"
						}
					}
				},
				#endregion

				#region N
				
				new CountryModel
				{
					Name = "Namibia",
					Code = "NA",
					NativeName = "Namibië",
					PhoneCode = "+264",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Erongo",
							Code = "ER"
						},
						new RegionModel
						{
							Name = "Hardap",
							Code = "HA"
						},
						new RegionModel
						{
							Name = "Kavango East",
							Code = "KE"
						},
						new RegionModel
						{
							Name = "Kavango West",
							Code = "KW"
						},
						new RegionModel
						{
							Name = "Karas",
							Code = "KA"
						},
						new RegionModel
						{
							Name = "Khomas",
							Code = "KH"
						},
						new RegionModel
						{
							Name = "Kunene",
							Code = "KU"
						},
						new RegionModel
						{
							Name = "Ohangwena",
							Code = "OW"
						},
						new RegionModel
						{
							Name = "Omaheke",
							Code = "OH"
						},
						new RegionModel
						{
							Name = "Omusati",
							Code = "OS"
						},
						new RegionModel
						{
							Name = "Oshana",
							Code = "ON"
						},
						new RegionModel
						{
							Name = "Oshikoto",
							Code = "OT"
						},
						new RegionModel
						{
							Name = "Otjozondjupa",
							Code = "OD"
						},
						new RegionModel
						{
							Name = "Zambezi",
							Code = "CA"
						}
					}
				},
				new CountryModel
				{
					Name = "Nauru",
					Code = "NR",
					NativeName = "Ripublik Naoero",
					PhoneCode = "+674",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aiwo",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Anabar",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Anetan",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Anibare",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Baiti",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Boe",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Buada",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Denigomodu",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Ewa",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Ijuw",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Meneng",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Nibok",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Uaboe",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Yaren",
							Code = "14"
						}
					}
				},
				new CountryModel
				{
					Name = "Nepal",
					Code = "NP",
					NativeName = "नेपाल",
					PhoneCode = "+977",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Province No. 1",
							Code = "1"
						},
						new RegionModel
						{
							Name = "Madhesh Province",
							Code = "2"
						},
						new RegionModel
						{
							Name = "Bagmati Province",
							Code = "3"
						},
						new RegionModel
						{
							Name = "Gandaki Province",
							Code = "4"
						},
						new RegionModel
						{
							Name = "Lumbini Province",
							Code = "5"
						},
						new RegionModel
						{
							Name = "Karnali Province",
							Code = "6"
						},
						new RegionModel
						{
							Name = "Sudurpashchim Province",
							Code = "7"
						}
					}
				},
				new CountryModel
				{
					Name = "Netherlands",
					Code = "NL",
					NativeName = "Nederland",
					PhoneCode = "+31",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Drenthe",
							Code = "DR"
						},
						new RegionModel
						{
							Name = "Flevoland",
							Code = "FL"
						},
						new RegionModel
						{
							Name = "Friesland",
							Code = "FR"
						},
						new RegionModel
						{
							Name = "Gelderland",
							Code = "GE"
						},
						new RegionModel
						{
							Name = "Groningen",
							Code = "GR"
						},
						new RegionModel
						{
							Name = "Limburg",
							Code = "LI"
						},
						new RegionModel
						{
							Name = "Noord-Brabant",
							Code = "NB"
						},
						new RegionModel
						{
							Name = "Noord-Holland",
							Code = "NH"
						},
						new RegionModel
						{
							Name = "Overijssel",
							Code = "OV"
						},
						new RegionModel
						{
							Name = "Utrecht",
							Code = "UT"
						},
						new RegionModel
						{
							Name = "Zeeland",
							Code = "ZE"
						},
						new RegionModel
						{
							Name = "Zuid-Holland",
							Code = "ZH"
						}
					}
				},
				new CountryModel
				{
					Name = "New Caledonia",
					Code = "NC",
					NativeName = "Nouvelle Calédonie",
					PhoneCode = "+687",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Iles Loyaute",
							Code = null
						},
						new RegionModel
						{
							Name = "Nord",
							Code = null
						},
						new RegionModel
						{
							Name = "Sud",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "New Zealand",
					Code = "NZ",
					NativeName = "Aotearoa",
					PhoneCode = "+64",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Auckland",
							Code = "AUK"
						},
						new RegionModel
						{
							Name = "Bay of Plenty",
							Code = "BOP"
						},
						new RegionModel
						{
							Name = "Canterbury",
							Code = "CAN"
						},
						new RegionModel
						{
							Name = "Gisborne",
							Code = "GIS"
						},
						new RegionModel
						{
							Name = "Hawke's Bay",
							Code = "HKB"
						},
						new RegionModel
						{
							Name = "Marlborough",
							Code = "MBH"
						},
						new RegionModel
						{
							Name = "Manawatu-Wanganui",
							Code = "MWT"
						},
						new RegionModel
						{
							Name = "Northland",
							Code = "NTL"
						},
						new RegionModel
						{
							Name = "Nelson",
							Code = "NSN"
						},
						new RegionModel
						{
							Name = "Otago",
							Code = "OTA"
						},
						new RegionModel
						{
							Name = "Southland",
							Code = "STL"
						},
						new RegionModel
						{
							Name = "Taranaki",
							Code = "TKI"
						},
						new RegionModel
						{
							Name = "Tasman",
							Code = "TAS"
						},
						new RegionModel
						{
							Name = "Waikato",
							Code = "WKO"
						},
						new RegionModel
						{
							Name = "Wellington",
							Code = "WGN"
						},
						new RegionModel
						{
							Name = "West Coast",
							Code = "WTC"
						},
						new RegionModel
						{
							Name = "Chatham Islands Territory",
							Code = "CIT"
						}
					}
				},
				new CountryModel
				{
					Name = "Nicaragua",
					Code = "NI",
					NativeName = "",
					PhoneCode = "+505",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Boaco",
							Code = "BO"
						},
						new RegionModel
						{
							Name = "Carazo",
							Code = "CA"
						},
						new RegionModel
						{
							Name = "Chinandega",
							Code = "CI"
						},
						new RegionModel
						{
							Name = "Chontales",
							Code = "CO"
						},
						new RegionModel
						{
							Name = "Estelí",
							Code = "ES"
						},
						new RegionModel
						{
							Name = "Granada",
							Code = "GR"
						},
						new RegionModel
						{
							Name = "Jinotega",
							Code = "JI"
						},
						new RegionModel
						{
							Name = "León",
							Code = "LE"
						},
						new RegionModel
						{
							Name = "Madriz",
							Code = "MD"
						},
						new RegionModel
						{
							Name = "Managua",
							Code = "MN"
						},
						new RegionModel
						{
							Name = "Masaya",
							Code = "MS"
						},
						new RegionModel
						{
							Name = "Matagalpa",
							Code = "MT"
						},
						new RegionModel
						{
							Name = "Nueva Segovia",
							Code = "NS"
						},
						new RegionModel
						{
							Name = "Río San Juan",
							Code = "SJ"
						},
						new RegionModel
						{
							Name = "Rivas",
							Code = "RI"
						},
						new RegionModel
						{
							Name = "Atlántico Norte",
							Code = "AN"
						},
						new RegionModel
						{
							Name = "Atlántico Sur",
							Code = "AS"
						}
					}
				},
				new CountryModel
				{
					Name = "Niger",
					Code = "NE",
					NativeName = "Nijar , Niiser",
					PhoneCode = "+227",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Agadez",
							Code = "1"
						},
						new RegionModel
						{
							Name = "Diffa",
							Code = "2"
						},
						new RegionModel
						{
							Name = "Dosso",
							Code = "3"
						},
						new RegionModel
						{
							Name = "Maradi",
							Code = "4"
						},
						new RegionModel
						{
							Name = "Niamey",
							Code = "8"
						},
						new RegionModel
						{
							Name = "Tahoua",
							Code = "5"
						},
						new RegionModel
						{
							Name = "Tillabéri",
							Code = "6"
						},
						new RegionModel
						{
							Name = "Zinder",
							Code = "7"
						}
					}
				},
				new CountryModel
				{
					Name = "Nigeria",
					Code = "NG",
					NativeName = "Nàìjíríà , Nijeriya, Niiseriya , Naìjíríyà",
					PhoneCode = "+234",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Abia",
							Code = "AB"
						},
						new RegionModel
						{
							Name = "Abuja Federal Capital Territory",
							Code = "FC"
						},
						new RegionModel
						{
							Name = "Adamawa",
							Code = "AD"
						},
						new RegionModel
						{
							Name = "Akwa Ibom",
							Code = "AK"
						},
						new RegionModel
						{
							Name = "Anambra",
							Code = "AN"
						},
						new RegionModel
						{
							Name = "Bauchi",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Bayelsa",
							Code = "BY"
						},
						new RegionModel
						{
							Name = "Benue",
							Code = "BE"
						},
						new RegionModel
						{
							Name = "Borno",
							Code = "BO"
						},
						new RegionModel
						{
							Name = "Cross River",
							Code = "CR"
						},
						new RegionModel
						{
							Name = "Delta",
							Code = "DE"
						},
						new RegionModel
						{
							Name = "Ebonyi",
							Code = "EB"
						},
						new RegionModel
						{
							Name = "Edo",
							Code = "ED"
						},
						new RegionModel
						{
							Name = "Ekiti",
							Code = "EK"
						},
						new RegionModel
						{
							Name = "Enugu",
							Code = "EN"
						},
						new RegionModel
						{
							Name = "Gombe",
							Code = "GO"
						},
						new RegionModel
						{
							Name = "Imo",
							Code = "IM"
						},
						new RegionModel
						{
							Name = "Jigawa",
							Code = "JI"
						},
						new RegionModel
						{
							Name = "Kaduna",
							Code = "KD"
						},
						new RegionModel
						{
							Name = "Kano",
							Code = "KN"
						},
						new RegionModel
						{
							Name = "Katsina",
							Code = "KT"
						},
						new RegionModel
						{
							Name = "Kebbi",
							Code = "KE"
						},
						new RegionModel
						{
							Name = "Kogi",
							Code = "KO"
						},
						new RegionModel
						{
							Name = "Kwara",
							Code = "KW"
						},
						new RegionModel
						{
							Name = "Lagos",
							Code = "LA"
						},
						new RegionModel
						{
							Name = "Nassarawa",
							Code = "NA"
						},
						new RegionModel
						{
							Name = "Niger",
							Code = "NI"
						},
						new RegionModel
						{
							Name = "Ogun",
							Code = "OG"
						},
						new RegionModel
						{
							Name = "Ondo",
							Code = "ON"
						},
						new RegionModel
						{
							Name = "Osun",
							Code = "OS"
						},
						new RegionModel
						{
							Name = "Oyo",
							Code = "OY"
						},
						new RegionModel
						{
							Name = "Plateau",
							Code = "PL"
						},
						new RegionModel
						{
							Name = "Rivers",
							Code = "RI"
						},
						new RegionModel
						{
							Name = "Sokoto",
							Code = "SO"
						},
						new RegionModel
						{
							Name = "Taraba",
							Code = "TA"
						},
						new RegionModel
						{
							Name = "Yobe",
							Code = "YO"
						},
						new RegionModel
						{
							Name = "Zamfara",
							Code = "ZA"
						}
					}
				},
				new CountryModel
				{
					Name = "Niue",
					Code = "NU",
					NativeName = "Niuē-fekai",
					PhoneCode = "+683",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Niue",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Norfolk Island",
					Code = "NF",
					NativeName = "Norfuk Ailen",
					PhoneCode = "+672",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Norfolk Island",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "North Korea",
					Code = "KP",
					NativeName = "조선민주주의인민공화국 , 朝鮮民主主義人民共和國",
					PhoneCode = "+850",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Chagang-do (Chagang Province)",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Hamgyong-bukto (North Hamgyong Province)",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Hamgyong-namdo (South Hamgyong Province)",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Hwanghae-bukto (North Hwanghae Province)",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Hwanghae-namdo (South Hwanghae Province)",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Kangwon-do (Kangwon Province)",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Nasŏn (Najin-Sŏnbong)",
							Code = "13"
						},
						new RegionModel
						{
							Name = "P'yongan-bukto (North P'yongan Province)",
							Code = "03"
						},
						new RegionModel
						{
							Name = "P'yongan-namdo (South P'yongan Province)",
							Code = "02"
						},
						new RegionModel
						{
							Name = "P'yongyang-si (P'yongyang City)",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Yanggang-do (Yanggang Province)",
							Code = "10"
						}
					}
				},
				new CountryModel
				{
					Name = "Northern Mariana Islands",
					Code = "MP",
					NativeName = "",
					PhoneCode = "+1 670",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Northern Islands",
							Code = null
						},
						new RegionModel
						{
							Name = "Rota",
							Code = null
						},
						new RegionModel
						{
							Name = "Saipan",
							Code = null
						},
						new RegionModel
						{
							Name = "Tinian",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Norway",
					Code = "NO",
					NativeName = "Norge , Noreg , Norgga ",
					PhoneCode = "+47",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Akershus",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Aust-Agder",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Buskerud",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Finnmark",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Hedmark",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Hordaland",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Møre og Romsdal",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Nordland",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Nord-Trøndelag",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Oppland",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Oslo",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Rogaland",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Sogn og Fjordane",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Sør-Trøndelag",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Telemark",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Troms",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Vest-Agder",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Vestfold",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Østfold",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Jan Mayen",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Svalbard",
							Code = "21"
						}
					}
				},
				#endregion

				#region O
				new CountryModel
				{
					Name = "Oman",
					Code = "OM",
					NativeName = "سلطانة عمان",
					PhoneCode = "+968",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ad Dakhiliyah",
							Code = "DA"
						},
						new RegionModel
						{
							Name = "Al Buraymi",
							Code = "BU"
						},
						new RegionModel
						{
							Name = "Al Wusta",
							Code = "WU"
						},
						new RegionModel
						{
							Name = "Az Zahirah",
							Code = "ZA"
						},
						new RegionModel
						{
							Name = "Janub al Batinah",
							Code = "BS"
						},
						new RegionModel
						{
							Name = "Janub ash Sharqiyah",
							Code = "SS"
						},
						new RegionModel
						{
							Name = "Masqat",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Musandam",
							Code = "MU"
						},
						new RegionModel
						{
							Name = "Shamal al Batinah",
							Code = "BJ"
						},
						new RegionModel
						{
							Name = "Shamal ash Sharqiyah",
							Code = "SJ"
						},
						new RegionModel
						{
							Name = "Zufar",
							Code = "ZU"
						}
					}
				},
				#endregion

				#region P
				new CountryModel
				{
					Name = "Pakistan",
					Code = "PK",
					NativeName = "اسلامی جمہوریہ پاكستان",
					PhoneCode = "+92",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Āzād Kashmīr",
							Code = "JK"
						},
						new RegionModel
						{
							Name = "Balōchistān",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Gilgit-Baltistān",
							Code = "GB"
						},
						new RegionModel
						{
							Name = "Islāmābād",
							Code = "IS"
						},
						new RegionModel
						{
							Name = "Khaībar Pakhtūnkhwās",
							Code = "KP"
						},
						new RegionModel
						{
							Name = "Punjāb",
							Code = "PB"
						},
						new RegionModel
						{
							Name = "Sindh",
							Code = "SD"
						},
						new RegionModel
						{
							Name = "Federally Administered Tribal Areas",
							Code = "TA"
						}
					}
				},
				new CountryModel
				{
					Name = "Palau",
					Code = "PW",
					NativeName = "Beluu er a Belau , パラオ共和国 ",
					PhoneCode = "+680",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aimeliik",
							Code = "002"
						},
						new RegionModel
						{
							Name = "Airai",
							Code = "004"
						},
						new RegionModel
						{
							Name = "Angaur",
							Code = "010"
						},
						new RegionModel
						{
							Name = "Hatobohei",
							Code = "050"
						},
						new RegionModel
						{
							Name = "Kayangel",
							Code = "100"
						},
						new RegionModel
						{
							Name = "Koror",
							Code = "150"
						},
						new RegionModel
						{
							Name = "Melekeok",
							Code = "212"
						},
						new RegionModel
						{
							Name = "Ngaraard",
							Code = "214"
						},
						new RegionModel
						{
							Name = "Ngarchelong",
							Code = "218"
						},
						new RegionModel
						{
							Name = "Ngardmau",
							Code = "222"
						},
						new RegionModel
						{
							Name = "Ngatpang",
							Code = "224"
						},
						new RegionModel
						{
							Name = "Ngchesar",
							Code = "226"
						},
						new RegionModel
						{
							Name = "Ngeremlengui",
							Code = "227"
						},
						new RegionModel
						{
							Name = "Ngiwal",
							Code = "228"
						},
						new RegionModel
						{
							Name = "Peleliu",
							Code = "350"
						},
						new RegionModel
						{
							Name = "Sonsoral",
							Code = "370"
						}
					}
				},
				new CountryModel
				{
					Name = "Palestine",
					Code = "PS",
					NativeName = "دولة فلسطين",
					PhoneCode = "+970",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ak Khalīl",
							Code = "HBN"
						},
						new RegionModel
						{
							Name = "Al Quds",
							Code = "JEM"
						},
						new RegionModel
						{
							Name = "Arīḩā wal Aghwār",
							Code = "JRH"
						},
						new RegionModel
						{
							Name = "Bayt Laḩm",
							Code = "BTH"
						},
						new RegionModel
						{
							Name = "Dayr al Balaḩ",
							Code = "DEB"
						},
						new RegionModel
						{
							Name = "Ghazzah",
							Code = "GZA"
						},
						new RegionModel
						{
							Name = "Janīn",
							Code = "JEN"
						},
						new RegionModel
						{
							Name = "Khān Yūnis",
							Code = "KYS"
						},
						new RegionModel
						{
							Name = "Nāblus",
							Code = "NBS"
						},
						new RegionModel
						{
							Name = "Qalqīyah",
							Code = "QQA"
						},
						new RegionModel
						{
							Name = "Rafaḩ",
							Code = "RFH"
						},
						new RegionModel
						{
							Name = "Rām Allāh wal Bīrah",
							Code = "RBH"
						},
						new RegionModel
						{
							Name = "Salfīt",
							Code = "SLT"
						},
						new RegionModel
						{
							Name = "Shamāl Ghazzah",
							Code = "NGZ"
						},
						new RegionModel
						{
							Name = "Ţūbās",
							Code = "TBS"
						},
						new RegionModel
						{
							Name = "Ţūlkarm",
							Code = "TKM"
						}
					}
				},
				new CountryModel
				{
					Name = "Panama",
					Code = "PA",
					NativeName = "Panamá",
					PhoneCode = "+507",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bocas del Toro",
							Code = "1"
						},
						new RegionModel
						{
							Name = "Chiriquí",
							Code = "4"
						},
						new RegionModel
						{
							Name = "Coclé",
							Code = "2"
						},
						new RegionModel
						{
							Name = "Colón",
							Code = "3"
						},
						new RegionModel
						{
							Name = "Darién",
							Code = "5"
						},
						new RegionModel
						{
							Name = "Emberá",
							Code = "EM"
						},
						new RegionModel
						{
							Name = "Herrera",
							Code = "6"
						},
						new RegionModel
						{
							Name = "Kuna Yala",
							Code = "KY"
						},
						new RegionModel
						{
							Name = "Los Santos",
							Code = "7"
						},
						new RegionModel
						{
							Name = "Ngäbe-Buglé",
							Code = "NB"
						},
						new RegionModel
						{
							Name = "Panamá",
							Code = "8"
						},
						new RegionModel
						{
							Name = "Panamá Oeste",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Veraguas",
							Code = "9"
						}
					}
				},
				new CountryModel
				{
					Name = "Papua New Guinea",
					Code = "PG",
					NativeName = "Papua Niu Gini , Papua Niugini",
					PhoneCode = "+675",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bougainville",
							Code = "NSB"
						},
						new RegionModel
						{
							Name = "Central",
							Code = "CPM"
						},
						new RegionModel
						{
							Name = "Chimbu",
							Code = "CPK"
						},
						new RegionModel
						{
							Name = "East New Britain",
							Code = "EBR"
						},
						new RegionModel
						{
							Name = "East Sepik",
							Code = "ESW"
						},
						new RegionModel
						{
							Name = "Eastern Highlands",
							Code = "EHG"
						},
						new RegionModel
						{
							Name = "Enga",
							Code = "EPW"
						},
						new RegionModel
						{
							Name = "Gulf",
							Code = "GPK"
						},
						new RegionModel
						{
							Name = "Hela",
							Code = "HLA"
						},
						new RegionModel
						{
							Name = "Jiwaka",
							Code = "JWK"
						},
						new RegionModel
						{
							Name = "Madang",
							Code = "MOM"
						},
						new RegionModel
						{
							Name = "Manus",
							Code = "MRL"
						},
						new RegionModel
						{
							Name = "Milne Bay",
							Code = "MBA"
						},
						new RegionModel
						{
							Name = "Morobe",
							Code = "MPL"
						},
						new RegionModel
						{
							Name = "Port Moresby",
							Code = "NCD"
						},
						new RegionModel
						{
							Name = "New Ireland",
							Code = "NIK"
						},
						new RegionModel
						{
							Name = "Northern",
							Code = "NPP"
						},
						new RegionModel
						{
							Name = "Southern Highlands",
							Code = "SHM"
						},
						new RegionModel
						{
							Name = "West New Britain",
							Code = "WBK"
						},
						new RegionModel
						{
							Name = "West Sepik",
							Code = "SAN"
						},
						new RegionModel
						{
							Name = "Western",
							Code = "WPD"
						},
						new RegionModel
						{
							Name = "Western Highlands",
							Code = "WHM"
						}
					}
				},
				new CountryModel
				{
					Name = "Paraguay",
					Code = "PY",
					NativeName = "Tetã Paraguái",
					PhoneCode = "+595",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Alto Paraguay",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Alto Parana",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Amambay",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Asuncion",
							Code = "ASU"
						},
						new RegionModel
						{
							Name = "Caaguazu",
							Code = "5"
						},
						new RegionModel
						{
							Name = "Caazapa",
							Code = "6"
						},
						new RegionModel
						{
							Name = "Canindeyu",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Central",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Concepcion",
							Code = "1"
						},
						new RegionModel
						{
							Name = "Cordillera",
							Code = "3"
						},
						new RegionModel
						{
							Name = "Boqueron",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Guaira",
							Code = "4"
						},
						new RegionModel
						{
							Name = "Itapua",
							Code = "7"
						},
						new RegionModel
						{
							Name = "Misiones",
							Code = "8"
						},
						new RegionModel
						{
							Name = "Neembucu",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Paraguari",
							Code = "9"
						},
						new RegionModel
						{
							Name = "Presidente Hayes",
							Code = "15"
						},
						new RegionModel
						{
							Name = "San Pedro",
							Code = "2"
						}
					}
				},
				new CountryModel
				{
					Name = "Peru",
					Code = "PE",
					NativeName = "Perú , Piruw",
					PhoneCode = "+51",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Amazonas",
							Code = "AMA"
						},
						new RegionModel
						{
							Name = "Ancash",
							Code = "ANC"
						},
						new RegionModel
						{
							Name = "Apurimac",
							Code = "APU"
						},
						new RegionModel
						{
							Name = "Arequipa",
							Code = "ARE"
						},
						new RegionModel
						{
							Name = "Ayacucho",
							Code = "AYA"
						},
						new RegionModel
						{
							Name = "Cajamarca",
							Code = "CAJ"
						},
						new RegionModel
						{
							Name = "Callao",
							Code = "CAL"
						},
						new RegionModel
						{
							Name = "Cusco",
							Code = "CUS"
						},
						new RegionModel
						{
							Name = "Huancavelica",
							Code = "HUV"
						},
						new RegionModel
						{
							Name = "Huanuco",
							Code = "HUC"
						},
						new RegionModel
						{
							Name = "Ica",
							Code = "ICA"
						},
						new RegionModel
						{
							Name = "Junin",
							Code = "JUN"
						},
						new RegionModel
						{
							Name = "La Libertad",
							Code = "LAL"
						},
						new RegionModel
						{
							Name = "Lambayeque",
							Code = "LAM"
						},
						new RegionModel
						{
							Name = "Lima",
							Code = "LIM"
						},
						new RegionModel
						{
							Name = "Loreto",
							Code = "LOR"
						},
						new RegionModel
						{
							Name = "Madre de Dios",
							Code = "MDD"
						},
						new RegionModel
						{
							Name = "Moquegua",
							Code = "MOQ"
						},
						new RegionModel
						{
							Name = "Municipalidad Metropolitana de Lima",
							Code = "LMA"
						},
						new RegionModel
						{
							Name = "Pasco",
							Code = "PAS"
						},
						new RegionModel
						{
							Name = "Piura",
							Code = "PIU"
						},
						new RegionModel
						{
							Name = "Puno",
							Code = "PUN"
						},
						new RegionModel
						{
							Name = "San Martin",
							Code = "SAM"
						},
						new RegionModel
						{
							Name = "Tacna",
							Code = "TAC"
						},
						new RegionModel
						{
							Name = "Tumbes",
							Code = "TUM"
						},
						new RegionModel
						{
							Name = "Ucayali",
							Code = "UCA"
						}
					}
				},
				new CountryModel
				{
					Name = "Philippines",
					Code = "PH",
					NativeName = "Pilipinas",
					PhoneCode = "+63",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Abra",
							Code = "ABR"
						},
						new RegionModel
						{
							Name = "Agusan del Norte",
							Code = "AGN"
						},
						new RegionModel
						{
							Name = "Agusan del Sur",
							Code = "AGS"
						},
						new RegionModel
						{
							Name = "Aklan",
							Code = "AKL"
						},
						new RegionModel
						{
							Name = "Albay",
							Code = "ALB"
						},
						new RegionModel
						{
							Name = "Antique",
							Code = "ANT"
						},
						new RegionModel
						{
							Name = "Apayao",
							Code = "APA"
						},
						new RegionModel
						{
							Name = "Aurora",
							Code = "AUR"
						},
						new RegionModel
						{
							Name = "Basilan",
							Code = "BAS"
						},
						new RegionModel
						{
							Name = "Bataan",
							Code = "BAN"
						},
						new RegionModel
						{
							Name = "Batanes",
							Code = "BTN"
						},
						new RegionModel
						{
							Name = "Batangas",
							Code = "BTG"
						},
						new RegionModel
						{
							Name = "Benguet",
							Code = "BEN"
						},
						new RegionModel
						{
							Name = "Biliran",
							Code = "BIL"
						},
						new RegionModel
						{
							Name = "Bohol",
							Code = "BOH"
						},
						new RegionModel
						{
							Name = "Bukidnon",
							Code = "BUK"
						},
						new RegionModel
						{
							Name = "Bulacan",
							Code = "BUL"
						},
						new RegionModel
						{
							Name = "Cagayan",
							Code = "CAG"
						},
						new RegionModel
						{
							Name = "Camarines Norte",
							Code = "CAN"
						},
						new RegionModel
						{
							Name = "Camarines Sur",
							Code = "CAS"
						},
						new RegionModel
						{
							Name = "Camiguin",
							Code = "CAM"
						},
						new RegionModel
						{
							Name = "Capiz",
							Code = "CAP"
						},
						new RegionModel
						{
							Name = "Catanduanes",
							Code = "CAT"
						},
						new RegionModel
						{
							Name = "Cavite",
							Code = "CAV"
						},
						new RegionModel
						{
							Name = "Cebu",
							Code = "CEB"
						},
						new RegionModel
						{
							Name = "Compostela",
							Code = "COM"
						},
						new RegionModel
						{
							Name = "Cotabato",
							Code = "NCO"
						},
						new RegionModel
						{
							Name = "Davao del Norte",
							Code = "DAV"
						},
						new RegionModel
						{
							Name = "Davao del Sur",
							Code = "DAS"
						},
						new RegionModel
						{
							Name = "Davao Occidental",
							Code = "DVO"
						},
						new RegionModel
						{
							Name = "Davao Oriental",
							Code = "DAO"
						},
						new RegionModel
						{
							Name = "Dinagat Islands",
							Code = "DIN"
						},
						new RegionModel
						{
							Name = "Eastern Samar",
							Code = "EAS"
						},
						new RegionModel
						{
							Name = "Guimaras",
							Code = "GUI"
						},
						new RegionModel
						{
							Name = "Ifugao",
							Code = "IFU"
						},
						new RegionModel
						{
							Name = "Ilocos Norte",
							Code = "ILN"
						},
						new RegionModel
						{
							Name = "Ilocos Sur",
							Code = "ILS"
						},
						new RegionModel
						{
							Name = "Iloilo",
							Code = "ILI"
						},
						new RegionModel
						{
							Name = "Isabela",
							Code = "ISA"
						},
						new RegionModel
						{
							Name = "Kalinga",
							Code = "KAL"
						},
						new RegionModel
						{
							Name = "La Union",
							Code = "LUN"
						},
						new RegionModel
						{
							Name = "Laguna",
							Code = "LAG"
						},
						new RegionModel
						{
							Name = "Lanao del Norte",
							Code = "LAN"
						},
						new RegionModel
						{
							Name = "Lanao del Sur",
							Code = "LAS"
						},
						new RegionModel
						{
							Name = "Leyte",
							Code = "LEY"
						},
						new RegionModel
						{
							Name = "Maguindanao",
							Code = "MAG"
						},
						new RegionModel
						{
							Name = "Masbate",
							Code = "MAS"
						},
						new RegionModel
						{
							Name = "Metro Manila",
							Code = "00"
						},
						new RegionModel
						{
							Name = "Mindoro Occidental",
							Code = "MDC"
						},
						new RegionModel
						{
							Name = "Mindoro Oriental",
							Code = "MDR"
						},
						new RegionModel
						{
							Name = "Misamis Occidental",
							Code = "MSC"
						},
						new RegionModel
						{
							Name = "Misamis Oriental",
							Code = "MSR"
						},
						new RegionModel
						{
							Name = "Mountain Province",
							Code = "MOU"
						},
						new RegionModel
						{
							Name = "Negros Occidental",
							Code = "NEC"
						},
						new RegionModel
						{
							Name = "Negros Oriental",
							Code = "NER"
						},
						new RegionModel
						{
							Name = "Northern Samar",
							Code = "NSA"
						},
						new RegionModel
						{
							Name = "Nueva Ecija",
							Code = "NUE"
						},
						new RegionModel
						{
							Name = "Nueva Vizcaya",
							Code = "NUV"
						},
						new RegionModel
						{
							Name = "Palawan",
							Code = "PLW"
						},
						new RegionModel
						{
							Name = "Pampanga",
							Code = "PAM"
						},
						new RegionModel
						{
							Name = "Pangasinan",
							Code = "PAN"
						},
						new RegionModel
						{
							Name = "Quezon",
							Code = "QUE"
						},
						new RegionModel
						{
							Name = "Quirino",
							Code = "QUI"
						},
						new RegionModel
						{
							Name = "Rizal",
							Code = "RIZ"
						},
						new RegionModel
						{
							Name = "Romblon",
							Code = "ROM"
						},
						new RegionModel
						{
							Name = "Samar",
							Code = "WSA"
						},
						new RegionModel
						{
							Name = "Sarangani",
							Code = "SAR"
						},
						new RegionModel
						{
							Name = "Siquijor",
							Code = "SIG"
						},
						new RegionModel
						{
							Name = "Sorsogon",
							Code = "SOR"
						},
						new RegionModel
						{
							Name = "Southern Leyte",
							Code = "SLE"
						},
						new RegionModel
						{
							Name = "Sultan Kudarat",
							Code = "AUK"
						},
						new RegionModel
						{
							Name = "Sulu",
							Code = "SLU"
						},
						new RegionModel
						{
							Name = "Surigao del Norte",
							Code = "SUN"
						},
						new RegionModel
						{
							Name = "Surigao del Sur",
							Code = "SUR"
						},
						new RegionModel
						{
							Name = "Tarlac",
							Code = "TAR"
						},
						new RegionModel
						{
							Name = "Tawi-Tawi",
							Code = "TAW"
						},
						new RegionModel
						{
							Name = "Zambales",
							Code = "ZMB"
						},
						new RegionModel
						{
							Name = "Zamboanga del Norte",
							Code = "ZAN"
						},
						new RegionModel
						{
							Name = "Zamboanga del Sur",
							Code = "ZAS"
						},
						new RegionModel
						{
							Name = "Zamboanga Sibugay",
							Code = "ZSI"
						}
					}
				},
				new CountryModel
				{
					Name = "Pitcairn",
					Code = "PN",
					NativeName = "Pitkern Ailen",
					PhoneCode = "+64",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Pitcairn Islands",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Poland",
					Code = "PL",
					NativeName = "Polska",
					PhoneCode = "+48",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Dolnośląskie",
							Code = "DS"
						},
						new RegionModel
						{
							Name = "Kujawsko-pomorskie",
							Code = "KP"
						},
						new RegionModel
						{
							Name = "Łódzkie",
							Code = "LD"
						},
						new RegionModel
						{
							Name = "Lubelskie",
							Code = "LU"
						},
						new RegionModel
						{
							Name = "Lubuskie",
							Code = "LB"
						},
						new RegionModel
						{
							Name = "Małopolskie",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Mazowieckie",
							Code = "MZ"
						},
						new RegionModel
						{
							Name = "Opolskie",
							Code = "OP"
						},
						new RegionModel
						{
							Name = "Podkarpackie",
							Code = "PK"
						},
						new RegionModel
						{
							Name = "Podlaskie",
							Code = "PD"
						},
						new RegionModel
						{
							Name = "Pomorskie",
							Code = "PM"
						},
						new RegionModel
						{
							Name = "Śląskie",
							Code = "SL"
						},
						new RegionModel
						{
							Name = "Świętokrzyskie",
							Code = "SK"
						},
						new RegionModel
						{
							Name = "Warmińsko-mazurskie",
							Code = "WN"
						},
						new RegionModel
						{
							Name = "Wielkopolskie",
							Code = "WP"
						},
						new RegionModel
						{
							Name = "Zachodniopomorskie",
							Code = "ZP"
						}
					}
				},
				new CountryModel
				{
					Name = "Portugal",
					Code = "PT",
					NativeName = "",
					PhoneCode = "+351",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Açores",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Aveiro",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Beja",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Braga",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Bragança",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Castelo Branco",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Coimbra",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Évora",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Faro",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Guarda",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Leiria",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Lisboa",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Madeira",
							Code = "30"
						},
						new RegionModel
						{
							Name = "Portalegre",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Porto",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Santarém",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Setúbal",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Viana do Castelo",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Vila Real",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Viseu",
							Code = "18"
						}
					}
				},
				new CountryModel
				{
					Name = "Puerto Rico",
					Code = "PR",
					NativeName = "",
					PhoneCode = "+1",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Adjuntas",
							Code = null
						},
						new RegionModel
						{
							Name = "Aguada",
							Code = null
						},
						new RegionModel
						{
							Name = "Aguadilla",
							Code = null
						},
						new RegionModel
						{
							Name = "Aguas Buenas",
							Code = null
						},
						new RegionModel
						{
							Name = "Aibonito",
							Code = null
						},
						new RegionModel
						{
							Name = "Anasco",
							Code = null
						},
						new RegionModel
						{
							Name = "Arecibo",
							Code = null
						},
						new RegionModel
						{
							Name = "Arroyo",
							Code = null
						},
						new RegionModel
						{
							Name = "Barceloneta",
							Code = null
						},
						new RegionModel
						{
							Name = "Barranquitas",
							Code = null
						},
						new RegionModel
						{
							Name = "Bayamon",
							Code = null
						},
						new RegionModel
						{
							Name = "Cabo Rojo",
							Code = null
						},
						new RegionModel
						{
							Name = "Caguas",
							Code = null
						},
						new RegionModel
						{
							Name = "Camuy",
							Code = null
						},
						new RegionModel
						{
							Name = "Canovanas",
							Code = null
						},
						new RegionModel
						{
							Name = "Carolina",
							Code = null
						},
						new RegionModel
						{
							Name = "Cat",
							Code = null
						},
						new RegionModel
						{
							Name = "Ceiba",
							Code = null
						},
						new RegionModel
						{
							Name = "Ciales",
							Code = null
						},
						new RegionModel
						{
							Name = "Cidra",
							Code = null
						},
						new RegionModel
						{
							Name = "Coamo",
							Code = null
						},
						new RegionModel
						{
							Name = "Comerio",
							Code = null
						},
						new RegionModel
						{
							Name = "Corozal",
							Code = null
						},
						new RegionModel
						{
							Name = "Culebra",
							Code = null
						},
						new RegionModel
						{
							Name = "Dorado",
							Code = null
						},
						new RegionModel
						{
							Name = "Fajardo",
							Code = null
						},
						new RegionModel
						{
							Name = "Florida",
							Code = null
						},
						new RegionModel
						{
							Name = "Guanica",
							Code = null
						},
						new RegionModel
						{
							Name = "Guayama",
							Code = null
						},
						new RegionModel
						{
							Name = "Guayanilla",
							Code = null
						},
						new RegionModel
						{
							Name = "Guaynabo",
							Code = null
						},
						new RegionModel
						{
							Name = "Gurabo",
							Code = null
						},
						new RegionModel
						{
							Name = "Hatillo",
							Code = null
						},
						new RegionModel
						{
							Name = "Hormigueros",
							Code = null
						},
						new RegionModel
						{
							Name = "Humacao",
							Code = null
						},
						new RegionModel
						{
							Name = "Isabe",
							Code = null
						},
						new RegionModel
						{
							Name = "Juana Diaz",
							Code = null
						},
						new RegionModel
						{
							Name = "Juncos",
							Code = null
						},
						new RegionModel
						{
							Name = "Lajas",
							Code = null
						},
						new RegionModel
						{
							Name = "Lares",
							Code = null
						},
						new RegionModel
						{
							Name = "Las Marias",
							Code = null
						},
						new RegionModel
						{
							Name = "Las oiza",
							Code = null
						},
						new RegionModel
						{
							Name = "Luquillo",
							Code = null
						},
						new RegionModel
						{
							Name = "Manati",
							Code = null
						},
						new RegionModel
						{
							Name = "Maricao",
							Code = null
						},
						new RegionModel
						{
							Name = "Maunabo",
							Code = null
						},
						new RegionModel
						{
							Name = "Mayaguez",
							Code = null
						},
						new RegionModel
						{
							Name = "Moca",
							Code = null
						},
						new RegionModel
						{
							Name = "Morovis",
							Code = null
						},
						new RegionModel
						{
							Name = "Naguabo",
							Code = null
						},
						new RegionModel
						{
							Name = "Naranjito",
							Code = null
						},
						new RegionModel
						{
							Name = "Orocovis",
							Code = null
						},
						new RegionModel
						{
							Name = "Patillas",
							Code = null
						},
						new RegionModel
						{
							Name = "Penuelas",
							Code = null
						},
						new RegionModel
						{
							Name = "Ponce",
							Code = null
						},
						new RegionModel
						{
							Name = "Quebradillas",
							Code = null
						},
						new RegionModel
						{
							Name = "Rincon",
							Code = null
						},
						new RegionModel
						{
							Name = "Rio Grande",
							Code = null
						},
						new RegionModel
						{
							Name = "Sabana linas",
							Code = null
						},
						new RegionModel
						{
							Name = "San German",
							Code = null
						},
						new RegionModel
						{
							Name = "San Juan",
							Code = null
						},
						new RegionModel
						{
							Name = "San Lorenzo",
							Code = null
						},
						new RegionModel
						{
							Name = "San Sebastian",
							Code = null
						},
						new RegionModel
						{
							Name = "Santa Isabel",
							Code = null
						},
						new RegionModel
						{
							Name = "Toa Alta",
							Code = null
						},
						new RegionModel
						{
							Name = "Toa Baja",
							Code = null
						},
						new RegionModel
						{
							Name = "Trujillo Alto",
							Code = null
						},
						new RegionModel
						{
							Name = "Utuado",
							Code = null
						},
						new RegionModel
						{
							Name = "Vega Alta",
							Code = null
						},
						new RegionModel
						{
							Name = "Vega ues",
							Code = null
						},
						new RegionModel
						{
							Name = "Villalba",
							Code = null
						},
						new RegionModel
						{
							Name = "Yabucoa",
							Code = null
						},
						new RegionModel
						{
							Name = "Yauco",
							Code = null
						}
					}
				},
				#endregion

				#region Q
				
				new CountryModel
				{
					Name = "Qatar",
					Code = "QA",
					NativeName = "دولة قطر",
					PhoneCode = "+974",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ad Dawḩah",
							Code = "DA"
						},
						new RegionModel
						{
							Name = "Al Khawr wa adh Dhakhīrah",
							Code = "KH"
						},
						new RegionModel
						{
							Name = "Al Wakrah",
							Code = "WA"
						},
						new RegionModel
						{
							Name = "Ar Rayyān",
							Code = "RA"
						},
						new RegionModel
						{
							Name = "Ash Shamāl",
							Code = "MS"
						},
						new RegionModel
						{
							Name = "Az̧ Za̧`āyin",
							Code = "ZA"
						},
						new RegionModel
						{
							Name = "Umm Şalāl",
							Code = "US"
						}
					}
				},
				#endregion

				#region R
				
				new CountryModel
				{
					Name = "Réunion",
					Code = "RE",
					NativeName = "La Réunion",
					PhoneCode = "+262",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Réunion",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Romania",
					Code = "RO",
					NativeName = "România",
					PhoneCode = "+40",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Alba",
							Code = "AB"
						},
						new RegionModel
						{
							Name = "Arad",
							Code = "AR"
						},
						new RegionModel
						{
							Name = "Arges",
							Code = "AG"
						},
						new RegionModel
						{
							Name = "Bacau",
							Code = "BC"
						},
						new RegionModel
						{
							Name = "Bihor",
							Code = "BH"
						},
						new RegionModel
						{
							Name = "Bistrita-Nasaud",
							Code = "BN"
						},
						new RegionModel
						{
							Name = "Botosani",
							Code = "BT"
						},
						new RegionModel
						{
							Name = "Braila",
							Code = "BR"
						},
						new RegionModel
						{
							Name = "Brasov",
							Code = "BV"
						},
						new RegionModel
						{
							Name = "Bucuresti",
							Code = "B"
						},
						new RegionModel
						{
							Name = "Buzau",
							Code = "BZ"
						},
						new RegionModel
						{
							Name = "Calarasi",
							Code = "CL"
						},
						new RegionModel
						{
							Name = "Caras-Severin",
							Code = "CS"
						},
						new RegionModel
						{
							Name = "Cluj",
							Code = "CJ"
						},
						new RegionModel
						{
							Name = "Constanta",
							Code = "CT"
						},
						new RegionModel
						{
							Name = "Covasna",
							Code = "CV"
						},
						new RegionModel
						{
							Name = "Dambovita",
							Code = "DB"
						},
						new RegionModel
						{
							Name = "Dolj",
							Code = "DJ"
						},
						new RegionModel
						{
							Name = "Galati",
							Code = "GL"
						},
						new RegionModel
						{
							Name = "Giurgiu",
							Code = "GR"
						},
						new RegionModel
						{
							Name = "Gorj",
							Code = "GJ"
						},
						new RegionModel
						{
							Name = "Harghita",
							Code = "HR"
						},
						new RegionModel
						{
							Name = "Hunedoara",
							Code = "HD"
						},
						new RegionModel
						{
							Name = "Ialomita",
							Code = "IL"
						},
						new RegionModel
						{
							Name = "Iasi",
							Code = "IS"
						},
						new RegionModel
						{
							Name = "Maramures",
							Code = "MM"
						},
						new RegionModel
						{
							Name = "Mehedinti",
							Code = "MH"
						},
						new RegionModel
						{
							Name = "Mures",
							Code = "MS"
						},
						new RegionModel
						{
							Name = "Neamt",
							Code = "NT"
						},
						new RegionModel
						{
							Name = "Olt",
							Code = "OT"
						},
						new RegionModel
						{
							Name = "Prahova",
							Code = "PH"
						},
						new RegionModel
						{
							Name = "Salaj",
							Code = "SJ"
						},
						new RegionModel
						{
							Name = "Satu Mare",
							Code = "SM"
						},
						new RegionModel
						{
							Name = "Sibiu",
							Code = "SB"
						},
						new RegionModel
						{
							Name = "Suceava",
							Code = "SV"
						},
						new RegionModel
						{
							Name = "Teleorman",
							Code = "TR"
						},
						new RegionModel
						{
							Name = "Timis",
							Code = "TM"
						},
						new RegionModel
						{
							Name = "Tulcea",
							Code = "TL"
						},
						new RegionModel
						{
							Name = "Valcea",
							Code = "VL"
						},
						new RegionModel
						{
							Name = "Vaslui",
							Code = "VS"
						},
						new RegionModel
						{
							Name = "Vrancea",
							Code = "VN"
						}
					}
				},
				new CountryModel
				{
					Name = "Russian",
					Code = "RU",
					NativeName = "Россия",
					PhoneCode = "+7",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Republic of Adygea",
							Code = "AD"
						},
						new RegionModel
						{
							Name = "Republic of Altai (Gorno-Altaysk)",
							Code = "AL"
						},
						new RegionModel
						{
							Name = "Altai Krai",
							Code = "ALT"
						},
						new RegionModel
						{
							Name = "Amur Oblast",
							Code = "AMU"
						},
						new RegionModel
						{
							Name = "Arkhangelsk Oblast",
							Code = "ARK"
						},
						new RegionModel
						{
							Name = "Astrakhan Oblast",
							Code = "AST"
						},
						new RegionModel
						{
							Name = "Republic of Bashkortostan",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Belgorod Oblast",
							Code = "BEL"
						},
						new RegionModel
						{
							Name = "Bryansk Oblast",
							Code = "BRY"
						},
						new RegionModel
						{
							Name = "Republic of Buryatia",
							Code = "BU"
						},
						new RegionModel
						{
							Name = "Chechen Republic",
							Code = "CE"
						},
						new RegionModel
						{
							Name = "Chelyabinsk Oblast",
							Code = "CHE"
						},
						new RegionModel
						{
							Name = "Chukotka Autonomous Okrug",
							Code = "CHU"
						},
						new RegionModel
						{
							Name = "Chuvash Republic",
							Code = "CU"
						},
						new RegionModel
						{
							Name = "Republic of Dagestan",
							Code = "DA"
						},
						new RegionModel
						{
							Name = "Republic of Ingushetia",
							Code = "IN"
						},
						new RegionModel
						{
							Name = "Irkutsk Oblast",
							Code = "IRK"
						},
						new RegionModel
						{
							Name = "Ivanovo Oblast",
							Code = "IVA"
						},
						new RegionModel
						{
							Name = "Jewish Autonomous Oblast",
							Code = "JEW"
						},
						new RegionModel
						{
							Name = "Kabardino-Balkar Republic",
							Code = "KB"
						},
						new RegionModel
						{
							Name = "Kaliningrad Oblast",
							Code = "KLN"
						},
						new RegionModel
						{
							Name = "Republic of Kalmykia",
							Code = "KL"
						},
						new RegionModel
						{
							Name = "Kaluga Oblast",
							Code = "KLU"
						},
						new RegionModel
						{
							Name = "Kamchatka Krai",
							Code = "KAM"
						},
						new RegionModel
						{
							Name = "Karachay-Cherkess Republic",
							Code = "KC"
						},
						new RegionModel
						{
							Name = "Republic of Karelia",
							Code = "KR"
						},
						new RegionModel
						{
							Name = "Khabarovsk Krai",
							Code = "KHA"
						},
						new RegionModel
						{
							Name = "Republic of Khakassia",
							Code = "KK"
						},
						new RegionModel
						{
							Name = "Khanty-Mansi Autonomous Okrug - Yugra",
							Code = "KHM"
						},
						new RegionModel
						{
							Name = "Kemerovo Oblast",
							Code = "KEM"
						},
						new RegionModel
						{
							Name = "Kirov Oblast",
							Code = "KIR"
						},
						new RegionModel
						{
							Name = "Komi Republic",
							Code = "KO"
						},
						new RegionModel
						{
							Name = "Kostroma Oblast",
							Code = "KOS"
						},
						new RegionModel
						{
							Name = "Krasnodar Krai",
							Code = "KDA"
						},
						new RegionModel
						{
							Name = "Krasnoyarsk Krai",
							Code = "KYA"
						},
						new RegionModel
						{
							Name = "Kurgan Oblast",
							Code = "KGN"
						},
						new RegionModel
						{
							Name = "Kursk Oblast",
							Code = "KRS"
						},
						new RegionModel
						{
							Name = "Leningrad Oblast",
							Code = "LEN"
						},
						new RegionModel
						{
							Name = "Lipetsk Oblast",
							Code = "LIP"
						},
						new RegionModel
						{
							Name = "Magadan Oblast",
							Code = "MAG"
						},
						new RegionModel
						{
							Name = "Mari El Republic",
							Code = "ME"
						},
						new RegionModel
						{
							Name = "Republic of Mordovia",
							Code = "MO"
						},
						new RegionModel
						{
							Name = "Moscow Oblast",
							Code = "MOS"
						},
						new RegionModel
						{
							Name = "Moscow",
							Code = "MOW"
						},
						new RegionModel
						{
							Name = "Murmansk Oblast",
							Code = "MU"
						},
						new RegionModel
						{
							Name = "Nenets Autonomous Okrug",
							Code = "NEN"
						},
						new RegionModel
						{
							Name = "Nizhny Novgorod Oblast",
							Code = "NIZ"
						},
						new RegionModel
						{
							Name = "Novgorod Oblast",
							Code = "NGR"
						},
						new RegionModel
						{
							Name = "Novosibirsk Oblast",
							Code = "NVS"
						},
						new RegionModel
						{
							Name = "Omsk Oblast",
							Code = "OMS"
						},
						new RegionModel
						{
							Name = "Orenburg Oblast",
							Code = "ORE"
						},
						new RegionModel
						{
							Name = "Oryol Oblast",
							Code = "ORL"
						},
						new RegionModel
						{
							Name = "Penza Oblast",
							Code = "PNZ"
						},
						new RegionModel
						{
							Name = "Perm Krai",
							Code = "PER"
						},
						new RegionModel
						{
							Name = "Primorsky Krai",
							Code = "PRI"
						},
						new RegionModel
						{
							Name = "Pskov Oblast",
							Code = "PSK"
						},
						new RegionModel
						{
							Name = "Rostov Oblast",
							Code = "ROS"
						},
						new RegionModel
						{
							Name = "Ryazan Oblast",
							Code = "RYA"
						},
						new RegionModel
						{
							Name = "Saint Petersburg",
							Code = "SPE"
						},
						new RegionModel
						{
							Name = "Sakha (Yakutia) Republic",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "Sakhalin Oblast",
							Code = "SAK"
						},
						new RegionModel
						{
							Name = "Samara Oblast",
							Code = "SAM"
						},
						new RegionModel
						{
							Name = "Saratov Oblast",
							Code = "SAR"
						},
						new RegionModel
						{
							Name = "Republic of North Ossetia-Alania",
							Code = "NOA"
						},
						new RegionModel
						{
							Name = "Smolensk Oblast",
							Code = "SMO"
						},
						new RegionModel
						{
							Name = "Stavropol Krai",
							Code = "STA"
						},
						new RegionModel
						{
							Name = "Sverdlovsk Oblast",
							Code = "SVE"
						},
						new RegionModel
						{
							Name = "Tambov Oblast",
							Code = "TAM"
						},
						new RegionModel
						{
							Name = "Republic of Tatarstan",
							Code = "TA"
						},
						new RegionModel
						{
							Name = "Tomsk Oblast",
							Code = "TOM"
						},
						new RegionModel
						{
							Name = "Tuva Republic",
							Code = "TU"
						},
						new RegionModel
						{
							Name = "Tula Oblast",
							Code = "TUL"
						},
						new RegionModel
						{
							Name = "Tver Oblast",
							Code = "TVE"
						},
						new RegionModel
						{
							Name = "Tyumen Oblast",
							Code = "TYU"
						},
						new RegionModel
						{
							Name = "Udmurt Republic",
							Code = "UD"
						},
						new RegionModel
						{
							Name = "Ulyanovsk Oblast",
							Code = "ULY"
						},
						new RegionModel
						{
							Name = "Vladimir Oblast",
							Code = "VLA"
						},
						new RegionModel
						{
							Name = "Volgograd Oblast",
							Code = "VGG"
						},
						new RegionModel
						{
							Name = "Vologda Oblast",
							Code = "VLG"
						},
						new RegionModel
						{
							Name = "Voronezh Oblast",
							Code = "VOR"
						},
						new RegionModel
						{
							Name = "Yamalo-Nenets Autonomous Okrug",
							Code = "YAN"
						},
						new RegionModel
						{
							Name = "Yaroslavl Oblast",
							Code = "YAR"
						},
						new RegionModel
						{
							Name = "Zabaykalsky Krai",
							Code = "ZAB"
						}
					}
				},
				new CountryModel
				{
					Name = "Rwanda",
					Code = "RW",
					NativeName = "",
					PhoneCode = "+250",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Kigali",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Eastern",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Northern",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Western",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Southern",
							Code = "05"
						}
					}
				},
				#endregion

				#region S
				new CountryModel
				{
					Name = "Saint Barthélemy",
					Code = "BL",
					NativeName = "",
					PhoneCode = "+590",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Au Vent",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Sous le Vent",
							Code = "01"
						}
					}
				},
				new CountryModel
				{
					Name = "Saint Helena",
					Code = "SH",
					NativeName = "",
					PhoneCode = "+290",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ascension",
							Code = "AC"
						},
						new RegionModel
						{
							Name = "Saint Helena",
							Code = "HL"
						},
						new RegionModel
						{
							Name = "Tristan da Cunha",
							Code = "TA"
						}
					}
				},
				new CountryModel
				{
					Name = "Saint Kitts and Nevis",
					Code = "KN",
					NativeName = "",
					PhoneCode = "+1",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Saint Kitts",
							Code = "K"
						},
						new RegionModel
						{
							Name = "Nevis",
							Code = "N"
						}
					}
				},
				new CountryModel
				{
					Name = "Saint Lucia",
					Code = "LC",
					NativeName = "Sent Lisi",
					PhoneCode = "+1",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Anse-la-Raye",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Canaries",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Castries",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Choiseul",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Dennery",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Gros Islet",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Laborie",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Micoud",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Soufriere",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Vieux Fort",
							Code = "11"
						}
					}
				},
				new CountryModel
				{
					Name = "Saint Pierre and Miquelon",
					Code = "PM",
					NativeName = "Saint Pierre et Miquelon",
					PhoneCode = "+508",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Miquelon",
							Code = null
						},
						new RegionModel
						{
							Name = "Saint Pierre",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Saint Vincent and the Grenadines",
					Code = "VC",
					NativeName = "",
					PhoneCode = "+1 784",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Charlotte",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Grenadines",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Saint Andrew",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Saint David",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Saint George",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Saint Patrick",
							Code = "05"
						}
					}
				},
				new CountryModel
				{
					Name = "Samoa",
					Code = "WS",
					NativeName = "Sāmoa",
					PhoneCode = "+685",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "A'ana",
							Code = "AA"
						},
						new RegionModel
						{
							Name = "Aiga-i-le-Tai",
							Code = "AL"
						},
						new RegionModel
						{
							Name = "Atua",
							Code = "AT"
						},
						new RegionModel
						{
							Name = "Fa'asaleleaga",
							Code = "FA"
						},
						new RegionModel
						{
							Name = "Gaga'emauga",
							Code = "GE"
						},
						new RegionModel
						{
							Name = "Gagaifomauga",
							Code = "GI"
						},
						new RegionModel
						{
							Name = "Palauli",
							Code = "PA"
						},
						new RegionModel
						{
							Name = "Satupa'itea",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "Tuamasaga",
							Code = "TU"
						},
						new RegionModel
						{
							Name = "Va'a-o-Fonoti",
							Code = "VF"
						},
						new RegionModel
						{
							Name = "Vaisigano",
							Code = "VS"
						}
					}
				},
				new CountryModel
				{
					Name = "San Marino",
					Code = "SM",
					NativeName = "",
					PhoneCode = "+378",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Acquaviva",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Borgo Maggiore",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Chiesanuova",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Domagnano",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Faetano",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Fiorentino",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Montegiardino",
							Code = "08"
						},
						new RegionModel
						{
							Name = "San Marino",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Serravalle",
							Code = "09"
						}
					}
				},
				new CountryModel
				{
					Name = "Sao Tome and Principe",
					Code = "ST",
					NativeName = "São Tomé e Príncipe",
					PhoneCode = "+239",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Principe",
							Code = "P"
						},
						new RegionModel
						{
							Name = "Sao Tome",
							Code = "S"
						}
					}
				},
				new CountryModel
				{
					Name = "Saudi Arabia",
					Code = "SA",
					NativeName = "المملكة العربية السعودية",
					PhoneCode = "+966",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "'Asir",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Al Bahah",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Al Hudud ash Shamaliyah",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Al Jawf",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Al Madinah al Munawwarah",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Al Qasim",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Ar Riyad",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Ash Sharqiyah",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Ha'il",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Jazan",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Makkah al Mukarramah",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Najran",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Tabuk",
							Code = "07"
						}
					}
				},
				new CountryModel
				{
					Name = "Senegal",
					Code = "SN",
					NativeName = "Sénégal",
					PhoneCode = "+221",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Dakar",
							Code = "DK"
						},
						new RegionModel
						{
							Name = "Diourbel",
							Code = "DB"
						},
						new RegionModel
						{
							Name = "Fatick",
							Code = "FK"
						},
						new RegionModel
						{
							Name = "Kaffrine",
							Code = "KA"
						},
						new RegionModel
						{
							Name = "Kaolack",
							Code = "KL"
						},
						new RegionModel
						{
							Name = "Kedougou",
							Code = "KE"
						},
						new RegionModel
						{
							Name = "Kolda",
							Code = "KD"
						},
						new RegionModel
						{
							Name = "Louga",
							Code = "LG"
						},
						new RegionModel
						{
							Name = "Matam",
							Code = "MT"
						},
						new RegionModel
						{
							Name = "Saint-Louis",
							Code = "SL"
						},
						new RegionModel
						{
							Name = "Sedhiou",
							Code = "SE"
						},
						new RegionModel
						{
							Name = "Tambacounda",
							Code = "TC"
						},
						new RegionModel
						{
							Name = "Thies",
							Code = "TH"
						},
						new RegionModel
						{
							Name = "Ziguinchor",
							Code = "ZG"
						}
					}
				},
				new CountryModel
				{
					Name = "Serbia",
					Code = "RS",
					NativeName = "Србија , Srbija",
					PhoneCode = "+381",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Beograd (Belgrade)",
							Code = "00"
						},
						new RegionModel
						{
							Name = "Borski",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Braničevski",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Jablanički",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Južnobački",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Južnobanatski",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Kolubarski",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Kosovski",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Kosovsko-Mitrovački",
							Code = "28"
						},
						new RegionModel
						{
							Name = "Kosovsko-Pomoravski",
							Code = "29"
						},
						new RegionModel
						{
							Name = "Mačvanski",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Moravički",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Nišavski",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Pčinjski",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Pećki",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Pirotski",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Podunavski",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Pomoravski",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Prizrenski",
							Code = "27"
						},
						new RegionModel
						{
							Name = "Rasinski",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Raški",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Severnobački",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Severnobanatski",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Srednjebanatski",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Sremski",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Šumadijski",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Toplički",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Zaječarski",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Zapadnobački",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Zlatiborski",
							Code = "16"
						}
					}
				},
				new CountryModel
				{
					Name = "Seychelles",
					Code = "SC",
					NativeName = "Sesel",
					PhoneCode = "+248",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Anse aux Pins",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Anse Boileau",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Anse Etoile",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Anse Royale",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Anu Cap",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Baie Lazare",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Baie Sainte Anne",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Beau Vallon",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Bel Air",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Bel Ombre",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Cascade",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Glacis",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Grand'Anse Mahe",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Grand'Anse Praslin",
							Code = "14"
						},
						new RegionModel
						{
							Name = "La Digue",
							Code = "15"
						},
						new RegionModel
						{
							Name = "La Riviere Anglaise",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Les Mamelles",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Mont Buxton",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Mont Fleuri",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Plaisance",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Pointe La Rue",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Port Glaud",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Roche Caiman",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Saint Louis",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Takamaka",
							Code = "23"
						}
					}
				},
				new CountryModel
				{
					Name = "Sierra Leone",
					Code = "SL",
					NativeName = "",
					PhoneCode = "+232",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Eastern",
							Code = "E"
						},
						new RegionModel
						{
							Name = "Northern",
							Code = "N"
						},
						new RegionModel
						{
							Name = "Southern",
							Code = "S"
						},
						new RegionModel
						{
							Name = "Western",
							Code = "W"
						}
					}
				},
				new CountryModel
				{
					Name = "Singapore",
					Code = "SG",
					NativeName = "Singapura , 新加坡 , சிங்கப்பூர்",
					PhoneCode = "+65",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Central Singapore",
							Code = "01"
						},
						new RegionModel
						{
							Name = "North East",
							Code = "02"
						},
						new RegionModel
						{
							Name = "North West",
							Code = "03"
						},
						new RegionModel
						{
							Name = "South East",
							Code = "04"
						},
						new RegionModel
						{
							Name = "South West",
							Code = "05"
						}
					}
				},
				new CountryModel
				{
					Name = "Sint Maarten (Dutch part)",
					Code = "SX",
					NativeName = "Sint Maarten",
					PhoneCode = "+1 721",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Sint Maarten",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Slovakia",
					Code = "SK",
					NativeName = "Slovensko",
					PhoneCode = "+421",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Banskobystricky",
							Code = "BC"
						},
						new RegionModel
						{
							Name = "Bratislavsky",
							Code = "BL"
						},
						new RegionModel
						{
							Name = "Kosicky",
							Code = "KI"
						},
						new RegionModel
						{
							Name = "Nitriansky",
							Code = "NI"
						},
						new RegionModel
						{
							Name = "Presovsky",
							Code = "PV"
						},
						new RegionModel
						{
							Name = "Trenciansky",
							Code = "TC"
						},
						new RegionModel
						{
							Name = "Trnavsky",
							Code = "TA"
						},
						new RegionModel
						{
							Name = "Zilinsky",
							Code = "ZI"
						}
					}
				},
				new CountryModel
				{
					Name = "Slovenia",
					Code = "SI",
					NativeName = "Slovenija",
					PhoneCode = "+386",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ajdovscina",
							Code = "001"
						},
						new RegionModel
						{
							Name = "Apace",
							Code = "195"
						},
						new RegionModel
						{
							Name = "Beltinci",
							Code = "002"
						},
						new RegionModel
						{
							Name = "Benedikt",
							Code = "148"
						},
						new RegionModel
						{
							Name = "Bistrica ob Sotli",
							Code = "149"
						},
						new RegionModel
						{
							Name = "Bled",
							Code = "003"
						},
						new RegionModel
						{
							Name = "Bloke",
							Code = "150"
						},
						new RegionModel
						{
							Name = "Bohinj",
							Code = "004"
						},
						new RegionModel
						{
							Name = "Borovnica",
							Code = "005"
						},
						new RegionModel
						{
							Name = "Bovec",
							Code = "006"
						},
						new RegionModel
						{
							Name = "Braslovce",
							Code = "151"
						},
						new RegionModel
						{
							Name = "Brda",
							Code = "007"
						},
						new RegionModel
						{
							Name = "Brezice",
							Code = "009"
						},
						new RegionModel
						{
							Name = "Brezovica",
							Code = "008"
						},
						new RegionModel
						{
							Name = "Cankova",
							Code = "152"
						},
						new RegionModel
						{
							Name = "Celje",
							Code = "011"
						},
						new RegionModel
						{
							Name = "Cerklje na Gorenjskem",
							Code = "012"
						},
						new RegionModel
						{
							Name = "Cerknica",
							Code = "013"
						},
						new RegionModel
						{
							Name = "Cerkno",
							Code = "014"
						},
						new RegionModel
						{
							Name = "Cerkvenjak",
							Code = "153"
						},
						new RegionModel
						{
							Name = "Cirkulane",
							Code = "196"
						},
						new RegionModel
						{
							Name = "Crensovci",
							Code = "015"
						},
						new RegionModel
						{
							Name = "Crna na Koroskem",
							Code = "016"
						},
						new RegionModel
						{
							Name = "Crnomelj",
							Code = "017"
						},
						new RegionModel
						{
							Name = "Destrnik",
							Code = "018"
						},
						new RegionModel
						{
							Name = "Divaca",
							Code = "019"
						},
						new RegionModel
						{
							Name = "Dobje",
							Code = "154"
						},
						new RegionModel
						{
							Name = "Dobrepolje",
							Code = "020"
						},
						new RegionModel
						{
							Name = "Dobrna",
							Code = "155"
						},
						new RegionModel
						{
							Name = "Dobrova-Polhov Gradec",
							Code = "021"
						},
						new RegionModel
						{
							Name = "Dobrovnik",
							Code = "156"
						},
						new RegionModel
						{
							Name = "Dol pri Ljubljani",
							Code = "022"
						},
						new RegionModel
						{
							Name = "Dolenjske Toplice",
							Code = "157"
						},
						new RegionModel
						{
							Name = "Domzale",
							Code = "023"
						},
						new RegionModel
						{
							Name = "Dornava",
							Code = "024"
						},
						new RegionModel
						{
							Name = "Dravograd",
							Code = "025"
						},
						new RegionModel
						{
							Name = "Duplek",
							Code = "026"
						},
						new RegionModel
						{
							Name = "Gorenja Vas-Poljane",
							Code = "027"
						},
						new RegionModel
						{
							Name = "Gorisnica",
							Code = "028"
						},
						new RegionModel
						{
							Name = "Gorje",
							Code = "207"
						},
						new RegionModel
						{
							Name = "Gornja Radgona",
							Code = "029"
						},
						new RegionModel
						{
							Name = "Gornji Grad",
							Code = "030"
						},
						new RegionModel
						{
							Name = "Gornji Petrovci",
							Code = "031"
						},
						new RegionModel
						{
							Name = "Grad",
							Code = "158"
						},
						new RegionModel
						{
							Name = "Grosuplje",
							Code = "032"
						},
						new RegionModel
						{
							Name = "Hajdina",
							Code = "159"
						},
						new RegionModel
						{
							Name = "Hoce-Slivnica",
							Code = "160"
						},
						new RegionModel
						{
							Name = "Hodos",
							Code = "161"
						},
						new RegionModel
						{
							Name = "Horjul",
							Code = "162"
						},
						new RegionModel
						{
							Name = "Hrastnik",
							Code = "034"
						},
						new RegionModel
						{
							Name = "Hrpelje-Kozina",
							Code = "035"
						},
						new RegionModel
						{
							Name = "Idrija",
							Code = "036"
						},
						new RegionModel
						{
							Name = "Ig",
							Code = "037"
						},
						new RegionModel
						{
							Name = "Ilirska Bistrica",
							Code = "038"
						},
						new RegionModel
						{
							Name = "Ivancna Gorica",
							Code = "039"
						},
						new RegionModel
						{
							Name = "Izola",
							Code = "040"
						},
						new RegionModel
						{
							Name = "Jesenice",
							Code = "041"
						},
						new RegionModel
						{
							Name = "Jursinci",
							Code = "042"
						},
						new RegionModel
						{
							Name = "Kamnik",
							Code = "043"
						},
						new RegionModel
						{
							Name = "Kanal",
							Code = "044"
						},
						new RegionModel
						{
							Name = "Kidricevo",
							Code = "045"
						},
						new RegionModel
						{
							Name = "Kobarid",
							Code = "046"
						},
						new RegionModel
						{
							Name = "Kobilje",
							Code = "047"
						},
						new RegionModel
						{
							Name = "Kocevje",
							Code = "048"
						},
						new RegionModel
						{
							Name = "Komen",
							Code = "049"
						},
						new RegionModel
						{
							Name = "Komenda",
							Code = "164"
						},
						new RegionModel
						{
							Name = "Koper",
							Code = "050"
						},
						new RegionModel
						{
							Name = "Kodanjevica na Krki",
							Code = "197"
						},
						new RegionModel
						{
							Name = "Kostel",
							Code = "165"
						},
						new RegionModel
						{
							Name = "Kozje",
							Code = "051"
						},
						new RegionModel
						{
							Name = "Kranj",
							Code = "052"
						},
						new RegionModel
						{
							Name = "Kranjska Gora",
							Code = "053"
						},
						new RegionModel
						{
							Name = "Krizevci",
							Code = "166"
						},
						new RegionModel
						{
							Name = "Krsko",
							Code = "054"
						},
						new RegionModel
						{
							Name = "Kungota",
							Code = "055"
						},
						new RegionModel
						{
							Name = "Kuzma",
							Code = "056"
						},
						new RegionModel
						{
							Name = "Lasko",
							Code = "057"
						},
						new RegionModel
						{
							Name = "Lenart",
							Code = "058"
						},
						new RegionModel
						{
							Name = "Lendava",
							Code = "059"
						},
						new RegionModel
						{
							Name = "Litija",
							Code = "060"
						},
						new RegionModel
						{
							Name = "Ljubljana",
							Code = "061"
						},
						new RegionModel
						{
							Name = "Ljubno",
							Code = "062"
						},
						new RegionModel
						{
							Name = "Ljutomer",
							Code = "063"
						},
						new RegionModel
						{
							Name = "Log-Dragomer",
							Code = "208"
						},
						new RegionModel
						{
							Name = "Logatec",
							Code = "064"
						},
						new RegionModel
						{
							Name = "Loska Dolina",
							Code = "065"
						},
						new RegionModel
						{
							Name = "Loski Potok",
							Code = "066"
						},
						new RegionModel
						{
							Name = "Lovrenc na Pohorju",
							Code = "167"
						},
						new RegionModel
						{
							Name = "Lukovica",
							Code = "068"
						},
						new RegionModel
						{
							Name = "Luce",
							Code = "067"
						},
						new RegionModel
						{
							Name = "Majsperk",
							Code = "069"
						},
						new RegionModel
						{
							Name = "Makole",
							Code = "198"
						},
						new RegionModel
						{
							Name = "Maribor",
							Code = "070"
						},
						new RegionModel
						{
							Name = "Markovci",
							Code = "168"
						},
						new RegionModel
						{
							Name = "Medvode",
							Code = "071"
						},
						new RegionModel
						{
							Name = "Menges",
							Code = "072"
						},
						new RegionModel
						{
							Name = "Metlika",
							Code = "073"
						},
						new RegionModel
						{
							Name = "Mezica",
							Code = "074"
						},
						new RegionModel
						{
							Name = "Miklavz na Dravskem Polju",
							Code = "169"
						},
						new RegionModel
						{
							Name = "Miren-Kostanjevica",
							Code = "075"
						},
						new RegionModel
						{
							Name = "Mirna",
							Code = "212"
						},
						new RegionModel
						{
							Name = "Mirna Pec",
							Code = "170"
						},
						new RegionModel
						{
							Name = "Mislinja",
							Code = "076"
						},
						new RegionModel
						{
							Name = "Mokronog-Trebelno",
							Code = "199"
						},
						new RegionModel
						{
							Name = "Moravce",
							Code = "077"
						},
						new RegionModel
						{
							Name = "Moravske Toplice",
							Code = "078"
						},
						new RegionModel
						{
							Name = "Mozirje",
							Code = "079"
						},
						new RegionModel
						{
							Name = "Murska Sobota",
							Code = "080"
						},
						new RegionModel
						{
							Name = "Naklo",
							Code = "082"
						},
						new RegionModel
						{
							Name = "Nazarje",
							Code = "083"
						},
						new RegionModel
						{
							Name = "Nova Gorica",
							Code = "084"
						},
						new RegionModel
						{
							Name = "Novo Mesto",
							Code = "085"
						},
						new RegionModel
						{
							Name = "Odranci",
							Code = "086"
						},
						new RegionModel
						{
							Name = "Ormoz",
							Code = "087"
						},
						new RegionModel
						{
							Name = "Osilnica",
							Code = "088"
						},
						new RegionModel
						{
							Name = "Pesnica",
							Code = "089"
						},
						new RegionModel
						{
							Name = "Piran",
							Code = "090"
						},
						new RegionModel
						{
							Name = "Pivka",
							Code = "091"
						},
						new RegionModel
						{
							Name = "Podcetrtek",
							Code = "092"
						},
						new RegionModel
						{
							Name = "Podlehnik",
							Code = "172"
						},
						new RegionModel
						{
							Name = "Podvelka",
							Code = "093"
						},
						new RegionModel
						{
							Name = "Poljcane",
							Code = "200"
						},
						new RegionModel
						{
							Name = "Postojna",
							Code = "094"
						},
						new RegionModel
						{
							Name = "Prebold",
							Code = "174"
						},
						new RegionModel
						{
							Name = "Preddvor",
							Code = "095"
						},
						new RegionModel
						{
							Name = "Prevalje",
							Code = "175"
						},
						new RegionModel
						{
							Name = "Ptuj",
							Code = "096"
						},
						new RegionModel
						{
							Name = "Race-Fram",
							Code = "098"
						},
						new RegionModel
						{
							Name = "Radece",
							Code = "099"
						},
						new RegionModel
						{
							Name = "Radenci",
							Code = "100"
						},
						new RegionModel
						{
							Name = "Radlje ob Dravi",
							Code = "101"
						},
						new RegionModel
						{
							Name = "Radovljica",
							Code = "102"
						},
						new RegionModel
						{
							Name = "Ravne na Koroskem",
							Code = "103"
						},
						new RegionModel
						{
							Name = "Razkrizje",
							Code = "176"
						},
						new RegionModel
						{
							Name = "Recica ob Savinji",
							Code = "209"
						},
						new RegionModel
						{
							Name = "Rence-Vogrsko",
							Code = "201"
						},
						new RegionModel
						{
							Name = "Ribnica",
							Code = "104"
						},
						new RegionModel
						{
							Name = "Ribnica na Poboriu",
							Code = "177"
						},
						new RegionModel
						{
							Name = "Rogaska Slatina",
							Code = "106"
						},
						new RegionModel
						{
							Name = "Rogasovci",
							Code = "105"
						},
						new RegionModel
						{
							Name = "Rogatec",
							Code = "107"
						},
						new RegionModel
						{
							Name = "Ruse",
							Code = "108"
						},
						new RegionModel
						{
							Name = "Salovci",
							Code = "033"
						},
						new RegionModel
						{
							Name = "Selnica ob Dravi",
							Code = "178"
						},
						new RegionModel
						{
							Name = "Semic",
							Code = "109"
						},
						new RegionModel
						{
							Name = "Sempeter-Vrtojba",
							Code = "183"
						},
						new RegionModel
						{
							Name = "Sencur",
							Code = "117"
						},
						new RegionModel
						{
							Name = "Sentilj",
							Code = "118"
						},
						new RegionModel
						{
							Name = "Sentjernej",
							Code = "119"
						},
						new RegionModel
						{
							Name = "Sentjur",
							Code = "120"
						},
						new RegionModel
						{
							Name = "Sentrupert",
							Code = "211"
						},
						new RegionModel
						{
							Name = "Sevnica",
							Code = "110"
						},
						new RegionModel
						{
							Name = "Sezana",
							Code = "111"
						},
						new RegionModel
						{
							Name = "Skocjan",
							Code = "121"
						},
						new RegionModel
						{
							Name = "Skofja Loka",
							Code = "122"
						},
						new RegionModel
						{
							Name = "Skofljica",
							Code = "123"
						},
						new RegionModel
						{
							Name = "Slovenj Gradec",
							Code = "112"
						},
						new RegionModel
						{
							Name = "Slovenska Bistrica",
							Code = "113"
						},
						new RegionModel
						{
							Name = "Slovenske Konjice",
							Code = "114"
						},
						new RegionModel
						{
							Name = "Smarje pri elsah",
							Code = "124"
						},
						new RegionModel
						{
							Name = "Smarjeske Toplice",
							Code = "206"
						},
						new RegionModel
						{
							Name = "Smartno ob Paki",
							Code = "125"
						},
						new RegionModel
						{
							Name = "Smartno pri Litiji",
							Code = "194"
						},
						new RegionModel
						{
							Name = "Sodrazica",
							Code = "179"
						},
						new RegionModel
						{
							Name = "Solcava",
							Code = "180"
						},
						new RegionModel
						{
							Name = "Sostanj",
							Code = "126"
						},
						new RegionModel
						{
							Name = "Sredisce ob Dravi",
							Code = "202"
						},
						new RegionModel
						{
							Name = "Starse",
							Code = "115"
						},
						new RegionModel
						{
							Name = "Store",
							Code = "127"
						},
						new RegionModel
						{
							Name = "Straza",
							Code = "203"
						},
						new RegionModel
						{
							Name = "Sveta Ana",
							Code = "181"
						},
						new RegionModel
						{
							Name = "Sveta Trojica v Slovenskih Goricah",
							Code = "204"
						},
						new RegionModel
						{
							Name = "Sveta Andraz v Slovenskih Goricah",
							Code = "182"
						},
						new RegionModel
						{
							Name = "Sveti Jurij",
							Code = "116"
						},
						new RegionModel
						{
							Name = "Sveti Jurij v Slovenskih Goricah",
							Code = "210"
						},
						new RegionModel
						{
							Name = "Sveti Tomaz",
							Code = "205"
						},
						new RegionModel
						{
							Name = "Tabor",
							Code = "184"
						},
						new RegionModel
						{
							Name = "Tisina",
							Code = "010"
						},
						new RegionModel
						{
							Name = "Tolmin",
							Code = "128"
						},
						new RegionModel
						{
							Name = "Trbovlje",
							Code = "129"
						},
						new RegionModel
						{
							Name = "Trebnje",
							Code = "130"
						},
						new RegionModel
						{
							Name = "Trnovska Vas",
							Code = "185"
						},
						new RegionModel
						{
							Name = "Trzin",
							Code = "186"
						},
						new RegionModel
						{
							Name = "Trzic",
							Code = "131"
						},
						new RegionModel
						{
							Name = "Turnisce",
							Code = "132"
						},
						new RegionModel
						{
							Name = "Velenje",
							Code = "133"
						},
						new RegionModel
						{
							Name = "Velika Polana",
							Code = "187"
						},
						new RegionModel
						{
							Name = "Velike Lasce",
							Code = "134"
						},
						new RegionModel
						{
							Name = "Verzej",
							Code = "188"
						},
						new RegionModel
						{
							Name = "Videm",
							Code = "135"
						},
						new RegionModel
						{
							Name = "Vipava",
							Code = "136"
						},
						new RegionModel
						{
							Name = "Vitanje",
							Code = "137"
						},
						new RegionModel
						{
							Name = "Vodice",
							Code = "138"
						},
						new RegionModel
						{
							Name = "Vojnik",
							Code = "139"
						},
						new RegionModel
						{
							Name = "Vransko",
							Code = "189"
						},
						new RegionModel
						{
							Name = "Vrhnika",
							Code = "140"
						},
						new RegionModel
						{
							Name = "Vuzenica",
							Code = "141"
						},
						new RegionModel
						{
							Name = "Zagorje ob Savi",
							Code = "142"
						},
						new RegionModel
						{
							Name = "Zavrc",
							Code = "143"
						},
						new RegionModel
						{
							Name = "Zrece",
							Code = "144"
						},
						new RegionModel
						{
							Name = "Zalec",
							Code = "190"
						},
						new RegionModel
						{
							Name = "Zelezniki",
							Code = "146"
						},
						new RegionModel
						{
							Name = "Zetale",
							Code = "191"
						},
						new RegionModel
						{
							Name = "Ziri",
							Code = "147"
						},
						new RegionModel
						{
							Name = "Zirovnica",
							Code = "192"
						},
						new RegionModel
						{
							Name = "Zuzemberk",
							Code = "193"
						}
					}
				},
				new CountryModel
				{
					Name = "Solomon Islands",
					Code = "SB",
					NativeName = "",
					PhoneCode = "+677",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Central",
							Code = "CE"
						},
						new RegionModel
						{
							Name = "Choiseul",
							Code = "CH"
						},
						new RegionModel
						{
							Name = "Guadalcanal",
							Code = "GU"
						},
						new RegionModel
						{
							Name = "Honiara",
							Code = "CT"
						},
						new RegionModel
						{
							Name = "Isabel",
							Code = "IS"
						},
						new RegionModel
						{
							Name = "Makira-Ulawa",
							Code = "MK"
						},
						new RegionModel
						{
							Name = "Malaita",
							Code = "ML"
						},
						new RegionModel
						{
							Name = "Rennell and Bellona",
							Code = "RB"
						},
						new RegionModel
						{
							Name = "Temotu",
							Code = "TE"
						},
						new RegionModel
						{
							Name = "Western",
							Code = "WE"
						}
					}
				},
				new CountryModel
				{
					Name = "Somalia",
					Code = "SO",
					NativeName = "Jamhuuriyadda Federaalka Soomaaliya , جمهورية الصومال الفدرالية",
					PhoneCode = "+252",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Awdal",
							Code = "AW"
						},
						new RegionModel
						{
							Name = "Bakool",
							Code = "BK"
						},
						new RegionModel
						{
							Name = "Banaadir",
							Code = "BN"
						},
						new RegionModel
						{
							Name = "Bari",
							Code = "BR"
						},
						new RegionModel
						{
							Name = "Bay",
							Code = "BY"
						},
						new RegionModel
						{
							Name = "Galguduud",
							Code = "GA"
						},
						new RegionModel
						{
							Name = "Gedo",
							Code = "GE"
						},
						new RegionModel
						{
							Name = "Hiiraan",
							Code = "HI"
						},
						new RegionModel
						{
							Name = "Jubbada Dhexe",
							Code = "JD"
						},
						new RegionModel
						{
							Name = "Jubbada Hoose",
							Code = "JH"
						},
						new RegionModel
						{
							Name = "Mudug",
							Code = "MU"
						},
						new RegionModel
						{
							Name = "Nugaal",
							Code = "NU"
						},
						new RegionModel
						{
							Name = "Sanaag",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "Shabeellaha Dhexe",
							Code = "SD"
						},
						new RegionModel
						{
							Name = "Shabeellaha Hoose",
							Code = "SH"
						},
						new RegionModel
						{
							Name = "Sool",
							Code = "SO"
						},
						new RegionModel
						{
							Name = "Togdheer",
							Code = "TO"
						},
						new RegionModel
						{
							Name = "Woqooyi Galbeed",
							Code = "WO"
						}
					}
				},
				new CountryModel
				{
					Name = "South Africa",
					Code = "ZA",
					NativeName = "Suid-Afrika , Iningizimu Afrika , Mzantsi Afrika",
					PhoneCode = "+27",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Eastern Cape",
							Code = "EC"
						},
						new RegionModel
						{
							Name = "Free State",
							Code = "FS"
						},
						new RegionModel
						{
							Name = "Gauteng",
							Code = "GT"
						},
						new RegionModel
						{
							Name = "KwaZulu-Natal",
							Code = "NL"
						},
						new RegionModel
						{
							Name = "Limpopo",
							Code = "LP"
						},
						new RegionModel
						{
							Name = "Mpumalanga",
							Code = "MP"
						},
						new RegionModel
						{
							Name = "Northern Cape",
							Code = "NC"
						},
						new RegionModel
						{
							Name = "North West",
							Code = "NW"
						},
						new RegionModel
						{
							Name = "Western Cape",
							Code = "WC"
						}
					}
				},
				new CountryModel
				{
					Name = "South Georgia and South Sandwich Islands",
					Code = "GS",
					NativeName = "",
					PhoneCode = "+500",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bird Island",
							Code = null
						},
						new RegionModel
						{
							Name = "Bristol Island",
							Code = null
						},
						new RegionModel
						{
							Name = "Clerke Rocks",
							Code = null
						},
						new RegionModel
						{
							Name = "Montagu Island",
							Code = null
						},
						new RegionModel
						{
							Name = "Saunders Island",
							Code = null
						},
						new RegionModel
						{
							Name = "South Georgia",
							Code = null
						},
						new RegionModel
						{
							Name = "Southern Thule",
							Code = null
						},
						new RegionModel
						{
							Name = "Traversay Islands",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "South Sudan",
					Code = "SS",
					NativeName = "Jamhuri ya Sudan Kusini",
					PhoneCode = "+211",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Central Equatoria",
							Code = "CE"
						},
						new RegionModel
						{
							Name = "Eastern Equatoria",
							Code = "EE"
						},
						new RegionModel
						{
							Name = "Jonglei",
							Code = "JG"
						},
						new RegionModel
						{
							Name = "Lakes",
							Code = "LK"
						},
						new RegionModel
						{
							Name = "Northern Bahr el Ghazal",
							Code = "BN"
						},
						new RegionModel
						{
							Name = "Unity",
							Code = "UY"
						},
						new RegionModel
						{
							Name = "Upper Nile",
							Code = "NU"
						},
						new RegionModel
						{
							Name = "Warrap",
							Code = "WR"
						},
						new RegionModel
						{
							Name = "Western Bahr el Ghazal",
							Code = "BW"
						},
						new RegionModel
						{
							Name = "Western Equatoria",
							Code = "EW"
						}
					}
				},
				new CountryModel
				{
					Name = "Spain",
					Code = "ES",
					NativeName = "España",
					PhoneCode = "+34",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Albacete",
							Code = "AB"
						},
						new RegionModel
						{
							Name = "Alicante",
							Code = "A"
						},
						new RegionModel
						{
							Name = "Almería",
							Code = "AN"
						},
						new RegionModel
						{
							Name = "Araba/Álava",
							Code = "VI"
						},
						new RegionModel
						{
							Name = "Asturias",
							Code = "O"
						},
						new RegionModel
						{
							Name = "Ávila",
							Code = "AV"
						},
						new RegionModel
						{
							Name = "Badajoz",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Barcelona",
							Code = "B"
						},
						new RegionModel
						{
							Name = "Bizkaia",
							Code = "BI"
						},
						new RegionModel
						{
							Name = "Burgos",
							Code = "BU"
						},
						new RegionModel
						{
							Name = "Cáceres",
							Code = "CC"
						},
						new RegionModel
						{
							Name = "Cádiz",
							Code = "CA"
						},
						new RegionModel
						{
							Name = "Cantabria",
							Code = "S"
						},
						new RegionModel
						{
							Name = "Castellón/Castelló",
							Code = "CS"
						},
						new RegionModel
						{
							Name = "Ceuta",
							Code = "CE"
						},
						new RegionModel
						{
							Name = "Ciudad Real",
							Code = "CR"
						},
						new RegionModel
						{
							Name = "Córdoba",
							Code = "CO"
						},
						new RegionModel
						{
							Name = "A Coruña",
							Code = "C"
						},
						new RegionModel
						{
							Name = "Cuenca",
							Code = "CU"
						},
						new RegionModel
						{
							Name = "Gipuzkoa",
							Code = "SS"
						},
						new RegionModel
						{
							Name = "Girona",
							Code = "GI"
						},
						new RegionModel
						{
							Name = "Granada",
							Code = "GR"
						},
						new RegionModel
						{
							Name = "Guadalajara",
							Code = "GU"
						},
						new RegionModel
						{
							Name = "Huelva",
							Code = "H"
						},
						new RegionModel
						{
							Name = "Huesca",
							Code = "HU"
						},
						new RegionModel
						{
							Name = "Illes Balears",
							Code = "PM"
						},
						new RegionModel
						{
							Name = "Jaén",
							Code = "J"
						},
						new RegionModel
						{
							Name = "León",
							Code = "LE"
						},
						new RegionModel
						{
							Name = "Lleida",
							Code = "L"
						},
						new RegionModel
						{
							Name = "Lugo",
							Code = "LU"
						},
						new RegionModel
						{
							Name = "Madrid",
							Code = "M"
						},
						new RegionModel
						{
							Name = "Málaga",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Melilla",
							Code = "ML"
						},
						new RegionModel
						{
							Name = "Murcia",
							Code = "MU"
						},
						new RegionModel
						{
							Name = "Navarra/Nafarroa",
							Code = "NA"
						},
						new RegionModel
						{
							Name = "Ourense",
							Code = "OR"
						},
						new RegionModel
						{
							Name = "Palencia",
							Code = "P"
						},
						new RegionModel
						{
							Name = "Las Palmas",
							Code = "GC"
						},
						new RegionModel
						{
							Name = "Pontevedra",
							Code = "PO"
						},
						new RegionModel
						{
							Name = "La Rioja",
							Code = "LO"
						},
						new RegionModel
						{
							Name = "Salamanca",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "Santa Cruz de Tenerife",
							Code = "TF"
						},
						new RegionModel
						{
							Name = "Segovia",
							Code = "SG"
						},
						new RegionModel
						{
							Name = "Sevilla",
							Code = "SE"
						},
						new RegionModel
						{
							Name = "Soria",
							Code = "SO"
						},
						new RegionModel
						{
							Name = "Tarragona",
							Code = "T"
						},
						new RegionModel
						{
							Name = "Teruel",
							Code = "TE"
						},
						new RegionModel
						{
							Name = "Toledo",
							Code = "TO"
						},
						new RegionModel
						{
							Name = "Valencia/València",
							Code = "V"
						},
						new RegionModel
						{
							Name = "Valladolid",
							Code = "VA"
						},
						new RegionModel
						{
							Name = "Zamora",
							Code = "ZA"
						},
						new RegionModel
						{
							Name = "Zaragoza",
							Code = "Z"
						}
					}
				},
				new CountryModel
				{
					Name = "Sri Lanka",
					Code = "LK",
					NativeName = "ශ්රී ලංකාව , இலங்கை",
					PhoneCode = "+94",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Basnahira",
							Code = "1"
						},
						new RegionModel
						{
							Name = "Dakunu",
							Code = "3"
						},
						new RegionModel
						{
							Name = "Madhyama",
							Code = "2"
						},
						new RegionModel
						{
							Name = "Naegenahira",
							Code = "5"
						},
						new RegionModel
						{
							Name = "Sabaragamuwa",
							Code = "9"
						},
						new RegionModel
						{
							Name = "Uturu",
							Code = "4"
						},
						new RegionModel
						{
							Name = "Uturumaeda",
							Code = "7"
						},
						new RegionModel
						{
							Name = "Vayamba",
							Code = "6"
						},
						new RegionModel
						{
							Name = "Uva",
							Code = "8"
						}
					}
				},
				new CountryModel
				{
					Name = "Sudan",
					Code = "SD",
					NativeName = "جمهورية السودان",
					PhoneCode = "+249",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Al Bahr al Ahmar",
							Code = "RS"
						},
						new RegionModel
						{
							Name = "Al Jazirah",
							Code = "GZ"
						},
						new RegionModel
						{
							Name = "Al Khartum",
							Code = "KH"
						},
						new RegionModel
						{
							Name = "Al Qadarif",
							Code = "GD"
						},
						new RegionModel
						{
							Name = "An Nil al Abyad",
							Code = "NW"
						},
						new RegionModel
						{
							Name = "An Nil al Azraq",
							Code = "NB"
						},
						new RegionModel
						{
							Name = "Ash Shamaliyah",
							Code = "NO"
						},
						new RegionModel
						{
							Name = "Gharb Darfur",
							Code = "DW"
						},
						new RegionModel
						{
							Name = "Gharb Kurdufan",
							Code = "GK"
						},
						new RegionModel
						{
							Name = "Janub Darfur",
							Code = "DS"
						},
						new RegionModel
						{
							Name = "Janub Kurdufan",
							Code = "KS"
						},
						new RegionModel
						{
							Name = "Kassala",
							Code = "KA"
						},
						new RegionModel
						{
							Name = "Nahr an Nil",
							Code = "NR"
						},
						new RegionModel
						{
							Name = "Shamal Darfur",
							Code = "DN"
						},
						new RegionModel
						{
							Name = "Sharq Darfur",
							Code = "DE"
						},
						new RegionModel
						{
							Name = "Shiamal Kurdufan",
							Code = "KN"
						},
						new RegionModel
						{
							Name = "Sinnar",
							Code = "SI"
						},
						new RegionModel
						{
							Name = "Wasat Darfur Zalinjay",
							Code = "DC"
						}
					}
				},
				new CountryModel
				{
					Name = "Suriname",
					Code = "SR",
					NativeName = "",
					PhoneCode = "+597",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Brokopondo",
							Code = "BR"
						},
						new RegionModel
						{
							Name = "Commewijne",
							Code = "CM"
						},
						new RegionModel
						{
							Name = "Coronie",
							Code = "CR"
						},
						new RegionModel
						{
							Name = "Marowijne",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Nickerie",
							Code = "NI"
						},
						new RegionModel
						{
							Name = "Para",
							Code = "PR"
						},
						new RegionModel
						{
							Name = "Paramaribo",
							Code = "PM"
						},
						new RegionModel
						{
							Name = "Saramacca",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "Sipaliwini",
							Code = "SI"
						},
						new RegionModel
						{
							Name = "Wanica",
							Code = "WA"
						}
					}
				},
				new CountryModel
				{
					Name = "Swaziland",
					Code = "SZ",
					NativeName = "Umbuso weSwatini",
					PhoneCode = "+268",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Hhohho",
							Code = "HH"
						},
						new RegionModel
						{
							Name = "Lubombo",
							Code = "LU"
						},
						new RegionModel
						{
							Name = "Manzini",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Shiselweni",
							Code = "SH"
						}
					}
				},
				new CountryModel
				{
					Name = "Sweden",
					Code = "SE",
					NativeName = "Sverige",
					PhoneCode = "+46",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Blekinge",
							Code = "K"
						},
						new RegionModel
						{
							Name = "Dalarna",
							Code = "W"
						},
						new RegionModel
						{
							Name = "Gävleborg",
							Code = "X"
						},
						new RegionModel
						{
							Name = "Gotland",
							Code = "I"
						},
						new RegionModel
						{
							Name = "Halland",
							Code = "N"
						},
						new RegionModel
						{
							Name = "Jämtland",
							Code = "Z"
						},
						new RegionModel
						{
							Name = "Jönköping",
							Code = "F"
						},
						new RegionModel
						{
							Name = "Kalmar",
							Code = "H"
						},
						new RegionModel
						{
							Name = "Kronoberg",
							Code = "G"
						},
						new RegionModel
						{
							Name = "Norrbotten",
							Code = "BD"
						},
						new RegionModel
						{
							Name = "Örebro",
							Code = "T"
						},
						new RegionModel
						{
							Name = "Östergötland",
							Code = "E"
						},
						new RegionModel
						{
							Name = "Skåne",
							Code = "M"
						},
						new RegionModel
						{
							Name = "Södermanland",
							Code = "D"
						},
						new RegionModel
						{
							Name = "Stockholm",
							Code = "AB"
						},
						new RegionModel
						{
							Name = "Uppsala",
							Code = "C"
						},
						new RegionModel
						{
							Name = "Värmland",
							Code = "S"
						},
						new RegionModel
						{
							Name = "Västerbotten",
							Code = "AC"
						},
						new RegionModel
						{
							Name = "Västernorrland",
							Code = "Y"
						},
						new RegionModel
						{
							Name = "Västmanland",
							Code = "U"
						},
						new RegionModel
						{
							Name = "Västra Götaland",
							Code = "O"
						}
					}
				},
				new CountryModel
				{
					Name = "Switzerland",
					Code = "CH",
					NativeName = "Schweiz , Svizzera , la Suisse , Helvetia",
					PhoneCode = "+41",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aargau",
							Code = "AG"
						},
						new RegionModel
						{
							Name = "Appenzell Ausserrhoden",
							Code = "AR"
						},
						new RegionModel
						{
							Name = "Appenzell Innerhoden",
							Code = "AI"
						},
						new RegionModel
						{
							Name = "Basel-Landschaft",
							Code = "BL"
						},
						new RegionModel
						{
							Name = "Basel-Stadt",
							Code = "BS"
						},
						new RegionModel
						{
							Name = "Bern",
							Code = "BE"
						},
						new RegionModel
						{
							Name = "Fribourg",
							Code = "FR"
						},
						new RegionModel
						{
							Name = "Genève",
							Code = "GE"
						},
						new RegionModel
						{
							Name = "Glarus",
							Code = "GL"
						},
						new RegionModel
						{
							Name = "Graubünden",
							Code = "GR"
						},
						new RegionModel
						{
							Name = "Jura",
							Code = "JU"
						},
						new RegionModel
						{
							Name = "Luzern",
							Code = "LU"
						},
						new RegionModel
						{
							Name = "Neuchâtel",
							Code = "NE"
						},
						new RegionModel
						{
							Name = "Nidwalden",
							Code = "NW"
						},
						new RegionModel
						{
							Name = "Obwalden",
							Code = "OW"
						},
						new RegionModel
						{
							Name = "Sankt Gallen",
							Code = "SG"
						},
						new RegionModel
						{
							Name = "Schaffhausen",
							Code = "SH"
						},
						new RegionModel
						{
							Name = "Schwyz",
							Code = "SZ"
						},
						new RegionModel
						{
							Name = "Solothurn",
							Code = "SO"
						},
						new RegionModel
						{
							Name = "Thurgau",
							Code = "TG"
						},
						new RegionModel
						{
							Name = "Ticino",
							Code = "TI"
						},
						new RegionModel
						{
							Name = "Uri",
							Code = "UR"
						},
						new RegionModel
						{
							Name = "Valais",
							Code = "VS"
						},
						new RegionModel
						{
							Name = "Vaud",
							Code = "VD"
						},
						new RegionModel
						{
							Name = "Zug",
							Code = "ZG"
						},
						new RegionModel
						{
							Name = "Zürich",
							Code = "ZH"
						}
					}
				},
				new CountryModel
				{
					Name = "Syria ",
					Code = "SY",
					NativeName = "سوريا",
					PhoneCode = "+963",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Al Hasakah",
							Code = "HA"
						},
						new RegionModel
						{
							Name = "Al Ladhiqiyah",
							Code = "LA"
						},
						new RegionModel
						{
							Name = "Al Qunaytirah",
							Code = "QU"
						},
						new RegionModel
						{
							Name = "Ar Raqqah",
							Code = "RA"
						},
						new RegionModel
						{
							Name = "As Suwayda'",
							Code = "SU"
						},
						new RegionModel
						{
							Name = "Dar'a",
							Code = "DR"
						},
						new RegionModel
						{
							Name = "Dayr az Zawr",
							Code = "DY"
						},
						new RegionModel
						{
							Name = "Dimashq",
							Code = "DI"
						},
						new RegionModel
						{
							Name = "Halab",
							Code = "HL"
						},
						new RegionModel
						{
							Name = "Hamah",
							Code = "HM"
						},
						new RegionModel
						{
							Name = "Hims",
							Code = "HI"
						},
						new RegionModel
						{
							Name = "Idlib",
							Code = "ID"
						},
						new RegionModel
						{
							Name = "Rif Dimashq",
							Code = "RD"
						},
						new RegionModel
						{
							Name = "Tartus",
							Code = "TA"
						}
					}
				},
				#endregion

				#region T
				new CountryModel
				{
					Name = "Taiwan",
					Code = "TW",
					NativeName = "中华民国 , 台湾",
					PhoneCode = "+886",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Changhua",
							Code = "CHA"
						},
						new RegionModel
						{
							Name = "Chiayi",
							Code = "CYQ"
						},
						new RegionModel
						{
							Name = "Hsinchu",
							Code = "HSQ"
						},
						new RegionModel
						{
							Name = "Hualien",
							Code = "HUA"
						},
						new RegionModel
						{
							Name = "Kaohsiung",
							Code = "KHH"
						},
						new RegionModel
						{
							Name = "Keelung",
							Code = "KEE"
						},
						new RegionModel
						{
							Name = "Kinmen",
							Code = "KIN"
						},
						new RegionModel
						{
							Name = "Lienchiang",
							Code = "LIE"
						},
						new RegionModel
						{
							Name = "Miaoli",
							Code = "MIA"
						},
						new RegionModel
						{
							Name = "Nantou",
							Code = "NAN"
						},
						new RegionModel
						{
							Name = "Penghu",
							Code = "PEN"
						},
						new RegionModel
						{
							Name = "New Taipei",
							Code = "NWT"
						},
						new RegionModel
						{
							Name = "Pingtung",
							Code = "PIF"
						},
						new RegionModel
						{
							Name = "Taichung",
							Code = "TXG"
						},
						new RegionModel
						{
							Name = "Tainan",
							Code = "TNN"
						},
						new RegionModel
						{
							Name = "Taipei",
							Code = "TPE"
						},
						new RegionModel
						{
							Name = "Taitung",
							Code = "TTT"
						},
						new RegionModel
						{
							Name = "Taoyuan",
							Code = "TAO"
						},
						new RegionModel
						{
							Name = "Yilan",
							Code = "ILA"
						},
						new RegionModel
						{
							Name = "Yunlin",
							Code = "YUN"
						}
					}
				},
				new CountryModel
				{
					Name = "Tajikistan",
					Code = "TJ",
					NativeName = "Тоҷикистон , Таджикистан",
					PhoneCode = "+992",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Dushanbe",
							Code = "DU"
						},
						new RegionModel
						{
							Name = "Kŭhistoni Badakhshon",
							Code = "GB"
						},
						new RegionModel
						{
							Name = "Khatlon",
							Code = "KT"
						},
						new RegionModel
						{
							Name = "Sughd",
							Code = "SU"
						}
					}
				},
				new CountryModel
				{
					Name = "Tanzania",
					Code = "TZ",
					NativeName = "",
					PhoneCode = "+255",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Arusha",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Coast",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Dar es Salaam",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Dodoma",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Iringa",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Kagera",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Kigoma",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Kilimanjaro",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Lindi",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Manyara",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Mara",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Mbeya",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Morogoro",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Mtwara",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Mwanza",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Pemba North",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Pemba South",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Rukwa",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Ruvuma",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Shinyanga",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Singida",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Tabora",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Tanga",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Zanzibar North",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Zanzibar Central/South",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Zanzibar Urban/West",
							Code = "15"
						}
					}
				},
				new CountryModel
				{
					Name = "Thailand",
					Code = "TH",
					NativeName = "ราชอาณาจักรไทย",
					PhoneCode = "+66",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Amnat Charoen",
							Code = "37"
						},
						new RegionModel
						{
							Name = "Ang Thong",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Bueng Kan",
							Code = "38"
						},
						new RegionModel
						{
							Name = "Buri Ram",
							Code = "31"
						},
						new RegionModel
						{
							Name = "Chachoengsao",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Chai Nat",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Chaiyaphum",
							Code = "36"
						},
						new RegionModel
						{
							Name = "Chanthaburi",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Chiang Mai",
							Code = "50"
						},
						new RegionModel
						{
							Name = "Chiang Rai",
							Code = "57"
						},
						new RegionModel
						{
							Name = "Chon Buri",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Chumphon",
							Code = "86"
						},
						new RegionModel
						{
							Name = "Kalasin",
							Code = "46"
						},
						new RegionModel
						{
							Name = "Kamphaeng Phet",
							Code = "62"
						},
						new RegionModel
						{
							Name = "Kanchanaburi",
							Code = "71"
						},
						new RegionModel
						{
							Name = "Khon Kaen",
							Code = "40"
						},
						new RegionModel
						{
							Name = "Krabi",
							Code = "81"
						},
						new RegionModel
						{
							Name = "Krung Thep Mahanakhon (Bangkok)",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Lampang",
							Code = "52"
						},
						new RegionModel
						{
							Name = "Lamphun",
							Code = "51"
						},
						new RegionModel
						{
							Name = "Loei",
							Code = "42"
						},
						new RegionModel
						{
							Name = "Lop Buri",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Mae Hong Son",
							Code = "58"
						},
						new RegionModel
						{
							Name = "Maha Sarakham",
							Code = "44"
						},
						new RegionModel
						{
							Name = "Mukdahan",
							Code = "49"
						},
						new RegionModel
						{
							Name = "Nakhon Nayok",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Nakhon Phathom",
							Code = "73"
						},
						new RegionModel
						{
							Name = "Nakhon Phanom",
							Code = "48"
						},
						new RegionModel
						{
							Name = "Nakhon Ratchasima",
							Code = "30"
						},
						new RegionModel
						{
							Name = "Nakhon Sawan",
							Code = "60"
						},
						new RegionModel
						{
							Name = "Nakhon Si Thammarat",
							Code = "80"
						},
						new RegionModel
						{
							Name = "Nan",
							Code = "55"
						},
						new RegionModel
						{
							Name = "Narathiwat",
							Code = "96"
						},
						new RegionModel
						{
							Name = "Nong Bua Lam Phu",
							Code = "39"
						},
						new RegionModel
						{
							Name = "Nong Khai",
							Code = "43"
						},
						new RegionModel
						{
							Name = "Nonthaburi",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Pathum Thani",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Pattani",
							Code = "94"
						},
						new RegionModel
						{
							Name = "Phangnga",
							Code = "82"
						},
						new RegionModel
						{
							Name = "Phatthalung",
							Code = "93"
						},
						new RegionModel
						{
							Name = "Phayao",
							Code = "56"
						},
						new RegionModel
						{
							Name = "Phetchabun",
							Code = "67"
						},
						new RegionModel
						{
							Name = "Phetchaburi",
							Code = "76"
						},
						new RegionModel
						{
							Name = "Phichit",
							Code = "66"
						},
						new RegionModel
						{
							Name = "Phitsanulok",
							Code = "65"
						},
						new RegionModel
						{
							Name = "Phra Nakhon Si Ayutthaya",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Phrae",
							Code = "54"
						},
						new RegionModel
						{
							Name = "Phuket",
							Code = "83"
						},
						new RegionModel
						{
							Name = "Prachin Buri",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Prachuap Khiri Khan",
							Code = "77"
						},
						new RegionModel
						{
							Name = "Ranong",
							Code = "85"
						},
						new RegionModel
						{
							Name = "Ratchaburi",
							Code = "70"
						},
						new RegionModel
						{
							Name = "Rayong",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Roi Et",
							Code = "45"
						},
						new RegionModel
						{
							Name = "Sa Kaeo",
							Code = "27"
						},
						new RegionModel
						{
							Name = "Sakon Nakhon",
							Code = "47"
						},
						new RegionModel
						{
							Name = "Samut Prakan",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Samut Sakhon",
							Code = "74"
						},
						new RegionModel
						{
							Name = "Samut Songkhram",
							Code = "75"
						},
						new RegionModel
						{
							Name = "Saraburi",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Satun",
							Code = "91"
						},
						new RegionModel
						{
							Name = "Sing Buri",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Si Sa ket",
							Code = "33"
						},
						new RegionModel
						{
							Name = "Songkhla",
							Code = "90"
						},
						new RegionModel
						{
							Name = "Sukhothai",
							Code = "64"
						},
						new RegionModel
						{
							Name = "Suphan Buri",
							Code = "72"
						},
						new RegionModel
						{
							Name = "Surat Thani",
							Code = "84"
						},
						new RegionModel
						{
							Name = "Surin",
							Code = "32"
						},
						new RegionModel
						{
							Name = "Tak",
							Code = "63"
						},
						new RegionModel
						{
							Name = "Trang",
							Code = "92"
						},
						new RegionModel
						{
							Name = "Trat",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Ubon Ratchathani",
							Code = "34"
						},
						new RegionModel
						{
							Name = "Udon Thani",
							Code = "41"
						},
						new RegionModel
						{
							Name = "Uthai Thani",
							Code = "61"
						},
						new RegionModel
						{
							Name = "Uttaradit",
							Code = "53"
						},
						new RegionModel
						{
							Name = "Yala",
							Code = "95"
						},
						new RegionModel
						{
							Name = "Yasothon",
							Code = "35"
						}
					}
				},
				new CountryModel
				{
					Name = "Timor-Leste",
					Code = "TL",
					NativeName = "Timor Leste , Timor Lorosa'e",
					PhoneCode = "+670",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aileu",
							Code = "AL"
						},
						new RegionModel
						{
							Name = "Ainaro",
							Code = "AN"
						},
						new RegionModel
						{
							Name = "Baucau",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Bobonaro",
							Code = "BO"
						},
						new RegionModel
						{
							Name = "Cova Lima",
							Code = "CO"
						},
						new RegionModel
						{
							Name = "Dili",
							Code = "DI"
						},
						new RegionModel
						{
							Name = "Ermera",
							Code = "ER"
						},
						new RegionModel
						{
							Name = "Lautem",
							Code = "LA"
						},
						new RegionModel
						{
							Name = "Liquica",
							Code = "LI"
						},
						new RegionModel
						{
							Name = "Manatuto",
							Code = "MT"
						},
						new RegionModel
						{
							Name = "Manufahi",
							Code = "MF"
						},
						new RegionModel
						{
							Name = "Oecussi",
							Code = "OE"
						},
						new RegionModel
						{
							Name = "Viqueque",
							Code = "VI"
						}
					}
				},
				new CountryModel
				{
					Name = "Togo",
					Code = "TG",
					NativeName = "République du Togo",
					PhoneCode = "+228",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Centre",
							Code = "C"
						},
						new RegionModel
						{
							Name = "Kara",
							Code = "K"
						},
						new RegionModel
						{
							Name = "Maritime",
							Code = "M"
						},
						new RegionModel
						{
							Name = "Plateaux",
							Code = "P"
						},
						new RegionModel
						{
							Name = "Savannes",
							Code = "S"
						}
					}
				},
				new CountryModel
				{
					Name = "Tokelau",
					Code = "TK",
					NativeName = "",
					PhoneCode = "+690",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Atafu",
							Code = null
						},
						new RegionModel
						{
							Name = "Fakaofo",
							Code = null
						},
						new RegionModel
						{
							Name = "Nukunonu",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Tonga",
					Code = "TO",
					NativeName = "Pule'anga Fakatu'i 'o Tonga",
					PhoneCode = "+676",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "'Eua",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Ha'apai",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Niuas",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Tongatapu",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Vava'u",
							Code = "05"
						}
					}
				},
				new CountryModel
				{
					Name = "Trinidad and Tobago",
					Code = "TT",
					NativeName = "",
					PhoneCode = "+1 868",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Arima",
							Code = "ARI"
						},
						new RegionModel
						{
							Name = "Chaguanas",
							Code = "CHA"
						},
						new RegionModel
						{
							Name = "Couva-Tabaquite-Talparo",
							Code = "CTT"
						},
						new RegionModel
						{
							Name = "Diefo Martin",
							Code = "DMN"
						},
						new RegionModel
						{
							Name = "Mayaro-Rio Claro",
							Code = "MRC"
						},
						new RegionModel
						{
							Name = "Penal-Debe",
							Code = "PED"
						},
						new RegionModel
						{
							Name = "Point Fortin",
							Code = "PTF"
						},
						new RegionModel
						{
							Name = "Port-of-Spain",
							Code = "POS"
						},
						new RegionModel
						{
							Name = "Princes Town",
							Code = "PRT"
						},
						new RegionModel
						{
							Name = "San Fernando",
							Code = "SFO"
						},
						new RegionModel
						{
							Name = "San Juan-Laventille",
							Code = "SJL"
						},
						new RegionModel
						{
							Name = "Sangre Grande",
							Code = "SGE"
						},
						new RegionModel
						{
							Name = "Siparia",
							Code = "SIP"
						},
						new RegionModel
						{
							Name = "Tobago",
							Code = "TOB"
						},
						new RegionModel
						{
							Name = "Tunapuna-Piarco",
							Code = "TUP"
						}
					}
				},
				new CountryModel
				{
					Name = "Tunisia",
					Code = "TN",
					NativeName = "الجمهورية التونسية",
					PhoneCode = "+216",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ariana",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Beja",
							Code = "31"
						},
						new RegionModel
						{
							Name = "Ben Arous",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Bizerte",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Gabes",
							Code = "81"
						},
						new RegionModel
						{
							Name = "Gafsa",
							Code = "71"
						},
						new RegionModel
						{
							Name = "Jendouba",
							Code = "32"
						},
						new RegionModel
						{
							Name = "Kairouan",
							Code = "41"
						},
						new RegionModel
						{
							Name = "Kasserine",
							Code = "42"
						},
						new RegionModel
						{
							Name = "Kebili",
							Code = "73"
						},
						new RegionModel
						{
							Name = "Kef",
							Code = "33"
						},
						new RegionModel
						{
							Name = "Mahdia",
							Code = "53"
						},
						new RegionModel
						{
							Name = "Medenine",
							Code = "82"
						},
						new RegionModel
						{
							Name = "Monastir",
							Code = "52"
						},
						new RegionModel
						{
							Name = "Nabeul",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Sfax",
							Code = "61"
						},
						new RegionModel
						{
							Name = "Sidi Bouzid",
							Code = "43"
						},
						new RegionModel
						{
							Name = "Siliana",
							Code = "34"
						},
						new RegionModel
						{
							Name = "Sousse",
							Code = "51"
						},
						new RegionModel
						{
							Name = "Tataouine",
							Code = "83"
						},
						new RegionModel
						{
							Name = "Tozeur",
							Code = "72"
						},
						new RegionModel
						{
							Name = "Tunis",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Zaghouan",
							Code = "22"
						}
					}
				},
				new CountryModel
				{
					Name = "Turkey",
					Code = "TR",
					NativeName = "Türkiye",
					PhoneCode = "+90",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Adana",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Adiyaman",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Afyonkarahisar",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Agri",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Aksaray",
							Code = "68"
						},
						new RegionModel
						{
							Name = "Amasya",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Ankara",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Antalya",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Ardahan",
							Code = "75"
						},
						new RegionModel
						{
							Name = "Artvin",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Aydin",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Balikesir",
							Code = "10"
						},
						new RegionModel
						{
							Name = "Bartin",
							Code = "74"
						},
						new RegionModel
						{
							Name = "Batman",
							Code = "72"
						},
						new RegionModel
						{
							Name = "Bayburt",
							Code = "69"
						},
						new RegionModel
						{
							Name = "Bilecik",
							Code = "11"
						},
						new RegionModel
						{
							Name = "Bingol",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Bitlis",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Bolu",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Burdur",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Bursa",
							Code = "16"
						},
						new RegionModel
						{
							Name = "Canakkale",
							Code = "17"
						},
						new RegionModel
						{
							Name = "Cankiri",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Corum",
							Code = "19"
						},
						new RegionModel
						{
							Name = "Denizli",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Diyarbakir",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Duzce",
							Code = "81"
						},
						new RegionModel
						{
							Name = "Edirne",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Elazig",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Erzincan",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Erzurum",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Eskisehir",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Gaziantep",
							Code = "27"
						},
						new RegionModel
						{
							Name = "Giresun",
							Code = "28"
						},
						new RegionModel
						{
							Name = "Gumushane",
							Code = "29"
						},
						new RegionModel
						{
							Name = "Hakkari",
							Code = "30"
						},
						new RegionModel
						{
							Name = "Hatay",
							Code = "31"
						},
						new RegionModel
						{
							Name = "Igdir",
							Code = "76"
						},
						new RegionModel
						{
							Name = "Isparta",
							Code = "32"
						},
						new RegionModel
						{
							Name = "Istanbul",
							Code = "34"
						},
						new RegionModel
						{
							Name = "Izmir",
							Code = "35"
						},
						new RegionModel
						{
							Name = "Kahramanmaras",
							Code = "46"
						},
						new RegionModel
						{
							Name = "Karabuk",
							Code = "78"
						},
						new RegionModel
						{
							Name = "Karaman",
							Code = "70"
						},
						new RegionModel
						{
							Name = "Kars",
							Code = "36"
						},
						new RegionModel
						{
							Name = "Kastamonu",
							Code = "37"
						},
						new RegionModel
						{
							Name = "Kayseri",
							Code = "38"
						},
						new RegionModel
						{
							Name = "Kilis",
							Code = "79"
						},
						new RegionModel
						{
							Name = "Kirikkale",
							Code = "71"
						},
						new RegionModel
						{
							Name = "Kirklareli",
							Code = "39"
						},
						new RegionModel
						{
							Name = "Kirsehir",
							Code = "40"
						},
						new RegionModel
						{
							Name = "Kocaeli",
							Code = "41"
						},
						new RegionModel
						{
							Name = "Konya",
							Code = "42"
						},
						new RegionModel
						{
							Name = "Kutahya",
							Code = "43"
						},
						new RegionModel
						{
							Name = "Malatya",
							Code = "44"
						},
						new RegionModel
						{
							Name = "Manisa",
							Code = "45"
						},
						new RegionModel
						{
							Name = "Mardin",
							Code = "47"
						},
						new RegionModel
						{
							Name = "Mersin",
							Code = "33"
						},
						new RegionModel
						{
							Name = "Mugla",
							Code = "48"
						},
						new RegionModel
						{
							Name = "Mus",
							Code = "49"
						},
						new RegionModel
						{
							Name = "Nevsehir",
							Code = "50"
						},
						new RegionModel
						{
							Name = "Nigde",
							Code = "51"
						},
						new RegionModel
						{
							Name = "Ordu",
							Code = "52"
						},
						new RegionModel
						{
							Name = "Osmaniye",
							Code = "80"
						},
						new RegionModel
						{
							Name = "Rize",
							Code = "53"
						},
						new RegionModel
						{
							Name = "Sakarya",
							Code = "54"
						},
						new RegionModel
						{
							Name = "Samsun",
							Code = "55"
						},
						new RegionModel
						{
							Name = "Sanliurfa",
							Code = "63"
						},
						new RegionModel
						{
							Name = "Siirt",
							Code = "56"
						},
						new RegionModel
						{
							Name = "Sinop",
							Code = "57"
						},
						new RegionModel
						{
							Name = "Sirnak",
							Code = "73"
						},
						new RegionModel
						{
							Name = "Sivas",
							Code = "58"
						},
						new RegionModel
						{
							Name = "Tekirdag",
							Code = "59"
						},
						new RegionModel
						{
							Name = "Tokat",
							Code = "60"
						},
						new RegionModel
						{
							Name = "Trabzon",
							Code = "61"
						},
						new RegionModel
						{
							Name = "Tunceli",
							Code = "62"
						},
						new RegionModel
						{
							Name = "Usak",
							Code = "64"
						},
						new RegionModel
						{
							Name = "Van",
							Code = "65"
						},
						new RegionModel
						{
							Name = "Yalova",
							Code = "77"
						},
						new RegionModel
						{
							Name = "Yozgat",
							Code = "66"
						},
						new RegionModel
						{
							Name = "Zonguldak",
							Code = "67"
						}
					}
				},
				new CountryModel
				{
					Name = "Turkmenistan",
					Code = "TM",
					NativeName = "Türkmenistan , Туркменистан",
					PhoneCode = "+993",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Ahal",
							Code = "A"
						},
						new RegionModel
						{
							Name = "Asgabat",
							Code = "S"
						},
						new RegionModel
						{
							Name = "Balkan",
							Code = "B"
						},
						new RegionModel
						{
							Name = "Dashoguz",
							Code = "D"
						},
						new RegionModel
						{
							Name = "Lebap",
							Code = "L"
						},
						new RegionModel
						{
							Name = "Mary",
							Code = "M"
						}
					}
				},
				new CountryModel
				{
					Name = "Turks and Caicos Islands",
					Code = "TC",
					NativeName = "",
					PhoneCode = "+1 649",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Turks and Caicos Islands",
							Code = null
						}
					}
				},
				new CountryModel
				{
					Name = "Tuvalu",
					Code = "TV",
					NativeName = "",
					PhoneCode = "+688",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Funafuti",
							Code = "FUN"
						},
						new RegionModel
						{
							Name = "Nanumanga",
							Code = "NMG"
						},
						new RegionModel
						{
							Name = "Nanumea",
							Code = "NMA"
						},
						new RegionModel
						{
							Name = "Niutao",
							Code = "NIT"
						},
						new RegionModel
						{
							Name = "Nui",
							Code = "NUI"
						},
						new RegionModel
						{
							Name = "Nukufetau",
							Code = "NKF"
						},
						new RegionModel
						{
							Name = "Nukulaelae",
							Code = "NKL"
						},
						new RegionModel
						{
							Name = "Vaitupu",
							Code = "VAU"
						}
					}
				},
				
				#endregion

				#region U
				new CountryModel
				{
					Name = "Uganda",
					Code = "UG",
					NativeName = "",
					PhoneCode = "+256",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Abim",
							Code = "317"
						},
						new RegionModel
						{
							Name = "Adjumani",
							Code = "301"
						},
						new RegionModel
						{
							Name = "Amolatar",
							Code = "314"
						},
						new RegionModel
						{
							Name = "Amuria",
							Code = "216"
						},
						new RegionModel
						{
							Name = "Amuru",
							Code = "319"
						},
						new RegionModel
						{
							Name = "Apac",
							Code = "302"
						},
						new RegionModel
						{
							Name = "Arua",
							Code = "303"
						},
						new RegionModel
						{
							Name = "Budaka",
							Code = "217"
						},
						new RegionModel
						{
							Name = "Bududa",
							Code = "223"
						},
						new RegionModel
						{
							Name = "Bugiri",
							Code = "201"
						},
						new RegionModel
						{
							Name = "Bukedea",
							Code = "224"
						},
						new RegionModel
						{
							Name = "Bukwa",
							Code = "218"
						},
						new RegionModel
						{
							Name = "Buliisa",
							Code = "419"
						},
						new RegionModel
						{
							Name = "Bundibugyo",
							Code = "401"
						},
						new RegionModel
						{
							Name = "Bushenyi",
							Code = "402"
						},
						new RegionModel
						{
							Name = "Busia",
							Code = "202"
						},
						new RegionModel
						{
							Name = "Butaleja",
							Code = "219"
						},
						new RegionModel
						{
							Name = "Dokolo",
							Code = "318"
						},
						new RegionModel
						{
							Name = "Gulu",
							Code = "304"
						},
						new RegionModel
						{
							Name = "Hoima",
							Code = "403"
						},
						new RegionModel
						{
							Name = "Ibanda",
							Code = "416"
						},
						new RegionModel
						{
							Name = "Iganga",
							Code = "203"
						},
						new RegionModel
						{
							Name = "Isingiro",
							Code = "417"
						},
						new RegionModel
						{
							Name = "Jinja",
							Code = "204"
						},
						new RegionModel
						{
							Name = "Kaabong",
							Code = "315"
						},
						new RegionModel
						{
							Name = "Kabale",
							Code = "404"
						},
						new RegionModel
						{
							Name = "Kabarole",
							Code = "405"
						},
						new RegionModel
						{
							Name = "Kaberamaido",
							Code = "213"
						},
						new RegionModel
						{
							Name = "Kalangala",
							Code = "101"
						},
						new RegionModel
						{
							Name = "Kaliro",
							Code = "220"
						},
						new RegionModel
						{
							Name = "Kampala",
							Code = "102"
						},
						new RegionModel
						{
							Name = "Kamuli",
							Code = "205"
						},
						new RegionModel
						{
							Name = "Kamwenge",
							Code = "413"
						},
						new RegionModel
						{
							Name = "Kanungu",
							Code = "414"
						},
						new RegionModel
						{
							Name = "Kapchorwa",
							Code = "206"
						},
						new RegionModel
						{
							Name = "Kasese",
							Code = "406"
						},
						new RegionModel
						{
							Name = "Katakwi",
							Code = "207"
						},
						new RegionModel
						{
							Name = "Kayunga",
							Code = "112"
						},
						new RegionModel
						{
							Name = "Kibaale",
							Code = "407"
						},
						new RegionModel
						{
							Name = "Kiboga",
							Code = "103"
						},
						new RegionModel
						{
							Name = "Kiruhura",
							Code = "418"
						},
						new RegionModel
						{
							Name = "Kisoro",
							Code = "408"
						},
						new RegionModel
						{
							Name = "Kitgum",
							Code = "305"
						},
						new RegionModel
						{
							Name = "Koboko",
							Code = "316"
						},
						new RegionModel
						{
							Name = "Kotido",
							Code = "306"
						},
						new RegionModel
						{
							Name = "Kumi",
							Code = "208"
						},
						new RegionModel
						{
							Name = "Kyenjojo",
							Code = "415"
						},
						new RegionModel
						{
							Name = "Lira",
							Code = "307"
						},
						new RegionModel
						{
							Name = "Luwero",
							Code = "104"
						},
						new RegionModel
						{
							Name = "Lyantonde",
							Code = "116"
						},
						new RegionModel
						{
							Name = "Manafwa",
							Code = "221"
						},
						new RegionModel
						{
							Name = "Maracha",
							Code = "320"
						},
						new RegionModel
						{
							Name = "Masaka",
							Code = "105"
						},
						new RegionModel
						{
							Name = "Masindi",
							Code = "409"
						},
						new RegionModel
						{
							Name = "Mayuge",
							Code = "214"
						},
						new RegionModel
						{
							Name = "Mbale",
							Code = "209"
						},
						new RegionModel
						{
							Name = "Mbarara",
							Code = "410"
						},
						new RegionModel
						{
							Name = "Mityana",
							Code = "114"
						},
						new RegionModel
						{
							Name = "Moroto",
							Code = "308"
						},
						new RegionModel
						{
							Name = "Moyo",
							Code = "309"
						},
						new RegionModel
						{
							Name = "Mpigi",
							Code = "106"
						},
						new RegionModel
						{
							Name = "Mubende",
							Code = "107"
						},
						new RegionModel
						{
							Name = "Mukono",
							Code = "108"
						},
						new RegionModel
						{
							Name = "Nakapiripirit",
							Code = "311"
						},
						new RegionModel
						{
							Name = "Nakaseke",
							Code = "115"
						},
						new RegionModel
						{
							Name = "Nakasongola",
							Code = "109"
						},
						new RegionModel
						{
							Name = "Namutumba",
							Code = "222"
						},
						new RegionModel
						{
							Name = "Nebbi",
							Code = "310"
						},
						new RegionModel
						{
							Name = "Ntungamo",
							Code = "411"
						},
						new RegionModel
						{
							Name = "Oyam",
							Code = "321"
						},
						new RegionModel
						{
							Name = "Pader",
							Code = "312"
						},
						new RegionModel
						{
							Name = "Pallisa",
							Code = "210"
						},
						new RegionModel
						{
							Name = "Rakai",
							Code = "110"
						},
						new RegionModel
						{
							Name = "Rukungiri",
							Code = "412"
						},
						new RegionModel
						{
							Name = "Sembabule",
							Code = "111"
						},
						new RegionModel
						{
							Name = "Sironko",
							Code = "215"
						},
						new RegionModel
						{
							Name = "Soroti",
							Code = "211"
						},
						new RegionModel
						{
							Name = "Tororo",
							Code = "212"
						},
						new RegionModel
						{
							Name = "Wakiso",
							Code = "113"
						},
						new RegionModel
						{
							Name = "Yumbe",
							Code = "313"
						}
					}
				},
				new CountryModel
				{
					Name = "Ukraine",
					Code = "UA",
					NativeName = "Україна",
					PhoneCode = "+380",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Cherkasy",
							Code = "71"
						},
						new RegionModel
						{
							Name = "Chernihiv",
							Code = "74"
						},
						new RegionModel
						{
							Name = "Chernivtsi",
							Code = "77"
						},
						new RegionModel
						{
							Name = "Dnipropetrovsk",
							Code = "12"
						},
						new RegionModel
						{
							Name = "Donetsk",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Ivano-Frankivsk",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Kharkiv",
							Code = "63"
						},
						new RegionModel
						{
							Name = "Kherson",
							Code = "65"
						},
						new RegionModel
						{
							Name = "Khmelnytskyi",
							Code = "68"
						},
						new RegionModel
						{
							Name = "Kiev",
							Code = "32"
						},
						new RegionModel
						{
							Name = "Kirovohrad",
							Code = "35"
						},
						new RegionModel
						{
							Name = "Luhansk",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Lviv",
							Code = "46"
						},
						new RegionModel
						{
							Name = "Mykolaiv",
							Code = "48"
						},
						new RegionModel
						{
							Name = "Odessa",
							Code = "51"
						},
						new RegionModel
						{
							Name = "Poltava",
							Code = "53"
						},
						new RegionModel
						{
							Name = "Rivne",
							Code = "56"
						},
						new RegionModel
						{
							Name = "Sumy",
							Code = "59"
						},
						new RegionModel
						{
							Name = "Ternopil",
							Code = "61"
						},
						new RegionModel
						{
							Name = "Vinnytsia",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Volyn",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Zakarpattia",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Zaporizhia",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Zhytomyr",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Avtonomna Respublika Krym",
							Code = "43"
						},
						new RegionModel
						{
							Name = "Kyiv",
							Code = "30"
						},
						new RegionModel
						{
							Name = "Sevastopol",
							Code = "40"
						}
					}
				},
				new CountryModel
				{
					Name = "United Arab Emirates",
					Code = "AE",
					NativeName = "دولة الإمارات العربية المتحدة",
					PhoneCode = "+971",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Abu Dhabi",
							Code = "AZ"
						},
						new RegionModel
						{
							Name = "Ajman",
							Code = "AJ"
						},
						new RegionModel
						{
							Name = "Dubai",
							Code = "DU"
						},
						new RegionModel
						{
							Name = "Fujairah",
							Code = "FU"
						},
						new RegionModel
						{
							Name = "Ras al Khaimah",
							Code = "RK"
						},
						new RegionModel
						{
							Name = "Sharjah",
							Code = "SH"
						},
						new RegionModel
						{
							Name = "Umm Al Quwain",
							Code = "UQ"
						}
					}
				},
				new CountryModel
				{
					Name = "United Kingdom",
					Code = "GB",
					NativeName = "",
					PhoneCode = "+44",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Aberdeen City",
							Code = "ABE"
						},
						new RegionModel
						{
							Name = "Aberdeenshire",
							Code = "ABD"
						},
						new RegionModel
						{
							Name = "Angus",
							Code = "ANS"
						},
						new RegionModel
						{
							Name = "Antrim and Newtownabbey",
							Code = "ANN"
						},
						new RegionModel
						{
							Name = "Ards and North Down",
							Code = "AND"
						},
						new RegionModel
						{
							Name = "Argyll and Bute",
							Code = "AGB"
						},
						new RegionModel
						{
							Name = "Armagh, Banbridge and Craigavon",
							Code = "ABC"
						},
						new RegionModel
						{
							Name = "Barking and Dagenham",
							Code = "BDG"
						},
						new RegionModel
						{
							Name = "Barnet",
							Code = "BNE"
						},
						new RegionModel
						{
							Name = "Barnsley",
							Code = "BNS"
						},
						new RegionModel
						{
							Name = "Bath and North East Somerset",
							Code = "BAS"
						},
						new RegionModel
						{
							Name = "Bedford",
							Code = "BDF"
						},
						new RegionModel
						{
							Name = "Belfast",
							Code = "BFS"
						},
						new RegionModel
						{
							Name = "Bexley",
							Code = "BEX"
						},
						new RegionModel
						{
							Name = "Birmingham",
							Code = "BIR"
						},
						new RegionModel
						{
							Name = "Blackburn with Darwen",
							Code = "BBD"
						},
						new RegionModel
						{
							Name = "Blackpool",
							Code = "BPL"
						},
						new RegionModel
						{
							Name = "Blaenau Gwent",
							Code = "BGW"
						},
						new RegionModel
						{
							Name = "Bolton",
							Code = "BOL"
						},
						new RegionModel
						{
							Name = "Bournemouth",
							Code = "BMH"
						},
						new RegionModel
						{
							Name = "Bracknell Forest",
							Code = "BRC"
						},
						new RegionModel
						{
							Name = "Bradford",
							Code = "BRD"
						},
						new RegionModel
						{
							Name = "Brent",
							Code = "BEN"
						},
						new RegionModel
						{
							Name = "Bridgend",
							Code = "BGE"
						},
						new RegionModel
						{
							Name = "Brighton and Hove",
							Code = "BNH"
						},
						new RegionModel
						{
							Name = "Bristol, City of",
							Code = "BST"
						},
						new RegionModel
						{
							Name = "Bromley",
							Code = "BRY"
						},
						new RegionModel
						{
							Name = "Buckinghamshire",
							Code = "BKM"
						},
						new RegionModel
						{
							Name = "Bury",
							Code = "BUR"
						},
						new RegionModel
						{
							Name = "Caerphilly",
							Code = "CAY"
						},
						new RegionModel
						{
							Name = "Calderdale",
							Code = "CLD"
						},
						new RegionModel
						{
							Name = "Cambridgeshire",
							Code = "CAM"
						},
						new RegionModel
						{
							Name = "Camden",
							Code = "CMD"
						},
						new RegionModel
						{
							Name = "Cardiff",
							Code = "CRF"
						},
						new RegionModel
						{
							Name = "Carmarthenshire",
							Code = "CMN"
						},
						new RegionModel
						{
							Name = "Causeway Coast and Glens",
							Code = "CCG"
						},
						new RegionModel
						{
							Name = "Central Bedfordshire",
							Code = "CBF"
						},
						new RegionModel
						{
							Name = "Ceredigion",
							Code = "CGN"
						},
						new RegionModel
						{
							Name = "Cheshire East",
							Code = "CHE"
						},
						new RegionModel
						{
							Name = "Cheshire West and Chester",
							Code = "CHW"
						},
						new RegionModel
						{
							Name = "Clackmannanshire",
							Code = "CLK"
						},
						new RegionModel
						{
							Name = "Conwy",
							Code = "CWY"
						},
						new RegionModel
						{
							Name = "Cornwall",
							Code = "CON"
						},
						new RegionModel
						{
							Name = "Coventry",
							Code = "COV"
						},
						new RegionModel
						{
							Name = "Croydon",
							Code = "CRY"
						},
						new RegionModel
						{
							Name = "Cumbria",
							Code = "CMA"
						},
						new RegionModel
						{
							Name = "Darlington",
							Code = "DAL"
						},
						new RegionModel
						{
							Name = "Denbighshire",
							Code = "DEN"
						},
						new RegionModel
						{
							Name = "Derby",
							Code = "DER"
						},
						new RegionModel
						{
							Name = "Derbyshire",
							Code = "DBY"
						},
						new RegionModel
						{
							Name = "Derry and Strabane",
							Code = "DRS"
						},
						new RegionModel
						{
							Name = "Devon",
							Code = "DEV"
						},
						new RegionModel
						{
							Name = "Doncaster",
							Code = "DNC"
						},
						new RegionModel
						{
							Name = "Dorset",
							Code = "DOR"
						},
						new RegionModel
						{
							Name = "Dudley",
							Code = "DUD"
						},
						new RegionModel
						{
							Name = "Dumfries and Galloway",
							Code = "DGY"
						},
						new RegionModel
						{
							Name = "Dundee City",
							Code = "DND"
						},
						new RegionModel
						{
							Name = "Durham County",
							Code = "DUR"
						},
						new RegionModel
						{
							Name = "Ealing",
							Code = "EAL"
						},
						new RegionModel
						{
							Name = "East Ayrshire",
							Code = "EAY"
						},
						new RegionModel
						{
							Name = "East Dunbartonshire",
							Code = "EDU"
						},
						new RegionModel
						{
							Name = "East Lothian",
							Code = "ELN"
						},
						new RegionModel
						{
							Name = "East Renfrewshire",
							Code = "ERW"
						},
						new RegionModel
						{
							Name = "East Riding of Yorkshire",
							Code = "ERY"
						},
						new RegionModel
						{
							Name = "East Sussex",
							Code = "ESX"
						},
						new RegionModel
						{
							Name = "Edinburgh, City of",
							Code = "EDH"
						},
						new RegionModel
						{
							Name = "Eilean Siar",
							Code = "ELS"
						},
						new RegionModel
						{
							Name = "Enfield",
							Code = "ENF"
						},
						new RegionModel
						{
							Name = "Essex",
							Code = "ESS"
						},
						new RegionModel
						{
							Name = "Falkirk",
							Code = "FAL"
						},
						new RegionModel
						{
							Name = "Fermanagh and Omagh",
							Code = "FMO"
						},
						new RegionModel
						{
							Name = "Fife",
							Code = "FIF"
						},
						new RegionModel
						{
							Name = "Flintshire",
							Code = "FLN"
						},
						new RegionModel
						{
							Name = "Gateshead",
							Code = "GAT"
						},
						new RegionModel
						{
							Name = "Glasgow City",
							Code = "GLG"
						},
						new RegionModel
						{
							Name = "Gloucestershire",
							Code = "GLS"
						},
						new RegionModel
						{
							Name = "Greenwich",
							Code = "GRE"
						},
						new RegionModel
						{
							Name = "Gwynedd",
							Code = "GWN"
						},
						new RegionModel
						{
							Name = "Hackney",
							Code = "HCK"
						},
						new RegionModel
						{
							Name = "Halton",
							Code = "HAL"
						},
						new RegionModel
						{
							Name = "Hammersmith and Fulham",
							Code = "HMF"
						},
						new RegionModel
						{
							Name = "Hampshire",
							Code = "HAM"
						},
						new RegionModel
						{
							Name = "Haringey",
							Code = "HRY"
						},
						new RegionModel
						{
							Name = "Harrow",
							Code = "HRW"
						},
						new RegionModel
						{
							Name = "Hartlepool",
							Code = "HPL"
						},
						new RegionModel
						{
							Name = "Havering",
							Code = "HAV"
						},
						new RegionModel
						{
							Name = "Herefordshire",
							Code = "HEF"
						},
						new RegionModel
						{
							Name = "Hertfordshire",
							Code = "HRT"
						},
						new RegionModel
						{
							Name = "Highland",
							Code = "HLD"
						},
						new RegionModel
						{
							Name = "Hillingdon",
							Code = "HIL"
						},
						new RegionModel
						{
							Name = "Hounslow",
							Code = "HNS"
						},
						new RegionModel
						{
							Name = "Inverclyde",
							Code = "IVC"
						},
						new RegionModel
						{
							Name = "Isle of Anglesey",
							Code = "AGY"
						},
						new RegionModel
						{
							Name = "Isle of Wight",
							Code = "IOW"
						},
						new RegionModel
						{
							Name = "Isles of Scilly",
							Code = "IOS"
						},
						new RegionModel
						{
							Name = "Islington",
							Code = "ISL"
						},
						new RegionModel
						{
							Name = "Kensington and Chelsea",
							Code = "KEC"
						},
						new RegionModel
						{
							Name = "Kent",
							Code = "KEN"
						},
						new RegionModel
						{
							Name = "Kingston upon Hull",
							Code = "KHL"
						},
						new RegionModel
						{
							Name = "Kingston upon Thames",
							Code = "KTT"
						},
						new RegionModel
						{
							Name = "Kirklees",
							Code = "KIR"
						},
						new RegionModel
						{
							Name = "Knowsley",
							Code = "KWL"
						},
						new RegionModel
						{
							Name = "Lambeth",
							Code = "LBH"
						},
						new RegionModel
						{
							Name = "Lancashire",
							Code = "LAN"
						},
						new RegionModel
						{
							Name = "Leeds",
							Code = "LDS"
						},
						new RegionModel
						{
							Name = "Leicester",
							Code = "LCE"
						},
						new RegionModel
						{
							Name = "Leicestershire",
							Code = "LEC"
						},
						new RegionModel
						{
							Name = "Lewisham",
							Code = "LEW"
						},
						new RegionModel
						{
							Name = "Lincolnshire",
							Code = "LIN"
						},
						new RegionModel
						{
							Name = "Lisburn and Castlereagh",
							Code = "LBC"
						},
						new RegionModel
						{
							Name = "Liverpool",
							Code = "LIV"
						},
						new RegionModel
						{
							Name = "London, City of",
							Code = "LND"
						},
						new RegionModel
						{
							Name = "Luton",
							Code = "LUT"
						},
						new RegionModel
						{
							Name = "Manchester",
							Code = "MAN"
						},
						new RegionModel
						{
							Name = "Medway",
							Code = "MDW"
						},
						new RegionModel
						{
							Name = "Merthyr Tydfil",
							Code = "MTY"
						},
						new RegionModel
						{
							Name = "Merton",
							Code = "MRT"
						},
						new RegionModel
						{
							Name = "Mid and East Antrim",
							Code = "MEA"
						},
						new RegionModel
						{
							Name = "Mid Ulster",
							Code = "MUL"
						},
						new RegionModel
						{
							Name = "Middlesbrough",
							Code = "MDB"
						},
						new RegionModel
						{
							Name = "Midlothian",
							Code = "MLN"
						},
						new RegionModel
						{
							Name = "Milton Keynes",
							Code = "MIK"
						},
						new RegionModel
						{
							Name = "Monmouthshire",
							Code = "MON"
						},
						new RegionModel
						{
							Name = "Moray",
							Code = "MRY"
						},
						new RegionModel
						{
							Name = "Neath Port Talbot",
							Code = "NTL"
						},
						new RegionModel
						{
							Name = "Newcastle upon Tyne",
							Code = "NET"
						},
						new RegionModel
						{
							Name = "Newham",
							Code = "NWM"
						},
						new RegionModel
						{
							Name = "Newport",
							Code = "NWP"
						},
						new RegionModel
						{
							Name = "Newry, Mourne and Down",
							Code = "NMD"
						},
						new RegionModel
						{
							Name = "Norfolk",
							Code = "NFK"
						},
						new RegionModel
						{
							Name = "North Ayrshire",
							Code = "NAY"
						},
						new RegionModel
						{
							Name = "North East Lincolnshire",
							Code = "NEL"
						},
						new RegionModel
						{
							Name = "North Lanarkshire",
							Code = "NLK"
						},
						new RegionModel
						{
							Name = "North Lincolnshire",
							Code = "NLN"
						},
						new RegionModel
						{
							Name = "North Somerset",
							Code = "NSM"
						},
						new RegionModel
						{
							Name = "North Tyneside",
							Code = "NTY"
						},
						new RegionModel
						{
							Name = "North Yorkshire",
							Code = "NYK"
						},
						new RegionModel
						{
							Name = "Northamptonshire",
							Code = "NTH"
						},
						new RegionModel
						{
							Name = "Northumberland",
							Code = "NBL"
						},
						new RegionModel
						{
							Name = "Nottingham",
							Code = "NGM"
						},
						new RegionModel
						{
							Name = "Nottinghamshire",
							Code = "NTT"
						},
						new RegionModel
						{
							Name = "Oldham",
							Code = "OLD"
						},
						new RegionModel
						{
							Name = "Orkney Islands",
							Code = "ORK"
						},
						new RegionModel
						{
							Name = "Oxfordshire",
							Code = "OXF"
						},
						new RegionModel
						{
							Name = "Pembrokeshire",
							Code = "PEM"
						},
						new RegionModel
						{
							Name = "Perth and Kinross",
							Code = "PKN"
						},
						new RegionModel
						{
							Name = "Peterborough",
							Code = "PTE"
						},
						new RegionModel
						{
							Name = "Plymouth",
							Code = "PLY"
						},
						new RegionModel
						{
							Name = "Poole",
							Code = "POL"
						},
						new RegionModel
						{
							Name = "Portsmouth",
							Code = "POR"
						},
						new RegionModel
						{
							Name = "Powys",
							Code = "POW"
						},
						new RegionModel
						{
							Name = "Reading",
							Code = "RDG"
						},
						new RegionModel
						{
							Name = "Redbridge",
							Code = "RDB"
						},
						new RegionModel
						{
							Name = "Redcar and Cleveland",
							Code = "RCC"
						},
						new RegionModel
						{
							Name = "Renfrewshire",
							Code = "RFW"
						},
						new RegionModel
						{
							Name = "Rhondda, Cynon, Taff",
							Code = "RCT"
						},
						new RegionModel
						{
							Name = "Richmond upon Thames",
							Code = "RIC"
						},
						new RegionModel
						{
							Name = "Rochdale",
							Code = "RCH"
						},
						new RegionModel
						{
							Name = "Rotherham",
							Code = "ROT"
						},
						new RegionModel
						{
							Name = "Rutland",
							Code = "RUT"
						},
						new RegionModel
						{
							Name = "St. Helens",
							Code = "SHN"
						},
						new RegionModel
						{
							Name = "Salford",
							Code = "SLF"
						},
						new RegionModel
						{
							Name = "Sandwell",
							Code = "SAW"
						},
						new RegionModel
						{
							Name = "Scottish Borders, The",
							Code = "SCB"
						},
						new RegionModel
						{
							Name = "Sefton",
							Code = "SFT"
						},
						new RegionModel
						{
							Name = "Sheffield",
							Code = "SHF"
						},
						new RegionModel
						{
							Name = "Shetland Islands",
							Code = "ZET"
						},
						new RegionModel
						{
							Name = "Shropshire",
							Code = "SHR"
						},
						new RegionModel
						{
							Name = "Slough",
							Code = "SLG"
						},
						new RegionModel
						{
							Name = "Solihull",
							Code = "SOL"
						},
						new RegionModel
						{
							Name = "Somerset",
							Code = "SOM"
						},
						new RegionModel
						{
							Name = "South Ayrshire",
							Code = "SAY"
						},
						new RegionModel
						{
							Name = "South Gloucestershire",
							Code = "SGC"
						},
						new RegionModel
						{
							Name = "South Lanarkshire",
							Code = "SLK"
						},
						new RegionModel
						{
							Name = "South Tyneside",
							Code = "STY"
						},
						new RegionModel
						{
							Name = "Southampton",
							Code = "STH"
						},
						new RegionModel
						{
							Name = "Southend-on-Sea",
							Code = "SOS"
						},
						new RegionModel
						{
							Name = "Southwark",
							Code = "SWK"
						},
						new RegionModel
						{
							Name = "Staffordshire",
							Code = "STS"
						},
						new RegionModel
						{
							Name = "Stirling",
							Code = "STG"
						},
						new RegionModel
						{
							Name = "Stockport",
							Code = "SKP"
						},
						new RegionModel
						{
							Name = "Stockton-on-Tees",
							Code = "STT"
						},
						new RegionModel
						{
							Name = "Stoke-on-Trent",
							Code = "STE"
						},
						new RegionModel
						{
							Name = "Suffolk",
							Code = "SFK"
						},
						new RegionModel
						{
							Name = "Sunderland",
							Code = "SND"
						},
						new RegionModel
						{
							Name = "Surrey",
							Code = "SRY"
						},
						new RegionModel
						{
							Name = "Sutton",
							Code = "STN"
						},
						new RegionModel
						{
							Name = "Swansea",
							Code = "SWA"
						},
						new RegionModel
						{
							Name = "Swindon",
							Code = "SWD"
						},
						new RegionModel
						{
							Name = "Tameside",
							Code = "TAM"
						},
						new RegionModel
						{
							Name = "Telford and Wrekin",
							Code = "TFW"
						},
						new RegionModel
						{
							Name = "Thurrock",
							Code = "THR"
						},
						new RegionModel
						{
							Name = "Torbay",
							Code = "TOB"
						},
						new RegionModel
						{
							Name = "Torfaen",
							Code = "TOF"
						},
						new RegionModel
						{
							Name = "Tower Hamlets",
							Code = "TWH"
						},
						new RegionModel
						{
							Name = "Trafford",
							Code = "TRF"
						},
						new RegionModel
						{
							Name = "Vale of Glamorgan, The",
							Code = "VGL"
						},
						new RegionModel
						{
							Name = "Wakefield",
							Code = "WKF"
						},
						new RegionModel
						{
							Name = "Walsall",
							Code = "WLL"
						},
						new RegionModel
						{
							Name = "Waltham Forest",
							Code = "WFT"
						},
						new RegionModel
						{
							Name = "Wandsworth",
							Code = "WND"
						},
						new RegionModel
						{
							Name = "Warrington",
							Code = "WRT"
						},
						new RegionModel
						{
							Name = "Warwickshire",
							Code = "WAR"
						},
						new RegionModel
						{
							Name = "West Berkshire",
							Code = "WBK"
						},
						new RegionModel
						{
							Name = "West Dunbartonshire",
							Code = "WDU"
						},
						new RegionModel
						{
							Name = "West Lothian",
							Code = "WLN"
						},
						new RegionModel
						{
							Name = "West Sussex",
							Code = "WSX"
						},
						new RegionModel
						{
							Name = "Westminster",
							Code = "WSM"
						},
						new RegionModel
						{
							Name = "Wigan",
							Code = "WGN"
						},
						new RegionModel
						{
							Name = "Wiltshire",
							Code = "WIL"
						},
						new RegionModel
						{
							Name = "Windsor and Maidenhead",
							Code = "WNM"
						},
						new RegionModel
						{
							Name = "Wirral",
							Code = "WRL"
						},
						new RegionModel
						{
							Name = "Wokingham",
							Code = "WOK"
						},
						new RegionModel
						{
							Name = "Wolverhampton",
							Code = "WLV"
						},
						new RegionModel
						{
							Name = "Worcestershire",
							Code = "WOR"
						},
						new RegionModel
						{
							Name = "Wrexham",
							Code = "WRX"
						},
						new RegionModel
						{
							Name = "York",
							Code = "YOR"
						}
					}
				},
				new CountryModel
				{
					Name = "United States",
					Code = "US",
					NativeName = "Estados Unidos",
					PhoneCode = "+1",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Alabama",
							Code = "AL"
						},
						new RegionModel
						{
							Name = "Alaska",
							Code = "AK"
						},
						new RegionModel
						{
							Name = "Arizona",
							Code = "AZ"
						},
						new RegionModel
						{
							Name = "Arkansas",
							Code = "AR"
						},
						new RegionModel
						{
							Name = "California",
							Code = "CA"
						},
						new RegionModel
						{
							Name = "Colorado",
							Code = "CO"
						},
						new RegionModel
						{
							Name = "Connecticut",
							Code = "CT"
						},
						new RegionModel
						{
							Name = "Delaware",
							Code = "DE"
						},
						new RegionModel
						{
							Name = "District of Columbia",
							Code = "DC"
						},
						new RegionModel
						{
							Name = "Micronesia",
							Code = "FM"
						},
						new RegionModel
						{
							Name = "Florida",
							Code = "FL"
						},
						new RegionModel
						{
							Name = "Georgia",
							Code = "GA"
						},
						new RegionModel
						{
							Name = "Guam",
							Code = "GU"
						},
						new RegionModel
						{
							Name = "Hawaii",
							Code = "HI"
						},
						new RegionModel
						{
							Name = "Idaho",
							Code = "ID"
						},
						new RegionModel
						{
							Name = "Illinois",
							Code = "IL"
						},
						new RegionModel
						{
							Name = "Indiana",
							Code = "IN"
						},
						new RegionModel
						{
							Name = "Iowa",
							Code = "IA"
						},
						new RegionModel
						{
							Name = "Kansas",
							Code = "KS"
						},
						new RegionModel
						{
							Name = "Kentucky",
							Code = "KY"
						},
						new RegionModel
						{
							Name = "Louisiana",
							Code = "LA"
						},
						new RegionModel
						{
							Name = "Maine",
							Code = "ME"
						},
						new RegionModel
						{
							Name = "Marshall Islands",
							Code = "MH"
						},
						new RegionModel
						{
							Name = "Maryland",
							Code = "MD"
						},
						new RegionModel
						{
							Name = "Massachusetts",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Michigan",
							Code = "MI"
						},
						new RegionModel
						{
							Name = "Minnesota",
							Code = "MN"
						},
						new RegionModel
						{
							Name = "Mississippi",
							Code = "MS"
						},
						new RegionModel
						{
							Name = "Missouri",
							Code = "MO"
						},
						new RegionModel
						{
							Name = "Montana",
							Code = "MT"
						},
						new RegionModel
						{
							Name = "Nebraska",
							Code = "NE"
						},
						new RegionModel
						{
							Name = "Nevada",
							Code = "NV"
						},
						new RegionModel
						{
							Name = "New Hampshire",
							Code = "NH"
						},
						new RegionModel
						{
							Name = "New Jersey",
							Code = "NJ"
						},
						new RegionModel
						{
							Name = "New Mexico",
							Code = "NM"
						},
						new RegionModel
						{
							Name = "New York",
							Code = "NY"
						},
						new RegionModel
						{
							Name = "North Carolina",
							Code = "NC"
						},
						new RegionModel
						{
							Name = "North Dakota",
							Code = "ND"
						},
						new RegionModel
						{
							Name = "Northern Mariana Islands",
							Code = "MP"
						},
						new RegionModel
						{
							Name = "Ohio",
							Code = "OH"
						},
						new RegionModel
						{
							Name = "Oklahoma",
							Code = "OK"
						},
						new RegionModel
						{
							Name = "Oregon",
							Code = "OR"
						},
						new RegionModel
						{
							Name = "Palau",
							Code = "PW"
						},
						new RegionModel
						{
							Name = "Pennsylvania",
							Code = "PA"
						},
						new RegionModel
						{
							Name = "Rhode Island",
							Code = "RI"
						},
						new RegionModel
						{
							Name = "South Carolina",
							Code = "SC"
						},
						new RegionModel
						{
							Name = "South Dakota",
							Code = "SD"
						},
						new RegionModel
						{
							Name = "Tennessee",
							Code = "TN"
						},
						new RegionModel
						{
							Name = "Texas",
							Code = "TX"
						},
						new RegionModel
						{
							Name = "Utah",
							Code = "UT"
						},
						new RegionModel
						{
							Name = "Vermont",
							Code = "VT"
						},
						new RegionModel
						{
							Name = "Virgin Islands",
							Code = "VI"
						},
						new RegionModel
						{
							Name = "Virginia",
							Code = "VA"
						},
						new RegionModel
						{
							Name = "Washington",
							Code = "WA"
						},
						new RegionModel
						{
							Name = "West Virginia",
							Code = "WV"
						},
						new RegionModel
						{
							Name = "Wisconsin",
							Code = "WI"
						},
						new RegionModel
						{
							Name = "Wyoming",
							Code = "WY"
						},
						new RegionModel
						{
							Name = "Armed Forces Americas",
							Code = "AA"
						},
						new RegionModel
						{
							Name = "Armed Forces Europe, Canada, Africa and Middle East",
							Code = "AE"
						},
						new RegionModel
						{
							Name = "Armed Forces Pacific",
							Code = "AP"
						}
					}
				},
				new CountryModel
				{
					Name = "Uruguay",
					Code = "UY",
					NativeName = "",
					PhoneCode = "+598",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Artigas",
							Code = "AR"
						},
						new RegionModel
						{
							Name = "Canelones",
							Code = "CA"
						},
						new RegionModel
						{
							Name = "Cerro Largo",
							Code = "CL"
						},
						new RegionModel
						{
							Name = "Colonia",
							Code = "CO"
						},
						new RegionModel
						{
							Name = "Durazno",
							Code = "DU"
						},
						new RegionModel
						{
							Name = "Flores",
							Code = "FS"
						},
						new RegionModel
						{
							Name = "Florida",
							Code = "FD"
						},
						new RegionModel
						{
							Name = "Lavalleja",
							Code = "LA"
						},
						new RegionModel
						{
							Name = "Maldonado",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Montevideo",
							Code = "MO"
						},
						new RegionModel
						{
							Name = "Paysandú",
							Code = "PA"
						},
						new RegionModel
						{
							Name = "Río Negro",
							Code = "RN"
						},
						new RegionModel
						{
							Name = "Rivera",
							Code = "RV"
						},
						new RegionModel
						{
							Name = "Rocha",
							Code = "RO"
						},
						new RegionModel
						{
							Name = "Salto",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "San José",
							Code = "SJ"
						},
						new RegionModel
						{
							Name = "Soriano",
							Code = "SO"
						},
						new RegionModel
						{
							Name = "Tacuarembó",
							Code = "TA"
						},
						new RegionModel
						{
							Name = "Treinta y Tres",
							Code = "TT"
						}
					}
				},
				new CountryModel
				{
					Name = "Uzbekistan",
					Code = "UZ",
					NativeName = "Ўзбекистон , Узбекистан",
					PhoneCode = "+998",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Toshkent shahri",
							Code = "TK"
						},
						new RegionModel
						{
							Name = "Andijon",
							Code = "AN"
						},
						new RegionModel
						{
							Name = "Buxoro",
							Code = "BU"
						},
						new RegionModel
						{
							Name = "Farg‘ona",
							Code = "FA"
						},
						new RegionModel
						{
							Name = "Jizzax",
							Code = "JI"
						},
						new RegionModel
						{
							Name = "Namangan",
							Code = "NG"
						},
						new RegionModel
						{
							Name = "Navoiy",
							Code = "NW"
						},
						new RegionModel
						{
							Name = "Qashqadaryo (Qarshi)",
							Code = "QA"
						},
						new RegionModel
						{
							Name = "Samarqand",
							Code = "SA"
						},
						new RegionModel
						{
							Name = "Sirdaryo (Guliston)",
							Code = "SI"
						},
						new RegionModel
						{
							Name = "Surxondaryo (Termiz)",
							Code = "SU"
						},
						new RegionModel
						{
							Name = "Toshkent wiloyati",
							Code = "TO"
						},
						new RegionModel
						{
							Name = "Xorazm (Urganch)",
							Code = "XO"
						},
						new RegionModel
						{
							Name = "Qoraqalpog‘iston Respublikasi (Nukus)",
							Code = "QR"
						}
					}
				},
				#endregion

				#region V
				new CountryModel
				{
					Name = "Vanuatu",
					Code = "VU",
					NativeName = "",
					PhoneCode = "+678",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Malampa",
							Code = "MAP"
						},
						new RegionModel
						{
							Name = "Pénama",
							Code = "PAM"
						},
						new RegionModel
						{
							Name = "Sanma",
							Code = "SAM"
						},
						new RegionModel
						{
							Name = "Shéfa",
							Code = "SEE"
						},
						new RegionModel
						{
							Name = "Taféa",
							Code = "TAE"
						},
						new RegionModel
						{
							Name = "Torba",
							Code = "TOB"
						}
					}
				},
				new CountryModel
				{
					Name = "Venezuela",
					Code = "VE",
					NativeName = "",
					PhoneCode = "+58",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Dependencias Federales",
							Code = "W"
						},
						new RegionModel
						{
							Name = "Distrito Federal",
							Code = "A"
						},
						new RegionModel
						{
							Name = "Amazonas",
							Code = "Z"
						},
						new RegionModel
						{
							Name = "Anzoátegui",
							Code = "B"
						},
						new RegionModel
						{
							Name = "Apure",
							Code = "C"
						},
						new RegionModel
						{
							Name = "Aragua",
							Code = "D"
						},
						new RegionModel
						{
							Name = "Barinas",
							Code = "E"
						},
						new RegionModel
						{
							Name = "Bolívar",
							Code = "F"
						},
						new RegionModel
						{
							Name = "Carabobo",
							Code = "G"
						},
						new RegionModel
						{
							Name = "Cojedes",
							Code = "H"
						},
						new RegionModel
						{
							Name = "Delta Amacuro",
							Code = "Y"
						},
						new RegionModel
						{
							Name = "Falcón",
							Code = "I"
						},
						new RegionModel
						{
							Name = "Guárico",
							Code = "J"
						},
						new RegionModel
						{
							Name = "Lara",
							Code = "K"
						},
						new RegionModel
						{
							Name = "Mérida",
							Code = "L"
						},
						new RegionModel
						{
							Name = "Miranda",
							Code = "M"
						},
						new RegionModel
						{
							Name = "Monagas",
							Code = "N"
						},
						new RegionModel
						{
							Name = "Nueva Esparta",
							Code = "O"
						},
						new RegionModel
						{
							Name = "Portuguesa",
							Code = "P"
						},
						new RegionModel
						{
							Name = "Sucre",
							Code = "R"
						},
						new RegionModel
						{
							Name = "Táchira",
							Code = "S"
						},
						new RegionModel
						{
							Name = "Trujillo",
							Code = "T"
						},
						new RegionModel
						{
							Name = "Vargas",
							Code = "X"
						},
						new RegionModel
						{
							Name = "Yaracuy",
							Code = "U"
						},
						new RegionModel
						{
							Name = "Zulia",
							Code = "V"
						}
					}
				},
				new CountryModel
				{
					Name = "Vietnam",
					Code = "VN",
					NativeName = "Cộng hòa Xã hội chủ nghĩa Việt Nam",
					PhoneCode = "+84",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "An Giang",
							Code = "44"
						},
						new RegionModel
						{
							Name = "Bà Rịa - Vũng Tàu",
							Code = "43"
						},
						new RegionModel
						{
							Name = "Bình Dương",
							Code = "57"
						},
						new RegionModel
						{
							Name = "Bình Phước",
							Code = "58"
						},
						new RegionModel
						{
							Name = "Bình Định",
							Code = "31"
						},
						new RegionModel
						{
							Name = "Bình Thuận",
							Code = "40"
						},
						new RegionModel
						{
							Name = "Bạc Liêu",
							Code = "55"
						},
						new RegionModel
						{
							Name = "Bắc Giang",
							Code = "54"
						},
						new RegionModel
						{
							Name = "Bắc Kạn",
							Code = "53"
						},
						new RegionModel
						{
							Name = "Bắc Ninh",
							Code = "56"
						},
						new RegionModel
						{
							Name = "Bến Tre",
							Code = "50"
						},
						new RegionModel
						{
							Name = "Cao Bằng",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Cà Mau",
							Code = "59"
						},
						new RegionModel
						{
							Name = "Đắk Lắk",
							Code = "33"
						},
						new RegionModel
						{
							Name = "Đắk Nông",
							Code = "72"
						},
						new RegionModel
						{
							Name = "Điện Biên",
							Code = "71"
						},
						new RegionModel
						{
							Name = "Đồng Nai",
							Code = "39"
						},
						new RegionModel
						{
							Name = "Đồng Tháp",
							Code = "45"
						},
						new RegionModel
						{
							Name = "Gia Lai",
							Code = "30"
						},
						new RegionModel
						{
							Name = "Hà Giang",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Hà Nam",
							Code = "63"
						},
						new RegionModel
						{
							Name = "Hà Tây",
							Code = "15"
						},
						new RegionModel
						{
							Name = "Hà Tĩnh",
							Code = "23"
						},
						new RegionModel
						{
							Name = "Hải Dương",
							Code = "61"
						},
						new RegionModel
						{
							Name = "Hậu Giang",
							Code = "73"
						},
						new RegionModel
						{
							Name = "Hòa Bình",
							Code = "14"
						},
						new RegionModel
						{
							Name = "Hưng Yên",
							Code = "66"
						},
						new RegionModel
						{
							Name = "Khánh Hòa",
							Code = "34"
						},
						new RegionModel
						{
							Name = "Kiên Giang",
							Code = "47"
						},
						new RegionModel
						{
							Name = "Kon Tum",
							Code = "28"
						},
						new RegionModel
						{
							Name = "Lai Châu",
							Code = "01"
						},
						new RegionModel
						{
							Name = "Lâm Đồng",
							Code = "35"
						},
						new RegionModel
						{
							Name = "Lạng Sơn",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Lào Cai",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Long An",
							Code = "41"
						},
						new RegionModel
						{
							Name = "Nam Định",
							Code = "67"
						},
						new RegionModel
						{
							Name = "Nghệ An",
							Code = "22"
						},
						new RegionModel
						{
							Name = "Ninh Bình",
							Code = "18"
						},
						new RegionModel
						{
							Name = "Ninh Thuận",
							Code = "36"
						},
						new RegionModel
						{
							Name = "Phú Thọ",
							Code = "68"
						},
						new RegionModel
						{
							Name = "Phú Yên",
							Code = "32"
						},
						new RegionModel
						{
							Name = "Quảng Bình",
							Code = "24"
						},
						new RegionModel
						{
							Name = "Quảng Nam",
							Code = "27"
						},
						new RegionModel
						{
							Name = "Quảng Ngãi",
							Code = "29"
						},
						new RegionModel
						{
							Name = "Quảng Ninh",
							Code = "13"
						},
						new RegionModel
						{
							Name = "Quảng Trị",
							Code = "25"
						},
						new RegionModel
						{
							Name = "Sóc Trăng",
							Code = "52"
						},
						new RegionModel
						{
							Name = "Sơn La",
							Code = "05"
						},
						new RegionModel
						{
							Name = "Tây Ninh",
							Code = "37"
						},
						new RegionModel
						{
							Name = "Thái Bình",
							Code = "20"
						},
						new RegionModel
						{
							Name = "Thái Nguyên",
							Code = "69"
						},
						new RegionModel
						{
							Name = "Thanh Hóa",
							Code = "21"
						},
						new RegionModel
						{
							Name = "Thừa Thiên–Huế",
							Code = "26"
						},
						new RegionModel
						{
							Name = "Tiền Giang",
							Code = "46"
						},
						new RegionModel
						{
							Name = "Trà Vinh",
							Code = "51"
						},
						new RegionModel
						{
							Name = "Tuyên Quang",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Vĩnh Long",
							Code = "49"
						},
						new RegionModel
						{
							Name = "Vĩnh Phúc",
							Code = "70"
						},
						new RegionModel
						{
							Name = "Yên Bái",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Cần Thơ",
							Code = "CT"
						},
						new RegionModel
						{
							Name = "Đà Nẵng",
							Code = "DN"
						},
						new RegionModel
						{
							Name = "Hà Nội",
							Code = "HN"
						},
						new RegionModel
						{
							Name = "Hải Phòng",
							Code = "HP"
						},
						new RegionModel
						{
							Name = "Hồ Chí Minh (Sài Gòn)",
							Code = "SG"
						}
					}
				},
				new CountryModel
				{
					Name = "British Virgin Islands",
					Code = "VG",
					NativeName = "",
					PhoneCode = "+1 284",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Anegada",
							Code = "ANG"
						},
						new RegionModel
						{
							Name = "Jost Van Dyke",
							Code = "JVD"
						},
						new RegionModel
						{
							Name = "Tortola",
							Code = "TTA"
						},
						new RegionModel
						{
							Name = "Virgin Gorda",
							Code = "VGD"
						}
					}
				},
				#endregion

				#region W
				new CountryModel
				{
					Name = "Wallis and Futuna",
					Code = "WF",
					NativeName = "Wallis et Futuna",
					PhoneCode = "+681",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Alo",
							Code = "ALO"
						},
						new RegionModel
						{
							Name = "Sigave",
							Code = "SIG"
						},
						new RegionModel
						{
							Name = "Wallis",
							Code = "WAL"
						}
					}
				},
				#endregion

				#region Y
				new CountryModel
				{
					Name = "Yemen",
					Code = "YE",
					NativeName = "الجمهوريّة اليمنية",
					PhoneCode = "+967",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Abyān",
							Code = "AB"
						},
						new RegionModel
						{
							Name = "'Adan",
							Code = "AD"
						},
						new RegionModel
						{
							Name = "Aḑ Ḑāli'",
							Code = "DA"
						},
						new RegionModel
						{
							Name = "Al Bayḑā'",
							Code = "BA"
						},
						new RegionModel
						{
							Name = "Al Ḩudaydah",
							Code = "HU"
						},
						new RegionModel
						{
							Name = "Al Jawf",
							Code = "JA"
						},
						new RegionModel
						{
							Name = "Al Mahrah",
							Code = "MR"
						},
						new RegionModel
						{
							Name = "Al Maḩwīt",
							Code = "MW"
						},
						new RegionModel
						{
							Name = "'Amrān",
							Code = "AM"
						},
						new RegionModel
						{
							Name = "Dhamār",
							Code = "DH"
						},
						new RegionModel
						{
							Name = "Ḩaḑramawt",
							Code = "HD"
						},
						new RegionModel
						{
							Name = "Ḩajjah",
							Code = "HJ"
						},
						new RegionModel
						{
							Name = "Ibb",
							Code = "IB"
						},
						new RegionModel
						{
							Name = "Laḩij",
							Code = "LA"
						},
						new RegionModel
						{
							Name = "Ma'rib",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Raymah",
							Code = "RA"
						},
						new RegionModel
						{
							Name = "Şā‘dah",
							Code = "SD"
						},
						new RegionModel
						{
							Name = "Şan‘ā'",
							Code = "SN"
						},
						new RegionModel
						{
							Name = "Shabwah",
							Code = "SH"
						},
						new RegionModel
						{
							Name = "Tā‘izz",
							Code = "TA"
						}
					}
				},
				#endregion

				#region Z
				new CountryModel
				{
					Name = "Zambia",
					Code = "ZM",
					NativeName = "",
					PhoneCode = "+260",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Central",
							Code = "02"
						},
						new RegionModel
						{
							Name = "Copperbelt",
							Code = "08"
						},
						new RegionModel
						{
							Name = "Eastern",
							Code = "03"
						},
						new RegionModel
						{
							Name = "Luapula",
							Code = "04"
						},
						new RegionModel
						{
							Name = "Lusaka",
							Code = "09"
						},
						new RegionModel
						{
							Name = "Northern",
							Code = "05"
						},
						new RegionModel
						{
							Name = "North-Western",
							Code = "06"
						},
						new RegionModel
						{
							Name = "Southern",
							Code = "07"
						},
						new RegionModel
						{
							Name = "Western",
							Code = "01"
						}
					}
				},
				new CountryModel
				{
					Name = "Zimbabwe",
					Code = "ZW",
					NativeName = "",
					PhoneCode = "+263",
					Regions = new ObservableCollection<RegionModel>
					{
						new RegionModel
						{
							Name = "Bulawayo",
							Code = "BU"
						},
						new RegionModel
						{
							Name = "Harare",
							Code = "HA"
						},
						new RegionModel
						{
							Name = "Manicaland",
							Code = "MA"
						},
						new RegionModel
						{
							Name = "Mashonaland Central",
							Code = "MC"
						},
						new RegionModel
						{
							Name = "Mashonaland East",
							Code = "ME"
						},
						new RegionModel
						{
							Name = "Mashonaland West",
							Code = "MW"
						},
						new RegionModel
						{
							Name = "Masvingo",
							Code = "MV"
						},
						new RegionModel
						{
							Name = "Matabeleland North",
							Code = "MN"
						},
						new RegionModel
						{
							Name = "Matabeleland South",
							Code = "MS"
						},
						new RegionModel("Midlands","MI")
					}
				}
				#endregion
			};
		}

		public static ObservableCollection<CountryModel> GetCountriesForPhoneCOde()
		{
			return new ObservableCollection<CountryModel>
			{
				#region A
				new CountryModel("Afghanistan","AF","+93","","افغانستان","افغانستان"),
				new CountryModel("Albania","AL","+355","XX XXX XXXX","Shqipërisë","Shqiperise"),
				new CountryModel("Algeria","DZ","+213","XXX XX XX XX","الجزائر‎"),
				new CountryModel("American Samoa","AS","+1684","XXX XXXX","Amerika Sāmoa"),
				new CountryModel("Andorra","AD","+376","XX XX XX","Principat d'Andorra"),
				new CountryModel("Angola","AO","+244","",""),
				new CountryModel("Anguilla","AI","+1264","XXX XXXX",""),
				new CountryModel("Antigua and Barbuda","AG","+1268","XXX XXXX",""),
				new CountryModel("Argentina","AR","+54","",""),
				new CountryModel("Armenia","AM","+374","XX XXX XXX","Հայաստան"),
				new CountryModel("Aruba","AW","+297","XXX XXXX",""),
				new CountryModel("Australia","AU","+61","",""),
				new CountryModel("Austria","AT","+43","","Österreich"),
				new CountryModel("Azerbaijan","AZ","+994","XX XXX XXXX","Azərbaycan"),
				#endregion

				#region B
				new CountryModel("Bahamas","BS","+1242","XXX XXXX",""),
				new CountryModel("Bahrain","BH","+973","XXXX XXXX","البحرين‎"),
				new CountryModel("Bangladesh","BD","+880","","বাংলাদেশ"),
				new CountryModel("Barbados","BB","+1246","XXX XXXX",""),
				new CountryModel("Belarus","BY","+375","XX XXX XXXX","Беларусь"),
				new CountryModel("Belgium","BE","+32","XXX XX XX XX","België","Belgique","Belgien"),
				new CountryModel("Belize","BZ","+501","", "Belice"),
				new CountryModel("Benin","BJ","+229","XX XXX XXX","Bénin"),
				new CountryModel("Bermuda","BM","+1441","XXX XXXX",""),
				new CountryModel("Bhutan","BT","+975","XX XXX XXX","འབྲུག་ རྒྱལ་ཁབ་"),
				new CountryModel("Bolivia","BO","+591","X XXX XXXX","Wuliwya","Buliwya","Volívia"),
				new CountryModel("Caribbean Netherlands","BQ","+599","X XXX XXXX","Caribisch Nederland"),
				new CountryModel("Bosnia and Herzegovina","BA","+387","","Босна и Херцеговина"),
				new CountryModel("Botswana","BW","+267","XX XXX XXX",""),
				new CountryModel("Bouvet Island","BV","+55","XX XXXXX XXXXX","Bouvetøya"),
				new CountryModel("Brazil","BR","+55","XX XXXXX XXXX","Brasil"),
				new CountryModel("British Indian Ocean Territory","IO","+246","XXX XXXX",""),
				new CountryModel("British Virgin Islands","VG","1284","XXX XXXX",""),
				new CountryModel("Brunei","BN","+673","XXX XXXX","بروني دارالسلام"),
				new CountryModel("Bulgaria","BG","+359","","България"),
				new CountryModel("Burkina Faso","BF","+226","XX XX XX XX",""),
				new CountryModel("Burundi","BI","+257","XX XX XXXX",""),
				#endregion

				#region C
				new CountryModel("Cambodia","KH","+855","","ព្រះរាជាណាចក្រកម្ពុជា"),
				new CountryModel("Cameroon","CM","+237","XXXX XXXX","Cameroun"),
				new CountryModel("Canada","CA","+1","XXX XXX XXXX",""),
				new CountryModel("Cape Verde","CV","+238","XXX XXXX","Cabo Verde","Kabu Verdi"),
				new CountryModel("Cayman Islands","KY","+1345","XXX XXXXX",""),
				new CountryModel("Central African Republic","CF","+236","XX XX XX XX","Ködörösêse tî Bêafrîka","République centrafricaine"),
				new CountryModel("Chad","TD","+235","XX XX XX XX","Tchad","جمهورية تشاد "),
				new CountryModel("Chile","CL","+56","X XXXX XXXX",""),
				new CountryModel("China","CN","+86","XXX XXXX XXXX","中华人民共和国"),
				new CountryModel("Christmas Island","CX","+61","XXXX XXX XXX",""),
				new CountryModel("Cocos (Keeling) Islands","CC","+851","","Pulu Kokos(Keeling)","Wilayah Kepulauan Cocos(Keeling)"),
				new CountryModel("Cocos (Keeling) Islands","CC","+891","","Pulu Kokos(Keeling)","Wilayah Kepulauan Cocos(Keeling)"),
				new CountryModel("Colombia","CO","+57","XXX XXX XXXX",""),
				new CountryModel("Comoros","KM","+269","XXX XXXX","Komori","Comores","الاتحاد القمري"),
				new CountryModel("Congo (Republic)","CG","+242","XX XXX XXXX",""),
				new CountryModel("Congo (Democratic Republic)", "CD","+243","XX XXX XXXX","République Démocratique du Congo","Repubilika ya Kôngo ya Dimokalasi","Republiki ya Kɔ́ngɔ Demokratiki","Jamhuri ya Kidemokrasia ya Kongo","Ditunga dia Kongu wa Mungalaata"),
				new CountryModel("Cook Islands","CK","+682","","Kuki ’Āirani"),
				new CountryModel("Costa Rica","CR","+506","XXXX XXXX",""),
				new CountryModel("Cote d'Ivoire","CI","+225","XX XXX XXX","Côte d’Ivoire"),
				new CountryModel("Croatia","HR","+385","","Hrvatska"),
				new CountryModel("Cuba","CU","+53","XXXX XXXX",""),
				new CountryModel("Curaçao","CW","+599","","Curazao"),
				new CountryModel("Cyprus","CY","+357","XXXX XXXX","Κύπρος","Kıbrıs"),
				new CountryModel("Czech Republic","CZ","+420","","Česká republika"),
				#endregion
				
				#region D
				new CountryModel("Denmark","DK","+45","XXXX XXXX","Danmark"),
				new CountryModel("Djibouti","DJ","+253","XX XX XX XX","Gabuutih Ummuuno","Jabuuti","جمهورية جيبوتي"),
				new CountryModel("Dominica","DM","+1767","XXX XXXX",""),
				new CountryModel("Dominican Republic","DO","+1","XXX XXX XXXX","República Dominicana"),
				#endregion
				
				#region E
				new CountryModel("Ecuador","EC","+593","XX XXX XXXX",""),
				new CountryModel("Egypt","EG","+20","XX XXXX XXXX","‎مِصر"),
				new CountryModel("El Salvador","SV","+503","XXXX XXXX", ""),
				new CountryModel("Equatorial Guinea","GQ","+240","","Guinée Équatoriale","Guiné Equatorial"),
				new CountryModel("Eritrea","ER","+291","X XXX XXX","ሃገረ ኤርትራ","دولة إرتريا"),
				new CountryModel("Estonia","EE","+372","","Eesti Vabariik"),
				new CountryModel("Ethiopia","ET","+251","","የኢትዮጵያ ፌዴራላዊ ዴሞክራሲያዊ ሪፐብሊክ"),
				#endregion
				
				#region F
				new CountryModel("Falkland Islands","FK","+500","XXXXX","Islas Malvinas"),
				new CountryModel("Faroe Islands","FO","+298","XXX XXX","Færøerne","Føroyar"),
				new CountryModel("Fiji","FJ","+679","","Matanitu Tugalala o Viti","फ़िजी गणराज्य"),
				new CountryModel("Finland","FI","+358","","Suomen"),
				new CountryModel("France","FR","+33","X XX XX XX",""),
				new CountryModel("French Guiana","GF","+594","","Guyane Française"),
				new CountryModel("French Polynesia","PF","+689","","Polynésie Française","Porinetia Farani"),
				#endregion
				
				#region G
				new CountryModel("Gabon","GA","+241","X XX XX XX",""),
				new CountryModel("Gambia","GM","+220","XXX XXXX",""),
				new CountryModel("Georgia","GE","+995","","საქართველო"),
				new CountryModel("Germany","DE","+49","XXXXX XXXXXXX","Deutschland"),
				new CountryModel("Ghana","GH","+233","",""),
				new CountryModel("Gibraltar","GI","+350","XXXXXXXX",""),
				new CountryModel("Greece","GR","+30","XXX XXX XXXX","Ελλάδα"),
				new CountryModel("Greenland","GL","+299","XXX XXX","Kalaallit Nunaat"),
				new CountryModel("Grenada","GD","+1473","XXX XXXX",""),
				new CountryModel("Guadeloupe","GP","+590","XXX XX XX XX",""),
				new CountryModel("Guam","GU","+1671","XXX XXXX","Guåhån"),
				new CountryModel("Guatemala","GT","+502","X XXX XXXX",""),
				new CountryModel("Guernsey","GG","+44","XXXXX XXXXXX",""),
				new CountryModel("Guinea","GN","+224","","Guinée"),
				new CountryModel("Guinea-Bissau","GW","+245","XXX XXXX","Guiné-Bissau"),
				new CountryModel("Guyana","GY","+592","",""),
				#endregion

				#region H
				new CountryModel("Haiti","HT","+509","","Haïti","Ayiti"),
				new CountryModel("Honduras","HN","+504","XXXX XXXX",""),
				new CountryModel("Hong Kong","HK","+852","X XXX XXXX","香港"),
				new CountryModel("Hungary","HU","+36","","Magyarország"),
				#endregion
				
				#region I
				new CountryModel("Iceland","IS","+354","XXX XXXX","Ísland"),
				new CountryModel("India","IN","+91","XXXXX XXXXX","भारत गणराज्य"),
				new CountryModel("Indonesia","ID","+62","",""),
				new CountryModel("Iran","IR","+98","XXX XXX XXXX","جمهوری اسلامی ایران"),
				new CountryModel("Iraq","IQ","+964","XXX XXX XXXX","جمهورية ألعراق - كۆماريى عێراق"),
				new CountryModel("Ireland","IE","+353","XX XXX XXXX","Éire"),
				new CountryModel("Isle of Man","IM","44","XXXXX XXXXXX","Ellan Vannin","Ellan Mannin"),
				new CountryModel("Israel","IL","972","XX XXX XXXX","מדינת ישראל", "دولة إسرائيل"),
				new CountryModel("Italy","IT","39","",""),
				#endregion
				
				#region	J
				new CountryModel("Jamaica","JM","1876","XXX XXXX","Jumieka"),
				new CountryModel("Japan","JP","81","XX XXXX XXXX","日本国"),
				new CountryModel("Jersey","JE","44","","Jèrri"),
				new CountryModel("Jordan","JO","962","X XXXX XXXXX","المملكة الأردنّيّة الهاشميّة"),
				#endregion
				
				#region K
				new CountryModel("Kazakhstan","KZ","+7","XXX XXX XXXX","Қазақстан Республикасы","Республика Казахстан"),
				new CountryModel("Kenya","KE","+254","","Kenya"),
				new CountryModel("Kiribati","KI","+686","","Kiribati"),
				new CountryModel("Kuwait","KW","+965","XXXX XXXX","دولة الكويت"),
				new CountryModel("Kyrgyzstan","KG","+996","XXX XXXXXX","Кыргыз Республикасы","Кыргызская Республика"),
				#endregion

				#region L
				new CountryModel("Laos","LA","+856","XX XX XXX XXX","ສາທາລະນະລັດປະຊາທິປະໄຕ ປະຊາຊົນລາວ"),
				new CountryModel("Latvia","LV","+371","XXX XXXXX","Latvijas Republika"),
				new CountryModel("Lebanon","LB","+961","","République Libanaise","الجمهورية اللبنانية"),
				new CountryModel("Lesotho","LS","+266","XX XXX XXX",""),
				new CountryModel("Liberia","LR","+231","",""),
				new CountryModel("Libya","LY","+218","XX XXX XXXX","Awanak en Libu","دولة ليبيا"),
				new CountryModel("Liechtenstein","LI","+423","",""),
				new CountryModel("Lithuania","LT","+370","XXX XXXXX","Lietuva"),
				new CountryModel("Luxembourg","LU","+352","","Lëtzebuerg","Luxemburg"),
				#endregion
				
				#region M
				new CountryModel("Macau","MO","+853","XXXX XXXX","澳門","澳门"),
				new CountryModel("Macedonia","MK","+389","XX XXX XXX","Северна Македонија","Maqedonisë së Veriut"),
				new CountryModel("Madagascar","MG","+261","XX XX XXX XX","Madagasikara"),
				new CountryModel("Malawi","MW","+265","XX XXX XXXX","Malaŵi"),
				new CountryModel("Malaysia","MY","+60","","مليسيا"),
				new CountryModel("Maldives","MV","+960","XXX XXXX","ދިވެހިރާއްޖޭގެ ޖުމުހޫރިއްޔާ"),
				new CountryModel("Mali","ML","+223","XXXX XXXX",""),
				new CountryModel("Malta","MT","+356","XX XX XX XX",""),
				new CountryModel("Marshall Islands","MH","+692","","Aolepān Aorōkin M̧ajeļ"),
				new CountryModel("Martinique","MQ","+596","","Matinik"),
				new CountryModel("Mauritania","MR","+222","XXXX XXXX","الجمهورية الإسلامية الموريتانية","Mauritanie"),
				new CountryModel("Mauritius", "MU","+230","","Maurice","Moris"),
				new CountryModel("Mayotte","YT","+262","XXXX XX XX XX",""),
				new CountryModel("Mexico","MX","+52","XXX XXX XXX XXXX","México"),
				new CountryModel("Micronesia","FM","+691","","ミクロネシア"),
				new CountryModel("Moldova","MD","+373","XX XXX XXX", ""),
				new CountryModel("Monaco","MC","+377","XXXX XXXX","Mu̍negu","Mónegue"),
				new CountryModel("Mongolia","MN","+976","XX XX XXXX","ᠮᠣᠩᠭ᠋ᠣᠯᠤᠯᠤᠰ"),
				new CountryModel("Montenegro","ME","+382","","Црна Гора","Crna Gora"),
				new CountryModel("Montserrat","MS","+1664","XXX XXXX",""),
				new CountryModel("Morocco","MA","+212","XX XXX XXXX","ⵎⵓⵔⴰⴽⵓⵛ","المغرب‎"),
				new CountryModel("Mozambique","MZ","+258","XX XXX XXXX","Moçambique"),
				new CountryModel("Myanmar","MM","+95","","ပြည်ထောင်စုသမ္မတမြန်မာနိုင်ငံ"),
				#endregion

				#region N
				new CountryModel("Namibia","NA","+264","XX XXX XXXX","Namibië"),
				new CountryModel("Nauru","NR","+674","","Ripublik Naoero"),
				new CountryModel("Nepal","NP","+977","XX XXXX XXXX","नेपाल"),
				new CountryModel("Netherlands","NL","+31","X XX XX XX XX","Nederland"),
				new CountryModel("New Caledonia","NC","+687","","Nouvelle Calédonie"),
				new CountryModel("New Zealand","NZ","+64","","Aotearoa"),
				new CountryModel("Nicaragua","NI","+505","XXXX XXXX",""),
				new CountryModel("Niger","NE","+227","XX XX XX XX","Nijar","Niiser"),
				new CountryModel("Nigeria","NG","+234","","Nàìjíríà","Nijeriya","Naìjíríyà"),
				new CountryModel("Niue","NU","+683","","Niuē-fekai"),
				new CountryModel("Norfolk Island","NF","+672","X XXXXX","Norfuk Ailen"),
				new CountryModel("North Korea","KP","+850","XXXX XXX XXXX","조선민주주의인민공화국","朝鮮民主主義人民共和國"),
				new CountryModel("Northern Mariana Islands","MP","+1670","XXX XXXX",""),
				new CountryModel("Norway","NO","+47","XXXX XXXX","Norge","Noreg","Norgga"),
				#endregion

				#region O
				new CountryModel("Oman","OM","+968","XXXX XXXX","سلطانة عمان"),
				#endregion

				#region P
				new CountryModel("Pakistan","PK","+92","XXX XXX XXXX","اسلامی جمہوریہ پاكستان"),
				new CountryModel("Palau","PW","+680","","Beluu er a Belau","パラオ共和国 "),
				new CountryModel("Palestine","PS","+970","XXX XX XXXX","دولة فلسطين"),
				new CountryModel("Panama","PA","+507","XXXX XXXX","Panamá"),
				new CountryModel("Papua New Guinea","PG","+675","","Papua Niu Gini","Papua Niugini"),
				new CountryModel("Paraguay","PY","+595","","Tetã Paraguái"),
				new CountryModel("Peru","PE","+51","","Perú","Piruw"),
				new CountryModel("Philippines","PH","+63","XXX XXX XXXX","Pilipinas"),
				new CountryModel("Pitcairn Islands","PN","+64","XXX XXX XXXX","Pitkern Ailen"),
				new CountryModel("Poland","PL","+48","","Polska"),
				new CountryModel("Portugal","PT","+351","X XXXX XXXX",""),
				new CountryModel("Puerto Rico","PR","1","XXX XXX XXXX",""),
				#endregion

				#region Q
				new CountryModel("Qatar","QA","974","XX XXX XXX","دولة قطر"),
				#endregion

				#region R
				
				new CountryModel("Réunion","RE","262","","La Réunion"),
				new CountryModel("Romania","RO","40","","România"),
				new CountryModel("Russian","RU","7","XXX XXX XXXX","Россия"),
				new CountryModel("Rwanda","RW","250","",""),
				#endregion

				#region S
				new CountryModel("Saint Barthélemy","BL","590","XXXX XX XXXX",""),
				new CountryModel("Saint Helena","SH","290","XXXX",""),
				new CountryModel("Saint Kitts and Nevis","KN","1869","XXX XXXX",""),
				new CountryModel("Saint Lucia","LC","1758","XXX XXXX","Sent Lisi"),
				new CountryModel("Saint Pierre and Miquelon","PM","508","","Saint Pierre et Miquelon"),
				new CountryModel("Saint Vincent and the Grenadines","VC","1784","XXX XXXX",""),
				new CountryModel("Samoa","WS","685","","Sāmoa"),
				new CountryModel("San Marino","SM","378","XXX XXX XXXX",""),
				new CountryModel("Sao Tome and Principe","ST","+239","XXX XXXX","São Tomé e Príncipe"),
				new CountryModel("Saudi Arabia","SA","+966","XX XXX XXXX","المملكة العربية السعودية"),
				new CountryModel("Senegal","SN","+221","XX XXX XXXX","Sénégal"),
				new CountryModel("Serbia","RS","+381","XX XXX XXXX","Србија","Srbija"),
				new CountryModel("Seychelles","SC","+248","X XX XX XX","Sesel"),
				new CountryModel("Sierra Leone","SL","+232","XX XXX XXX",""),
				new CountryModel("Singapore", "SG","+65","XXXX XXXX","Singapura","新加坡","சிங்கப்பூர்"),
				new CountryModel("Sint Maarten","SX","+1721","XXX XXXX","Sint Maarten"),
				new CountryModel("Slovakia","SK","+421","","Slovensko"),
				new CountryModel("Slovenia","SI","+386","XX XXX XXX","Slovenija"),
				new CountryModel("Solomon Islands","SB","+677","",""),
				new CountryModel("Somalia","SO","+252","XX XXX XXX","Jamhuuriyadda Federaalka Soomaaliya","جمهورية الصومال الفدرالية"),
				new CountryModel("South Africa","ZA","27","XX XXX XXXX","Suid-Afrika","Iningizimu Afrika","Mzantsi Afrika"),
				new CountryModel("South Georgia and South Sandwich Islands","GS","500","XXXXX",""),
				new CountryModel("South Korea","KR","82","XXX XXXX XXXX","대한민국","大韓民國"),
				new CountryModel("South Sudan","SS","211","XX XXX XXXX","Jamhuri ya Sudan Kusini"),
				new CountryModel("Spain","ES","34","","España"),
				new CountryModel("Sri Lanka","LK","94","XX XXX XXXX","ශ්රී ලංකාව , இலங்கை"),
				new CountryModel("Sudan","SD","249","XX XXX XXXX","جمهورية السودان"),
				new CountryModel("Suriname","SR","597","XXX XXXX",""),
				new CountryModel("Swaziland","SZ","268","XXXX XXXX","Umbuso weSwatini"),
				new CountryModel("Sweden","SE","46","XX XXX XXXX","Sverige"),
				new CountryModel("Switzerland","CH","41","XX XXX XXXX","Schweiz","Svizzera"),
				new CountryModel("Syria","SY","963","","سوريا"),
				#endregion

				#region T
				new CountryModel("Taiwan","TW","886","","中华民国","台湾"),
				new CountryModel("Tajikistan","TJ","992","XX XXX XXXX","Тоҷикистон","Таджикистан"),
				new CountryModel("Tanzania","TZ","255","XXXX XXX XXX",""),
				new CountryModel("Thailand","TH","66","XXX XXX XXXX","ราชอาณาจักรไทย"),
				new CountryModel("Timor-Leste","TL","670","XXXX XXXX","Timor Leste , Timor Lorosa'e"),
				new CountryModel("Togo","TG","228","XX XX XX XX","République du Togo"),
				new CountryModel("Tokelau","TK","690","XXXX",""),
				new CountryModel("Tonga","TO","676","","Pule'anga Fakatu'i 'o Tonga"),
				new CountryModel("Trinidad and Tobago","TT","1868","XXX XXXX",""),
				new CountryModel("Tunisia","TN","216","XX XXX XXX","الجمهورية التونسية"),
				new CountryModel("Turkey","TR","90","XXX XXX XXXX","Türkiye"),
				new CountryModel("Turkmenistan","TM","993","XX XXXXXX","Türkmenistan","Туркменистан"),
				new CountryModel("Turks and Caicos Islands","TC","1649","XXX XXXX",""),
				new CountryModel("Tuvalu","TV","688","",""),
				#endregion

				#region U
				new CountryModel("Uganda","UG","256","XXXX XXXXXX"),
				new CountryModel("Ukraine","UA","380","XXX XXX XXXX","Україна"),
				new CountryModel("United Arab Emirates","AE","971","XX XXX XXXX","دولة الإمارات العربية المتحدة"),
				new CountryModel("United Kingdom","GB","44","XXXX XXXXXX",""),
				new CountryModel("United States","US","1","XXX XXX XXXX","Estados Unidos"),
				new CountryModel("Uruguay","UY","598","X XXX XXXX",""),
				new CountryModel("Uzbekistan","UZ","998","XX XXXXXXX","Ўзбекистон","Узбекистан"),
				#endregion

				#region V
				new CountryModel("Vanuatu","VU","678","",""),
				new CountryModel("Venezuela","VE","58","XXXX XXXXXXX",""),
				new CountryModel("Vietnam","VN","84","XXX XXX XX XX","Cộng hòa Xã hội chủ nghĩa Việt Nam"),
				#endregion

				#region W
				new CountryModel("Wallis and Futuna","WF","681","","Wallis et Futuna"),
				#endregion

				#region Y
				new CountryModel("Yemen","YE","967","","الجمهوريّة اليمنية"),
				#endregion

				#region Z
				new CountryModel("Zambia","ZM","260","XX XXX XXXX",""),
				new CountryModel("Zimbabwe","ZW","263","XX XXX XXXX",""),
				#endregion
			};
		}

		public static CountryModel GetCountry(string code) 
		{
			var countries = new ObservableCollection<CountryModel>();
			
			switch (code[0]) 
			{
				case 'A':
					countries = new ObservableCollection<CountryModel> { 
					#region A
					new CountryModel
					{
							Name = "Afghanistan",
							Code = "AF",
							NativeName = " افغانستان , افغانستان",
							PhoneCode = "+93",
							Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Badakhshan",
								Code = "BDS"
							},
							new RegionModel
							{
								Name = "Badghis",
								Code = "BDG"
							},
							new RegionModel
							{
								Name = "Baghlan",
								Code = "BGL"
							},
							new RegionModel
							{
								Name = "Balkh",
								Code = "BAL"
							},
							new RegionModel
							{
								Name = "Bamyan",
								Code = "BAM"
							},
							new RegionModel
							{
								Name = "Daykundi",
								Code = "DAY"
							},
							new RegionModel
							{
								Name = "Farah",
								Code = "FRA"
							},
							new RegionModel
							{
								Name = "Faryab",
								Code = "FYB"
							},
							new RegionModel
							{
								Name = "Ghazni",
								Code = "GHA"
							},
							new RegionModel
							{
								Name = "Ghor",
								Code = "GHO"
							},
							new RegionModel
							{
								Name = "Helmand",
								Code = "HEL"
							},
							new RegionModel
							{
								Name = "Herat",
								Code = "HER"
							},
							new RegionModel
							{
								Name = "Jowzjan",
								Code = "JOW"
							},
							new RegionModel
							{
								Name = "Kabul",
								Code = "KAB"
							},
							new RegionModel
							{
								Name = "Kandahar",
								Code = "KAN"
							},
							new RegionModel
							{
								Name = "Kapisa",
								Code = "KAP"
							},
							new RegionModel
							{
								Name = "Khost",
								Code = "KHO"
							},
							new RegionModel
							{
								Name = "Kunar",
								Code = "KNR"
							},
							new RegionModel
							{
								Name = "Kunduz",
								Code = "KDZ"
							},
							new RegionModel
							{
								Name = "Laghman",
								Code = "LAG"
							},
							new RegionModel
							{
								Name = "Logar",
								Code = "LOW"
							},
							new RegionModel
							{
								Name = "Maidan Wardak",
								Code = "WAR"
							},
							new RegionModel
							{
								Name = "Nangarhar",
								Code = "NAN"
							},
							new RegionModel
							{
								Name = "Nimruz",
								Code = "NIM"
							},
							new RegionModel
							{
								Name = "Nuristan",
								Code = "NUR"
							},
							new RegionModel
							{
								Name = "Paktia",
								Code = "PIA"
							},
							new RegionModel
							{
								Name = "Paktika",
								Code = "PKA"
							},
							new RegionModel
							{
								Name = "Panjshir",
								Code = "PAN"
							},
							new RegionModel
							{
								Name = "Parwan",
								Code = "PAR"
							},
							new RegionModel
							{
								Name = "Samangan",
								Code = "SAM"
							},
							new RegionModel
							{
								Name = "Sar-e Pol",
								Code = "SAR"
							},
							new RegionModel
							{
								Name = "Takhar",
								Code = "TAK"
							},
							new RegionModel
							{
								Name = "Urozgan",
								Code = "ORU"
							},
							new RegionModel
							{
								Name = "Zabul",
								Code = "ZAB"
							}
						}
						},
					new CountryModel
					{
						Name = "Albania",
						Code = "AL",
						NativeName = "Shqipërisë , Shqiperise",
						PhoneCode = "+355",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Berat",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Dibër",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Durrës",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Elbasan",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Fier",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Gjirokastër",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Korçë",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Kukës",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Lezhë",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Shkodër",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Tirana",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Vlorë",
								Code = "12"
							}
						}
					},
					new CountryModel
					{
						Name = "Algeria",
						Code = "DZ",
						NativeName = "ⴷⵣⴰⵢⴻⵔ , الجزائر‎",
						PhoneCode = "+213",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Adrar",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Aïn Defla",
								Code = "44"
							},
							new RegionModel
							{
								Name = "Aïn Témouchent",
								Code = "46"
							},
							new RegionModel
							{
								Name = "Algiers",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Annaba",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Batna",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Béchar",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Béjaïa",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Biskra",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Blida",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Bordj Bou Arréridj",
								Code = "34"
							},
							new RegionModel
							{
								Name = "Bouïra",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Boumerdès",
								Code = "35"
							},
							new RegionModel
							{
								Name = "Chlef",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Constantine",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Djelfa",
								Code = "17"
							},
							new RegionModel
							{
								Name = "El Bayadh",
								Code = "32"
							},
							new RegionModel
							{
								Name = "El Oued",
								Code = "39"
							},
							new RegionModel
							{
								Name = "El Tarf",
								Code = "36"
							},
							new RegionModel
							{
								Name = "Ghardaïa",
								Code = "47"
							},
							new RegionModel
							{
								Name = "Guelma",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Illizi",
								Code = "33"
							},
							new RegionModel
							{
								Name = "Jijel",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Khenchela",
								Code = "40"
							},
							new RegionModel
							{
								Name = "Laghouat",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Mascara",
								Code = "29"
							},
							new RegionModel
							{
								Name = "Médéa",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Mila",
								Code = "43"
							},
							new RegionModel
							{
								Name = "Mostaganem",
								Code = "27"
							},
							new RegionModel
							{
								Name = "Msila",
								Code = "28"
							},
							new RegionModel
							{
								Name = "Naâma",
								Code = "45"
							},
							new RegionModel
							{
								Name = "Oran",
								Code = "31"
							},
							new RegionModel
							{
								Name = "Ouargla",
								Code = "30"
							},
							new RegionModel
							{
								Name = "Oum el Bouaghi",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Relizane",
								Code = "48"
							},
							new RegionModel
							{
								Name = "Saïda",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Sétif",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Sidi Bel Abbès",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Skikda",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Souk Ahras",
								Code = "41"
							},
							new RegionModel
							{
								Name = "Tamanghasset",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Tébessa",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Tiaret",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Tindouf",
								Code = "37"
							},
							new RegionModel
							{
								Name = "Tipaza",
								Code = "42"
							},
							new RegionModel
							{
								Name = "Tissemsilt",
								Code = "38"
							},
							new RegionModel
							{
								Name = "Tizi Ouzou",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Tlemcen",
								Code = "13"
							}
						}
					},
					new CountryModel
					{
						Name = "American Samoa",
						Code = "AS",
						NativeName = "Amerika Sāmoa",
						PhoneCode = "+1 684",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Tutuila",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Aunu'u",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Ta'ū",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Ofu‑Olosega",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Rose Atoll",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Swains Island",
								Code = "22"
							}
						}
					},
					new CountryModel
					{
						Name = "Andorra",
						Code = "AD",
						NativeName = "Principat d'Andorra",
						PhoneCode = "+376",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Andorra la Vella",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Canillo",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Encamp",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Escaldes-Engordany",
								Code = "08"
							},
							new RegionModel
							{
								Name = "La Massana",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Ordino",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Sant Julià de Lòria",
								Code = "06"
							}
						}
					},
					new CountryModel
					{
						Name = "Angola",
						Code = "AO",
						NativeName = "",
						PhoneCode = "+244",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bengo",
								Code = "BGO"
							},
							new RegionModel
							{
								Name = "Benguela",
								Code = "BGU"
							},
							new RegionModel
							{
								Name = "Bié",
								Code = "BIE"
							},
							new RegionModel
							{
								Name = "Cabinda",
								Code = "CAB"
							},
							new RegionModel
							{
								Name = "Cuando Cubango",
								Code = "CCU"
							},
							new RegionModel
							{
								Name = "Cuanza Norte",
								Code = "CNO"
							},
							new RegionModel
							{
								Name = "Cuanza Sul",
								Code = "CUS"
							},
							new RegionModel
							{
								Name = "Cunene",
								Code = "CNN"
							},
							new RegionModel
							{
								Name = "Huambo",
								Code = "HUA"
							},
							new RegionModel
							{
								Name = "Huíla",
								Code = "HUI"
							},
							new RegionModel
							{
								Name = "Luanda",
								Code = "LUA"
							},
							new RegionModel
							{
								Name = "Lunda Norte",
								Code = "LNO"
							},
							new RegionModel
							{
								Name = "Lunda Sul",
								Code = "LSU"
							},
							new RegionModel
							{
								Name = "Malanje",
								Code = "MAL"
							},
							new RegionModel
							{
								Name = "Moxico",
								Code = "MOX"
							},
							new RegionModel
							{
								Name = "Namibe",
								Code = "NAM"
							},
							new RegionModel
							{
								Name = "Uíge",
								Code = "UIG"
							},
							new RegionModel
							{
								Name = "Zaire",
								Code = "ZAI"
							}
						}
					},
					new CountryModel
					{
						Name = "Anguilla",
						Code = "AI",
						NativeName = "",
						PhoneCode = "+1 264",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Anguilla",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Anguillita Island",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Blowing Rock",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Cove Cay",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Crocus Cay",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Deadman's Cay",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Dog Island",
								Code = "07"
							},
							new RegionModel
							{
								Name = "East Cay",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Little Island",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Little Scrub Island",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Mid Cay",
								Code = "11"
							},
							new RegionModel
							{
								Name = "North Cay",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Prickly Pear Cays",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Rabbit Island",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Sandy Island/Sand Island",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Scilly Cay",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Scrub Island",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Seal Island",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Sombrero/Hat Island",
								Code = "19"
							},
							new RegionModel
							{
								Name = "South Cay",
								Code = "20"
							},
							new RegionModel
							{
								Name = "South Wager Island",
								Code = "21"
							},
							new RegionModel
							{
								Name = "West Cay",
								Code = "22"
							}
						}
					},
					new CountryModel
					{
						Name = "Antigua and Barbuda",
						Code = "AG",
						NativeName = "",
						PhoneCode = "+1 268",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Antigua Island",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Barbuda Island",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Bird Island",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Bishop Island",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Blake Island",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Crump Island",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Dulcina Island",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Exchange Island",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Five Islands",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Great Bird Island",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Green Island",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Guiana Island",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Hawes Island",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Hells Gate Island",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Henry Island",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Johnson Island",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Kid Island",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Lobster Island",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Maiden Island",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Moor Island",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Nanny Island",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Pelican Island",
								Code = "27"
							},
							new RegionModel
							{
								Name = "Prickly Pear Island",
								Code = "28"
							},
							new RegionModel
							{
								Name = "Rabbit Island",
								Code = "29"
							},
							new RegionModel
							{
								Name = "Red Head Island",
								Code = "31"
							},
							new RegionModel
							{
								Name = "Redonda Island",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Sandy Island",
								Code = "32"
							},
							new RegionModel
							{
								Name = "Smith Island",
								Code = "33"
							},
							new RegionModel
							{
								Name = "The Sisters",
								Code = "34"
							},
							new RegionModel
							{
								Name = "Vernon Island",
								Code = "35"
							},
							new RegionModel
							{
								Name = "Wicked Will Island",
								Code = "36"
							},
							new RegionModel
							{
								Name = "York Island",
								Code = "37"
							}
						}
					},
					new CountryModel
					{
						Name = "Argentina",
						Code = "AR",
						NativeName = "",
						PhoneCode = "+54",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Buenos Aires",
								Code = "B"
							},
							new RegionModel
							{
								Name = "Capital Federal",
								Code = "C"
							},
							new RegionModel
							{
								Name = "Catamarca",
								Code = "K"
							},
							new RegionModel
							{
								Name = "Chaco",
								Code = "H"
							},
							new RegionModel
							{
								Name = "Chubut",
								Code = "U"
							},
							new RegionModel
							{
								Name = "Córdoba",
								Code = "X"
							},
							new RegionModel
							{
								Name = "Corrientes",
								Code = "W"
							},
							new RegionModel
							{
								Name = "Entre Ríos",
								Code = "E"
							},
							new RegionModel
							{
								Name = "Formosa",
								Code = "P"
							},
							new RegionModel
							{
								Name = "Jujuy",
								Code = "Y"
							},
							new RegionModel
							{
								Name = "La Pampa",
								Code = "L"
							},
							new RegionModel
							{
								Name = "La Rioja",
								Code = "F"
							},
							new RegionModel
							{
								Name = "Mendoza",
								Code = "M"
							},
							new RegionModel
							{
								Name = "Misiones",
								Code = "N"
							},
							new RegionModel
							{
								Name = "Neuquén",
								Code = "Q"
							},
							new RegionModel
							{
								Name = "Río Negro",
								Code = "R"
							},
							new RegionModel
							{
								Name = "Salta",
								Code = "A"
							},
							new RegionModel
							{
								Name = "San Juan",
								Code = "J"
							},
							new RegionModel
							{
								Name = "San Luis",
								Code = "D"
							},
							new RegionModel
							{
								Name = "Santa Cruz",
								Code = "Z"
							},
							new RegionModel
							{
								Name = "Santa Fe",
								Code = "S"
							},
							new RegionModel
							{
								Name = "Santiago del Estero",
								Code = "G"
							},
							new RegionModel
							{
								Name = "Tierra del Fuego",
								Code = "V"
							},
							new RegionModel
							{
								Name = "Tucumán",
								Code = "T"
							}
						}
					},
					new CountryModel
					{
						Name = "Armenia",
						Code = "AM",
						NativeName = "Հայաստան",
						PhoneCode = "+374",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aragatsotn",
								Code = "AG"
							},
							new RegionModel
							{
								Name = "Ararat",
								Code = "AR"
							},
							new RegionModel
							{
								Name = "Armavir",
								Code = "AV"
							},
							new RegionModel
							{
								Name = "Gegharkunik",
								Code = "GR"
							},
							new RegionModel
							{
								Name = "Kotayk",
								Code = "KT"
							},
							new RegionModel
							{
								Name = "Lori",
								Code = "LO"
							},
							new RegionModel
							{
								Name = "Shirak",
								Code = "SH"
							},
							new RegionModel
							{
								Name = "Syunik",
								Code = "SU"
							},
							new RegionModel
							{
								Name = "Tavush",
								Code = "TV"
							},
							new RegionModel
							{
								Name = "Vayots Dzor",
								Code = "VD"
							},
							new RegionModel
							{
								Name = "Yerevan",
								Code = "ER"
							}
						}
					},
					new CountryModel
					{
						Name = "Aruba",
						Code = "AW",
						NativeName = "",
						PhoneCode = "+297",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aruba",
								Code = "AW"
							}
						}
					},
					new CountryModel
					{
						Name = "Australia",
						Code = "AU",
						NativeName = "",
						PhoneCode = "+61",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Australian Capital Territory",
								Code = "ACT"
							},
							new RegionModel
							{
								Name = "New South Wales",
								Code = "NSW"
							},
							new RegionModel
							{
								Name = "Northern Territory",
								Code = "NT"
							},
							new RegionModel
							{
								Name = "Queensland",
								Code = "QLD"
							},
							new RegionModel
							{
								Name = "South Australia",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "Tasmania",
								Code = "TAS"
							},
							new RegionModel
							{
								Name = "Victoria",
								Code = "VIC"
							},
							new RegionModel
							{
								Name = "Western Australia",
								Code = "WA"
							}
						}
					},
					new CountryModel
					{
						Name = "Austria",
						Code = "AT",
						NativeName = "Österreich",
						PhoneCode = "+43",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Burgenland",
								Code = "1"
							},
							new RegionModel
							{
								Name = "Kärnten",
								Code = "2"
							},
							new RegionModel
							{
								Name = "Niederösterreich",
								Code = "3"
							},
							new RegionModel
							{
								Name = "Oberösterreich",
								Code = "4"
							},
							new RegionModel
							{
								Name = "Salzburg",
								Code = "5"
							},
							new RegionModel
							{
								Name = "Steiermark",
								Code = "6"
							},
							new RegionModel
							{
								Name = "Tirol",
								Code = "7"
							},
							new RegionModel
							{
								Name = "Vorarlberg",
								Code = "8"
							},
							new RegionModel
							{
								Name = "Wien",
								Code = "9"
							}
						}
					},
					new CountryModel
					{
						Name = "Azerbaijan",
						Code = "AZ",
						NativeName = "Azərbaycan",
						PhoneCode = "+994",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Abşeron",
								Code = "ABS"
							},
							new RegionModel
							{
								Name = "Ağcabədi",
								Code = "AGC"
							},
							new RegionModel
							{
								Name = "Ağdam",
								Code = "AGM"
							},
							new RegionModel
							{
								Name = "Ağdaş",
								Code = "AGS"
							},
							new RegionModel
							{
								Name = "Ağstafa",
								Code = "AGA"
							},
							new RegionModel
							{
								Name = "Ağsu",
								Code = "AGU"
							},
							new RegionModel
							{
								Name = "Astara",
								Code = "AST"
							},
							new RegionModel
							{
								Name = "Bakı",
								Code = "BAK"
							},
							new RegionModel
							{
								Name = "Babək",
								Code = "BAB"
							},
							new RegionModel
							{
								Name = "Balakən",
								Code = "BAL"
							},
							new RegionModel
							{
								Name = "Bərdə",
								Code = "BAR"
							},
							new RegionModel
							{
								Name = "Beyləqan",
								Code = "BEY"
							},
							new RegionModel
							{
								Name = "Biləsuvar",
								Code = "BIL"
							},
							new RegionModel
							{
								Name = "Cəbrayıl",
								Code = "CAB"
							},
							new RegionModel
							{
								Name = "Cəlilabad",
								Code = "CAL"
							},
							new RegionModel
							{
								Name = "Culfa",
								Code = "CUL"
							},
							new RegionModel
							{
								Name = "Daşkəsən",
								Code = "DAS"
							},
							new RegionModel
							{
								Name = "Füzuli",
								Code = "FUZ"
							},
							new RegionModel
							{
								Name = "Gədəbəy",
								Code = "GAD"
							},
							new RegionModel
							{
								Name = "Goranboy",
								Code = "GOR"
							},
							new RegionModel
							{
								Name = "Göyçay",
								Code = "GOY"
							},
							new RegionModel
							{
								Name = "Göygöl",
								Code = "GYG"
							},
							new RegionModel
							{
								Name = "Hacıqabul",
								Code = "HAC"
							},
							new RegionModel
							{
								Name = "İmişli",
								Code = "IMI"
							},
							new RegionModel
							{
								Name = "İsmayıllı",
								Code = "ISM"
							},
							new RegionModel
							{
								Name = "Kəlbəcər",
								Code = "KAL"
							},
							new RegionModel
							{
								Name = "Kǝngǝrli",
								Code = "KAN"
							},
							new RegionModel
							{
								Name = "Kürdəmir",
								Code = "KUR"
							},
							new RegionModel
							{
								Name = "Laçın",
								Code = "LAC"
							},
							new RegionModel
							{
								Name = "Lənkəran",
								Code = "LAN"
							},
							new RegionModel
							{
								Name = "Lerik",
								Code = "LER"
							},
							new RegionModel
							{
								Name = "Masallı",
								Code = "MAS"
							},
							new RegionModel
							{
								Name = "Neftçala",
								Code = "NEF"
							},
							new RegionModel
							{
								Name = "Oğuz",
								Code = "OGU"
							},
							new RegionModel
							{
								Name = "Ordubad",
								Code = "ORD"
							},
							new RegionModel
							{
								Name = "Qəbələ",
								Code = "QAB"
							},
							new RegionModel
							{
								Name = "Qax",
								Code = "QAX"
							},
							new RegionModel
							{
								Name = "Qazax",
								Code = "QAZ"
							},
							new RegionModel
							{
								Name = "Qobustan",
								Code = "QOB"
							},
							new RegionModel
							{
								Name = "Quba",
								Code = "QBA"
							},
							new RegionModel
							{
								Name = "Qubadli",
								Code = "QBI"
							},
							new RegionModel
							{
								Name = "Qusar",
								Code = "QUS"
							},
							new RegionModel
							{
								Name = "Saatlı",
								Code = "SAT"
							},
							new RegionModel
							{
								Name = "Sabirabad",
								Code = "SAB"
							},
							new RegionModel
							{
								Name = "Şabran",
								Code = "SBN"
							},
							new RegionModel
							{
								Name = "Sədərək",
								Code = "SAD"
							},
							new RegionModel
							{
								Name = "Şahbuz",
								Code = "SAH"
							},
							new RegionModel
							{
								Name = "Şəki",
								Code = "SAK"
							},
							new RegionModel
							{
								Name = "Salyan",
								Code = "SAL"
							},
							new RegionModel
							{
								Name = "Şamaxı",
								Code = "SMI"
							},
							new RegionModel
							{
								Name = "Şəmkir",
								Code = "SKR"
							},
							new RegionModel
							{
								Name = "Samux",
								Code = "SMX"
							},
							new RegionModel
							{
								Name = "Şərur",
								Code = "SAR"
							},
							new RegionModel
							{
								Name = "Siyəzən",
								Code = "SIY"
							},
							new RegionModel
							{
								Name = "Şuşa",
								Code = "SUS"
							},
							new RegionModel
							{
								Name = "Tərtər",
								Code = "TAR"
							},
							new RegionModel
							{
								Name = "Tovuz",
								Code = "TOV"
							},
							new RegionModel
							{
								Name = "Ucar",
								Code = "UCA"
							},
							new RegionModel
							{
								Name = "Xaçmaz",
								Code = "XAC"
							},
							new RegionModel
							{
								Name = "Xızı",
								Code = "XIZ"
							},
							new RegionModel
							{
								Name = "Xocalı",
								Code = "XCI"
							},
							new RegionModel
							{
								Name = "Xocavənd",
								Code = "XVD"
							},
							new RegionModel
							{
								Name = "Yardımlı",
								Code = "YAR"
							},
							new RegionModel
							{
								Name = "Yevlax",
								Code = "YEV"
							},
							new RegionModel
							{
								Name = "Zəngilan",
								Code = "ZAN"
							},
							new RegionModel
							{
								Name = "Zaqatala",
								Code = "ZAQ"
							},
							new RegionModel
							{
								Name = "Zərdab",
								Code = "ZAR"
							}
						}
					},
						#endregion
					};
					break;
				case 'B':
					countries = new ObservableCollection<CountryModel> { 
					#region B
					new CountryModel
					{
						Name = "Bahamas",
						Code = "BS",
						NativeName = "",
						PhoneCode = "+1 242",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Acklins Island",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Berry Islands",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Bimini",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Black Point",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Cat Island",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Central Abaco",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Crooked Island and Long Cay",
								Code = "28"
							},
							new RegionModel
							{
								Name = "East Grand Bahama",
								Code = "29"
							},
							new RegionModel
							{
								Name = "Exuma",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Freeport",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Fresh Creek",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Governor's Harbour",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Green Turtle Cay",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Harbour Island",
								Code = "09"
							},
							new RegionModel
							{
								Name = "High Rock",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Inagua",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Kemps Bay",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Long Island",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Marsh Harbour",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Mayaguana",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Moore’s Island",
								Code = "40"
							},
							new RegionModel
							{
								Name = "New Providence",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Nichollstown and Berry Islands",
								Code = "17"
							},
							new RegionModel
							{
								Name = "North Abaco",
								Code = "42"
							},
							new RegionModel
							{
								Name = "North Andros",
								Code = "41"
							},
							new RegionModel
							{
								Name = "North Eleuthera",
								Code = "33"
							},
							new RegionModel
							{
								Name = "Ragged Island",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Rock Sound",
								Code = "19"
							},
							new RegionModel
							{
								Name = "San Salvador and Rum Cay",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Sandy Point",
								Code = "21"
							},
							new RegionModel
							{
								Name = "South Abaco",
								Code = "35"
							},
							new RegionModel
							{
								Name = "South Andros",
								Code = "36"
							},
							new RegionModel
							{
								Name = "South Eleuthera",
								Code = "37"
							},
							new RegionModel
							{
								Name = "West Grand Bahama",
								Code = "39"
							}
						}
					},
					new CountryModel
					{
						Name = "Bahrain",
						Code = "BH",
						NativeName = "البحرين‎",
						PhoneCode = "+973",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Al Janūbīyah",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Al Manāmah",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Al Muḩarraq",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Al Wusţá",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Ash Shamālīyah",
								Code = "17"
							}
						}
					},
					new CountryModel
					{
						Name = "Bangladesh",
						Code = "BD",
						NativeName = "বাংলাদেশ",
						PhoneCode = "+880",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Barisal",
								Code = "A"
							},
							new RegionModel
							{
								Name = "Chittagong",
								Code = "B"
							},
							new RegionModel
							{
								Name = "Dhaka",
								Code = "C"
							},
							new RegionModel
							{
								Name = "Khulna",
								Code = "D"
							},
							new RegionModel
							{
								Name = "Mymensingh",
								Code = "M"
							},
							new RegionModel
							{
								Name = "Rajshahi",
								Code = "E"
							},
							new RegionModel
							{
								Name = "Rangpur",
								Code = "F"
							},
							new RegionModel
							{
								Name = "Sylhet",
								Code = "G"
							}
						}
					},
					new CountryModel
					{
						Name = "Barbados",
						Code = "BB",
						NativeName = "",
						PhoneCode = "+1 246",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Christ Church",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Saint Andrew",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Saint George",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Saint James",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Saint John",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Saint Joseph",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Saint Lucy",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Saint Michael",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Saint Peter",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Saint Philip",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Saint Thomas",
								Code = "11"
							}
						}
					},
					new CountryModel
					{
						Name = "Belarus",
						Code = "BY",
						NativeName = "Беларусь",
						PhoneCode = "+375",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Brest voblast",
								Code = "BR"
							},
							new RegionModel
							{
								Name = "Gorod Minsk",
								Code = "HM"
							},
							new RegionModel
							{
								Name = "Homiel voblast",
								Code = "HO"
							},
							new RegionModel
							{
								Name = "Hrodna voblast",
								Code = "HR"
							},
							new RegionModel
							{
								Name = "Mahilyow voblast",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Minsk voblast",
								Code = "MI"
							},
							new RegionModel
							{
								Name = "Vitsebsk voblast",
								Code = "VI"
							}
						}
					},
					new CountryModel
					{
						Name = "Belgium",
						Code = "BE",
						NativeName = "België , Belgique , Belgien",
						PhoneCode = "+32",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Brussels",
								Code = "BRU"
							},
							new RegionModel
							{
								Name = "Flanders",
								Code = "VLG"
							},
							new RegionModel
							{
								Name = "Wallonia",
								Code = "WAL"
							}
						}
					},
					new CountryModel
					{
						Name = "Belize",
						Code = "BZ",
						NativeName = "Belice",
						PhoneCode = "+501",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Belize District",
								Code = "BZ"
							},
							new RegionModel
							{
								Name = "Cayo District",
								Code = "CY"
							},
							new RegionModel
							{
								Name = "Corozal District",
								Code = "CZL"
							},
							new RegionModel
							{
								Name = "Orange Walk District",
								Code = "OW"
							},
							new RegionModel
							{
								Name = "Stann Creek District",
								Code = "SC"
							},
							new RegionModel
							{
								Name = "Toledo District",
								Code = "TOL"
							}
						}
					},
					new CountryModel
					{
						Name = "Benin",
						Code = "BJ",
						NativeName = "Bénin",
						PhoneCode = "+229",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Alibori",
								Code = "AL"
							},
							new RegionModel
							{
								Name = "Atakora",
								Code = "AK"
							},
							new RegionModel
							{
								Name = "Atlantique",
								Code = "AQ"
							},
							new RegionModel
							{
								Name = "Borgou",
								Code = "BO"
							},
							new RegionModel
							{
								Name = "Collines Department",
								Code = "CO"
							},
							new RegionModel
							{
								Name = "Donga",
								Code = "DO"
							},
							new RegionModel
							{
								Name = "Kouffo",
								Code = "KO"
							},
							new RegionModel
							{
								Name = "Littoral Department",
								Code = "LI"
							},
							new RegionModel
							{
								Name = "Mono Department",
								Code = "MO"
							},
							new RegionModel
							{
								Name = "Ouémé",
								Code = "OU"
							},
							new RegionModel
							{
								Name = "Plateau",
								Code = "PL"
							},
							new RegionModel
							{
								Name = "Zou",
								Code = "ZO"
							}
						}
					},
					new CountryModel
					{
						Name = "Bermuda",
						Code = "BM",
						NativeName = "",
						PhoneCode = "+1 441",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "City of Hamilton",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Devonshire Parish",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Hamilton Parish",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Paget Parish",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Pembroke Parish",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Sandys Parish",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Smith's Parish",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Southampton Parish",
								Code = "10"
							},
							new RegionModel
							{
								Name = "St. George's Parish",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Town of St. George",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Warwick Parish",
								Code = "11"
							}
						}
					},
					new CountryModel
					{
						Name = "Bhutan",
						Code = "BT",
						NativeName = "འབྲུག་ རྒྱལ་ཁབ་",
						PhoneCode = "+975",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bumthang",
								Code = "33"
							},
							new RegionModel
							{
								Name = "Chhukha",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Dagana",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Gasa",
								Code = "GA"
							},
							new RegionModel
							{
								Name = "Haa",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Lhuntse",
								Code = "44"
							},
							new RegionModel
							{
								Name = "Mongar",
								Code = "42"
							},
							new RegionModel
							{
								Name = "Paro",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Pemagatshel",
								Code = "43"
							},
							new RegionModel
							{
								Name = "Punakha",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Samdrup Jongkhar",
								Code = "45"
							},
							new RegionModel
							{
								Name = "Samtse",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Sarpang",
								Code = "31"
							},
							new RegionModel
							{
								Name = "Thimphu",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Trashigang",
								Code = "41"
							},
							new RegionModel
							{
								Name = "Trashiyangtse",
								Code = "TY"
							},
							new RegionModel
							{
								Name = "Trongsa",
								Code = "32"
							},
							new RegionModel
							{
								Name = "Tsirang",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Wangdue Phodrang",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Zhemgang",
								Code = "34"
							}
						}
					},
					new CountryModel
					{
						Name = "Bolivia",
						Code = "BO",
						NativeName = "Wuliwya , Buliwya , Volívia",
						PhoneCode = "+591",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Beni",
								Code = "BE"
							},
							new RegionModel
							{
								Name = "Chuquisaca",
								Code = "CH"
							},
							new RegionModel
							{
								Name = "Cochabamba",
								Code = "CB"
							},
							new RegionModel
							{
								Name = "La Paz",
								Code = "LP"
							},
							new RegionModel
							{
								Name = "Oruro",
								Code = "OR"
							},
							new RegionModel
							{
								Name = "Pando",
								Code = "PD"
							},
							new RegionModel
							{
								Name = "Potosí",
								Code = "PT"
							},
							new RegionModel
							{
								Name = "Santa Cruz",
								Code = "SC"
							},
							new RegionModel
							{
								Name = "Tarija",
								Code = "TJ"
							}
						}
					},
					new CountryModel
					{
						Name = "Caribbean Netherlands",
						Code = "BQ",
						NativeName = "Caribisch Nederland",
						PhoneCode = "+599",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bonaire",
								Code = "BO"
							},
							new RegionModel
							{
								Name = "Saba Isand",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "Sint Eustatius",
								Code = "SE"
							}
						}
					},
					new CountryModel
					{
						Name = "Bosnia and Herzegovina",
						Code = "BA",
						NativeName = "Босна и Херцеговина",
						PhoneCode = "+387",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Brčko Distrikt",
								Code = "BRC"
							},
							new RegionModel
							{
								Name = "Federacija Bosne i Hercegovine",
								Code = "BIH"
							},
							new RegionModel
							{
								Name = "Republika Srpska",
								Code = "SRP"
							}
						}
					},
					new CountryModel
					{
						Name = "Botswana",
						Code = "BW",
						NativeName = "",
						PhoneCode = "+267",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Central",
								Code = "CE"
							},
							new RegionModel
							{
								Name = "Ghanzi",
								Code = "GH"
							},
							new RegionModel
							{
								Name = "Kgalagadi",
								Code = "KG"
							},
							new RegionModel
							{
								Name = "Kgatleng",
								Code = "KL"
							},
							new RegionModel
							{
								Name = "Kweneng",
								Code = "KW"
							},
							new RegionModel
							{
								Name = "North West",
								Code = "NW"
							},
							new RegionModel
							{
								Name = "North-East",
								Code = "NE"
							},
							new RegionModel
							{
								Name = "South East",
								Code = "SE"
							},
							new RegionModel
							{
								Name = "Southern",
								Code = "SO"
							}
						}
					},
					new CountryModel
					{
						Name = "Bouvet Island",
						Code = "BV",
						NativeName = "Bouvetøya",
						PhoneCode = "+55",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bouvet Island",
								Code = "BV"
							}
						}
					},
					new CountryModel
					{
						Name = "Brazil",
						Code = "BR",
						NativeName = "Brasil",
						PhoneCode = "+55",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Acre",
								Code = "AC"
							},
							new RegionModel
							{
								Name = "Alagoas",
								Code = "AL"
							},
							new RegionModel
							{
								Name = "Amapá",
								Code = "AP"
							},
							new RegionModel
							{
								Name = "Amazonas",
								Code = "AM"
							},
							new RegionModel
							{
								Name = "Bahia",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Ceará",
								Code = "CE"
							},
							new RegionModel
							{
								Name = "Distrito Federal",
								Code = "DF"
							},
							new RegionModel
							{
								Name = "Espírito Santo",
								Code = "ES"
							},
							new RegionModel
							{
								Name = "Goiás",
								Code = "GO"
							},
							new RegionModel
							{
								Name = "Maranhão",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Mato Grosso",
								Code = "MT"
							},
							new RegionModel
							{
								Name = "Mato Grosso do Sul",
								Code = "MS"
							},
							new RegionModel
							{
								Name = "Minas Gerais",
								Code = "MG"
							},
							new RegionModel
							{
								Name = "Pará",
								Code = "PA"
							},
							new RegionModel
							{
								Name = "Paraíba",
								Code = "PB"
							},
							new RegionModel
							{
								Name = "Paraná",
								Code = "PR"
							},
							new RegionModel
							{
								Name = "Pernambuco",
								Code = "PE"
							},
							new RegionModel
							{
								Name = "Piauí",
								Code = "PI"
							},
							new RegionModel
							{
								Name = "Rio de Janeiro",
								Code = "RJ"
							},
							new RegionModel
							{
								Name = "Rio Grande do Norte",
								Code = "RN"
							},
							new RegionModel
							{
								Name = "Rio Grande do Sul",
								Code = "RS"
							},
							new RegionModel
							{
								Name = "Rondônia",
								Code = "RO"
							},
							new RegionModel
							{
								Name = "Roraima",
								Code = "RR"
							},
							new RegionModel
							{
								Name = "Santa Catarina",
								Code = "SC"
							},
							new RegionModel
							{
								Name = "São Paulo",
								Code = "SP"
							},
							new RegionModel
							{
								Name = "Sergipe",
								Code = "SE"
							},
							new RegionModel
							{
								Name = "Tocantins",
								Code = "TO"
							}
						}
					},
					new CountryModel
					{
						Name = "British Indian Ocean Territory",
						Code = "IO",
						NativeName = "",
						PhoneCode = "+246",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "British Indian Ocean Territory",
								Code = "IO"
							}
						}
					},
					new CountryModel
					{
						Name = "Brunei",
						Code = "BN",
						NativeName = "بروني دارالسلام",
						PhoneCode = "+673",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Belait",
								Code = "BE"
							},
							new RegionModel
							{
								Name = "Brunei Muara",
								Code = "BM"
							},
							new RegionModel
							{
								Name = "Temburong",
								Code = "TE"
							},
							new RegionModel
							{
								Name = "Tutong",
								Code = "TU"
							}
						}
					},
					new CountryModel
					{
						Name = "Bulgaria",
						Code = "BG",
						NativeName = "България",
						PhoneCode = "+359",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Blagoevgrad",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Burgas",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Dobrich",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Gabrovo",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Jambol",
								Code = "28"
							},
							new RegionModel
							{
								Name = "Khaskovo",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Kjustendil",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Kurdzhali",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Lovech",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Montana",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Pazardzhik",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Pernik",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Pleven",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Plovdiv",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Razgrad",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Ruse",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Shumen",
								Code = "27"
							},
							new RegionModel
							{
								Name = "Silistra",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Sliven",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Smoljan",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Sofija",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Sofija-Grad",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Stara Zagora",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Turgovishhe",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Varna",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Veliko Turnovo",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Vidin",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Vraca",
								Code = "06"
							}
						}
					},
					new CountryModel
					{
						Name = "Burkina Faso",
						Code = "BF",
						NativeName = "",
						PhoneCode = "+226",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Balé",
								Code = "BAL"
							},
							new RegionModel
							{
								Name = "Bam/Lake Bam",
								Code = "BAM"
							},
							new RegionModel
							{
								Name = "Banwa Province",
								Code = "BAN"
							},
							new RegionModel
							{
								Name = "Bazèga",
								Code = "BAZ"
							},
							new RegionModel
							{
								Name = "Bougouriba",
								Code = "BGR"
							},
							new RegionModel
							{
								Name = "Boulgou Province",
								Code = "BLG"
							},
							new RegionModel
							{
								Name = "Boulkiemdé",
								Code = "BLK"
							},
							new RegionModel
							{
								Name = "Comoé/Komoe",
								Code = "COM"
							},
							new RegionModel
							{
								Name = "Ganzourgou Province",
								Code = "GAN"
							},
							new RegionModel
							{
								Name = "Gnagna",
								Code = "GNA"
							},
							new RegionModel
							{
								Name = "Gourma Province",
								Code = "GOU"
							},
							new RegionModel
							{
								Name = "Houet",
								Code = "HOU"
							},
							new RegionModel
							{
								Name = "Ioba",
								Code = "IOB"
							},
							new RegionModel
							{
								Name = "Kadiogo",
								Code = "KAD"
							},
							new RegionModel
							{
								Name = "Kénédougou",
								Code = "KEN"
							},
							new RegionModel
							{
								Name = "Komondjari",
								Code = "KMD"
							},
							new RegionModel
							{
								Name = "Kompienga",
								Code = "KMP"
							},
							new RegionModel
							{
								Name = "Kossi Province",
								Code = "KOS"
							},
							new RegionModel
							{
								Name = "Koulpélogo",
								Code = "KOP"
							},
							new RegionModel
							{
								Name = "Kouritenga",
								Code = "KOT"
							},
							new RegionModel
							{
								Name = "Kourwéogo",
								Code = "KOW"
							},
							new RegionModel
							{
								Name = "Léraba",
								Code = "LER"
							},
							new RegionModel
							{
								Name = "Loroum",
								Code = "LOR"
							},
							new RegionModel
							{
								Name = "Mouhoun",
								Code = "MOU"
							},
							new RegionModel
							{
								Name = "Namentenga",
								Code = "NAM"
							},
							new RegionModel
							{
								Name = "Naouri/Nahouri",
								Code = "NAO"
							},
							new RegionModel
							{
								Name = "Nayala",
								Code = "NAY"
							},
							new RegionModel
							{
								Name = "Noumbiel",
								Code = "NOU"
							},
							new RegionModel
							{
								Name = "Oubritenga",
								Code = "OUB"
							},
							new RegionModel
							{
								Name = "Oudalan",
								Code = "OUD"
							},
							new RegionModel
							{
								Name = "Passoré",
								Code = "PAS"
							},
							new RegionModel
							{
								Name = "Poni",
								Code = "PON"
							},
							new RegionModel
							{
								Name = "Sanguié",
								Code = "SNG"
							},
							new RegionModel
							{
								Name = "Sanmatenga",
								Code = "SMT"
							},
							new RegionModel
							{
								Name = "Séno",
								Code = "SEN"
							},
							new RegionModel
							{
								Name = "Sissili",
								Code = "SIS"
							},
							new RegionModel
							{
								Name = "Soum",
								Code = "SOM"
							},
							new RegionModel
							{
								Name = "Sourou",
								Code = "SOR"
							},
							new RegionModel
							{
								Name = "Tapoa",
								Code = "TAP"
							},
							new RegionModel
							{
								Name = "Tui/Tuy",
								Code = "TUI"
							},
							new RegionModel
							{
								Name = "Yagha",
								Code = "YAG"
							},
							new RegionModel
							{
								Name = "Yatenga",
								Code = "YAT"
							},
							new RegionModel
							{
								Name = "Ziro",
								Code = "ZIR"
							},
							new RegionModel
							{
								Name = "Zondoma",
								Code = "ZON"
							},
							new RegionModel
							{
								Name = "Zoundwéogo",
								Code = "ZOU"
							}
						}
					},
					new CountryModel
					{
						Name = "Burundi",
						Code = "BI",
						NativeName = "",
						PhoneCode = "+257",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bubanza",
								Code = "BB"
							},
							new RegionModel
							{
								Name = "Bujumbura Mairie",
								Code = "BM"
							},
							new RegionModel
							{
								Name = "Bujumbura Rural",
								Code = "BL"
							},
							new RegionModel
							{
								Name = "Bururi",
								Code = "BR"
							},
							new RegionModel
							{
								Name = "Cankuzo",
								Code = "CA"
							},
							new RegionModel
							{
								Name = "Cibitoke",
								Code = "CI"
							},
							new RegionModel
							{
								Name = "Gitega",
								Code = "GI"
							},
							new RegionModel
							{
								Name = "Karuzi",
								Code = "KR"
							},
							new RegionModel
							{
								Name = "Kayanza",
								Code = "KY"
							},
							new RegionModel
							{
								Name = "Kirundo",
								Code = "KI"
							},
							new RegionModel
							{
								Name = "Makamba",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Muramvya",
								Code = "MU"
							},
							new RegionModel
							{
								Name = "Muyinga",
								Code = "MY"
							},
							new RegionModel
							{
								Name = "Mwaro",
								Code = "MW"
							},
							new RegionModel
							{
								Name = "Ngozi",
								Code = "NG"
							},
							new RegionModel
							{
								Name = "Rutana",
								Code = "RT"
							},
							new RegionModel
							{
								Name = "Ruyigi",
								Code = "RY"
							}
						}
					},
					#endregion
					};
					break;
				case 'C':
					countries = new ObservableCollection<CountryModel> { 
					#region C
					new CountryModel
					{
						Name = "Cambodia",
						Code = "KH",
						NativeName = "ព្រះរាជាណាចក្រកម្ពុជា",
						PhoneCode = "+855",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Baat Dambang",
								Code = "2"
							},
							new RegionModel
							{
								Name = "Banteay Mean Chey",
								Code = "1"
							},
							new RegionModel
							{
								Name = "Kampong Chaam",
								Code = "3"
							},
							new RegionModel
							{
								Name = "Kampong Chhnang",
								Code = "4"
							},
							new RegionModel
							{
								Name = "Kampong Spueu",
								Code = "5"
							},
							new RegionModel
							{
								Name = "Kampong Thum",
								Code = "6"
							},
							new RegionModel
							{
								Name = "Kampot",
								Code = "7"
							},
							new RegionModel
							{
								Name = "Kandaal",
								Code = "8"
							},
							new RegionModel
							{
								Name = "Kaoh Kong",
								Code = "9"
							},
							new RegionModel
							{
								Name = "Kracheh",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Krong Kaeb",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Krong Pailin",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Krong Preah Sihanouk",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Mondol Kiri",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Otdar Mean Chey",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Phnom Penh",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Pousaat",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Preah Vihear",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Prey Veaeng",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Rotanah Kiri",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Siem Reab",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Stueng Treng",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Svaay Rieng",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Taakaev",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Tbong Khmum",
								Code = "25"
							}
						}
					},
					new CountryModel
					{
						Name = "Cameroon",
						Code = "CM",
						NativeName = "Cameroun",
						PhoneCode = "+237",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Adamaoua",
								Code = "AD"
							},
							new RegionModel
							{
								Name = "Centre",
								Code = "CE"
							},
							new RegionModel
							{
								Name = "Est",
								Code = "ES"
							},
							new RegionModel
							{
								Name = "Extrême-Nord",
								Code = "EN"
							},
							new RegionModel
							{
								Name = "Littoral",
								Code = "LT"
							},
							new RegionModel
							{
								Name = "Nord",
								Code = "NO"
							},
							new RegionModel
							{
								Name = "Nord-Ouest",
								Code = "NW"
							},
							new RegionModel
							{
								Name = "Ouest",
								Code = "OU"
							},
							new RegionModel
							{
								Name = "Sud",
								Code = "SU"
							},
							new RegionModel
							{
								Name = "Sud-Ouest",
								Code = "SW"
							}
						}
					},
					new CountryModel
					{
						Name = "Canada",
						Code = "CA",
						NativeName = "",
						PhoneCode = "+1",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Alberta",
								Code = "AB"
							},
							new RegionModel
							{
								Name = "British Columbia",
								Code = "BC"
							},
							new RegionModel
							{
								Name = "Manitoba",
								Code = "MB"
							},
							new RegionModel
							{
								Name = "New Brunswick",
								Code = "NB"
							},
							new RegionModel
							{
								Name = "Newfoundland and Labrador",
								Code = "NL"
							},
							new RegionModel
							{
								Name = "Northwest Territories",
								Code = "NT"
							},
							new RegionModel
							{
								Name = "Nova Scotia",
								Code = "NS"
							},
							new RegionModel
							{
								Name = "Nunavut",
								Code = "NU"
							},
							new RegionModel
							{
								Name = "Ontario",
								Code = "ON"
							},
							new RegionModel
							{
								Name = "Prince Edward Island",
								Code = "PE"
							},
							new RegionModel
							{
								Name = "Quebec",
								Code = "QC"
							},
							new RegionModel
							{
								Name = "Saskatchewan",
								Code = "SK"
							},
							new RegionModel
							{
								Name = "Yukon",
								Code = "YT"
							}
						}
					},
					new CountryModel
					{
						Name = "Cape Verde",
						Code = "CV",
						NativeName = "Cabo Verde , Kabu Verdi",
						PhoneCode = "+238",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Boa Vista",
								Code = "BV"
							},
							new RegionModel
							{
								Name = "Brava",
								Code = "BR"
							},
							new RegionModel
							{
								Name = "Calheta de São Miguel",
								Code = "CS"
							},
							new RegionModel
							{
								Name = "Maio",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Mosteiros",
								Code = "MO"
							},
							new RegionModel
							{
								Name = "Paúl",
								Code = "PA"
							},
							new RegionModel
							{
								Name = "Porto Novo",
								Code = "PN"
							},
							new RegionModel
							{
								Name = "Praia",
								Code = "PR"
							},
							new RegionModel
							{
								Name = "Ribeira Brava",
								Code = "RB"
							},
							new RegionModel
							{
								Name = "Ribeira Grande",
								Code = "RG"
							},
							new RegionModel
							{
								Name = "Sal",
								Code = "SL"
							},
							new RegionModel
							{
								Name = "Santa Catarina",
								Code = "CA"
							},
							new RegionModel
							{
								Name = "Santa Cruz",
								Code = "CR"
							},
							new RegionModel
							{
								Name = "São Domingos",
								Code = "SD"
							},
							new RegionModel
							{
								Name = "São Filipe",
								Code = "SF"
							},
							new RegionModel
							{
								Name = "São Nicolau",
								Code = "SN"
							},
							new RegionModel
							{
								Name = "São Vicente",
								Code = "SV"
							},
							new RegionModel
							{
								Name = "Tarrafal",
								Code = "TA"
							},
							new RegionModel
							{
								Name = "Tarrafal de São Nicolau",
								Code = "TS"
							}
						}
					},
					new CountryModel
					{
						Name = "Cayman Islands",
						Code = "KY",
						NativeName = "",
						PhoneCode = "+1",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Creek",
								Code = null
							},
							new RegionModel
							{
								Name = "Eastern",
								Code = null
							},
							new RegionModel
							{
								Name = "Midland",
								Code = null
							},
							new RegionModel
							{
								Name = "South Town",
								Code = null
							},
							new RegionModel
							{
								Name = "Spot Bay",
								Code = null
							},
							new RegionModel
							{
								Name = "Stake Bay",
								Code = null
							},
							new RegionModel
							{
								Name = "West End",
								Code = null
							},
							new RegionModel
							{
								Name = "Western",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Central African Republic",
						Code = "CF",
						NativeName = "Ködörösêse tî Bêafrîka , République centrafricaine",
						PhoneCode = "+236",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bamingui-Bangoran",
								Code = "BB"
							},
							new RegionModel
							{
								Name = "Bangui",
								Code = "BGF"
							},
							new RegionModel
							{
								Name = "Basse-Kotto",
								Code = "BK"
							},
							new RegionModel
							{
								Name = "Haute-Kotto",
								Code = "HK"
							},
							new RegionModel
							{
								Name = "Haut-Mbomou",
								Code = "HM"
							},
							new RegionModel
							{
								Name = "Kémo",
								Code = "KG"
							},
							new RegionModel
							{
								Name = "Lobaye",
								Code = "LB"
							},
							new RegionModel
							{
								Name = "Mambéré-Kadéï",
								Code = "HS"
							},
							new RegionModel
							{
								Name = "Mbomou",
								Code = "MB"
							},
							new RegionModel
							{
								Name = "Nana-Grebizi",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Nana-Mambéré",
								Code = "NM"
							},
							new RegionModel
							{
								Name = "Ombella-M'Poko",
								Code = "MP"
							},
							new RegionModel
							{
								Name = "Ouaka",
								Code = "UK"
							},
							new RegionModel
							{
								Name = "Ouham",
								Code = "AC"
							},
							new RegionModel
							{
								Name = "Ouham Péndé",
								Code = "OP"
							},
							new RegionModel
							{
								Name = "Sangha-Mbaéré",
								Code = "SE"
							},
							new RegionModel
							{
								Name = "Vakaga",
								Code = "VK"
							}
						}
					},
					new CountryModel
					{
						Name = "Chad",
						Code = "TD",
						NativeName = "Tchad , جمهورية تشاد ",
						PhoneCode = "+235",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bahr el Ghazal",
								Code = "BG"
							},
							new RegionModel
							{
								Name = "Batha",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Borkou",
								Code = "BO"
							},
							new RegionModel
							{
								Name = "Chari-Baguirmi",
								Code = "CB"
							},
							new RegionModel
							{
								Name = "Ennedi-Est",
								Code = "EE"
							},
							new RegionModel
							{
								Name = "Ennedi-Ouest",
								Code = "EO"
							},
							new RegionModel
							{
								Name = "Guéra",
								Code = "GR"
							},
							new RegionModel
							{
								Name = "Hadjer Lamis",
								Code = "HL"
							},
							new RegionModel
							{
								Name = "Kanem",
								Code = "KA"
							},
							new RegionModel
							{
								Name = "Lac",
								Code = "LC"
							},
							new RegionModel
							{
								Name = "Logone Occidental",
								Code = "LO"
							},
							new RegionModel
							{
								Name = "Logone Oriental",
								Code = "LR"
							},
							new RegionModel
							{
								Name = "Mondoul",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Mayo-Kébbi-Est",
								Code = "ME"
							},
							new RegionModel
							{
								Name = "Moyen-Chari",
								Code = "MC"
							},
							new RegionModel
							{
								Name = "Ouaddai",
								Code = "OD"
							},
							new RegionModel
							{
								Name = "Salamat",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "Sila",
								Code = "SI"
							},
							new RegionModel
							{
								Name = "Tandjilé",
								Code = "TA"
							},
							new RegionModel
							{
								Name = "Tibesti",
								Code = "TI"
							},
							new RegionModel
							{
								Name = "Ville de Ndjamena",
								Code = "ND"
							},
							new RegionModel
							{
								Name = "Wadi Fira",
								Code = "WF"
							}
						}
					},
					new CountryModel
					{
						Name = "Chile",
						Code = "CL",
						NativeName = "",
						PhoneCode = "+56",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aisén del General Carlos Ibáñez del Campo",
								Code = "AI"
							},
							new RegionModel
							{
								Name = "Antofagasta",
								Code = "AN"
							},
							new RegionModel
							{
								Name = "Araucanía",
								Code = "AR"
							},
							new RegionModel
							{
								Name = "Arica y Parinacota",
								Code = "AP"
							},
							new RegionModel
							{
								Name = "Atacama",
								Code = "AT"
							},
							new RegionModel
							{
								Name = "Bío-Bío",
								Code = "BI"
							},
							new RegionModel
							{
								Name = "Coquimbo",
								Code = "CO"
							},
							new RegionModel
							{
								Name = "Libertador General Bernardo O'Higgins",
								Code = "LI"
							},
							new RegionModel
							{
								Name = "Los Lagos",
								Code = "LL"
							},
							new RegionModel
							{
								Name = "Los Ríos",
								Code = "LR"
							},
							new RegionModel
							{
								Name = "Magallanes y Antartica Chilena",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Marga-Marga",
								Code = ""
							},
							new RegionModel
							{
								Name = "Maule",
								Code = "ML"
							},
							new RegionModel
							{
								Name = "Ñuble",
								Code = "NB"
							},
							new RegionModel
							{
								Name = "Región Metropolitana de Santiago",
								Code = "RM"
							},
							new RegionModel
							{
								Name = "Tarapacá",
								Code = "TA"
							},
							new RegionModel
							{
								Name = "Valparaíso",
								Code = "VS"
							}
						}
					},
					new CountryModel
					{
						Name = "China",
						Code = "CN",
						NativeName = "中华人民共和国",
						PhoneCode = "+86",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Anhui",
								Code = "AH"
							},
							new RegionModel
							{
								Name = "Beijing",
								Code = "BJ"
							},
							new RegionModel
							{
								Name = "Chongqing",
								Code = "CQ"
							},
							new RegionModel
							{
								Name = "Fujian",
								Code = "FJ"
							},
							new RegionModel
							{
								Name = "Gansu",
								Code = "GS"
							},
							new RegionModel
							{
								Name = "Guangdong",
								Code = "GD"
							},
							new RegionModel
							{
								Name = "Guangxi",
								Code = "GX"
							},
							new RegionModel
							{
								Name = "Guizhou",
								Code = "GZ"
							},
							new RegionModel
							{
								Name = "Hainan",
								Code = "HI"
							},
							new RegionModel
							{
								Name = "Hebei",
								Code = "HE"
							},
							new RegionModel
							{
								Name = "Heilongjiang",
								Code = "HL"
							},
							new RegionModel
							{
								Name = "Henan",
								Code = "HA"
							},
							new RegionModel
							{
								Name = "Hong Kong",
								Code = "HK"
							},
							new RegionModel
							{
								Name = "Hubei",
								Code = "HB"
							},
							new RegionModel
							{
								Name = "Hunan",
								Code = "HN"
							},
							new RegionModel
							{
								Name = "Inner Mongolia",
								Code = "NM"
							},
							new RegionModel
							{
								Name = "Jiangsu",
								Code = "JS"
							},
							new RegionModel
							{
								Name = "Jiangxi",
								Code = "JX"
							},
							new RegionModel
							{
								Name = "Jilin",
								Code = "JL"
							},
							new RegionModel
							{
								Name = "Liaoning",
								Code = "LN"
							},
							new RegionModel
							{
								Name = "Macau",
								Code = "MO"
							},
							new RegionModel
							{
								Name = "Ningxia",
								Code = "NX"
							},
							new RegionModel
							{
								Name = "Qinghai",
								Code = "QH"
							},
							new RegionModel
							{
								Name = "Shaanxi",
								Code = "SN"
							},
							new RegionModel
							{
								Name = "Shandong",
								Code = "SD"
							},
							new RegionModel
							{
								Name = "Shanghai",
								Code = "SH"
							},
							new RegionModel
							{
								Name = "Shanxi",
								Code = "SX"
							},
							new RegionModel
							{
								Name = "Sichuan",
								Code = "SC"
							},
							new RegionModel
							{
								Name = "Tianjin",
								Code = "TJ"
							},
							new RegionModel
							{
								Name = "Tibet",
								Code = "XZ"
							},
							new RegionModel
							{
								Name = "Xinjiang",
								Code = "XJ"
							},
							new RegionModel
							{
								Name = "Yunnan",
								Code = "YN"
							},
							new RegionModel
							{
								Name = "Zhejiang",
								Code = "ZJ"
							}
						}
					},
					new CountryModel
					{
						Name = "Christmas Island",
						Code = "CX",
						NativeName = "",
						PhoneCode = "+61",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Christmas Island",
								Code = "CX"
							}
						}
					},
					new CountryModel
					{
						Name = "Cocos (Keeling) Islands",
						Code = "CC",
						NativeName = "Pulu Kokos (Keeling) , Wilayah Kepulauan Cocos (Keeling)",
						PhoneCode = "+851",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Direction Island",
								Code = "DI"
							},
							new RegionModel
							{
								Name = "Home Island",
								Code = "HM"
							},
							new RegionModel
							{
								Name = "Horsburgh Island",
								Code = "HR"
							},
							new RegionModel
							{
								Name = "North Keeling Island",
								Code = "NK"
							},
							new RegionModel
							{
								Name = "South Island",
								Code = "SI"
							},
							new RegionModel
							{
								Name = "West Island",
								Code = "WI"
							}
						}
					},
					new CountryModel
					{
						Name = "Cocos (Keeling) Islands",
						Code = "CC",
						NativeName = "Pulu Kokos (Keeling) , Wilayah Kepulauan Cocos (Keeling)",
						PhoneCode = "+891",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Direction Island",
								Code = "DI"
							},
							new RegionModel
							{
								Name = "Home Island",
								Code = "HM"
							},
							new RegionModel
							{
								Name = "Horsburgh Island",
								Code = "HR"
							},
							new RegionModel
							{
								Name = "North Keeling Island",
								Code = "NK"
							},
							new RegionModel
							{
								Name = "South Island",
								Code = "SI"
							},
							new RegionModel
							{
								Name = "West Island",
								Code = "WI"
							}
						}
					},
					new CountryModel
					{
						Name = "Colombia",
						Code = "CO",
						NativeName = "",
						PhoneCode = "+57",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Amazonas",
								Code = "AMA"
							},
							new RegionModel
							{
								Name = "Antioquia",
								Code = "ANT"
							},
							new RegionModel
							{
								Name = "Arauca",
								Code = "ARA"
							},
							new RegionModel
							{
								Name = "Archipiélago de San Andrés",
								Code = "SAP"
							},
							new RegionModel
							{
								Name = "Atlántico",
								Code = "ATL"
							},
							new RegionModel
							{
								Name = "Bogotá D.C.",
								Code = "DC"
							},
							new RegionModel
							{
								Name = "Bolívar",
								Code = "BOL"
							},
							new RegionModel
							{
								Name = "Boyacá",
								Code = "BOY"
							},
							new RegionModel
							{
								Name = "Caldas",
								Code = "CAL"
							},
							new RegionModel
							{
								Name = "Caquetá",
								Code = "CAQ"
							},
							new RegionModel
							{
								Name = "Casanare",
								Code = "CAS"
							},
							new RegionModel
							{
								Name = "Cauca",
								Code = "CAU"
							},
							new RegionModel
							{
								Name = "Cesar",
								Code = "CES"
							},
							new RegionModel
							{
								Name = "Chocó",
								Code = "CHO"
							},
							new RegionModel
							{
								Name = "Córdoba",
								Code = "COR"
							},
							new RegionModel
							{
								Name = "Cundinamarca",
								Code = "CUN"
							},
							new RegionModel
							{
								Name = "Guainía",
								Code = "GUA"
							},
							new RegionModel
							{
								Name = "Guaviare",
								Code = "GUV"
							},
							new RegionModel
							{
								Name = "Huila",
								Code = "HUI"
							},
							new RegionModel
							{
								Name = "La Guajira",
								Code = "LAG"
							},
							new RegionModel
							{
								Name = "Magdalena",
								Code = "MAG"
							},
							new RegionModel
							{
								Name = "Meta",
								Code = "MET"
							},
							new RegionModel
							{
								Name = "Nariño",
								Code = "NAR"
							},
							new RegionModel
							{
								Name = "Norte de Santander",
								Code = "NSA"
							},
							new RegionModel
							{
								Name = "Putumayo",
								Code = "PUT"
							},
							new RegionModel
							{
								Name = "Quindío",
								Code = "QUI"
							},
							new RegionModel
							{
								Name = "Risaralda",
								Code = "RIS"
							},
							new RegionModel
							{
								Name = "Santander",
								Code = "SAN"
							},
							new RegionModel
							{
								Name = "Sucre",
								Code = "SUC"
							},
							new RegionModel
							{
								Name = "Tolima",
								Code = "TOL"
							},
							new RegionModel
							{
								Name = "Valle del Cauca",
								Code = "VAC"
							},
							new RegionModel
							{
								Name = "Vaupés",
								Code = "VAU"
							},
							new RegionModel
							{
								Name = "Vichada",
								Code = "VID"
							}
						}
					},
					new CountryModel
					{
						Name = "Comoros",
						Code = "KM",
						NativeName = "Komori , Comores , الاتحاد القمري ",
						PhoneCode = "+269",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Andjazîdja",
								Code = "G"
							},
							new RegionModel
							{
								Name = "Andjouân",
								Code = "A"
							},
							new RegionModel
							{
								Name = "Moûhîlî",
								Code = "M"
							}
						}
					},
					new CountryModel
					{
						Name = "Congo, Republic of the (Brazzaville)",
						Code = "CG",
						NativeName = "",
						PhoneCode = "+242",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bouenza",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Brazzaville",
								Code = "BZV"
							},
							new RegionModel
							{
								Name = "Cuvette",
								Code = "8"
							},
							new RegionModel
							{
								Name = "Cuvette-Ouest",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Kouilou",
								Code = "5"
							},
							new RegionModel
							{
								Name = "Lékoumou",
								Code = "2"
							},
							new RegionModel
							{
								Name = "Likouala",
								Code = "7"
							},
							new RegionModel
							{
								Name = "Niari",
								Code = "9"
							},
							new RegionModel
							{
								Name = "Plateaux",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Pointe-Noire",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Pool",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Sangha",
								Code = "13"
							}
						}
					},
					new CountryModel
					{
						Name = "Congo, the Democratic Republic of the (Kinshasa)",
						Code = "CD",
						NativeName = "République démocratique du Congo , Repubilika ya Kôngo ya Dimokalasi , Republiki ya Kɔ́ngɔ Demokratiki , Jamhuri ya Kidemokrasia ya Kongo , Ditunga dia Kongu wa Mungalaata",
						PhoneCode = "+243",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bandundu",
								Code = "BN"
							},
							new RegionModel
							{
								Name = "Bas-Congo",
								Code = "BC"
							},
							new RegionModel
							{
								Name = "Équateur",
								Code = "EQ"
							},
							new RegionModel
							{
								Name = "Kasaï-Occidental",
								Code = "KE"
							},
							new RegionModel
							{
								Name = "Kasaï-Oriental",
								Code = "KW"
							},
							new RegionModel
							{
								Name = "Katanga",
								Code = "KA"
							},
							new RegionModel
							{
								Name = "Kinshasa",
								Code = "KN"
							},
							new RegionModel
							{
								Name = "Maniema",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Nord-Kivu",
								Code = "NK"
							},
							new RegionModel
							{
								Name = "Orientale",
								Code = "OR"
							},
							new RegionModel
							{
								Name = "Sud-Kivu",
								Code = "SK"
							}
						}
					},
					new CountryModel
					{
						Name = "Cook Islands",
						Code = "CK",
						NativeName = "Kuki ’Āirani",
						PhoneCode = "+682",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aitutaki",
								Code = null
							},
							new RegionModel
							{
								Name = "Atiu",
								Code = null
							},
							new RegionModel
							{
								Name = "Avarua",
								Code = null
							},
							new RegionModel
							{
								Name = "Mangaia",
								Code = null
							},
							new RegionModel
							{
								Name = "Manihiki",
								Code = null
							},
							new RegionModel
							{
								Name = "Ma'uke",
								Code = null
							},
							new RegionModel
							{
								Name = "Mitiaro",
								Code = null
							},
							new RegionModel
							{
								Name = "Nassau",
								Code = null
							},
							new RegionModel
							{
								Name = "Palmerston",
								Code = null
							},
							new RegionModel
							{
								Name = "Penrhyn",
								Code = null
							},
							new RegionModel
							{
								Name = "Pukapuka",
								Code = null
							},
							new RegionModel
							{
								Name = "Rakahanga",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Costa Rica",
						Code = "CR",
						NativeName = "",
						PhoneCode = "+506",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Alajuela",
								Code = "2"
							},
							new RegionModel
							{
								Name = "Cartago",
								Code = "3"
							},
							new RegionModel
							{
								Name = "Guanacaste",
								Code = "5"
							},
							new RegionModel
							{
								Name = "Heredia",
								Code = "4"
							},
							new RegionModel
							{
								Name = "Limón",
								Code = "7"
							},
							new RegionModel
							{
								Name = "Puntarenas",
								Code = "6"
							},
							new RegionModel
							{
								Name = "San José",
								Code = "1"
							}
						}
					},
					new CountryModel
					{
						Name = "Cote d'Ivoire",
						Code = "CI",
						NativeName = "Côte d’Ivoire",
						PhoneCode = "+225",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Agnéby",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Bafing",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Bas-Sassandra",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Denguélé",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Dix-Huit Montagnes",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Fromager",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Haut-Sassandra",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Lacs",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Lagunes",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Marahoué",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Moyen-Cavally",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Moyen-Comoé",
								Code = "05"
							},
							new RegionModel
							{
								Name = "N'zi-Comoé",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Savanes",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Sud-Bandama",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Sud-Comoé",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Vallée du Bandama",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Worodougou",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Zanzan",
								Code = "08"
							}
						}
					},
					new CountryModel
					{
						Name = "Croatia",
						Code = "HR",
						NativeName = "Hrvatska",
						PhoneCode = "+385",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bjelovarsko-bilogorska županija",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Brodsko-posavska županija",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Dubrovačko-neretvanska županija",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Grad Zagreb",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Istarska županija",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Karlovačka županija",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Koprivničko-križevačka županija",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Krapinsko-zagorska županija",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Ličko-senjska županija",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Međimurska županija",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Osječko-baranjska županija",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Požeško-slavonska županija",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Primorsko-goranska županija",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Sisačko-moslavačka županija",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Splitsko-dalmatinska županija",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Šibensko-kninska županija",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Varaždinska županija",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Virovitičko-podravska županija",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Vukovarsko-srijemska županija",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Zadarska županija",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Zagrebačka županija",
								Code = "01"
							}
						}
					},
					new CountryModel
					{
						Name = "Cuba",
						Code = "CU",
						NativeName = "",
						PhoneCode = "+53",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Artemisa",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Camagüey",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Ciego de Ávila",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Cienfuegos",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Granma",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Guantánamo",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Holguín",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Isla de la Juventud",
								Code = "99"
							},
							new RegionModel
							{
								Name = "La Habana",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Las Tunas",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Matanzas",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Mayabeque",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Pinar del Río",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Sancti Spíritus",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Santiago de Cuba",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Villa Clara",
								Code = "05"
							}
						}
					},
					new CountryModel
					{
						Name = "Curaçao",
						Code = "CW",
						NativeName = "Curazao , Curaçao",
						PhoneCode = "+599",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Curaçao",
								Code = "CW"
							}
						}
					},
					new CountryModel
					{
						Name = "Cyprus",
						Code = "CY",
						NativeName = "Κύπρος , Kıbrıs",
						PhoneCode = "+357",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ammochostos",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Keryneia",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Larnaka",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Lefkosia",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Lemesos",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Pafos",
								Code = "05"
							}
						}
					},
					new CountryModel
					{
						Name = "Czech Republic",
						Code = "CZ",
						NativeName = "Česká republika",
						PhoneCode = "+420",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Hlavní město Praha",
								Code = "PR"
							},
							new RegionModel
							{
								Name = "Jihočeský kraj",
								Code = "JC"
							},
							new RegionModel
							{
								Name = "Jihomoravský kraj",
								Code = "JM"
							},
							new RegionModel
							{
								Name = "Karlovarský kraj",
								Code = "KA"
							},
							new RegionModel
							{
								Name = "Královéhradecký kraj",
								Code = "KR"
							},
							new RegionModel
							{
								Name = "Liberecký kraj",
								Code = "LI"
							},
							new RegionModel
							{
								Name = "Moravskoslezský kraj",
								Code = "MO"
							},
							new RegionModel
							{
								Name = "Olomoucký kraj",
								Code = "OL"
							},
							new RegionModel
							{
								Name = "Pardubický kraj",
								Code = "PA"
							},
							new RegionModel
							{
								Name = "Plzeňský kraj",
								Code = "PL"
							},
							new RegionModel
							{
								Name = "Středočeský kraj",
								Code = "ST"
							},
							new RegionModel
							{
								Name = "Ústecký kraj",
								Code = "US"
							},
							new RegionModel
							{
								Name = "Vysočina",
								Code = "VY"
							},
							new RegionModel
							{
								Name = "Zlínský kraj",
								Code = "ZL"
							}
						}
					},
					#endregion
				};
					break;
				case 'D':
					countries = new ObservableCollection<CountryModel> { 
					#region D
					new CountryModel
					{
						Name = "Denmark",
						Code = "DK",
						NativeName = "Danmark",
						PhoneCode = "+45",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Hovedstaden",
								Code = "84"
							},
							new RegionModel
							{
								Name = "Kujalleq",
								Code = "GL-KU"
							},
							new RegionModel
							{
								Name = "Midtjylland",
								Code = "82"
							},
							new RegionModel
							{
								Name = "Norderøerne",
								Code = "FO-01"
							},
							new RegionModel
							{
								Name = "Nordjylland",
								Code = "81"
							},
							new RegionModel
							{
								Name = "Østerø",
								Code = "FO-06"
							},
							new RegionModel
							{
								Name = "Qaasuitsup",
								Code = "GL-QA"
							},
							new RegionModel
							{
								Name = "Qeqqata",
								Code = "GL-QE"
							},
							new RegionModel
							{
								Name = "Sandø",
								Code = "FO-02"
							},
							new RegionModel
							{
								Name = "Sermersooq",
								Code = "GL-SM"
							},
							new RegionModel
							{
								Name = "Sjælland",
								Code = "85"
							},
							new RegionModel
							{
								Name = "Strømø",
								Code = "FO-03"
							},
							new RegionModel
							{
								Name = "Suderø",
								Code = "FO-04"
							},
							new RegionModel
							{
								Name = "Syddanmark",
								Code = "83"
							},
							new RegionModel
							{
								Name = "Vågø",
								Code = "FO-05"
							}
						}
					},
					new CountryModel
					{
						Name = "Djibouti",
						Code = "DJ",
						NativeName = "Gabuutih Ummuuno , Jabuuti , جمهورية جيبوتي ",
						PhoneCode = "+253",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ali Sabieh",
								Code = "AS"
							},
							new RegionModel
							{
								Name = "Arta",
								Code = "AR"
							},
							new RegionModel
							{
								Name = "Dikhil",
								Code = "DI"
							},
							new RegionModel
							{
								Name = "Obock",
								Code = "OB"
							},
							new RegionModel
							{
								Name = "Tadjourah",
								Code = "TA"
							}
						}
					},
					new CountryModel
					{
						Name = "Dominica",
						Code = "DM",
						NativeName = "",
						PhoneCode = "+1",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Saint Andrew Parish",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Saint David Parish",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Saint George Parish",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Saint John Parish",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Saint Joseph Parish",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Saint Luke Parish",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Saint Mark Parish",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Saint Patrick Parish",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Saint Paul Parish",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Saint Peter Parish",
								Code = "11"
							}
						}
					},
					new CountryModel
					{
						Name = "Dominican Republic",
						Code = "DO",
						NativeName = "República Dominicana",
						PhoneCode = "+1",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Cibao Central",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Del Valle",
								Code = "37"
							},
							new RegionModel
							{
								Name = "Distrito Nacional",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Enriquillo",
								Code = "38"
							},
							new RegionModel
							{
								Name = "Norcentral",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Nordeste",
								Code = "33"
							},
							new RegionModel
							{
								Name = "Noroeste",
								Code = "34"
							},
							new RegionModel
							{
								Name = "Norte",
								Code = "35"
							},
							new RegionModel
							{
								Name = "Valdesia",
								Code = "42"
							}
						}
					},
					#endregion
				};
					break;
				case 'E':
					countries = new ObservableCollection<CountryModel> { 
					#region E
					new CountryModel
					{
						Name = "Ecuador",
						Code = "EC",
						NativeName = "",
						PhoneCode = "+593",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Azuay",
								Code = "A"
							},
							new RegionModel
							{
								Name = "Bolívar",
								Code = "B"
							},
							new RegionModel
							{
								Name = "Cañar",
								Code = "F"
							},
							new RegionModel
							{
								Name = "Carchi",
								Code = "C"
							},
							new RegionModel
							{
								Name = "Chimborazo",
								Code = "H"
							},
							new RegionModel
							{
								Name = "Cotopaxi",
								Code = "X"
							},
							new RegionModel
							{
								Name = "El Oro",
								Code = "O"
							},
							new RegionModel
							{
								Name = "Esmeraldas",
								Code = "E"
							},
							new RegionModel
							{
								Name = "Galápagos",
								Code = "W"
							},
							new RegionModel
							{
								Name = "Guayas",
								Code = "G"
							},
							new RegionModel
							{
								Name = "Imbabura",
								Code = "I"
							},
							new RegionModel
							{
								Name = "Loja",
								Code = "L"
							},
							new RegionModel
							{
								Name = "Los Ríos",
								Code = "R"
							},
							new RegionModel
							{
								Name = "Manabí",
								Code = "M"
							},
							new RegionModel
							{
								Name = "Morona-Santiago",
								Code = "S"
							},
							new RegionModel
							{
								Name = "Napo",
								Code = "N"
							},
							new RegionModel
							{
								Name = "Orellana",
								Code = "D"
							},
							new RegionModel
							{
								Name = "Pastaza",
								Code = "Y"
							},
							new RegionModel
							{
								Name = "Pichincha",
								Code = "P"
							},
							new RegionModel
							{
								Name = "Santa Elena",
								Code = "SE"
							},
							new RegionModel
							{
								Name = "Santo Domingo de los Tsáchilas",
								Code = "SD"
							},
							new RegionModel
							{
								Name = "Sucumbíos",
								Code = "U"
							},
							new RegionModel
							{
								Name = "Tungurahua",
								Code = "T"
							},
							new RegionModel
							{
								Name = "Zamora-Chinchipe",
								Code = "Z"
							}
						}
					},
					new CountryModel
					{
						Name = "Egypt",
						Code = "EG",
						NativeName = "‎ مِصر ",
						PhoneCode = "+20",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Alexandria",
								Code = "ALX"
							},
							new RegionModel
							{
								Name = "Aswan",
								Code = "ASN"
							},
							new RegionModel
							{
								Name = "Asyout",
								Code = "AST"
							},
							new RegionModel
							{
								Name = "Bani Sueif",
								Code = "BNS"
							},
							new RegionModel
							{
								Name = "Beheira",
								Code = "BH"
							},
							new RegionModel
							{
								Name = "Cairo",
								Code = "C"
							},
							new RegionModel
							{
								Name = "Daqahlia",
								Code = "DK"
							},
							new RegionModel
							{
								Name = "Dumiat",
								Code = "DT"
							},
							new RegionModel
							{
								Name = "El Bahr El Ahmar",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "El Ismailia",
								Code = "IS"
							},
							new RegionModel
							{
								Name = "El Suez",
								Code = "SUZ"
							},
							new RegionModel
							{
								Name = "El Wadi El Gedeed",
								Code = "WAD"
							},
							new RegionModel
							{
								Name = "Fayoum",
								Code = "FYM"
							},
							new RegionModel
							{
								Name = "Gharbia",
								Code = "GH"
							},
							new RegionModel
							{
								Name = "Giza",
								Code = "GZ"
							},
							new RegionModel
							{
								Name = "Helwan",
								Code = "HU"
							},
							new RegionModel
							{
								Name = "Kafr El Sheikh",
								Code = "KFS"
							},
							new RegionModel
							{
								Name = "Luxor",
								Code = "LX"
							},
							new RegionModel
							{
								Name = "Matrouh",
								Code = "MT"
							},
							new RegionModel
							{
								Name = "Menia",
								Code = "MN"
							},
							new RegionModel
							{
								Name = "Menofia",
								Code = "MNF"
							},
							new RegionModel
							{
								Name = "North Sinai",
								Code = "SIN"
							},
							new RegionModel
							{
								Name = "Port Said",
								Code = "PTS"
							},
							new RegionModel
							{
								Name = "Qalubia",
								Code = "KB"
							},
							new RegionModel
							{
								Name = "Qena",
								Code = "KN"
							},
							new RegionModel
							{
								Name = "Sharqia",
								Code = "SHR"
							},
							new RegionModel
							{
								Name = "Sixth of October",
								Code = "SU"
							},
							new RegionModel
							{
								Name = "Sohag",
								Code = "SHG"
							},
							new RegionModel
							{
								Name = "South Sinai",
								Code = "JS"
							}
						}
					},
					new CountryModel
					{
						Name = "El Salvador",
						Code = "SV",
						NativeName = "",
						PhoneCode = "+503",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ahuachapán",
								Code = "AH"
							},
							new RegionModel
							{
								Name = "Cabañas",
								Code = "CA"
							},
							new RegionModel
							{
								Name = "Cuscatlán",
								Code = "CU"
							},
							new RegionModel
							{
								Name = "Chalatenango",
								Code = "CH"
							},
							new RegionModel
							{
								Name = "La Libertad",
								Code = "LI"
							},
							new RegionModel
							{
								Name = "La Paz",
								Code = "PA"
							},
							new RegionModel
							{
								Name = "La Unión",
								Code = "UN"
							},
							new RegionModel
							{
								Name = "Morazán",
								Code = "MO"
							},
							new RegionModel
							{
								Name = "San Miguel",
								Code = "SM"
							},
							new RegionModel
							{
								Name = "San Salvador",
								Code = "SS"
							},
							new RegionModel
							{
								Name = "Santa Ana",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "San Vicente",
								Code = "SV"
							},
							new RegionModel
							{
								Name = "Sonsonate",
								Code = "SO"
							},
							new RegionModel
							{
								Name = "Usulután",
								Code = "US"
							}
						}
					},
					new CountryModel
					{
						Name = "Equatorial Guinea",
						Code = "GQ",
						NativeName = "Guinée équatoriale , Guiné Equatorial",
						PhoneCode = "+240",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Annobón",
								Code = "AN"
							},
							new RegionModel
							{
								Name = "Bioko Norte",
								Code = "BN"
							},
							new RegionModel
							{
								Name = "Bioko Sur",
								Code = "BS"
							},
							new RegionModel
							{
								Name = "Centro Sur",
								Code = "CS"
							},
							new RegionModel
							{
								Name = "Kié-Ntem",
								Code = "KN"
							},
							new RegionModel
							{
								Name = "Litoral",
								Code = "LI"
							},
							new RegionModel
							{
								Name = "Wele-Nzas",
								Code = "WN"
							}
						}
					},
					new CountryModel
					{
						Name = "Eritrea",
						Code = "ER",
						NativeName = "ሃገረ ኤርትራ , دولة إرتريا  ",
						PhoneCode = "+291",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Anseba",
								Code = "AN"
							},
							new RegionModel
							{
								Name = "Debub",
								Code = "DU"
							},
							new RegionModel
							{
								Name = "Debub-Keih-Bahri",
								Code = "DK"
							},
							new RegionModel
							{
								Name = "Gash-Barka",
								Code = "GB"
							},
							new RegionModel
							{
								Name = "Maekel",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Semien-Keih-Bahri",
								Code = "SK"
							}
						}
					},
					new CountryModel
					{
						Name = "Estonia",
						Code = "EE",
						NativeName = "Eesti Vabariik",
						PhoneCode = "+372",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Harjumaa (Tallinn)",
								Code = "37"
							},
							new RegionModel
							{
								Name = "Hiiumaa (Kardla)",
								Code = "39"
							},
							new RegionModel
							{
								Name = "Ida-Virumaa (Johvi)",
								Code = "44"
							},
							new RegionModel
							{
								Name = "Järvamaa (Paide)",
								Code = "41"
							},
							new RegionModel
							{
								Name = "Jõgevamaa (Jogeva)",
								Code = "49"
							},
							new RegionModel
							{
								Name = "Läänemaa",
								Code = "57"
							},
							new RegionModel
							{
								Name = "Lääne-Virumaa (Rakvere)",
								Code = "59"
							},
							new RegionModel
							{
								Name = "Pärnumaa (Parnu)",
								Code = "67"
							},
							new RegionModel
							{
								Name = "Põlvamaa (Polva)",
								Code = "65"
							},
							new RegionModel
							{
								Name = "Raplamaa (Rapla)",
								Code = "70"
							},
							new RegionModel
							{
								Name = "Saaremaa (Kuessaare)",
								Code = "74"
							},
							new RegionModel
							{
								Name = "Tartumaa (Tartu)",
								Code = "78"
							},
							new RegionModel
							{
								Name = "Valgamaa (Valga)",
								Code = "82"
							},
							new RegionModel
							{
								Name = "Viljandimaa (Viljandi)",
								Code = "84"
							},
							new RegionModel
							{
								Name = "Võrumaa (Voru)",
								Code = "86"
							}
						}
					},
					new CountryModel
					{
						Name = "Ethiopia",
						Code = "ET",
						NativeName = "የኢትዮጵያ ፌዴራላዊ ዴሞክራሲያዊ ሪፐብሊክ",
						PhoneCode = "+251",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Addis Ababa",
								Code = "AA"
							},
							new RegionModel
							{
								Name = "Afar",
								Code = "AF"
							},
							new RegionModel
							{
								Name = "Amhara",
								Code = "AM"
							},
							new RegionModel
							{
								Name = "Benshangul-Gumaz",
								Code = "BE"
							},
							new RegionModel
							{
								Name = "Dire Dawa",
								Code = "DD"
							},
							new RegionModel
							{
								Name = "Gambela",
								Code = "GA"
							},
							new RegionModel
							{
								Name = "Harari",
								Code = "HA"
							},
							new RegionModel
							{
								Name = "Oromia",
								Code = "OR"
							},
							new RegionModel
							{
								Name = "Somali",
								Code = "SO"
							},
							new RegionModel
							{
								Name = "Southern Nations Nationalities and People's Region",
								Code = "SN"
							},
							new RegionModel
							{
								Name = "Tigray",
								Code = "TI"
							}
						}
					},
					#endregion
				};
					break;
				case 'F':
					countries = new ObservableCollection<CountryModel> { 
					#region F
					new CountryModel
					{
						Name = "Falkland Islands (Islas Malvinas)",
						Code = "FK",
						NativeName = "",
						PhoneCode = "+500",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Falkland Islands (Islas Malvinas)",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Faroe Islands",
						Code = "FO",
						NativeName = "Færøerne , Føroyar",
						PhoneCode = "+298",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bordoy",
								Code = null
							},
							new RegionModel
							{
								Name = "Eysturoy",
								Code = null
							},
							new RegionModel
							{
								Name = "Mykines",
								Code = null
							},
							new RegionModel
							{
								Name = "Sandoy",
								Code = null
							},
							new RegionModel
							{
								Name = "Skuvoy",
								Code = null
							},
							new RegionModel
							{
								Name = "Streymoy",
								Code = null
							},
							new RegionModel
							{
								Name = "Suduroy",
								Code = null
							},
							new RegionModel
							{
								Name = "Tvoroyri",
								Code = null
							},
							new RegionModel
							{
								Name = "Vagar",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Fiji",
						Code = "FJ",
						NativeName = "Matanitu Tugalala o Viti , फ़िजी गणराज्य",
						PhoneCode = "+679",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ba",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Bua",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Cakaudrove",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Kadavu",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Lau",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Lomaiviti",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Macuata",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Nadroga and Navosa",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Naitasiri",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Namosi",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Ra",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Rewa",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Rotuma",
								Code = "R"
							},
							new RegionModel
							{
								Name = "Serua",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Tailevu",
								Code = "14"
							}
						}
					},
					new CountryModel
					{
						Name = "Finland",
						Code = "FI",
						NativeName = "Suomen ",
						PhoneCode = "+358",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ahvenanmaan maakunta",
								Code = "FI-01"
							},
							new RegionModel
							{
								Name = "Etelä-Karjala",
								Code = "FI-02"
							},
							new RegionModel
							{
								Name = "Etelä-Pohjanmaa",
								Code = "FI-03"
							},
							new RegionModel
							{
								Name = "Etelä-Savo",
								Code = "FI-04"
							},
							new RegionModel
							{
								Name = "Kainuu",
								Code = "FI-05"
							},
							new RegionModel
							{
								Name = "Kanta-Häme",
								Code = "FI-06"
							},
							new RegionModel
							{
								Name = "Keski-Pohjanmaa",
								Code = "FI-07"
							},
							new RegionModel
							{
								Name = "Keski-Suomi",
								Code = "FI-08"
							},
							new RegionModel
							{
								Name = "Kymenlaakso",
								Code = "FI-09"
							},
							new RegionModel
							{
								Name = "Lappi",
								Code = "FI-10"
							},
							new RegionModel
							{
								Name = "Pirkanmaa",
								Code = "FI-11"
							},
							new RegionModel
							{
								Name = "Pohjanmaa",
								Code = "FI-12"
							},
							new RegionModel
							{
								Name = "Pohjois-Karjala",
								Code = "FI-13"
							},
							new RegionModel
							{
								Name = "Pohjois-Pohjanmaa",
								Code = "FI-14"
							},
							new RegionModel
							{
								Name = "Pohjois-Savo",
								Code = "FI-15"
							},
							new RegionModel
							{
								Name = "Päijät-Häme",
								Code = "FI-16"
							},
							new RegionModel
							{
								Name = "Satakunta",
								Code = "FI-17"
							},
							new RegionModel
							{
								Name = "Uusimaa",
								Code = "FI-18"
							},
							new RegionModel
							{
								Name = "Varsinais-Suomi",
								Code = "FI-19"
							}
						}
					},
					new CountryModel
					{
						Name = "France",
						Code = "FR",
						NativeName = "",
						PhoneCode = "+33",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Auvergne-Rhône-Alpes",
								Code = "ARA"
							},
							new RegionModel
							{
								Name = "Bourgogne-Franche-Comté",
								Code = "BFC"
							},
							new RegionModel
							{
								Name = "Bretagne",
								Code = "BRE"
							},
							new RegionModel
							{
								Name = "Centre-Val de Loire",
								Code = "CVL"
							},
							new RegionModel
							{
								Name = "Corse",
								Code = "COR"
							},
							new RegionModel
							{
								Name = "Grand Est",
								Code = "GES"
							},
							new RegionModel
							{
								Name = "Hauts-de-France",
								Code = "HDF"
							},
							new RegionModel
							{
								Name = "Île-de-France",
								Code = "IDF"
							},
							new RegionModel
							{
								Name = "Normandie",
								Code = "NOR"
							},
							new RegionModel
							{
								Name = "Nouvelle-Aquitaine",
								Code = "NAQ"
							},
							new RegionModel
							{
								Name = "Occitanie",
								Code = "OCC"
							},
							new RegionModel
							{
								Name = "Pays de la Loire",
								Code = "PDL"
							},
							new RegionModel
							{
								Name = "Provence-Alpes-Cote d'Azur",
								Code = "PAC"
							},
							new RegionModel
							{
								Name = "Clipperton",
								Code = "CP"
							},
							new RegionModel
							{
								Name = "Guadeloupe",
								Code = "GP"
							},
							new RegionModel
							{
								Name = "Guyane",
								Code = "GF"
							},
							new RegionModel
							{
								Name = "Martinique",
								Code = "MQ"
							},
							new RegionModel
							{
								Name = "Mayotte",
								Code = "YT"
							},
							new RegionModel
							{
								Name = "Nouvelle-Calédonie",
								Code = "NC"
							},
							new RegionModel
							{
								Name = "Polynésie",
								Code = "PF"
							},
							new RegionModel
							{
								Name = "Saint-Pierre-et-Miquelon",
								Code = "PM"
							},
							new RegionModel
							{
								Name = "Saint Barthélemy",
								Code = "BL"
							},
							new RegionModel
							{
								Name = "Saint Martin",
								Code = "MF"
							},
							new RegionModel
							{
								Name = "Réunion",
								Code = "RE"
							},
							new RegionModel
							{
								Name = "Terres Australes Françaises",
								Code = "TF"
							},
							new RegionModel
							{
								Name = "Wallis-et-Futuna",
								Code = "WF"
							}
						}
					},
					new CountryModel
					{
						Name = "French Guiana",
						Code = "GF",
						NativeName = "Guyane Française",
						PhoneCode = "+594",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "French Guiana",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "French Polynesia",
						Code = "PF",
						NativeName = "Polynésie Française , Porinetia Farani",
						PhoneCode = "+689",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Archipel des Marquises",
								Code = null
							},
							new RegionModel
							{
								Name = "Archipel des Tuamotu",
								Code = null
							},
							new RegionModel
							{
								Name = "Archipel des Tubuai",
								Code = null
							},
							new RegionModel
							{
								Name = "Iles du Vent",
								Code = null
							},
							new RegionModel
							{
								Name = "Iles Sous-le-Vent",
								Code = null
							}
						}
					},
					#endregion
				};
					break;
				case 'G':
					countries = new ObservableCollection<CountryModel> { 
					#region G
					new CountryModel
					{
						Name = "Gabon",
						Code = "GA",
						NativeName = "",
						PhoneCode = "+241",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Estuaire",
								Code = "1"
							},
							new RegionModel
							{
								Name = "Haut-Ogooué",
								Code = "2"
							},
							new RegionModel
							{
								Name = "Moyen-Ogooué",
								Code = "3"
							},
							new RegionModel
							{
								Name = "Ngounié",
								Code = "4"
							},
							new RegionModel
							{
								Name = "Nyanga",
								Code = "5"
							},
							new RegionModel
							{
								Name = "Ogooué-Ivindo",
								Code = "6"
							},
							new RegionModel
							{
								Name = "Ogooué-Lolo",
								Code = "7"
							},
							new RegionModel
							{
								Name = "Ogooué-Maritime",
								Code = "8"
							},
							new RegionModel
							{
								Name = "Woleu-Ntem",
								Code = "9"
							}
						}
					},
					new CountryModel
					{
						Name = "Gambia",
						Code = "GM",
						NativeName = "",
						PhoneCode = "+220",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Banjul",
								Code = "B"
							},
							new RegionModel
							{
								Name = "Central River",
								Code = "M"
							},
							new RegionModel
							{
								Name = "Lower River",
								Code = "L"
							},
							new RegionModel
							{
								Name = "North Bank",
								Code = "N"
							},
							new RegionModel
							{
								Name = "Upper River",
								Code = "U"
							},
							new RegionModel
							{
								Name = "Western",
								Code = "W"
							}
						}
					},
					new CountryModel
					{
						Name = "Georgia",
						Code = "GE",
						NativeName = "საქართველო",
						PhoneCode = "+995",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Abkhazia (Sokhumi)",
								Code = "AB"
							},
							new RegionModel
							{
								Name = "Ajaria (Bat'umi)",
								Code = "AJ"
							},
							new RegionModel
							{
								Name = "Guria",
								Code = "GU"
							},
							new RegionModel
							{
								Name = "Imereti",
								Code = "IM"
							},
							new RegionModel
							{
								Name = "K'akheti",
								Code = "KA"
							},
							new RegionModel
							{
								Name = "Kvemo Kartli",
								Code = "KK"
							},
							new RegionModel
							{
								Name = "Mtshkheta-Mtianeti",
								Code = "MM"
							},
							new RegionModel
							{
								Name = "Rach'a-Lexhkumi-KvemoSvaneti",
								Code = "RL"
							},
							new RegionModel
							{
								Name = "Samegrelo-Zemo Svaneti",
								Code = "SZ"
							},
							new RegionModel
							{
								Name = "Samtskhe-Javakheti",
								Code = "SJ"
							},
							new RegionModel
							{
								Name = "Shida Kartli",
								Code = "SK"
							},
							new RegionModel
							{
								Name = "Tbilisi",
								Code = "TB"
							}
						}
					},
					new CountryModel
					{
						Name = "Germany",
						Code = "DE",
						NativeName = "Deutschland",
						PhoneCode = "+49",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Baden-Württemberg",
								Code = "BW"
							},
							new RegionModel
							{
								Name = "Bayern",
								Code = "BY"
							},
							new RegionModel
							{
								Name = "Berlin",
								Code = "BE"
							},
							new RegionModel
							{
								Name = "Brandenburg",
								Code = "BB"
							},
							new RegionModel
							{
								Name = "Bremen",
								Code = "HB"
							},
							new RegionModel
							{
								Name = "Hamburg",
								Code = "HH"
							},
							new RegionModel
							{
								Name = "Hessen",
								Code = "HE"
							},
							new RegionModel
							{
								Name = "Mecklenburg-Vorpommern",
								Code = "MV"
							},
							new RegionModel
							{
								Name = "Niedersachsen",
								Code = "NI"
							},
							new RegionModel
							{
								Name = "Nordrhein-Westfalen",
								Code = "NW"
							},
							new RegionModel
							{
								Name = "Rheinland-Pfalz",
								Code = "RP"
							},
							new RegionModel
							{
								Name = "Saarland",
								Code = "SL"
							},
							new RegionModel
							{
								Name = "Sachsen",
								Code = "SN"
							},
							new RegionModel
							{
								Name = "Sachsen-Anhalt",
								Code = "ST"
							},
							new RegionModel
							{
								Name = "Schleswig-Holstein",
								Code = "SH"
							},
							new RegionModel
							{
								Name = "Thüringen",
								Code = "TH"
							}
						}
					},
					new CountryModel
					{
						Name = "Ghana",
						Code = "GH",
						NativeName = "",
						PhoneCode = "+233",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ahafo",
								Code = null
							},
							new RegionModel
							{
								Name = "Ashanti",
								Code = "AH"
							},
							new RegionModel
							{
								Name = "Bono",
								Code = null
							},
							new RegionModel
							{
								Name = "Bono East",
								Code = null
							},
							new RegionModel
							{
								Name = "Central",
								Code = "CP"
							},
							new RegionModel
							{
								Name = "Eastern",
								Code = "EP"
							},
							new RegionModel
							{
								Name = "Greater Accra",
								Code = "AA"
							},
							new RegionModel
							{
								Name = "Northern",
								Code = "NP"
							},
							new RegionModel
							{
								Name = "North East",
								Code = null
							},
							new RegionModel
							{
								Name = "Oti",
								Code = null
							},
							new RegionModel
							{
								Name = "Savannah",
								Code = null
							},
							new RegionModel
							{
								Name = "Upper East",
								Code = "UE"
							},
							new RegionModel
							{
								Name = "Upper West",
								Code = "UW"
							},
							new RegionModel
							{
								Name = "Volta",
								Code = "TV"
							},
							new RegionModel
							{
								Name = "Western",
								Code = "WP"
							},
							new RegionModel
							{
								Name = "Western North",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Gibraltar",
						Code = "GI",
						NativeName = "",
						PhoneCode = "+350",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Gibraltar",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Greece",
						Code = "GR",
						NativeName = "Ελλάδα",
						PhoneCode = "+30",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Anatolikí Makedonía kai Thráki",
								Code = "A"
							},
							new RegionModel
							{
								Name = "Attikḯ",
								Code = "I"
							},
							new RegionModel
							{
								Name = "Dytikí Elláda",
								Code = "G"
							},
							new RegionModel
							{
								Name = "Dytikí Makedonía",
								Code = "C"
							},
							new RegionModel
							{
								Name = "Ionía Nísia",
								Code = "F"
							},
							new RegionModel
							{
								Name = "Kentrikí Makedonía",
								Code = "B"
							},
							new RegionModel
							{
								Name = "Krítí",
								Code = "M"
							},
							new RegionModel
							{
								Name = "Notío Aigaío",
								Code = "L"
							},
							new RegionModel
							{
								Name = "Peloponnísos",
								Code = "J"
							},
							new RegionModel
							{
								Name = "Stereá Elláda",
								Code = "H"
							},
							new RegionModel
							{
								Name = "Thessalía",
								Code = "E"
							},
							new RegionModel
							{
								Name = "Voreío Aigaío",
								Code = "K"
							},
							new RegionModel
							{
								Name = "Ípeiros",
								Code = "D"
							},
							new RegionModel
							{
								Name = "Ágion Óros",
								Code = "69"
							}
						}
					},
					new CountryModel
					{
						Name = "Greenland",
						Code = "GL",
						NativeName = "Kalaallit Nunaat",
						PhoneCode = "+299",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Kommune Kujalleq",
								Code = "KU"
							},
							new RegionModel
							{
								Name = "Kommuneqarfik Sermersooq",
								Code = "SM"
							},
							new RegionModel
							{
								Name = "Qaasuitsup Kommunia",
								Code = "QA"
							},
							new RegionModel
							{
								Name = "Qeqqata Kommunia",
								Code = "QE"
							}
						}
					},
					new CountryModel
					{
						Name = "Grenada",
						Code = "GD",
						NativeName = "",
						PhoneCode = "+1 473",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Saint Andrew",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Saint David",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Saint George",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Saint John",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Saint Mark",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Saint Patrick",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Southern Grenadine Islands",
								Code = "10"
							}
						}
					},
					new CountryModel
					{
						Name = "Guadeloupe",
						Code = "GP",
						NativeName = "",
						PhoneCode = "+590",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Guadeloupe",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Guam",
						Code = "GU",
						NativeName = "Guåhån",
						PhoneCode = "+1 671",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Guam",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Guatemala",
						Code = "GT",
						NativeName = "",
						PhoneCode = "+502",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Alta Verapaz",
								Code = "AV"
							},
							new RegionModel
							{
								Name = "Baja Verapaz",
								Code = "BV"
							},
							new RegionModel
							{
								Name = "Chimaltenango",
								Code = "CM"
							},
							new RegionModel
							{
								Name = "Chiquimula",
								Code = "CQ"
							},
							new RegionModel
							{
								Name = "El Progreso",
								Code = "PR"
							},
							new RegionModel
							{
								Name = "Escuintla",
								Code = "ES"
							},
							new RegionModel
							{
								Name = "Guatemala",
								Code = "GU"
							},
							new RegionModel
							{
								Name = "Huehuetenango",
								Code = "HU"
							},
							new RegionModel
							{
								Name = "Izabal",
								Code = "IZ"
							},
							new RegionModel
							{
								Name = "Jalapa",
								Code = "JA"
							},
							new RegionModel
							{
								Name = "Jutiapa",
								Code = "JU"
							},
							new RegionModel
							{
								Name = "Petén",
								Code = "PE"
							},
							new RegionModel
							{
								Name = "Quetzaltenango",
								Code = "QZ"
							},
							new RegionModel
							{
								Name = "Quiché",
								Code = "QC"
							},
							new RegionModel
							{
								Name = "Retalhuleu",
								Code = "Re"
							},
							new RegionModel
							{
								Name = "Sacatepéquez",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "San Marcos",
								Code = "SM"
							},
							new RegionModel
							{
								Name = "Santa Rosa",
								Code = "SR"
							},
							new RegionModel
							{
								Name = "Sololá",
								Code = "SO"
							},
							new RegionModel
							{
								Name = "Suchitepéquez",
								Code = "SU"
							},
							new RegionModel
							{
								Name = "Totonicapán",
								Code = "TO"
							},
							new RegionModel
							{
								Name = "Zacapa",
								Code = "ZA"
							}
						}
					},
					new CountryModel
					{
						Name = "Guernsey",
						Code = "GG",
						NativeName = "",
						PhoneCode = "+44",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Castel",
								Code = null
							},
							new RegionModel
							{
								Name = "Forest",
								Code = null
							},
							new RegionModel
							{
								Name = "St. Andrew",
								Code = null
							},
							new RegionModel
							{
								Name = "St. Martin",
								Code = null
							},
							new RegionModel
							{
								Name = "St. Peter Port",
								Code = null
							},
							new RegionModel
							{
								Name = "St. Pierre du Bois",
								Code = null
							},
							new RegionModel
							{
								Name = "St. Sampson",
								Code = null
							},
							new RegionModel
							{
								Name = "St. Saviour",
								Code = null
							},
							new RegionModel
							{
								Name = "Torteval",
								Code = null
							},
							new RegionModel
							{
								Name = "Vale",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Guinea",
						Code = "GN",
						NativeName = "Guinée",
						PhoneCode = "+224",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Boké",
								Code = "B"
							},
							new RegionModel
							{
								Name = "Conakry",
								Code = "C"
							},
							new RegionModel
							{
								Name = "Faranah",
								Code = "F"
							},
							new RegionModel
							{
								Name = "Kankan",
								Code = "K"
							},
							new RegionModel
							{
								Name = "Kindia",
								Code = "D"
							},
							new RegionModel
							{
								Name = "Labé",
								Code = "L"
							},
							new RegionModel
							{
								Name = "Mamou",
								Code = "M"
							},
							new RegionModel
							{
								Name = "Nzérékoré",
								Code = "N"
							}
						}
					},
					new CountryModel
					{
						Name = "Guinea-Bissau",
						Code = "GW",
						NativeName = "Guiné-Bissau",
						PhoneCode = "+245",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bafatá",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Biombo",
								Code = "BM"
							},
							new RegionModel
							{
								Name = "Bissau",
								Code = "BS"
							},
							new RegionModel
							{
								Name = "Bolama-Bijagos",
								Code = "BL"
							},
							new RegionModel
							{
								Name = "Cacheu",
								Code = "CA"
							},
							new RegionModel
							{
								Name = "Gabú",
								Code = "GA"
							},
							new RegionModel
							{
								Name = "Oio",
								Code = "OI"
							},
							new RegionModel
							{
								Name = "Quinara",
								Code = "QU"
							},
							new RegionModel
							{
								Name = "Tombali",
								Code = "TO"
							}
						}
					},
					new CountryModel
					{
						Name = "Guyana",
						Code = "GY",
						NativeName = "",
						PhoneCode = "+592",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Barima-Waini",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Cuyuni-Mazaruni",
								Code = "CU"
							},
							new RegionModel
							{
								Name = "Demerara-Mahaica",
								Code = "DE"
							},
							new RegionModel
							{
								Name = "East Berbice-Corentyne",
								Code = "EB"
							},
							new RegionModel
							{
								Name = "Essequibo Islands-West Demerara",
								Code = "ES"
							},
							new RegionModel
							{
								Name = "Mahaica-Berbice",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Pomeroon-Supenaam",
								Code = "PM"
							},
							new RegionModel
							{
								Name = "Potaro-Siparuni",
								Code = "PT"
							},
							new RegionModel
							{
								Name = "Upper Demerara-Berbice",
								Code = "UD"
							},
							new RegionModel
							{
								Name = "Upper Takutu-Upper Essequibo",
								Code = "UT"
							}
						}
					},
					#endregion
					};
					break;
				case 'H':
					countries = new ObservableCollection<CountryModel> { 
					#region H
					new CountryModel
					{
						Name = "Haiti",
						Code = "HT",
						NativeName = "Haïti , Ayiti",
						PhoneCode = "+509",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Artibonite",
								Code = "AR"
							},
							new RegionModel
							{
								Name = "Centre",
								Code = "CE"
							},
							new RegionModel
							{
								Name = "Grand'Anse",
								Code = "GA"
							},
							new RegionModel
							{
								Name = "Nippes",
								Code = "NI"
							},
							new RegionModel
							{
								Name = "Nord",
								Code = "ND"
							},
							new RegionModel
							{
								Name = "Nord-Est",
								Code = "NE"
							},
							new RegionModel
							{
								Name = "Nord-Ouest",
								Code = "NO"
							},
							new RegionModel
							{
								Name = "Ouest",
								Code = "OU"
							},
							new RegionModel
							{
								Name = "Sud",
								Code = "SD"
							},
							new RegionModel
							{
								Name = "Sud-Est",
								Code = "SE"
							}
						}
					},
					new CountryModel
					{
						Name = "Honduras",
						Code = "HN",
						NativeName = "",
						PhoneCode = "+504",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Atlántida",
								Code = "AT"
							},
							new RegionModel
							{
								Name = "Choluteca",
								Code = "CH"
							},
							new RegionModel
							{
								Name = "Colón",
								Code = "CL"
							},
							new RegionModel
							{
								Name = "Comayagua",
								Code = "CM"
							},
							new RegionModel
							{
								Name = "Copán",
								Code = "CP"
							},
							new RegionModel
							{
								Name = "Cortés",
								Code = "CR"
							},
							new RegionModel
							{
								Name = "El Paraíso",
								Code = "EP"
							},
							new RegionModel
							{
								Name = "Francisco Morazán",
								Code = "FM"
							},
							new RegionModel
							{
								Name = "Gracias a Dios",
								Code = "GD"
							},
							new RegionModel
							{
								Name = "Intibucá",
								Code = "IN"
							},
							new RegionModel
							{
								Name = "Islas de la Bahía",
								Code = "IB"
							},
							new RegionModel
							{
								Name = "La Paz",
								Code = "LP"
							},
							new RegionModel
							{
								Name = "Lempira",
								Code = "LE"
							},
							new RegionModel
							{
								Name = "Ocotepeque",
								Code = "OC"
							},
							new RegionModel
							{
								Name = "Olancho",
								Code = "OL"
							},
							new RegionModel
							{
								Name = "Santa Bárbara",
								Code = "SB"
							},
							new RegionModel
							{
								Name = "Valle",
								Code = "VA"
							},
							new RegionModel
							{
								Name = "Yoro",
								Code = "YO"
							}
						}
					},
					new CountryModel
					{
						Name = "Hong Kong",
						Code = "HK",
						NativeName = "香港",
						PhoneCode = "+852",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Hong Kong",
								Code = "HK"
							}
						}
					},
					new CountryModel
					{
						Name = "Hungary",
						Code = "HU",
						NativeName = "Magyarország",
						PhoneCode = "+36",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bács-Kiskun",
								Code = "BK"
							},
							new RegionModel
							{
								Name = "Baranya",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Békés",
								Code = "BE"
							},
							new RegionModel
							{
								Name = "Békéscsaba",
								Code = "BC"
							},
							new RegionModel
							{
								Name = "Borsod-Abauj-Zemplen",
								Code = "BZ"
							},
							new RegionModel
							{
								Name = "Budapest",
								Code = "BU"
							},
							new RegionModel
							{
								Name = "Csongrád",
								Code = "CS"
							},
							new RegionModel
							{
								Name = "Debrecen",
								Code = "DE"
							},
							new RegionModel
							{
								Name = "Dunaújváros",
								Code = "DU"
							},
							new RegionModel
							{
								Name = "Eger",
								Code = "EG"
							},
							new RegionModel
							{
								Name = "Érd",
								Code = "ER"
							},
							new RegionModel
							{
								Name = "Fejér",
								Code = "FE"
							},
							new RegionModel
							{
								Name = "Győr",
								Code = "GY"
							},
							new RegionModel
							{
								Name = "Győr-Moson-Sopron",
								Code = "GS"
							},
							new RegionModel
							{
								Name = "Hajdú-Bihar",
								Code = "HB"
							},
							new RegionModel
							{
								Name = "Heves",
								Code = "HE"
							},
							new RegionModel
							{
								Name = "Hódmezővásárhely",
								Code = "HV"
							},
							new RegionModel
							{
								Name = "Jász-Nagykun-Szolnok",
								Code = "N"
							},
							new RegionModel
							{
								Name = "Kaposvár",
								Code = "KV"
							},
							new RegionModel
							{
								Name = "Kecskemét",
								Code = "KM"
							},
							new RegionModel
							{
								Name = "Komárom-Esztergom",
								Code = "KE"
							},
							new RegionModel
							{
								Name = "Miskolc",
								Code = "MI"
							},
							new RegionModel
							{
								Name = "Nagykanizsa",
								Code = "NK"
							},
							new RegionModel
							{
								Name = "Nógrád",
								Code = "NO"
							},
							new RegionModel
							{
								Name = "Nyíregyháza",
								Code = "NY"
							},
							new RegionModel
							{
								Name = "Pécs",
								Code = "PS"
							},
							new RegionModel
							{
								Name = "Pest",
								Code = "PE"
							},
							new RegionModel
							{
								Name = "Salgótarján",
								Code = "ST"
							},
							new RegionModel
							{
								Name = "Somogy",
								Code = "SO"
							},
							new RegionModel
							{
								Name = "Sopron",
								Code = "SN"
							},
							new RegionModel
							{
								Name = "Szabolcs-á-Bereg",
								Code = "SZ"
							},
							new RegionModel
							{
								Name = "Szeged",
								Code = "SD"
							},
							new RegionModel
							{
								Name = "Székesfehérvár",
								Code = "SF"
							},
							new RegionModel
							{
								Name = "Szekszárd",
								Code = "SS"
							},
							new RegionModel
							{
								Name = "Szolnok",
								Code = "SK"
							},
							new RegionModel
							{
								Name = "Szombathely",
								Code = "SH"
							},
							new RegionModel
							{
								Name = "Tatabánya",
								Code = "TB"
							},
							new RegionModel
							{
								Name = "Tolna",
								Code = "TO"
							},
							new RegionModel
							{
								Name = "Vas",
								Code = "VA"
							},
							new RegionModel
							{
								Name = "Veszprém",
								Code = "VE"
							},
							new RegionModel
							{
								Name = "Veszprém (City)",
								Code = "VM"
							},
							new RegionModel
							{
								Name = "Zala",
								Code = "ZA"
							},
							new RegionModel
							{
								Name = "Zalaegerszeg",
								Code = "ZE"
							}
						}
					},
					#endregion
					};
					break;
				case 'I':
					countries = new ObservableCollection<CountryModel> { 
					#region I
					new CountryModel
					{
						Name = "Iceland",
						Code = "IS",
						NativeName = "Ísland",
						PhoneCode = "+354",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Austurland",
								Code = "7"
							},
							new RegionModel
							{
								Name = "Höfuðborgarsvæði",
								Code = "1"
							},
							new RegionModel
							{
								Name = "Norðurland eystra",
								Code = "6"
							},
							new RegionModel
							{
								Name = "Norðurland vestra",
								Code = "5"
							},
							new RegionModel
							{
								Name = "Suðurland",
								Code = "8"
							},
							new RegionModel
							{
								Name = "Suðurnes",
								Code = "2"
							},
							new RegionModel
							{
								Name = "Vestfirðir",
								Code = "4"
							},
							new RegionModel
							{
								Name = "Vesturland",
								Code = "3"
							}
						}
					},
					new CountryModel
					{
						Name = "India",
						Code = "IN",
						NativeName = "भारत गणराज्य",
						PhoneCode = "+91",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Andaman and Nicobar Islands",
								Code = "AN"
							},
							new RegionModel
							{
								Name = "Andhra Pradesh",
								Code = "AP"
							},
							new RegionModel
							{
								Name = "Arunachal Pradesh",
								Code = "AR"
							},
							new RegionModel
							{
								Name = "Assam",
								Code = "AS"
							},
							new RegionModel
							{
								Name = "Bihar",
								Code = "BR"
							},
							new RegionModel
							{
								Name = "Chandigarh",
								Code = "CH"
							},
							new RegionModel
							{
								Name = "Chhattisgarh",
								Code = "CT"
							},
							new RegionModel
							{
								Name = "Dadra and Nagar Haveli and Daman and Diu",
								Code = "DH"
							},
							new RegionModel
							{
								Name = "Delhi",
								Code = "DL"
							},
							new RegionModel
							{
								Name = "Goa",
								Code = "GA"
							},
							new RegionModel
							{
								Name = "Gujarat",
								Code = "GJ"
							},
							new RegionModel
							{
								Name = "Haryana",
								Code = "HR"
							},
							new RegionModel
							{
								Name = "Himachal Pradesh",
								Code = "HP"
							},
							new RegionModel
							{
								Name = "Jammu and Kashmir",
								Code = "JK"
							},
							new RegionModel
							{
								Name = "Jharkhand",
								Code = "JH"
							},
							new RegionModel
							{
								Name = "Karnataka",
								Code = "KA"
							},
							new RegionModel
							{
								Name = "Kerala",
								Code = "KL"
							},
							new RegionModel
							{
								Name = "Ladakh",
								Code = "LA"
							},
							new RegionModel
							{
								Name = "Lakshadweep",
								Code = "LD"
							},
							new RegionModel
							{
								Name = "Madhya Pradesh",
								Code = "MP"
							},
							new RegionModel
							{
								Name = "Maharashtra",
								Code = "MH"
							},
							new RegionModel
							{
								Name = "Manipur",
								Code = "MN"
							},
							new RegionModel
							{
								Name = "Meghalaya",
								Code = "ML"
							},
							new RegionModel
							{
								Name = "Mizoram",
								Code = "MZ"
							},
							new RegionModel
							{
								Name = "Nagaland",
								Code = "NL"
							},
							new RegionModel
							{
								Name = "Odisha",
								Code = "OR"
							},
							new RegionModel
							{
								Name = "Puducherry",
								Code = "PY"
							},
							new RegionModel
							{
								Name = "Punjab",
								Code = "PB"
							},
							new RegionModel
							{
								Name = "Rajasthan",
								Code = "RJ"
							},
							new RegionModel
							{
								Name = "Sikkim",
								Code = "SK"
							},
							new RegionModel
							{
								Name = "Tamil Nadu",
								Code = "TN"
							},
							new RegionModel
							{
								Name = "Telangana",
								Code = "TG"
							},
							new RegionModel
							{
								Name = "Tripura",
								Code = "TR"
							},
							new RegionModel
							{
								Name = "Uttarakhand",
								Code = "UT"
							},
							new RegionModel
							{
								Name = "Uttar Pradesh",
								Code = "UP"
							},
							new RegionModel
							{
								Name = "West Bengal",
								Code = "WB"
							}
						}
					},
					new CountryModel
					{
						Name = "Indonesia",
						Code = "ID",
						NativeName = "",
						PhoneCode = "+62",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aceh",
								Code = "AC"
							},
							new RegionModel
							{
								Name = "Bali",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Bangka Belitung",
								Code = "BB"
							},
							new RegionModel
							{
								Name = "Banten",
								Code = "BT"
							},
							new RegionModel
							{
								Name = "Bengkulu",
								Code = "BE"
							},
							new RegionModel
							{
								Name = "Gorontalo",
								Code = "GO"
							},
							new RegionModel
							{
								Name = "Jakarta Raya",
								Code = "JK"
							},
							new RegionModel
							{
								Name = "Jambi",
								Code = "JA"
							},
							new RegionModel
							{
							Name = "Jawa Barat",
								Code = "JB"
							},
							new RegionModel
							{
								Name = "Jawa Tengah",
								Code = "JT"
							},
							new RegionModel
							{
								Name = "Jawa Timur",
								Code = "JI"
							},
							new RegionModel
							{
								Name = "Kalimantan Barat",
								Code = "KB"
							},
							new RegionModel
							{
								Name = "Kalimantan Selatan",
								Code = "KS"
							},
							new RegionModel
							{
								Name = "Kalimantan Tengah",
								Code = "KT"
							},
							new RegionModel
							{
								Name = "Kalimantan Timur",
								Code = "KI"
							},
							new RegionModel
							{
								Name = "Kalimantan Utara",
								Code = "KU"
							},
							new RegionModel
							{
								Name = "Kepulauan Riau",
								Code = "KR"
							},
							new RegionModel
							{
								Name = "Lampung",
								Code = "LA"
							},
							new RegionModel
							{
								Name = "Maluku",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Maluku Utara",
								Code = "MU"
							},
							new RegionModel
							{
								Name = "Nusa Tenggara Barat",
								Code = "NB"
							},
							new RegionModel
							{
								Name = "Nusa Tenggara Timur",
								Code = "NT"
							},
							new RegionModel
							{
								Name = "Papua",
								Code = "PA"
							},
							new RegionModel
							{
								Name = "Papua Barat",
								Code = "PB"
							},
							new RegionModel
							{
								Name = "Riau",
								Code = "RI"
							},
							new RegionModel
							{
								Name = "Sulawesi Selatan",
								Code = "SR"
							},
							new RegionModel
							{
								Name = "Sulawesi Tengah",
								Code = "ST"
							},
							new RegionModel
							{
								Name = "Sulawesi Tenggara",
								Code = "SG"
							},
							new RegionModel
							{
								Name = "Sulawesi Utara",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "Sumatera Barat",
								Code = "SB"
							},
							new RegionModel
							{
								Name = "Sumatera Selatan",
								Code = "SS"
							},
							new RegionModel
							{
								Name = "Sumatera Utara",
								Code = "SU"
							},
							new RegionModel
							{
								Name = "Yogyakarta",
								Code = "YO"
							}
						}
					},
					new CountryModel
					{
						Name = "Iran",
						Code = "IR",
						NativeName = "جمهوری اسلامی ایران",
						PhoneCode = "+98",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Alborz",
								Code = "32"
							},
							new RegionModel
							{
								Name = "Ardabīl",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Āz̄arbāyjān-e Gharbī",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Āz̄arbāyjān-e Sharqī",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Būshehr",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Chahār Maḩāl va Bakhtīārī",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Eşfahān",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Fārs",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Gīlān",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Golestān",
								Code = "27"
							},
							new RegionModel
							{
								Name = "Hamadān",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Hormozgān",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Īlām",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Kermān",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Kermānshāh",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Khorāsān-e Jonūbī",
								Code = "29"
							},
							new RegionModel
							{
								Name = "Khorāsān-e Raẕavī",
								Code = "30"
							},
							new RegionModel
							{
								Name = "Khorāsān-e Shomālī",
								Code = "61"
							},
							new RegionModel
							{
								Name = "Khūzestān",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Kohgīlūyeh va Bowyer Aḩmad",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Kordestān",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Lorestān",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Markazi",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Māzandarān",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Qazvīn",
								Code = "28"
							},
							new RegionModel
							{
								Name = "Qom",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Semnān",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Sīstān va Balūchestān",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Tehrān",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Yazd",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Zanjān",
								Code = "11"
							}
						}
					},
					new CountryModel
					{
						Name = "Iraq",
						Code = "IQ",
						NativeName = "جمهورية ألعراق , كۆماريى عێراق",
						PhoneCode = "+964",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Al Anbār",
								Code = "AN"
							},
							new RegionModel
							{
								Name = "Al Başrah",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Al Muthanná",
								Code = "MU"
							},
							new RegionModel
							{
								Name = "Al Qādisīyah",
								Code = "QA"
							},
							new RegionModel
							{
								Name = "An Najaf",
								Code = "NA"
							},
							new RegionModel
							{
								Name = "Arbīl",
								Code = "AR"
							},
							new RegionModel
							{
								Name = "As Sulaymānīyah",
								Code = "SU"
							},
							new RegionModel
							{
								Name = "Bābil",
								Code = "BB"
							},
							new RegionModel
							{
								Name = "Baghdād",
								Code = "BG"
							},
							new RegionModel
							{
								Name = "Dohuk",
								Code = "DA"
							},
							new RegionModel
							{
								Name = "Dhī Qār",
								Code = "DQ"
							},
							new RegionModel
							{
								Name = "Diyālá",
								Code = "DI"
							},
							new RegionModel
							{
								Name = "Karbalā'",
								Code = "KA"
							},
							new RegionModel
							{
								Name = "Kirkuk",
								Code = "KI"
							},
							new RegionModel
							{
								Name = "Maysān",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Nīnawá",
								Code = "NI"
							},
							new RegionModel
							{
								Name = "Şalāḩ ad Dīn",
								Code = "SD"
							},
							new RegionModel
							{
								Name = "Wāsiţ",
								Code = "WA"
							}
						}
					},
					new CountryModel
					{
						Name = "Ireland",
						Code = "IE",
						NativeName = "Éire",
						PhoneCode = "+353",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Carlow",
								Code = "CW"
							},
							new RegionModel
							{
								Name = "Cavan",
								Code = "CN"
							},
							new RegionModel
							{
								Name = "Clare",
								Code = "CE"
							},
							new RegionModel
							{
								Name = "Cork",
								Code = "CO"
							},
							new RegionModel
							{
								Name = "Donegal",
								Code = "DL"
							},
							new RegionModel
							{
								Name = "Dublin",
								Code = "D"
							},
							new RegionModel
							{
								Name = "Galway",
								Code = "G"
							},
							new RegionModel
							{
								Name = "Kerry",
								Code = "KY"
							},
							new RegionModel
							{
								Name = "Kildare",
								Code = "KE"
							},
							new RegionModel
							{
								Name = "Kilkenny",
								Code = "KK"
							},
							new RegionModel
							{
								Name = "Laois",
								Code = "LS"
							},
							new RegionModel
							{
								Name = "Leitrim",
								Code = "LM"
							},
							new RegionModel
							{
								Name = "Limerick",
								Code = "LK"
							},
							new RegionModel
							{
								Name = "Longford",
								Code = "LD"
							},
							new RegionModel
							{
								Name = "Louth",
								Code = "LH"
							},
							new RegionModel
							{
								Name = "Mayo",
								Code = "MO"
							},
							new RegionModel
							{
								Name = "Meath",
								Code = "MH"
							},
							new RegionModel
							{
								Name = "Monaghan",
								Code = "MN"
							},
							new RegionModel
							{
								Name = "Offaly",
								Code = "OY"
							},
							new RegionModel
							{
								Name = "Roscommon",
								Code = "RN"
							},
							new RegionModel
							{
								Name = "Sligo",
								Code = "SO"
							},
							new RegionModel
							{
								Name = "Tipperary",
								Code = "TA"
							},
							new RegionModel
							{
								Name = "Waterford",
								Code = "WD"
							},
							new RegionModel
							{
								Name = "Westmeath",
								Code = "WH"
							},
							new RegionModel
							{
								Name = "Wexford",
								Code = "WX"
							},
							new RegionModel
							{
								Name = "Wicklow",
								Code = "WW"
							}
						}
					},
					new CountryModel
					{
						Name = "Isle of Man",
						Code = "IM",
						NativeName = "Ellan Vannin , Ellan Mannin",
						PhoneCode = "+44",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Isle of Man",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Israel",
						Code = "IL",
						NativeName = "מדינת ישראל , دولة إسرائيل",
						PhoneCode = "+972",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "HaDarom",
								Code = "D"
							},
							new RegionModel
							{
								Name = "HaMerkaz",
								Code = "M"
							},
							new RegionModel
							{
								Name = "HaTsafon",
								Code = "Z"
							},
							new RegionModel
							{
								Name = "H̱efa",
								Code = "HA"
							},
							new RegionModel
							{
								Name = "Tel-Aviv",
								Code = "TA"
							},
							new RegionModel
							{
								Name = "Yerushalayim",
								Code = "JM"
							}
						}
					},
					new CountryModel
					{
						Name = "Italy",
						Code = "IT",
						NativeName = "",
						PhoneCode = "+39",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Abruzzo",
								Code = "65"
							},
							new RegionModel
							{
								Name = "Basilicata",
								Code = "77"
							},
							new RegionModel
							{
								Name = "Calabria",
								Code = "78"
							},
							new RegionModel
							{
								Name = "Campania",
								Code = "72"
							},
							new RegionModel
							{
								Name = "Emilia-Romagna",
								Code = "45"
							},
							new RegionModel
							{
								Name = "Friuli-Venezia Giulia",
								Code = "36"
							},
							new RegionModel
							{
								Name = "Lazio",
								Code = "62"
							},
							new RegionModel
							{
								Name = "Liguria",
								Code = "42"
							},
							new RegionModel
							{
								Name = "Lombardia",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Marche",
								Code = "57"
							},
							new RegionModel
							{
								Name = "Molise",
								Code = "67"
							},
							new RegionModel
							{
								Name = "Piemonte",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Puglia",
								Code = "75"
							},
							new RegionModel
							{
								Name = "Sardegna",
								Code = "88"
							},
							new RegionModel
							{
								Name = "Sicilia",
								Code = "82"
							},
							new RegionModel
							{
								Name = "Toscana",
								Code = "52"
							},
							new RegionModel
							{
								Name = "Trentino-Alto Adige",
								Code = "32"
							},
							new RegionModel
							{
								Name = "Umbria",
								Code = "55"
							},
							new RegionModel
							{
								Name = "Valle d'Aosta",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Veneto",
								Code = "34"
							}
						}
					},
					#endregion
				};
					break;
				case 'J':
					countries = new ObservableCollection<CountryModel> { 
					#region	J
					new CountryModel
					{
						Name = "Jamaica",
						Code = "JM",
						NativeName = "Jumieka",
						PhoneCode = "+1",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Clarendon",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Hanover",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Kingston",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Manchester",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Portland",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Saint Andrew",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Saint Ann",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Saint Catherine",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Saint Elizabeth",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Saint James",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Saint Mary",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Saint Thomas",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Trelawny",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Westmoreland",
								Code = "10"
							}
						}
					},
					new CountryModel
					{
						Name = "Japan",
						Code = "JP",
						NativeName = "日本国",
						PhoneCode = "+81",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aichi",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Akita",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Aomori",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Chiba",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Ehime",
								Code = "38"
							},
							new RegionModel
							{
								Name = "Fukui",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Fukuoka",
								Code = "40"
							},
							new RegionModel
							{
								Name = "Fukushima",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Gifu",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Gunma",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Hiroshima",
								Code = "34"
							},
							new RegionModel
							{
								Name = "Hokkaido",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Hyogo",
								Code = "28"
							},
							new RegionModel
							{
								Name = "Ibaraki",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Ishikawa",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Iwate",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Kagawa",
								Code = "37"
							},
							new RegionModel
							{
								Name = "Kagoshima",
								Code = "46"
							},
							new RegionModel
							{
								Name = "Kanagawa",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Kochi",
								Code = "39"
							},
							new RegionModel
							{
								Name = "Kumamoto",
								Code = "43"
							},
							new RegionModel
							{
								Name = "Kyoto",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Mie",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Miyagi",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Miyazaki",
								Code = "45"
							},
							new RegionModel
							{
								Name = "Nagano",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Nagasaki",
								Code = "42"
							},
							new RegionModel
							{
								Name = "Nara",
								Code = "29"
							},
							new RegionModel
							{
								Name = "Niigata",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Oita",
								Code = "44"
							},
							new RegionModel
							{
								Name = "Okayama",
								Code = "33"
							},
							new RegionModel
							{
								Name = "Okinawa",
								Code = "47"
							},
							new RegionModel
							{
								Name = "Osaka",
								Code = "27"
							},
							new RegionModel
							{
								Name = "Saga",
								Code = "41"
							},
							new RegionModel
							{
								Name = "Saitama",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Shiga",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Shimane",
								Code = "32"
							},
							new RegionModel
							{
								Name = "Shizuoka",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Tochigi",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Tokushima",
								Code = "36"
							},
							new RegionModel
							{
								Name = "Tokyo",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Tottori",
								Code = "31"
							},
							new RegionModel
							{
								Name = "Toyama",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Wakayama",
								Code = "30"
							},
							new RegionModel
							{
								Name = "Yamagata",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Yamaguchi",
								Code = "35"
							},
							new RegionModel
							{
								Name = "Yamanashi",
								Code = "19"
							}
						}
					},
					new CountryModel
					{
						Name = "Jersey",
						Code = "JE",
						NativeName = "Jèrri",
						PhoneCode = "+44",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Jersey",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Jordan",
						Code = "JO",
						NativeName = "المملكة الأردنّيّة الهاشميّة",
						PhoneCode = "+962",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "‘Ajlūn",
								Code = "AJ"
							},
							new RegionModel
							{
								Name = "Al 'Aqabah",
								Code = "AQ"
							},
							new RegionModel
							{
								Name = "Al Balqā’",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Al Karak",
								Code = "KA"
							},
							new RegionModel
							{
								Name = "Al Mafraq",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Al ‘A̅şimah",
								Code = "AM"
							},
							new RegionModel
							{
								Name = "Aţ Ţafīlah",
								Code = "AT"
							},
							new RegionModel
							{
								Name = "Az Zarqā’",
								Code = "AZ"
							},
							new RegionModel
							{
								Name = "Irbid",
								Code = "IR"
							},
							new RegionModel
							{
								Name = "Jarash",
								Code = "JA"
							},
							new RegionModel
							{
								Name = "Ma‘ān",
								Code = "MN"
							},
							new RegionModel
							{
								Name = "Mādabā",
								Code = "MD"
							}
						}
					},
					#endregion
				};
					break;
				case 'K':
					countries = new ObservableCollection<CountryModel> { 
					#region K
					new CountryModel
					{
						Name = "Kazakhstan",
						Code = "KZ",
						NativeName = "Қазақстан Республикасы , Республика Казахстан",
						PhoneCode = "+7",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Almaty",
								Code = "ALA"
							},
							new RegionModel
							{
								Name = "Aqmola",
								Code = "AKM"
							},
							new RegionModel
							{
								Name = "Aqtobe",
								Code = "AKT"
							},
							new RegionModel
							{
								Name = "Astana",
								Code = "AST"
							},
							new RegionModel
							{
								Name = "Atyrau",
								Code = "ATY"
							},
							new RegionModel
							{
								Name = "Batys Qazaqstan",
								Code = "ZAP"
							},
							new RegionModel
							{
								Name = "Bayqongyr",
								Code = null
							},
							new RegionModel
							{
								Name = "Mangghystau",
								Code = "MAN"
							},
							new RegionModel
							{
								Name = "Ongtustik Qazaqstan",
								Code = "YUZ"
							},
							new RegionModel
							{
								Name = "Pavlodar",
								Code = "PAV"
							},
							new RegionModel
							{
								Name = "Qaraghandy",
								Code = "KAR"
							},
							new RegionModel
							{
								Name = "Qostanay",
								Code = "KUS"
							},
							new RegionModel
							{
								Name = "Qyzylorda",
								Code = "KZY"
							},
							new RegionModel
							{
								Name = "Shyghys Qazaqstan",
								Code = "VOS"
							},
							new RegionModel
							{
								Name = "Soltustik Qazaqstan",
								Code = "SEV"
							},
							new RegionModel
							{
								Name = "Zhambyl",
								Code = "ZHA"
							}
						}
					},
					new CountryModel
					{
						Name = "Kenya",
						Code = "KE",
						NativeName = "Kenya",
						PhoneCode = "+254",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Baringo",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Bomet",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Bungoma",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Busia",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Eleyo/Marakwet",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Embu",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Garissa",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Homa Bay",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Isiolo",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Kajiado",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Kakamega",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Kericho",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Kiambu",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Kilifi",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Kirinyaga",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Kisii",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Kisumu",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Kitui",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Kwale",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Laikipia",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Lamu",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Machakos",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Makueni",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Mandera",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Marsabit",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Meru",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Migori",
								Code = "27"
							},
							new RegionModel
							{
								Name = "Mombasa",
								Code = "28"
							},
							new RegionModel
							{
								Name = "Murang'a",
								Code = "29"
							},
							new RegionModel
							{
								Name = "Nairobi City",
								Code = "30"
							},
							new RegionModel
							{
								Name = "Nakuru",
								Code = "31"
							},
							new RegionModel
							{
								Name = "Nandi",
								Code = "32"
							},
							new RegionModel
							{
								Name = "Narok",
								Code = "33"
							},
							new RegionModel
							{
								Name = "Nyamira",
								Code = "34"
							},
							new RegionModel
							{
								Name = "Nyandarua",
								Code = "35"
							},
							new RegionModel
							{
								Name = "Nyeri",
								Code = "36"
							},
							new RegionModel
							{
								Name = "Samburu",
								Code = "37"
							},
							new RegionModel
							{
								Name = "Siaya",
								Code = "38"
							},
							new RegionModel
							{
								Name = "Taita/Taveta",
								Code = "39"
							},
							new RegionModel
							{
								Name = "Tana River",
								Code = "40"
							},
							new RegionModel
							{
								Name = "Tharaka-Nithi",
								Code = "41"
							},
							new RegionModel
							{
								Name = "Trans Nzoia",
								Code = "42"
							},
							new RegionModel
							{
								Name = "Turkana",
								Code = "43"
							},
							new RegionModel
							{
								Name = "Uasin Gishu",
								Code = "44"
							},
							new RegionModel
							{
								Name = "Vihiga",
								Code = "45"
							},
							new RegionModel
							{
								Name = "Wajir",
								Code = "46"
							},
							new RegionModel
							{
								Name = "West Pokot",
								Code = "47"
							}
						}
					},
					new CountryModel
					{
						Name = "Kiribati",
						Code = "KI",
						NativeName = "Kiribati",
						PhoneCode = "+686",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Abaiang",
								Code = null
							},
							new RegionModel
							{
								Name = "Abemama",
								Code = null
							},
							new RegionModel
							{
								Name = "Aranuka",
								Code = null
							},
							new RegionModel
							{
								Name = "Arorae",
								Code = null
							},
							new RegionModel
							{
								Name = "Banaba",
								Code = null
							},
							new RegionModel
							{
								Name = "Beru",
								Code = null
							},
							new RegionModel
							{
								Name = "Butaritari",
								Code = null
							},
							new RegionModel
							{
								Name = "Central Gilberts",
								Code = null
							},
							new RegionModel
							{
								Name = "Gilbert Islands",
								Code = "G"
							},
							new RegionModel
							{
								Name = "Kanton",
								Code = null
							},
							new RegionModel
							{
								Name = "Kiritimati",
								Code = null
							},
							new RegionModel
							{
								Name = "Kuria",
								Code = null
							},
							new RegionModel
							{
								Name = "Line Islands",
								Code = "L"
							},
							new RegionModel
							{
								Name = "Maiana",
								Code = null
							},
							new RegionModel
							{
								Name = "Makin",
								Code = null
							},
							new RegionModel
							{
								Name = "Marakei",
								Code = null
							},
							new RegionModel
							{
								Name = "Nikunau",
								Code = null
							},
							new RegionModel
							{
								Name = "Nonouti",
								Code = null
							},
							new RegionModel
							{
								Name = "Northern Gilberts",
								Code = null
							},
							new RegionModel
							{
								Name = "Onotoa",
								Code = null
							},
							new RegionModel
							{
								Name = "Phoenix Islands",
								Code = "P"
							},
							new RegionModel
							{
								Name = "Southern Gilberts",
								Code = null
							},
							new RegionModel
							{
								Name = "Tabiteuea",
								Code = null
							},
							new RegionModel
							{
								Name = "Tabuaeran",
								Code = null
							},
							new RegionModel
							{
								Name = "Tamana",
								Code = null
							},
							new RegionModel
							{
								Name = "Tarawa",
								Code = null
							},
							new RegionModel
							{
								Name = "Teraina",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Korea",
						Code = "KR",
						NativeName = "대한민국 , 大韓民國",
						PhoneCode = "+82",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ch'ungch'ongbuk-do",
								Code = "43"
							},
							new RegionModel
							{
								Name = "Ch'ungch'ongnam-do",
								Code = "44"
							},
							new RegionModel
							{
								Name = "Cheju-do",
								Code = "49"
							},
							new RegionModel
							{
								Name = "Chollabuk-do",
								Code = "45"
							},
							new RegionModel
							{
								Name = "Chollanam-do",
								Code = "46"
							},
							new RegionModel
							{
								Name = "Inch'on-Kwangyokhi",
								Code = "28"
							},
							new RegionModel
							{
								Name = "Kang-won-do",
								Code = "42"
							},
							new RegionModel
							{
								Name = "Kwangju-Kwangyokshi",
								Code = "29"
							},
							new RegionModel
							{
								Name = "Kyonggi-do",
								Code = "41"
							},
							new RegionModel
							{
								Name = "Kyongsangbuk-do",
								Code = "47"
							},
							new RegionModel
							{
								Name = "Kyongsangnam-do",
								Code = "48"
							},
							new RegionModel
							{
								Name = "Pusan-Kwangyokshi",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Seoul-T'ukpyolshi",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Sejong",
								Code = "50"
							},
							new RegionModel
							{
								Name = "Taegu-Kwangyokshi",
								Code = "27"
							},
							new RegionModel
							{
								Name = "Taejon-Kwangyokshi",
								Code = "30"
							},
							new RegionModel
							{
								Name = "Ulsan-Kwangyokshi",
								Code = "31"
							}
						}
					},
					new CountryModel
					{
						Name = "Kuwait",
						Code = "KW",
						NativeName = " دولة الكويت ",
						PhoneCode = "+965",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Al Aḩmadi",
								Code = "AH"
							},
							new RegionModel
							{
								Name = "Al Farwānīyah",
								Code = "FA"
							},
							new RegionModel
							{
								Name = "Al Jahrā’",
								Code = "JA"
							},
							new RegionModel
							{
								Name = "Al ‘Āşimah",
								Code = "KU"
							},
							new RegionModel
							{
								Name = "Ḩawallī",
								Code = "HA"
							},
							new RegionModel
							{
								Name = "Mubārak al Kabir",
								Code = "MU"
							}
						}
					},
					new CountryModel
					{
						Name = "Kyrgyzstan",
						Code = "KG",
						NativeName = "Кыргыз Республикасы , Кыргызская Республика",
						PhoneCode = "+996",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Batken Oblasty",
								Code = "B"
							},
							new RegionModel
							{
								Name = "Bishkek Shaary",
								Code = "GB"
							},
							new RegionModel
							{
								Name = "Chuy Oblasty (Bishkek)",
								Code = "C"
							},
							new RegionModel
							{
								Name = "Jalal-Abad Oblasty",
								Code = "J"
							},
							new RegionModel
							{
								Name = "Naryn Oblasty",
								Code = "N"
							},
							new RegionModel
							{
								Name = "Osh Oblasty",
								Code = "O"
							},
							new RegionModel
							{
								Name = "Talas Oblasty",
								Code = "T"
							},
							new RegionModel
							{
								Name = "Ysyk-Kol Oblasty (Karakol)",
								Code = "Y"
							}
						}
					},
					#endregion
					};
					break;
				case 'L':
					countries = new ObservableCollection<CountryModel> { 
					#region L
					new CountryModel
					{
						Name = "Laos",
						Code = "LA",
						NativeName = "ສາທາລະນະລັດປະຊາທິປະໄຕ ປະຊາຊົນລາວ",
						PhoneCode = "+856",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Attapu",
								Code = "AT"
							},
							new RegionModel
							{
								Name = "Bokèo",
								Code = "BK"
							},
							new RegionModel
							{
								Name = "Bolikhamxai",
								Code = "BL"
							},
							new RegionModel
							{
								Name = "Champasak",
								Code = "CH"
							},
							new RegionModel
							{
								Name = "Houaphan",
								Code = "HO"
							},
							new RegionModel
							{
								Name = "Khammouan",
								Code = "KH"
							},
							new RegionModel
							{
								Name = "Louang Namtha",
								Code = "LM"
							},
							new RegionModel
							{
								Name = "Louangphabang",
								Code = "LP"
							},
							new RegionModel
							{
								Name = "Oudômxai",
								Code = "OU"
							},
							new RegionModel
							{
								Name = "Phôngsali",
								Code = "PH"
							},
							new RegionModel
							{
								Name = "Salavan",
								Code = "SL"
							},
							new RegionModel
							{
								Name = "Savannakhét",
								Code = "SV"
							},
							new RegionModel
							{
								Name = "Vientiane",
								Code = "VI"
							},
							new RegionModel
							{
								Name = "Xaignabouli",
								Code = "XA"
							},
							new RegionModel
							{
								Name = "Xékong",
								Code = "XE"
							},
							new RegionModel
							{
								Name = "Xaisomboun",
								Code = "XS"
							},
							new RegionModel
							{
								Name = "Xiangkhouang",
								Code = "XI"
							}
						}
					},
					new CountryModel
					{
						Name = "Latvia",
						Code = "LV",
						NativeName = "Latvijas Republika",
						PhoneCode = "+371",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aglona",
								Code = "001"
							},
							new RegionModel
							{
								Name = "Aizkraukle",
								Code = "002"
							},
							new RegionModel
							{
								Name = "Aizpute",
								Code = "003"
							},
							new RegionModel
							{
								Name = "Aknīste",
								Code = "004"
							},
							new RegionModel
							{
								Name = "Aloja",
								Code = "005"
							},
							new RegionModel
							{
								Name = "Alsunga",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Alūksne",
								Code = "007"
							},
							new RegionModel
							{
								Name = "Amata",
								Code = "008"
							},
							new RegionModel
							{
								Name = "Ape",
								Code = "009"
							},
							new RegionModel
							{
								Name = "Auce",
								Code = "010"
							},
							new RegionModel
							{
								Name = "Ādaži",
								Code = "011"
							},
							new RegionModel
							{
								Name = "Babīte",
								Code = "012"
							},
							new RegionModel
							{
								Name = "Baldone",
								Code = "013"
							},
							new RegionModel
							{
								Name = "Baltinava",
								Code = "014"
							},
							new RegionModel
							{
								Name = "Balvi",
								Code = "015"
							},
							new RegionModel
							{
								Name = "Bauska",
								Code = "016"
							},
							new RegionModel
							{
								Name = "Beverīna",
								Code = "017"
							},
							new RegionModel
							{
								Name = "Brocēni",
								Code = "018"
							},
							new RegionModel
							{
								Name = "Burtnieki",
								Code = "019"
							},
							new RegionModel
							{
								Name = "Carnikava",
								Code = "020"
							},
							new RegionModel
							{
								Name = "Cesvaine",
								Code = "021"
							},
							new RegionModel
							{
								Name = "Cēsis",
								Code = "022"
							},
							new RegionModel
							{
								Name = "Cibla",
								Code = "023"
							},
							new RegionModel
							{
								Name = "Dagda",
								Code = "024"
							},
							new RegionModel
							{
								Name = "Daugavpils",
								Code = "025"
							},
							new RegionModel
							{
								Name = "Daugavpils (City)",
								Code = "DGV"
							},
							new RegionModel
							{
								Name = "Dobele",
								Code = "026"
							},
							new RegionModel
							{
								Name = "Dundaga",
								Code = "027"
							},
							new RegionModel
							{
								Name = "Durbe",
								Code = "028"
							},
							new RegionModel
							{
								Name = "Engure",
								Code = "029"
							},
							new RegionModel
							{
								Name = "Ērgļi",
								Code = "030"
							},
							new RegionModel
							{
								Name = "Garkalne",
								Code = "031"
							},
							new RegionModel
							{
								Name = "Grobiņa",
								Code = "032"
							},
							new RegionModel
							{
								Name = "Gulbene",
								Code = "033"
							},
							new RegionModel
							{
								Name = "Iecava",
								Code = "034"
							},
							new RegionModel
							{
								Name = "Ikšķile",
								Code = "035"
							},
							new RegionModel
							{
								Name = "Ilūkste",
								Code = "036"
							},
							new RegionModel
							{
								Name = "Inčukalns",
								Code = "037"
							},
							new RegionModel
							{
								Name = "Jaunjelgava",
								Code = "038"
							},
							new RegionModel
							{
								Name = "Jaunpiebalga",
								Code = "039"
							},
							new RegionModel
							{
								Name = "Jaunpils",
								Code = "040"
							},
							new RegionModel
							{
								Name = "Jelgava",
								Code = "041"
							},
							new RegionModel
							{
								Name = "Jelgava (City)",
								Code = "JEL"
							},
							new RegionModel
							{
								Name = "Jēkabpils",
								Code = "042"
							},
							new RegionModel
							{
								Name = "Jēkabpils (City)",
								Code = "JKB"
							},
							new RegionModel
							{
								Name = "Jūrmala (City)",
								Code = "JUR"
							},
							new RegionModel
							{
								Name = "Kandava",
								Code = "043"
							},
							new RegionModel
							{
								Name = "Kārsava",
								Code = "044"
							},
							new RegionModel
							{
								Name = "Kocēni",
								Code = "045"
							},
							new RegionModel
							{
								Name = "Koknese",
								Code = "046"
							},
							new RegionModel
							{
								Name = "Krāslava",
								Code = "047"
							},
							new RegionModel
							{
								Name = "Krimulda",
								Code = "048"
							},
							new RegionModel
							{
								Name = "Krustpils",
								Code = "049"
							},
							new RegionModel
							{
								Name = "Kuldīga",
								Code = "050"
							},
							new RegionModel
							{
								Name = "Ķegums",
								Code = "051"
							},
							new RegionModel
							{
								Name = "Ķekava",
								Code = "052"
							},
							new RegionModel
							{
								Name = "Lielvārde",
								Code = "053"
							},
							new RegionModel
							{
								Name = "Liepāja",
								Code = "LPX"
							},
							new RegionModel
							{
								Name = "Limbaži",
								Code = "054"
							},
							new RegionModel
							{
								Name = "Līgatne",
								Code = "055"
							},
							new RegionModel
							{
								Name = "Līvāni",
								Code = "056"
							},
							new RegionModel
							{
								Name = "Lubāna",
								Code = "057"
							},
							new RegionModel
							{
								Name = "Ludza",
								Code = "058"
							},
							new RegionModel
							{
								Name = "Madona",
								Code = "059"
							},
							new RegionModel
							{
								Name = "Mazsalaca",
								Code = "060"
							},
							new RegionModel
							{
								Name = "Mālpils",
								Code = "061"
							},
							new RegionModel
							{
								Name = "Mārupe",
								Code = "062"
							},
							new RegionModel
							{
								Name = "Mērsrags",
								Code = "063"
							},
							new RegionModel
							{
								Name = "Naukšēni",
								Code = "064"
							},
							new RegionModel
							{
								Name = "Nereta",
								Code = "065"
							},
							new RegionModel
							{
								Name = "Nīca",
								Code = "066"
							},
							new RegionModel
							{
								Name = "Ogre",
								Code = "067"
							},
							new RegionModel
							{
								Name = "Olaine",
								Code = "068"
							},
							new RegionModel
							{
								Name = "Ozolnieki",
								Code = "069"
							},
							new RegionModel
							{
								Name = "Pārgauja",
								Code = "070"
							},
							new RegionModel
							{
								Name = "Pāvilosta",
								Code = "071"
							},
							new RegionModel
							{
								Name = "Pļaviņas",
								Code = "072"
							},
							new RegionModel
							{
								Name = "Preiļi",
								Code = "073"
							},
							new RegionModel
							{
								Name = "Priekule",
								Code = "074"
							},
							new RegionModel
							{
								Name = "Priekuļi",
								Code = "075"
							},
							new RegionModel
							{
								Name = "Rauna",
								Code = "076"
							},
							new RegionModel
							{
								Name = "Rēzekne",
								Code = "077"
							},
							new RegionModel
							{
								Name = "Rēzekne (City)",
								Code = "REZ"
							},
							new RegionModel
							{
								Name = "Riebiņi",
								Code = "078"
							},
							new RegionModel
							{
								Name = "Rīga",
								Code = "RIX"
							},
							new RegionModel
							{
								Name = "Roja",
								Code = "079"
							},
							new RegionModel
							{
								Name = "Ropaži",
								Code = "080"
							},
							new RegionModel
							{
								Name = "Rucava",
								Code = "081"
							},
							new RegionModel
							{
								Name = "Rugāji",
								Code = "082"
							},
							new RegionModel
							{
								Name = "Rundāle",
								Code = "083"
							},
							new RegionModel
							{
								Name = "Rūjiena",
								Code = "084"
							},
							new RegionModel
							{
								Name = "Sala",
								Code = "085"
							},
							new RegionModel
							{
								Name = "Salacgrīva",
								Code = "086"
							},
							new RegionModel
							{
								Name = "Salaspils",
								Code = "087"
							},
							new RegionModel
							{
								Name = "Saldus",
								Code = "088"
							},
							new RegionModel
							{
								Name = "Saulkrasti",
								Code = "089"
							},
							new RegionModel
							{
								Name = "Sēja",
								Code = "090"
							},
							new RegionModel
							{
								Name = "Sigulda",
								Code = "091"
							},
							new RegionModel
							{
								Name = "Skrīveri",
								Code = "092"
							},
							new RegionModel
							{
								Name = "Skrunda",
								Code = "093"
							},
							new RegionModel
							{
								Name = "Smiltene",
								Code = "094"
							},
							new RegionModel
							{
								Name = "Stopiņi",
								Code = "095"
							},
							new RegionModel
							{
								Name = "Strenči",
								Code = "096"
							},
							new RegionModel
							{
								Name = "Talsi",
								Code = "097"
							},
							new RegionModel
							{
								Name = "Tērvete",
								Code = "098"
							},
							new RegionModel
							{
								Name = "Tukums",
								Code = "099"
							},
							new RegionModel
							{
								Name = "Vaiņode",
								Code = "100"
							},
							new RegionModel
							{
								Name = "Valka",
								Code = "101"
							},
							new RegionModel
							{
								Name = "Valmiera",
								Code = "VMR"
							},
							new RegionModel
							{
								Name = "Varakļāni",
								Code = "102"
							},
							new RegionModel
							{
								Name = "Vārkava",
								Code = "103"
							},
							new RegionModel
							{
								Name = "Vecpiebalga",
								Code = "104"
							},
							new RegionModel
							{
								Name = "Vecumnieki",
								Code = "105"
							},
							new RegionModel
							{
								Name = "Ventspils",
								Code = "106"
							},
							new RegionModel
							{
								Name = "Ventspils (City)",
								Code = "VEN"
							},
							new RegionModel
							{
								Name = "Viesīte",
								Code = "107"
							},
							new RegionModel
							{
								Name = "Viļaka",
								Code = "108"
							},
							new RegionModel
							{
								Name = "Viļāni",
								Code = "109"
							},
							new RegionModel
							{
								Name = "Zilupe",
								Code = "110"
							}
						}
					},
					new CountryModel
					{
						Name = "Lebanon",
						Code = "LB",
						NativeName = "République libanaise , الجمهورية اللبنانية",
						PhoneCode = "+961",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aakkâr",
								Code = "AK"
							},
							new RegionModel
							{
								Name = "Baalbelk-Hermel",
								Code = "BH"
							},
							new RegionModel
							{
								Name = "Béqaa",
								Code = "BI"
							},
							new RegionModel
							{
								Name = "Beyrouth",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Liban-Nord",
								Code = "AS"
							},
							new RegionModel
							{
								Name = "Liban-Sud",
								Code = "JA"
							},
							new RegionModel
							{
								Name = "Mont-Liban",
								Code = "JL"
							},
							new RegionModel
							{
								Name = "Nabatîyé",
								Code = "NA"
							}
						}
					},
					new CountryModel
					{
						Name = "Lesotho",
						Code = "LS",
						NativeName = "",
						PhoneCode = "+266",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Berea",
								Code = "D"
							},
							new RegionModel
							{
								Name = "Butha-Buthe",
								Code = "B"
							},
							new RegionModel
							{
								Name = "Leribe",
								Code = "C"
							},
							new RegionModel
							{
								Name = "Mafeteng",
								Code = "E"
							},
							new RegionModel
							{
								Name = "Maseru",
								Code = "A"
							},
							new RegionModel
							{
								Name = "Mohales Hoek",
								Code = "F"
							},
							new RegionModel
							{
								Name = "Mokhotlong",
								Code = "J"
							},
							new RegionModel
							{
								Name = "Qacha's Nek",
								Code = "H"
							},
							new RegionModel
							{
								Name = "Quthing",
								Code = "G"
							},
							new RegionModel
							{
								Name = "Thaba-Tseka",
								Code = "K"
							}
						}
					},
					new CountryModel
					{
						Name = "Liberia",
						Code = "LR",
						NativeName = "",
						PhoneCode = "+231",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bomi",
								Code = "BM"
							},
							new RegionModel
							{
								Name = "Bong",
								Code = "BG"
							},
							new RegionModel
							{
								Name = "Gbarpolu",
								Code = "GP"
							},
							new RegionModel
							{
								Name = "Grand Bassa",
								Code = "GB"
							},
							new RegionModel
							{
								Name = "Grand Cape Mount",
								Code = "CM"
							},
							new RegionModel
							{
								Name = "Grand Gedeh",
								Code = "GG"
							},
							new RegionModel
							{
								Name = "Grand Kru",
								Code = "GK"
							},
							new RegionModel
							{
								Name = "Lofa",
								Code = "LO"
							},
							new RegionModel
							{
								Name = "Margibi",
								Code = "MG"
							},
							new RegionModel
							{
								Name = "Maryland",
								Code = "MY"
							},
							new RegionModel
							{
								Name = "Montserrado",
								Code = "MO"
							},
							new RegionModel
							{
								Name = "Nimba",
								Code = "NI"
							},
							new RegionModel
							{
								Name = "River Cess",
								Code = "RI"
							},
							new RegionModel
							{
								Name = "River Geee",
								Code = "RG"
							},
							new RegionModel
							{
								Name = "Sinoe",
								Code = "SI"
							}
						}
					},
					new CountryModel
					{
						Name = "Libya",
						Code = "LY",
						NativeName = "Awanak en Libu , دولة ليبيا",
						PhoneCode = "+218",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Al Buţnān",
								Code = "BU"
							},
							new RegionModel
							{
								Name = "Al Jabal al Akhḑar",
								Code = "JA"
							},
							new RegionModel
							{
								Name = "Al Jabal al Gharbī",
								Code = "JG"
							},
							new RegionModel
							{
								Name = "Al Jafārah",
								Code = "JI"
							},
							new RegionModel
							{
								Name = "Al Jufrah",
								Code = "JU"
							},
							new RegionModel
							{
								Name = "Al Kufrah",
								Code = "FK"
							},
							new RegionModel
							{
								Name = "Al Marj",
								Code = "MJ"
							},
							new RegionModel
							{
								Name = "Al Marquab",
								Code = "MB"
							},
							new RegionModel
							{
								Name = "Al Wāḩāt",
								Code = "WA"
							},
							new RegionModel
							{
								Name = "An Nuqaţ al Khams",
								Code = "NQ"
							},
							new RegionModel
							{
								Name = "Az Zāwiyah",
								Code = "ZA"
							},
							new RegionModel
							{
								Name = "Banghāzī",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Darnah",
								Code = "DR"
							},
							new RegionModel
							{
								Name = "Ghāt",
								Code = "GH"
							},
							new RegionModel
							{
								Name = "Mişrātah",
								Code = "MI"
							},
							new RegionModel
							{
								Name = "Murzuq",
								Code = "MQ"
							},
							new RegionModel
							{
								Name = "Nālūt",
								Code = "NL"
							},
							new RegionModel
							{
								Name = "Sabhā",
								Code = "SB"
							},
							new RegionModel
							{
								Name = "Surt",
								Code = "SR"
							},
							new RegionModel
							{
								Name = "Ţarābulus",
								Code = "TB"
							},
							new RegionModel
							{
								Name = "Yafran",
								Code = "WD"
							},
							new RegionModel
							{
								Name = "Wādī ash Shāţiʾ",
								Code = "WS"
							}
						}
					},
					new CountryModel
					{
						Name = "Liechtenstein",
						Code = "LI",
						NativeName = "",
						PhoneCode = "+423",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Balzers",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Eschen",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Gamprin",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Mauren",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Planken",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Ruggell",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Schaan",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Schellenberg",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Triesen",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Triesenberg",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Vaduz",
								Code = "11"
							}
						}
					},
					new CountryModel
					{
						Name = "Lithuania",
						Code = "LT",
						NativeName = "Lietuva",
						PhoneCode = "+370",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Alytaus",
								Code = "AL"
							},
							new RegionModel
							{
								Name = "Kauno",
								Code = "KU"
							},
							new RegionModel
							{
								Name = "Klaipėdos",
								Code = "KL"
							},
							new RegionModel
							{
								Name = "Marijampolės",
								Code = "MR"
							},
							new RegionModel
							{
								Name = "Panevėžio",
								Code = "PN"
							},
							new RegionModel
							{
								Name = "Šiaulių",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "Tauragės",
								Code = "TA"
							},
							new RegionModel
							{
								Name = "Telšių",
								Code = "TE"
							},
							new RegionModel
							{
								Name = "Utenos",
								Code = "UT"
							},
							new RegionModel
							{
								Name = "Vilniaus",
								Code = "VL"
							}
						}
					},
					new CountryModel
					{
						Name = "Luxembourg",
						Code = "LU",
						NativeName = "Lëtzebuerg , Luxemburg",
						PhoneCode = "+352",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Capellen",
								Code = "CA"
							},
							new RegionModel
							{
								Name = "Clevaux",
								Code = "CL"
							},
							new RegionModel
							{
								Name = "Diekirch",
								Code = "DI"
							},
							new RegionModel
							{
								Name = "Echternach",
								Code = "EC"
							},
							new RegionModel
							{
								Name = "Esch-sur-Alzette",
								Code = "ES"
							},
							new RegionModel
							{
								Name = "Grevenmacher",
								Code = "GR"
							},
							new RegionModel
							{
								Name = "Luxembourg",
								Code = "LU"
							},
							new RegionModel
							{
								Name = "Mersch",
								Code = "ME"
							},
							new RegionModel
							{
								Name = "Redange",
								Code = "RD"
							},
							new RegionModel
							{
								Name = "Remich",
								Code = "RM"
							},
							new RegionModel
							{
								Name = "Vianden",
								Code = "VD"
							},
							new RegionModel
							{
								Name = "Wiltz",
								Code = "WI"
							}
						}
					},
					#endregion
					};
					break;
				case 'M':
					countries = new ObservableCollection<CountryModel> { 
					#region M
					new CountryModel
					{
						Name = "Macao",
						Code = "MO",
						NativeName = "澳門 , 澳门 , Macau",
						PhoneCode = "+853",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Macao",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Macedonia (FYROM)",
						Code = "MK",
						NativeName = "Северна Македонија , Maqedonisë së Veriut",
						PhoneCode = "+389",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aračinovo",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Berovo",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Bitola",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Bogdanci",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Bogovinje",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Bosilovo",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Brvenica",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Centar Župa",
								Code = "78"
							},
							new RegionModel
							{
								Name = "Čaška",
								Code = "80"
							},
							new RegionModel
							{
								Name = "Češinovo-Obleševo",
								Code = "81"
							},
							new RegionModel
							{
								Name = "Čučer Sandevo",
								Code = "82"
							},
							new RegionModel
							{
								Name = "Debar",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Debarca",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Delčevo",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Demir Hisar",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Demir Kapija",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Doran",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Dolneni",
								Code = "27"
							},
							new RegionModel
							{
								Name = "Gevgelija",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Gostivar",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Gradsko",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Ilinden",
								Code = "34"
							},
							new RegionModel
							{
								Name = "Jegunovce",
								Code = "35"
							},
							new RegionModel
							{
								Name = "Karbinci",
								Code = "37"
							},
							new RegionModel
							{
								Name = "Kavadarci",
								Code = "36"
							},
							new RegionModel
							{
								Name = "Kičevo",
								Code = "40"
							},
							new RegionModel
							{
								Name = "Kočani",
								Code = "42"
							},
							new RegionModel
							{
								Name = "Konče",
								Code = "41"
							},
							new RegionModel
							{
								Name = "Kratovo",
								Code = "43"
							},
							new RegionModel
							{
								Name = "Kriva Palanka",
								Code = "44"
							},
							new RegionModel
							{
								Name = "Krivogaštani",
								Code = "45"
							},
							new RegionModel
							{
								Name = "Kruševo",
								Code = "46"
							},
							new RegionModel
							{
								Name = "Kumanovo",
								Code = "47"
							},
							new RegionModel
							{
								Name = "Lipkovo",
								Code = "48"
							},
							new RegionModel
							{
								Name = "Lozovo",
								Code = "49"
							},
							new RegionModel
							{
								Name = "Makedonska Kamenica",
								Code = "51"
							},
							new RegionModel
							{
								Name = "Makedonski Brod",
								Code = "52"
							},
							new RegionModel
							{
								Name = "Mavrovo i Rostuša",
								Code = "50"
							},
							new RegionModel
							{
								Name = "Mogila",
								Code = "53"
							},
							new RegionModel
							{
								Name = "Negotino",
								Code = "54"
							},
							new RegionModel
							{
								Name = "Novaci",
								Code = "55"
							},
							new RegionModel
							{
								Name = "Novo Selo",
								Code = "56"
							},
							new RegionModel
							{
								Name = "Ohrid",
								Code = "58"
							},
							new RegionModel
							{
								Name = "Pehčevo",
								Code = "60"
							},
							new RegionModel
							{
								Name = "Petrovec",
								Code = "59"
							},
							new RegionModel
							{
								Name = "Plasnica",
								Code = "61"
							},
							new RegionModel
							{
								Name = "Prilep",
								Code = "62"
							},
							new RegionModel
							{
								Name = "Probištip",
								Code = "63"
							},
							new RegionModel
							{
								Name = "Radoviš",
								Code = ""
							},
							new RegionModel
							{
								Name = "Rankovce",
								Code = "65"
							},
							new RegionModel
							{
								Name = "Resen",
								Code = "66"
							},
							new RegionModel
							{
								Name = "Rosoman",
								Code = "67"
							},
							new RegionModel
							{
								Name = "Skopje",
								Code = "85"
							},
							new RegionModel
							{
								Name = "Sopište",
								Code = "70"
							},
							new RegionModel
							{
								Name = "Staro Nagoričane",
								Code = "71"
							},
							new RegionModel
							{
								Name = "Struga",
								Code = "72"
							},
							new RegionModel
							{
								Name = "Strumica",
								Code = "73"
							},
							new RegionModel
							{
								Name = "Studeničani",
								Code = "74"
							},
							new RegionModel
							{
								Name = "Sveti Nikole",
								Code = "69"
							},
							new RegionModel
							{
								Name = "Štip",
								Code = "83"
							},
							new RegionModel
							{
								Name = "Tearce",
								Code = "75"
							},
							new RegionModel
							{
								Name = "Tetovo",
								Code = "76"
							},
							new RegionModel
							{
								Name = "Valandovo",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Vasilevo",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Veles",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Vevčani",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Vinica",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Vrapčište",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Zelenikovo",
								Code = "32"
							},
							new RegionModel
							{
								Name = "Zrnovci",
								Code = "33"
							},
							new RegionModel
							{
								Name = "Želino",
								Code = "30"
							}
						}
					},
					new CountryModel
					{
						Name = "Madagascar",
						Code = "MG",
						NativeName = "Madagasikara",
						PhoneCode = "+261",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Antananarivo",
								Code = "T"
							},
							new RegionModel
							{
								Name = "Antsiranana",
								Code = "D"
							},
							new RegionModel
							{
								Name = "Fianarantsoa",
								Code = "F"
							},
							new RegionModel
							{
								Name = "Mahajanga",
								Code = "M"
							},
							new RegionModel
							{
								Name = "Toamasina",
								Code = "A"
							},
							new RegionModel
							{
								Name = "Toliara",
								Code = "U"
							}
						}
					},
					new CountryModel
					{
						Name = "Malawi",
						Code = "MW",
						NativeName = "Malaŵi",
						PhoneCode = "+265",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Balaka",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Blantyre",
								Code = "BL"
							},
							new RegionModel
							{
								Name = "Chikwawa",
								Code = "CK"
							},
							new RegionModel
							{
								Name = "Chiradzulu",
								Code = "CR"
							},
							new RegionModel
							{
								Name = "Chitipa",
								Code = "CT"
							},
							new RegionModel
							{
								Name = "Dedza",
								Code = "DE"
							},
							new RegionModel
							{
								Name = "Dowa",
								Code = "DO"
							},
							new RegionModel
							{
								Name = "Karonga",
								Code = "KR"
							},
							new RegionModel
							{
								Name = "Kasungu",
								Code = "KS"
							},
							new RegionModel
							{
								Name = "Likoma",
								Code = "LK"
							},
							new RegionModel
							{
								Name = "Lilongwe",
								Code = "LI"
							},
							new RegionModel
							{
								Name = "Machinga",
								Code = "MH"
							},
							new RegionModel
							{
								Name = "Mangochi",
								Code = "MG"
							},
							new RegionModel
							{
								Name = "Mchinji",
								Code = "MC"
							},
							new RegionModel
							{
								Name = "Mulanje",
								Code = "MU"
							},
							new RegionModel
							{
								Name = "Mwanza",
								Code = "MW"
							},
							new RegionModel
							{
								Name = "Mzimba",
								Code = "MZ"
							},
							new RegionModel
							{
								Name = "Nkhata Bay",
								Code = "NE"
							},
							new RegionModel
							{
								Name = "Nkhotakota",
								Code = "NB"
							},
							new RegionModel
							{
								Name = "Nsanje",
								Code = "NS"
							},
							new RegionModel
							{
								Name = "Ntcheu",
								Code = "NU"
							},
							new RegionModel
							{
								Name = "Ntchisi",
								Code = "NI"
							},
							new RegionModel
							{
								Name = "Phalombe",
								Code = "PH"
							},
							new RegionModel
							{
								Name = "Rumphi",
								Code = "RU"
							},
							new RegionModel
							{
								Name = "Salima",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "Thyolo",
								Code = "TH"
							},
							new RegionModel
							{
								Name = "Zomba",
								Code = "ZO"
							}
						}
					},
					new CountryModel
					{
						Name = "Malaysia",
						Code = "MY",
						NativeName = "مليسيا",
						PhoneCode = "+60",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Johor",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Kedah",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Kelantan",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Melaka",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Negeri Sembilan",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Pahang",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Perak",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Perlis",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Pulau Pinang",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Sabah",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Sarawak",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Selangor",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Terengganu",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Wilayah Persekutuan (Kuala Lumpur)",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Wilayah Persekutuan (Labuan)",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Wilayah Persekutuan (Putrajaya)",
								Code = "16"
							}
						}
					},
					new CountryModel
					{
						Name = "Maldives",
						Code = "MV",
						NativeName = "ދިވެހިރާއްޖޭގެ ޖުމުހޫރިއްޔާ",
						PhoneCode = "+960",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Alifu Alifu",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Alifu Dhaalu",
								Code = "00"
							},
							new RegionModel
							{
								Name = "Baa",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Dhaalu",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Faafu",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Gaafu Alifu",
								Code = "27"
							},
							new RegionModel
							{
								Name = "Gaafu Dhaalu",
								Code = "28"
							},
							new RegionModel
							{
								Name = "Gnaviyani",
								Code = "29"
							},
							new RegionModel
							{
								Name = "Haa Alifu",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Haa Dhaalu",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Kaafu",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Laamu",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Lhaviyani",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Malé",
								Code = "MLE"
							},
							new RegionModel
							{
								Name = "Meemu",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Noonu",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Raa",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Seenu",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Shaviyani",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Thaa",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Vaavu",
								Code = "04"
							}
						}
					},
					new CountryModel
					{
						Name = "Mali",
						Code = "ML",
						NativeName = "",
						PhoneCode = "+223",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bamako",
								Code = "BKO"
							},
							new RegionModel
							{
								Name = "Gao",
								Code = "7"
							},
							new RegionModel
							{
								Name = "Kayes",
								Code = "1"
							},
							new RegionModel
							{
								Name = "Kidal",
								Code = "8"
							},
							new RegionModel
							{
								Name = "Koulikoro",
								Code = "2"
							},
							new RegionModel
							{
								Name = "Mopti",
								Code = "5"
							},
							new RegionModel
							{
								Name = "Segou",
								Code = "4"
							},
							new RegionModel
							{
								Name = "Sikasso",
								Code = "3"
							},
							new RegionModel
							{
								Name = "Tombouctou",
								Code = "6"
							},
							new RegionModel
							{
								Name = "Taoudénit",
								Code = "9"
							},
							new RegionModel
							{
								Name = "Ménaka",
								Code = "10"
							}
						}
					},
					new CountryModel
					{
						Name = "Malta",
						Code = "MT",
						NativeName = "",
						PhoneCode = "+356",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Attard",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Balzan",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Birgu",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Birkirkara",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Birżebbuġa",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Bormla",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Dingli",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Fgura",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Floriana",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Fontana",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Guda",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Gżira",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Għajnsielem",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Għarb",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Għargħur",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Għasri",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Għaxaq",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Ħamrun",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Iklin",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Isla",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Kalkara",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Kerċem",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Kirkop",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Lija",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Luqa",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Marsa",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Marsaskala",
								Code = "27"
							},
							new RegionModel
							{
								Name = "Marsaxlokk",
								Code = "28"
							},
							new RegionModel
							{
								Name = "Mdina",
								Code = "29"
							},
							new RegionModel
							{
								Name = "Mellieħa",
								Code = "30"
							},
							new RegionModel
							{
								Name = "Mġarr",
								Code = "31"
							},
							new RegionModel
							{
								Name = "Mosta",
								Code = "32"
							},
							new RegionModel
							{
								Name = "Mqabba",
								Code = "33"
							},
							new RegionModel
							{
								Name = "Msida",
								Code = "34"
							},
							new RegionModel
							{
								Name = "Mtarfa",
								Code = "35"
							},
							new RegionModel
							{
								Name = "Munxar",
								Code = "36"
							},
							new RegionModel
							{
								Name = "Nadur",
								Code = "37"
							},
							new RegionModel
							{
								Name = "Naxxar",
								Code = "38"
							},
							new RegionModel
							{
								Name = "Paola",
								Code = "39"
							},
							new RegionModel
							{
								Name = "Pembroke",
								Code = "40"
							},
							new RegionModel
							{
								Name = "Pietà",
								Code = "41"
							},
							new RegionModel
							{
								Name = "Qala",
								Code = "42"
							},
							new RegionModel
							{
								Name = "Qormi",
								Code = "43"
							},
							new RegionModel
							{
								Name = "Qrendi",
								Code = "44"
							},
							new RegionModel
							{
								Name = "Rabat Għawdex",
								Code = "45"
							},
							new RegionModel
							{
								Name = "Rabat Malta",
								Code = "46"
							},
							new RegionModel
							{
								Name = "Safi",
								Code = "47"
							},
							new RegionModel
							{
								Name = "San Ġiljan",
								Code = "48"
							},
							new RegionModel
							{
								Name = "San Ġwann",
								Code = "49"
							},
							new RegionModel
							{
								Name = "San Lawrenz",
								Code = "50"
							},
							new RegionModel
							{
								Name = "San Pawl il-Baħar",
								Code = "51"
							},
							new RegionModel
							{
								Name = "Sannat",
								Code = "52"
							},
							new RegionModel
							{
								Name = "Santa Luċija",
								Code = "53"
							},
							new RegionModel
							{
								Name = "Santa Venera",
								Code = "54"
							},
							new RegionModel
							{
								Name = "Siġġiewi",
								Code = "55"
							},
							new RegionModel
							{
								Name = "Sliema",
								Code = "56"
							},
							new RegionModel
							{
								Name = "Swieqi",
								Code = "57"
							},
							new RegionModel
							{
								Name = "Tai Xbiex",
								Code = "58"
							},
							new RegionModel
							{
								Name = "Tarzien",
								Code = "59"
							},
							new RegionModel
							{
								Name = "Valletta",
								Code = "60"
							},
							new RegionModel
							{
								Name = "Xagħra",
								Code = "61"
							},
							new RegionModel
							{
								Name = "Xewkija",
								Code = "62"
							},
							new RegionModel
							{
								Name = "Xgħajra",
								Code = "63"
							},
							new RegionModel
							{
								Name = "Żabbar",
								Code = "64"
							},
							new RegionModel
							{
								Name = "Żebbuġ Għawde",
								Code = "65"
							},
							new RegionModel
							{
								Name = "Żebbuġ Malta",
								Code = "66"
							},
							new RegionModel
							{
								Name = "Żejtun",
								Code = "67"
							},
							new RegionModel
							{
								Name = "Żurrieq",
								Code = "68"
							}
						}
					},
					new CountryModel
					{
						Name = "Marshall Islands",
						Code = "MH",
						NativeName = "Aolepān Aorōkin M̧ajeļ",
						PhoneCode = "+692",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ailinglaplap",
								Code = "ALL"
							},
							new RegionModel
							{
								Name = "Ailuk",
								Code = "ALK"
							},
							new RegionModel
							{
								Name = "Arno",
								Code = "ARN"
							},
							new RegionModel
							{
								Name = "Aur",
								Code = "AUR"
							},
							new RegionModel
							{
								Name = "Bikini and Kili",
								Code = "KIL"
							},
							new RegionModel
							{
								Name = "Ebon",
								Code = "EBO"
							},
							new RegionModel
							{
								Name = "Jabat",
								Code = "JAB"
							},
							new RegionModel
							{
								Name = "Jaluit",
								Code = "JAL"
							},
							new RegionModel
							{
								Name = "Kwajalein",
								Code = "KWA"
							},
							new RegionModel
							{
								Name = "Lae",
								Code = "LAE"
							},
							new RegionModel
							{
								Name = "Lib",
								Code = "LIB"
							},
							new RegionModel
							{
								Name = "Likiep",
								Code = "LIK"
							},
							new RegionModel
							{
								Name = "Majuro",
								Code = "MAJ"
							},
							new RegionModel
							{
								Name = "Maloelap",
								Code = "MAL"
							},
							new RegionModel
							{
								Name = "Mejit",
								Code = "MEJ"
							},
							new RegionModel
							{
								Name = "Namdrik",
								Code = "NMK"
							},
							new RegionModel
							{
								Name = "Namu",
								Code = "NMU"
							},
							new RegionModel
							{
								Name = "Rongelap",
								Code = "RON"
							},
							new RegionModel
							{
								Name = "Ujae",
								Code = "UJA"
							},
							new RegionModel
							{
								Name = "Utrik",
								Code = "UTI"
							},
							new RegionModel
							{
								Name = "Wotho",
								Code = "WTH"
							},
							new RegionModel
							{
								Name = "Wotje",
								Code = "WTJ"
							}
						}
					},
					new CountryModel
					{
						Name = "Martinique",
						Code = "MQ",
						NativeName = "Matinik ",
						PhoneCode = "+596",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Martinique",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Mauritania",
						Code = "MR",
						NativeName = "الجمهورية الإسلامية الموريتانية , Mauritanie",
						PhoneCode = "+222",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Adrar",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Assaba",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Brakna",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Dakhlet Nouadhibou",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Gorgol",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Guidimaka",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Hodh Ech Chargui",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Hodh El Gharbi",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Inchiri",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Nouakchott Nord",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Nouakchott Ouest",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Nouakchott Sud",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Tagant",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Tiris Zemmour",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Trarza",
								Code = "06"
							}
						}
					},
					new CountryModel
					{
						Name = "Mauritius",
						Code = "MU",
						NativeName = "Maurice , Moris",
						PhoneCode = "+230",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Agalega Islands",
								Code = "AG"
							},
							new RegionModel
							{
								Name = "Beau Bassin-Rose Hill",
								Code = "BR"
							},
							new RegionModel
							{
								Name = "Black River",
								Code = "BL"
							},
							new RegionModel
							{
								Name = "Cargados Carajos Shoals",
								Code = "CC"
							},
							new RegionModel
							{
								Name = "Curepipe",
								Code = "CU"
							},
							new RegionModel
							{
								Name = "Flacq",
								Code = "FL"
							},
							new RegionModel
							{
								Name = "Grand Port",
								Code = "GP"
							},
							new RegionModel
							{
								Name = "Moka",
								Code = "MO"
							},
							new RegionModel
							{
								Name = "Pamplemousses",
								Code = "PA"
							},
							new RegionModel
							{
								Name = "Plaines Wilhems",
								Code = "PW"
							},
							new RegionModel
							{
								Name = "Port Louis (City)",
								Code = "PU"
							},
							new RegionModel
							{
								Name = "Port Louis",
								Code = "PL"
							},
							new RegionModel
							{
								Name = "Riviere du Rempart",
								Code = "RR"
							},
							new RegionModel
							{
								Name = "Rodrigues Island",
								Code = "RO"
							},
							new RegionModel
							{
								Name = "Savanne",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "Vacoas-Phoenix",
								Code = "CP"
							}
						}
					},
					new CountryModel
					{
						Name = "Mayotte",
						Code = "YT",
						NativeName = "",
						PhoneCode = "+262",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Dzaoudzi",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Pamandzi",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Mamoudzou",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Dembeni",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Bandrélé",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Kani-Kéli",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Bouéni",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Chirongui",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Sada",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Ouangani",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Chiconi",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Tsingoni",
								Code = "12"
							},
							new RegionModel
							{
								Name = "M'Tsangamouji",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Acoua",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Mtsamboro",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Bandraboua",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Koungou",
								Code = "17"
							}
						}
					},
					new CountryModel
					{
						Name = "Mexico",
						Code = "MX",
						NativeName = "México",
						PhoneCode = "+52",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aguascalientes",
								Code = "AGU"
							},
							new RegionModel
							{
								Name = "Baja California",
								Code = "BCN"
							},
							new RegionModel
							{
								Name = "Baja California Sur",
								Code = "BCS"
							},
							new RegionModel
							{
								Name = "Campeche",
								Code = "CAM"
							},
							new RegionModel
							{
								Name = "Ciudad de México",
								Code = "DIF"
							},
							new RegionModel
							{
								Name = "Chiapas",
								Code = "CHP"
							},
							new RegionModel
							{
								Name = "Chihuahua",
								Code = "CHH"
							},
							new RegionModel
							{
								Name = "Coahuila de Zaragoza",
								Code = "COA"
							},
							new RegionModel
							{
								Name = "Colima",
								Code = "COL"
							},
							new RegionModel
							{
								Name = "Durango",
								Code = "DUR"
							},
							new RegionModel
							{
								Name = "Estado de México",
								Code = "MEX"
							},
							new RegionModel
							{
								Name = "Guanajuato",
								Code = "GUA"
							},
							new RegionModel
							{
								Name = "Guerrero",
								Code = "GRO"
							},
							new RegionModel
							{
								Name = "Hidalgo",
								Code = "HID"
							},
							new RegionModel
							{
								Name = "Jalisco",
								Code = "JAL"
							},
							new RegionModel
							{
								Name = "Michoacán de Ocampo",
								Code = "MIC"
							},
							new RegionModel
							{
								Name = "Morelos",
								Code = "MOR"
							},
							new RegionModel
							{
								Name = "Nayarit",
								Code = "NAY"
							},
							new RegionModel
							{
								Name = "Nuevo León",
								Code = "NLE"
							},
							new RegionModel
							{
								Name = "Oaxaca",
								Code = "OAX"
							},
							new RegionModel
							{
								Name = "Puebla",
								Code = "PUE"
							},
							new RegionModel
							{
								Name = "Querétaro de Arteaga",
								Code = "QUE"
							},
							new RegionModel
							{
								Name = "Quintana Roo",
								Code = "ROO"
							},
							new RegionModel
							{
								Name = "San Luis Potosí",
								Code = "SLP"
							},
							new RegionModel
							{
								Name = "Sinaloa",
								Code = "SIN"
							},
							new RegionModel
							{
								Name = "Sonora",
								Code = "SON"
							},
							new RegionModel
							{
								Name = "Tabasco",
								Code = "TAB"
							},
							new RegionModel
							{
								Name = "Tamaulipas",
								Code = "TAM"
							},
							new RegionModel
							{
								Name = "Tlaxcala",
								Code = "TLA"
							},
							new RegionModel
							{
								Name = "Veracruz",
								Code = "VER"
							},
							new RegionModel
							{
								Name = "Yucatán",
								Code = "YUC"
							},
							new RegionModel
							{
								Name = "Zacatecas",
								Code = "ZAC"
							}
						}
					},
					new CountryModel
					{
						Name = "Micronesia, Federated States of",
						Code = "FM",
						NativeName = "ミクロネシア",
						PhoneCode = "+691",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Chuuk (Truk)",
								Code = "TRK"
							},
							new RegionModel
							{
								Name = "Kosrae",
								Code = "KSA"
							},
							new RegionModel
							{
								Name = "Pohnpei",
								Code = "PNI"
							},
							new RegionModel
							{
								Name = "Yap",
								Code = "YAP"
							}
						}
					},
					new CountryModel
					{
						Name = "Moldova",
						Code = "MD",
						NativeName = "",
						PhoneCode = "+373",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aenii Noi",
								Code = "AN"
							},
							new RegionModel
							{
								Name = "Basarabeasca",
								Code = "BS"
							},
							new RegionModel
							{
								Name = "Bălți",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Bender",
								Code = "BD"
							},
							new RegionModel
							{
								Name = "Briceni",
								Code = "BR"
							},
							new RegionModel
							{
								Name = "Cahul",
								Code = "CA"
							},
							new RegionModel
							{
								Name = "Cantemir",
								Code = "CT"
							},
							new RegionModel
							{
								Name = "Călărași",
								Code = "CL"
							},
							new RegionModel
							{
								Name = "Căușeni",
								Code = "CS"
							},
							new RegionModel
							{
								Name = "Chișinău",
								Code = "CU"
							},
							new RegionModel
							{
								Name = "Cimișlia",
								Code = "CM"
							},
							new RegionModel
							{
								Name = "Criuleni",
								Code = "CR"
							},
							new RegionModel
							{
								Name = "Dondușeni",
								Code = "DO"
							},
							new RegionModel
							{
								Name = "Drochia",
								Code = "DR"
							},
							new RegionModel
							{
								Name = "Dubăsari",
								Code = "DU"
							},
							new RegionModel
							{
								Name = "Edineț",
								Code = "ED"
							},
							new RegionModel
							{
								Name = "Fălești",
								Code = "FA"
							},
							new RegionModel
							{
								Name = "Florești",
								Code = "FL"
							},
							new RegionModel
							{
								Name = "Găgăuzia",
								Code = "GA"
							},
							new RegionModel
							{
								Name = "Glodeni",
								Code = "GL"
							},
							new RegionModel
							{
								Name = "Hîncești",
								Code = "HI"
							},
							new RegionModel
							{
								Name = "Ialoveni",
								Code = "IA"
							},
							new RegionModel
							{
								Name = "Leova",
								Code = "LE"
							},
							new RegionModel
							{
								Name = "Nisporeni",
								Code = "NI"
							},
							new RegionModel
							{
								Name = "Ocnița",
								Code = "OC"
							},
							new RegionModel
							{
								Name = "Orhei",
								Code = "OR"
							},
							new RegionModel
							{
								Name = "Rezina",
								Code = "RE"
							},
							new RegionModel
							{
								Name = "Rîșcani",
								Code = "RI"
							},
							new RegionModel
							{
								Name = "Sîngerei",
								Code = "SI"
							},
							new RegionModel
							{
								Name = "Soroca",
								Code = "SO"
							},
							new RegionModel
							{
								Name = "Stânga Nistrului",
								Code = "SN"
							},
							new RegionModel
							{
								Name = "Strășeni",
								Code = "ST"
							},
							new RegionModel
							{
								Name = "Șoldănești",
								Code = "SD"
							},
							new RegionModel
							{
								Name = "Ștefan Vodă",
								Code = "SV"
							},
							new RegionModel
							{
								Name = "Taraclia",
								Code = "TA"
							},
							new RegionModel
							{
								Name = "Telenești",
								Code = "TE"
							},
							new RegionModel
							{
								Name = "Ungheni",
								Code = "UN"
							}
						}
					},
					new CountryModel
					{
						Name = "Monaco",
						Code = "MC",
						NativeName = "Mu̍negu , Mónegue",
						PhoneCode = "+377",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Colle",
								Code = "CL"
							},
							new RegionModel
							{
								Name = "Condamine",
								Code = "CO"
							},
							new RegionModel
							{
								Name = "Fontvieille",
								Code = "FO"
							},
							new RegionModel
							{
								Name = "Gare",
								Code = "GA"
							},
							new RegionModel
							{
								Name = "Jardin Exotique",
								Code = "JE"
							},
							new RegionModel
							{
								Name = "Larvotto",
								Code = "LA"
							},
							new RegionModel
							{
								Name = "Malbousquet",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Monaco-Ville",
								Code = "MO"
							},
							new RegionModel
							{
								Name = "Moneghetti",
								Code = "MG"
							},
							new RegionModel
							{
								Name = "Monte-Carlo",
								Code = "MC"
							},
							new RegionModel
							{
								Name = "Moulins",
								Code = "MU"
							},
							new RegionModel
							{
								Name = "Port-Hercule",
								Code = "PH"
							},
							new RegionModel
							{
								Name = "Saint-Roman",
								Code = "SR"
							},
							new RegionModel
							{
								Name = "Sainte-Dévote",
								Code = "SD"
							},
							new RegionModel
							{
								Name = "Source",
								Code = "SO"
							},
							new RegionModel
							{
								Name = "Spélugues",
								Code = "SP"
							},
							new RegionModel
							{
								Name = "Vallon de la Rousse",
								Code = "VR"
							}
						}
					},
					new CountryModel
					{
						Name = "Mongolia",
						Code = "MN",
						NativeName = "ᠮᠣᠩᠭ᠋ᠣᠯᠤᠯᠤᠰ",
						PhoneCode = "+976",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Arhangay",
								Code = "073"
							},
							new RegionModel
							{
								Name = "Bayan-Olgiy",
								Code = "071"
							},
							new RegionModel
							{
								Name = "Bayanhongor",
								Code = "069"
							},
							new RegionModel
							{
								Name = "Bulgan",
								Code = "067"
							},
							new RegionModel
							{
								Name = "Darhan",
								Code = "037"
							},
							new RegionModel
							{
								Name = "Dornod",
								Code = "061"
							},
							new RegionModel
							{
								Name = "Dornogovi",
								Code = "063"
							},
							new RegionModel
							{
								Name = "Dundgovi",
								Code = "059"
							},
							new RegionModel
							{
								Name = "Dzavhan",
								Code = "057"
							},
							new RegionModel
							{
								Name = "Govi-Altay",
								Code = "065"
							},
							new RegionModel
							{
								Name = "Govi-Sumber",
								Code = "064"
							},
							new RegionModel
							{
								Name = "Hovd",
								Code = "043"
							},
							new RegionModel
							{
								Name = "Hovsgol",
								Code = "041"
							},
							new RegionModel
							{
								Name = "Omnogovi",
								Code = "053"
							},
							new RegionModel
							{
								Name = "Ovorhangay",
								Code = "055"
							},
							new RegionModel
							{
								Name = "Selenge",
								Code = "049"
							},
							new RegionModel
							{
								Name = "Suhbaatar",
								Code = "051"
							},
							new RegionModel
							{
								Name = "Tov",
								Code = "047"
							},
							new RegionModel
							{
								Name = "Ulaanbaatar",
								Code = "1"
							},
							new RegionModel
							{
								Name = "Uvs",
								Code = "046"
							},
							new RegionModel
							{
								Name = "Erdenet",
								Code = "074"
							}
						}
					},
					new CountryModel
					{
						Name = "Montenegro",
						Code = "ME",
						NativeName = "Црна Гора , Crna Gora",
						PhoneCode = "+382",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Andrijevica",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Bar",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Berane",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Bijelo Polje",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Budva",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Cetinje",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Danilovgrad",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Gusinje",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Herceg Novi",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Kolašin",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Kotor",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Mojkovac",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Nikšić",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Petnica",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Plav",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Plužine",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Pljevlja",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Podgorica",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Rožaje",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Šavnik",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Tivat",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Ulcinj",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Žabljak",
								Code = "21"
							}
						}
					},
					new CountryModel
					{
						Name = "Montserrat",
						Code = "MS",
						NativeName = "",
						PhoneCode = "+1664",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Saint Anthony",
								Code = null
							},
							new RegionModel
							{
								Name = "Saint Georges",
								Code = null
							},
							new RegionModel
							{
								Name = "Saint Peter's",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Morocco",
						Code = "MA",
						NativeName = "ⵎⵓⵔⴰⴽⵓⵛ , المغرب‎",
						PhoneCode = "+212",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Tanger-Tétouan-Al Hoceïma",
								Code = "MA-01"
							},
							new RegionModel
							{
								Name = "L'Oriental",
								Code = "MA-02"
							},
							new RegionModel
							{
								Name = "Fès-Meknès",
								Code = "MA-03"
							},
							new RegionModel
							{
								Name = "Rabat-Salé-Kénitra",
								Code = "MA-04"
							},
							new RegionModel
							{
								Name = "Béni Mellal-Khénifra",
								Code = "MA-05"
							},
							new RegionModel
							{
								Name = "Casablanca-Settat",
								Code = "MA-06"
							},
							new RegionModel
							{
								Name = "Marrakech-Safi",
								Code = "MA-07"
							},
							new RegionModel
							{
								Name = "Drâa-Tafilalet",
								Code = "MA-08"
							},
							new RegionModel
							{
								Name = "Souss-Massa",
								Code = "MA-09"
							},
							new RegionModel
							{
								Name = "Guelmim-Oued Noun",
								Code = "MA-10"
							},
							new RegionModel
							{
								Name = "Laâyoune-Sakia El Hamra",
								Code = "MA-11"
							},
							new RegionModel
							{
								Name = "Dakhla-Oued Ed-Dahab",
								Code = "MA-12"
							}
						}
					},
					new CountryModel
					{
						Name = "Mozambique",
						Code = "MZ",
						NativeName = "Moçambique",
						PhoneCode = "+258",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Cabo Delgado",
								Code = "P"
							},
							new RegionModel
							{
								Name = "Gaza",
								Code = "G"
							},
							new RegionModel
							{
								Name = "Inhambane",
								Code = "I"
							},
							new RegionModel
							{
								Name = "Manica",
								Code = "B"
							},
							new RegionModel
							{
								Name = "Maputo",
								Code = "L"
							},
							new RegionModel
							{
								Name = "Maputo (City)",
								Code = "MPM"
							},
							new RegionModel
							{
								Name = "Nampula",
								Code = "N"
							},
							new RegionModel
							{
								Name = "Niassa",
								Code = "A"
							},
							new RegionModel
							{
								Name = "Sofala",
								Code = "S"
							},
							new RegionModel
							{
								Name = "Tete",
								Code = "T"
							},
							new RegionModel
							{
								Name = "Zambezia",
								Code = "Q"
							}
						}
					},
					new CountryModel
					{
						Name = "Myanmar",
						Code = "MM",
						NativeName = "ပြည်ထောင်စုသမ္မတမြန်မာနိုင်ငံ",
						PhoneCode = "+95",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ayeyarwady",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Bago",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Chin",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Kachin",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Kayah",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Kayin",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Magway",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Mandalay",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Mon",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Nay Pyi Taw",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Rakhine",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Sagaing",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Shan",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Tanintharyi",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Yangon",
								Code = "06"
							}
						}
					},
					#endregion
					};
					break;
				case 'N':
					countries = new ObservableCollection<CountryModel> { 
					#region N
				
					new CountryModel
					{
						Name = "Namibia",
						Code = "NA",
						NativeName = "Namibië",
						PhoneCode = "+264",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Erongo",
								Code = "ER"
							},
							new RegionModel
							{
								Name = "Hardap",
								Code = "HA"
							},
							new RegionModel
							{
								Name = "Kavango East",
								Code = "KE"
							},
							new RegionModel
							{
								Name = "Kavango West",
								Code = "KW"
							},
							new RegionModel
							{
								Name = "Karas",
								Code = "KA"
							},
							new RegionModel
							{
								Name = "Khomas",
								Code = "KH"
							},
							new RegionModel
							{
								Name = "Kunene",
								Code = "KU"
							},
							new RegionModel
							{
								Name = "Ohangwena",
								Code = "OW"
							},
							new RegionModel
							{
								Name = "Omaheke",
								Code = "OH"
							},
							new RegionModel
							{
								Name = "Omusati",
								Code = "OS"
							},
							new RegionModel
							{
								Name = "Oshana",
								Code = "ON"
							},
							new RegionModel
							{
								Name = "Oshikoto",
								Code = "OT"
							},
							new RegionModel
							{
								Name = "Otjozondjupa",
								Code = "OD"
							},
							new RegionModel
							{
								Name = "Zambezi",
								Code = "CA"
							}
						}
					},
					new CountryModel
					{
						Name = "Nauru",
						Code = "NR",
						NativeName = "Ripublik Naoero",
						PhoneCode = "+674",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aiwo",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Anabar",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Anetan",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Anibare",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Baiti",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Boe",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Buada",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Denigomodu",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Ewa",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Ijuw",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Meneng",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Nibok",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Uaboe",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Yaren",
								Code = "14"
							}
						}
					},
					new CountryModel
					{
						Name = "Nepal",
						Code = "NP",
						NativeName = "नेपाल",
						PhoneCode = "+977",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Province No. 1",
								Code = "1"
							},
							new RegionModel
							{
								Name = "Madhesh Province",
								Code = "2"
							},
							new RegionModel
							{
								Name = "Bagmati Province",
								Code = "3"
							},
							new RegionModel
							{
								Name = "Gandaki Province",
								Code = "4"
							},
							new RegionModel
							{
								Name = "Lumbini Province",
								Code = "5"
							},
							new RegionModel
							{
								Name = "Karnali Province",
								Code = "6"
							},
							new RegionModel
							{
								Name = "Sudurpashchim Province",
								Code = "7"
							}
						}
					},
					new CountryModel
					{
						Name = "Netherlands",
						Code = "NL",
						NativeName = "Nederland",
						PhoneCode = "+31",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Drenthe",
								Code = "DR"
							},
							new RegionModel
							{
								Name = "Flevoland",
								Code = "FL"
							},
							new RegionModel
							{
								Name = "Friesland",
								Code = "FR"
							},
							new RegionModel
							{
								Name = "Gelderland",
								Code = "GE"
							},
							new RegionModel
							{
								Name = "Groningen",
								Code = "GR"
							},
							new RegionModel
							{
								Name = "Limburg",
								Code = "LI"
							},
							new RegionModel
							{
								Name = "Noord-Brabant",
								Code = "NB"
							},
							new RegionModel
							{
								Name = "Noord-Holland",
								Code = "NH"
							},
							new RegionModel
							{
								Name = "Overijssel",
								Code = "OV"
							},
							new RegionModel
							{
								Name = "Utrecht",
								Code = "UT"
							},
							new RegionModel
							{
								Name = "Zeeland",
								Code = "ZE"
							},
							new RegionModel
							{
								Name = "Zuid-Holland",
								Code = "ZH"
							}
						}
					},
					new CountryModel
					{
						Name = "New Caledonia",
						Code = "NC",
						NativeName = "Nouvelle Calédonie",
						PhoneCode = "+687",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Iles Loyaute",
								Code = null
							},
							new RegionModel
							{
								Name = "Nord",
								Code = null
							},
							new RegionModel
							{
								Name = "Sud",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "New Zealand",
						Code = "NZ",
						NativeName = "Aotearoa",
						PhoneCode = "+64",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Auckland",
								Code = "AUK"
							},
							new RegionModel
							{
								Name = "Bay of Plenty",
								Code = "BOP"
							},
							new RegionModel
							{
								Name = "Canterbury",
								Code = "CAN"
							},
							new RegionModel
							{
								Name = "Gisborne",
								Code = "GIS"
							},
							new RegionModel
							{
								Name = "Hawke's Bay",
								Code = "HKB"
							},
							new RegionModel
							{
								Name = "Marlborough",
								Code = "MBH"
							},
							new RegionModel
							{
								Name = "Manawatu-Wanganui",
								Code = "MWT"
							},
							new RegionModel
							{
								Name = "Northland",
								Code = "NTL"
							},
							new RegionModel
							{
								Name = "Nelson",
								Code = "NSN"
							},
							new RegionModel
							{
								Name = "Otago",
								Code = "OTA"
							},
							new RegionModel
							{
								Name = "Southland",
								Code = "STL"
							},
							new RegionModel
							{
								Name = "Taranaki",
								Code = "TKI"
							},
							new RegionModel
							{
								Name = "Tasman",
								Code = "TAS"
							},
							new RegionModel
							{
								Name = "Waikato",
								Code = "WKO"
							},
							new RegionModel
							{
								Name = "Wellington",
								Code = "WGN"
							},
							new RegionModel
							{
								Name = "West Coast",
								Code = "WTC"
							},
							new RegionModel
							{
								Name = "Chatham Islands Territory",
								Code = "CIT"
							}
						}
					},
					new CountryModel
					{
						Name = "Nicaragua",
						Code = "NI",
						NativeName = "",
						PhoneCode = "+505",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Boaco",
								Code = "BO"
							},
							new RegionModel
							{
								Name = "Carazo",
								Code = "CA"
							},
							new RegionModel
							{
								Name = "Chinandega",
								Code = "CI"
							},
							new RegionModel
							{
								Name = "Chontales",
								Code = "CO"
							},
							new RegionModel
							{
								Name = "Estelí",
								Code = "ES"
							},
							new RegionModel
							{
								Name = "Granada",
								Code = "GR"
							},
							new RegionModel
							{
								Name = "Jinotega",
								Code = "JI"
							},
							new RegionModel
							{
								Name = "León",
								Code = "LE"
							},
							new RegionModel
							{
								Name = "Madriz",
								Code = "MD"
							},
							new RegionModel
							{
								Name = "Managua",
								Code = "MN"
							},
							new RegionModel
							{
								Name = "Masaya",
								Code = "MS"
							},
							new RegionModel
							{
								Name = "Matagalpa",
								Code = "MT"
							},
							new RegionModel
							{
								Name = "Nueva Segovia",
								Code = "NS"
							},
							new RegionModel
							{
								Name = "Río San Juan",
								Code = "SJ"
							},
							new RegionModel
							{
								Name = "Rivas",
								Code = "RI"
							},
							new RegionModel
							{
								Name = "Atlántico Norte",
								Code = "AN"
							},
							new RegionModel
							{
								Name = "Atlántico Sur",
								Code = "AS"
							}
						}
					},
					new CountryModel
					{
						Name = "Niger",
						Code = "NE",
						NativeName = "Nijar , Niiser",
						PhoneCode = "+227",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Agadez",
								Code = "1"
							},
							new RegionModel
							{
								Name = "Diffa",
								Code = "2"
							},
							new RegionModel
							{
								Name = "Dosso",
								Code = "3"
							},
							new RegionModel
							{
								Name = "Maradi",
								Code = "4"
							},
							new RegionModel
							{
								Name = "Niamey",
								Code = "8"
							},
							new RegionModel
							{
								Name = "Tahoua",
								Code = "5"
							},
							new RegionModel
							{
								Name = "Tillabéri",
								Code = "6"
							},
							new RegionModel
							{
								Name = "Zinder",
								Code = "7"
							}
						}
					},
					new CountryModel
					{
						Name = "Nigeria",
						Code = "NG",
						NativeName = "Nàìjíríà , Nijeriya, Niiseriya , Naìjíríyà",
						PhoneCode = "+234",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Abia",
								Code = "AB"
							},
							new RegionModel
							{
								Name = "Abuja Federal Capital Territory",
								Code = "FC"
							},
							new RegionModel
							{
								Name = "Adamawa",
								Code = "AD"
							},
							new RegionModel
							{
								Name = "Akwa Ibom",
								Code = "AK"
							},
							new RegionModel
							{
								Name = "Anambra",
								Code = "AN"
							},
							new RegionModel
							{
								Name = "Bauchi",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Bayelsa",
								Code = "BY"
							},
							new RegionModel
							{
								Name = "Benue",
								Code = "BE"
							},
							new RegionModel
							{
								Name = "Borno",
								Code = "BO"
							},
							new RegionModel
							{
								Name = "Cross River",
								Code = "CR"
							},
							new RegionModel
							{
								Name = "Delta",
								Code = "DE"
							},
							new RegionModel
							{
								Name = "Ebonyi",
								Code = "EB"
							},
							new RegionModel
							{
								Name = "Edo",
								Code = "ED"
							},
							new RegionModel
							{
								Name = "Ekiti",
								Code = "EK"
							},
							new RegionModel
							{
								Name = "Enugu",
								Code = "EN"
							},
							new RegionModel
							{
								Name = "Gombe",
								Code = "GO"
							},
							new RegionModel
							{
								Name = "Imo",
								Code = "IM"
							},
							new RegionModel
							{
								Name = "Jigawa",
								Code = "JI"
							},
							new RegionModel
							{
								Name = "Kaduna",
								Code = "KD"
							},
							new RegionModel
							{
								Name = "Kano",
								Code = "KN"
							},
							new RegionModel
							{
								Name = "Katsina",
								Code = "KT"
							},
							new RegionModel
							{
								Name = "Kebbi",
								Code = "KE"
							},
							new RegionModel
							{
								Name = "Kogi",
								Code = "KO"
							},
							new RegionModel
							{
								Name = "Kwara",
								Code = "KW"
							},
							new RegionModel
							{
								Name = "Lagos",
								Code = "LA"
							},
							new RegionModel
							{
								Name = "Nassarawa",
								Code = "NA"
							},
							new RegionModel
							{
								Name = "Niger",
								Code = "NI"
							},
							new RegionModel
							{
								Name = "Ogun",
								Code = "OG"
							},
							new RegionModel
							{
								Name = "Ondo",
								Code = "ON"
							},
							new RegionModel
							{
								Name = "Osun",
								Code = "OS"
							},
							new RegionModel
							{
								Name = "Oyo",
								Code = "OY"
							},
							new RegionModel
							{
								Name = "Plateau",
								Code = "PL"
							},
							new RegionModel
							{
								Name = "Rivers",
								Code = "RI"
							},
							new RegionModel
							{
								Name = "Sokoto",
								Code = "SO"
							},
							new RegionModel
							{
								Name = "Taraba",
								Code = "TA"
							},
							new RegionModel
							{
								Name = "Yobe",
								Code = "YO"
							},
							new RegionModel
							{
								Name = "Zamfara",
								Code = "ZA"
							}
						}
					},
					new CountryModel
					{
						Name = "Niue",
						Code = "NU",
						NativeName = "Niuē-fekai",
						PhoneCode = "+683",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Niue",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Norfolk Island",
						Code = "NF",
						NativeName = "Norfuk Ailen",
						PhoneCode = "+672",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Norfolk Island",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "North Korea",
						Code = "KP",
						NativeName = "조선민주주의인민공화국 , 朝鮮民主主義人民共和國",
						PhoneCode = "+850",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Chagang-do (Chagang Province)",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Hamgyong-bukto (North Hamgyong Province)",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Hamgyong-namdo (South Hamgyong Province)",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Hwanghae-bukto (North Hwanghae Province)",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Hwanghae-namdo (South Hwanghae Province)",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Kangwon-do (Kangwon Province)",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Nasŏn (Najin-Sŏnbong)",
								Code = "13"
							},
							new RegionModel
							{
								Name = "P'yongan-bukto (North P'yongan Province)",
								Code = "03"
							},
							new RegionModel
							{
								Name = "P'yongan-namdo (South P'yongan Province)",
								Code = "02"
							},
							new RegionModel
							{
								Name = "P'yongyang-si (P'yongyang City)",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Yanggang-do (Yanggang Province)",
								Code = "10"
							}
						}
					},
					new CountryModel
					{
						Name = "Northern Mariana Islands",
						Code = "MP",
						NativeName = "",
						PhoneCode = "+1 670",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Northern Islands",
								Code = null
							},
							new RegionModel
							{
								Name = "Rota",
								Code = null
							},
							new RegionModel
							{
								Name = "Saipan",
								Code = null
							},
							new RegionModel
							{
								Name = "Tinian",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Norway",
						Code = "NO",
						NativeName = "Norge , Noreg , Norgga ",
						PhoneCode = "+47",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Akershus",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Aust-Agder",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Buskerud",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Finnmark",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Hedmark",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Hordaland",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Møre og Romsdal",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Nordland",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Nord-Trøndelag",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Oppland",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Oslo",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Rogaland",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Sogn og Fjordane",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Sør-Trøndelag",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Telemark",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Troms",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Vest-Agder",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Vestfold",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Østfold",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Jan Mayen",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Svalbard",
								Code = "21"
							}
						}
					},
					#endregion
					};
					break;
				case 'O':
					countries = new ObservableCollection<CountryModel> { 
					#region O
					new CountryModel
					{
						Name = "Oman",
						Code = "OM",
						NativeName = "سلطانة عمان",
						PhoneCode = "+968",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ad Dakhiliyah",
								Code = "DA"
							},
							new RegionModel
							{
								Name = "Al Buraymi",
								Code = "BU"
							},
							new RegionModel
							{
								Name = "Al Wusta",
								Code = "WU"
							},
							new RegionModel
							{
								Name = "Az Zahirah",
								Code = "ZA"
							},
							new RegionModel
							{
								Name = "Janub al Batinah",
								Code = "BS"
							},
							new RegionModel
							{
								Name = "Janub ash Sharqiyah",
								Code = "SS"
							},
							new RegionModel
							{
								Name = "Masqat",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Musandam",
								Code = "MU"
							},
							new RegionModel
							{
								Name = "Shamal al Batinah",
								Code = "BJ"
							},
							new RegionModel
							{
								Name = "Shamal ash Sharqiyah",
								Code = "SJ"
							},
							new RegionModel
							{
								Name = "Zufar",
								Code = "ZU"
							}
						}
					},
					#endregion
					};
					break;
				case 'P':
					countries = new ObservableCollection<CountryModel> { 
					#region P
					new CountryModel
					{
						Name = "Pakistan",
						Code = "PK",
						NativeName = "اسلامی جمہوریہ پاكستان",
						PhoneCode = "+92",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Āzād Kashmīr",
								Code = "JK"
							},
							new RegionModel
							{
								Name = "Balōchistān",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Gilgit-Baltistān",
								Code = "GB"
							},
							new RegionModel
							{
								Name = "Islāmābād",
								Code = "IS"
							},
							new RegionModel
							{
								Name = "Khaībar Pakhtūnkhwās",
								Code = "KP"
							},
							new RegionModel
							{
								Name = "Punjāb",
								Code = "PB"
							},
							new RegionModel
							{
								Name = "Sindh",
								Code = "SD"
							},
							new RegionModel
							{
								Name = "Federally Administered Tribal Areas",
								Code = "TA"
							}
						}
					},
					new CountryModel
					{
						Name = "Palau",
						Code = "PW",
						NativeName = "Beluu er a Belau , パラオ共和国 ",
						PhoneCode = "+680",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aimeliik",
								Code = "002"
							},
							new RegionModel
							{
								Name = "Airai",
								Code = "004"
							},
							new RegionModel
							{
								Name = "Angaur",
								Code = "010"
							},
							new RegionModel
							{
								Name = "Hatobohei",
								Code = "050"
							},
							new RegionModel
							{
								Name = "Kayangel",
								Code = "100"
							},
							new RegionModel
							{
								Name = "Koror",
								Code = "150"
							},
							new RegionModel
							{
								Name = "Melekeok",
								Code = "212"
							},
							new RegionModel
							{
								Name = "Ngaraard",
								Code = "214"
							},
							new RegionModel
							{
								Name = "Ngarchelong",
								Code = "218"
							},
							new RegionModel
							{
								Name = "Ngardmau",
								Code = "222"
							},
							new RegionModel
							{
								Name = "Ngatpang",
								Code = "224"
							},
							new RegionModel
							{
								Name = "Ngchesar",
								Code = "226"
							},
							new RegionModel
							{
								Name = "Ngeremlengui",
								Code = "227"
							},
							new RegionModel
							{
								Name = "Ngiwal",
								Code = "228"
							},
							new RegionModel
							{
								Name = "Peleliu",
								Code = "350"
							},
							new RegionModel
							{
								Name = "Sonsoral",
								Code = "370"
							}
						}
					},
					new CountryModel
					{
						Name = "Palestine",
						Code = "PS",
						NativeName = "دولة فلسطين",
						PhoneCode = "+970",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ak Khalīl",
								Code = "HBN"
							},
							new RegionModel
							{
								Name = "Al Quds",
								Code = "JEM"
							},
							new RegionModel
							{
								Name = "Arīḩā wal Aghwār",
								Code = "JRH"
							},
							new RegionModel
							{
								Name = "Bayt Laḩm",
								Code = "BTH"
							},
							new RegionModel
							{
								Name = "Dayr al Balaḩ",
								Code = "DEB"
							},
							new RegionModel
							{
								Name = "Ghazzah",
								Code = "GZA"
							},
							new RegionModel
							{
								Name = "Janīn",
								Code = "JEN"
							},
							new RegionModel
							{
								Name = "Khān Yūnis",
								Code = "KYS"
							},
							new RegionModel
							{
								Name = "Nāblus",
								Code = "NBS"
							},
							new RegionModel
							{
								Name = "Qalqīyah",
								Code = "QQA"
							},
							new RegionModel
							{
								Name = "Rafaḩ",
								Code = "RFH"
							},
							new RegionModel
							{
								Name = "Rām Allāh wal Bīrah",
								Code = "RBH"
							},
							new RegionModel
							{
								Name = "Salfīt",
								Code = "SLT"
							},
							new RegionModel
							{
								Name = "Shamāl Ghazzah",
								Code = "NGZ"
							},
							new RegionModel
							{
								Name = "Ţūbās",
								Code = "TBS"
							},
							new RegionModel
							{
								Name = "Ţūlkarm",
								Code = "TKM"
							}
						}
					},
					new CountryModel
					{
						Name = "Panama",
						Code = "PA",
						NativeName = "Panamá",
						PhoneCode = "+507",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bocas del Toro",
								Code = "1"
							},
							new RegionModel
							{
								Name = "Chiriquí",
								Code = "4"
							},
							new RegionModel
							{
								Name = "Coclé",
								Code = "2"
							},
							new RegionModel
							{
								Name = "Colón",
								Code = "3"
							},
							new RegionModel
							{
								Name = "Darién",
								Code = "5"
							},
							new RegionModel
							{
								Name = "Emberá",
								Code = "EM"
							},
							new RegionModel
							{
								Name = "Herrera",
								Code = "6"
							},
							new RegionModel
							{
								Name = "Kuna Yala",
								Code = "KY"
							},
							new RegionModel
							{
								Name = "Los Santos",
								Code = "7"
							},
							new RegionModel
							{
								Name = "Ngäbe-Buglé",
								Code = "NB"
							},
							new RegionModel
							{
								Name = "Panamá",
								Code = "8"
							},
							new RegionModel
							{
								Name = "Panamá Oeste",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Veraguas",
								Code = "9"
							}
						}
					},
					new CountryModel
					{
						Name = "Papua New Guinea",
						Code = "PG",
						NativeName = "Papua Niu Gini , Papua Niugini",
						PhoneCode = "+675",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bougainville",
								Code = "NSB"
							},
							new RegionModel
							{
								Name = "Central",
								Code = "CPM"
							},
							new RegionModel
							{
								Name = "Chimbu",
								Code = "CPK"
							},
							new RegionModel
							{
								Name = "East New Britain",
								Code = "EBR"
							},
							new RegionModel
							{
								Name = "East Sepik",
								Code = "ESW"
							},
							new RegionModel
							{
								Name = "Eastern Highlands",
								Code = "EHG"
							},
							new RegionModel
							{
								Name = "Enga",
								Code = "EPW"
							},
							new RegionModel
							{
								Name = "Gulf",
								Code = "GPK"
							},
							new RegionModel
							{
								Name = "Hela",
								Code = "HLA"
							},
							new RegionModel
							{
								Name = "Jiwaka",
								Code = "JWK"
							},
							new RegionModel
							{
								Name = "Madang",
								Code = "MOM"
							},
							new RegionModel
							{
								Name = "Manus",
								Code = "MRL"
							},
							new RegionModel
							{
								Name = "Milne Bay",
								Code = "MBA"
							},
							new RegionModel
							{
								Name = "Morobe",
								Code = "MPL"
							},
							new RegionModel
							{
								Name = "Port Moresby",
								Code = "NCD"
							},
							new RegionModel
							{
								Name = "New Ireland",
								Code = "NIK"
							},
							new RegionModel
							{
								Name = "Northern",
								Code = "NPP"
							},
							new RegionModel
							{
								Name = "Southern Highlands",
								Code = "SHM"
							},
							new RegionModel
							{
								Name = "West New Britain",
								Code = "WBK"
							},
							new RegionModel
							{
								Name = "West Sepik",
								Code = "SAN"
							},
							new RegionModel
							{
								Name = "Western",
								Code = "WPD"
							},
							new RegionModel
							{
								Name = "Western Highlands",
								Code = "WHM"
							}
						}
					},
					new CountryModel
					{
						Name = "Paraguay",
						Code = "PY",
						NativeName = "Tetã Paraguái",
						PhoneCode = "+595",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Alto Paraguay",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Alto Parana",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Amambay",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Asuncion",
								Code = "ASU"
							},
							new RegionModel
							{
								Name = "Caaguazu",
								Code = "5"
							},
							new RegionModel
							{
								Name = "Caazapa",
								Code = "6"
							},
							new RegionModel
							{
								Name = "Canindeyu",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Central",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Concepcion",
								Code = "1"
							},
							new RegionModel
							{
								Name = "Cordillera",
								Code = "3"
							},
							new RegionModel
							{
								Name = "Boqueron",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Guaira",
								Code = "4"
							},
							new RegionModel
							{
								Name = "Itapua",
								Code = "7"
							},
							new RegionModel
							{
								Name = "Misiones",
								Code = "8"
							},
							new RegionModel
							{
								Name = "Neembucu",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Paraguari",
								Code = "9"
							},
							new RegionModel
							{
								Name = "Presidente Hayes",
								Code = "15"
							},
							new RegionModel
							{
								Name = "San Pedro",
								Code = "2"
							}
						}
					},
					new CountryModel
					{
						Name = "Peru",
						Code = "PE",
						NativeName = "Perú , Piruw",
						PhoneCode = "+51",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Amazonas",
								Code = "AMA"
							},
							new RegionModel
							{
								Name = "Ancash",
								Code = "ANC"
							},
							new RegionModel
							{
								Name = "Apurimac",
								Code = "APU"
							},
							new RegionModel
							{
								Name = "Arequipa",
								Code = "ARE"
							},
							new RegionModel
							{
								Name = "Ayacucho",
								Code = "AYA"
							},
							new RegionModel
							{
								Name = "Cajamarca",
								Code = "CAJ"
							},
							new RegionModel
							{
								Name = "Callao",
								Code = "CAL"
							},
							new RegionModel
							{
								Name = "Cusco",
								Code = "CUS"
							},
							new RegionModel
							{
								Name = "Huancavelica",
								Code = "HUV"
							},
							new RegionModel
							{
								Name = "Huanuco",
								Code = "HUC"
							},
							new RegionModel
							{
								Name = "Ica",
								Code = "ICA"
							},
							new RegionModel
							{
								Name = "Junin",
								Code = "JUN"
							},
							new RegionModel
							{
								Name = "La Libertad",
								Code = "LAL"
							},
							new RegionModel
							{
								Name = "Lambayeque",
								Code = "LAM"
							},
							new RegionModel
							{
								Name = "Lima",
								Code = "LIM"
							},
							new RegionModel
							{
								Name = "Loreto",
								Code = "LOR"
							},
							new RegionModel
							{
								Name = "Madre de Dios",
								Code = "MDD"
							},
							new RegionModel
							{
								Name = "Moquegua",
								Code = "MOQ"
							},
							new RegionModel
							{
								Name = "Municipalidad Metropolitana de Lima",
								Code = "LMA"
							},
							new RegionModel
							{
								Name = "Pasco",
								Code = "PAS"
							},
							new RegionModel
							{
								Name = "Piura",
								Code = "PIU"
							},
							new RegionModel
							{
								Name = "Puno",
								Code = "PUN"
							},
							new RegionModel
							{
								Name = "San Martin",
								Code = "SAM"
							},
							new RegionModel
							{
								Name = "Tacna",
								Code = "TAC"
							},
							new RegionModel
							{
								Name = "Tumbes",
								Code = "TUM"
							},
							new RegionModel
							{
								Name = "Ucayali",
								Code = "UCA"
							}
						}
					},
					new CountryModel
					{
						Name = "Philippines",
						Code = "PH",
						NativeName = "Pilipinas",
						PhoneCode = "+63",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Abra",
								Code = "ABR"
							},
							new RegionModel
							{
								Name = "Agusan del Norte",
								Code = "AGN"
							},
							new RegionModel
							{
								Name = "Agusan del Sur",
								Code = "AGS"
							},
							new RegionModel
							{
								Name = "Aklan",
								Code = "AKL"
							},
							new RegionModel
							{
								Name = "Albay",
								Code = "ALB"
							},
							new RegionModel
							{
								Name = "Antique",
								Code = "ANT"
							},
							new RegionModel
							{
								Name = "Apayao",
								Code = "APA"
							},
							new RegionModel
							{
								Name = "Aurora",
								Code = "AUR"
							},
							new RegionModel
							{
								Name = "Basilan",
								Code = "BAS"
							},
							new RegionModel
							{
								Name = "Bataan",
								Code = "BAN"
							},
							new RegionModel
							{
								Name = "Batanes",
								Code = "BTN"
							},
							new RegionModel
							{
								Name = "Batangas",
								Code = "BTG"
							},
							new RegionModel
							{
								Name = "Benguet",
								Code = "BEN"
							},
							new RegionModel
							{
								Name = "Biliran",
								Code = "BIL"
							},
							new RegionModel
							{
								Name = "Bohol",
								Code = "BOH"
							},
							new RegionModel
							{
								Name = "Bukidnon",
								Code = "BUK"
							},
							new RegionModel
							{
								Name = "Bulacan",
								Code = "BUL"
							},
							new RegionModel
							{
								Name = "Cagayan",
								Code = "CAG"
							},
							new RegionModel
							{
								Name = "Camarines Norte",
								Code = "CAN"
							},
							new RegionModel
							{
								Name = "Camarines Sur",
								Code = "CAS"
							},
							new RegionModel
							{
								Name = "Camiguin",
								Code = "CAM"
							},
							new RegionModel
							{
								Name = "Capiz",
								Code = "CAP"
							},
							new RegionModel
							{
								Name = "Catanduanes",
								Code = "CAT"
							},
							new RegionModel
							{
								Name = "Cavite",
								Code = "CAV"
							},
							new RegionModel
							{
								Name = "Cebu",
								Code = "CEB"
							},
							new RegionModel
							{
								Name = "Compostela",
								Code = "COM"
							},
							new RegionModel
							{
								Name = "Cotabato",
								Code = "NCO"
							},
							new RegionModel
							{
								Name = "Davao del Norte",
								Code = "DAV"
							},
							new RegionModel
							{
								Name = "Davao del Sur",
								Code = "DAS"
							},
							new RegionModel
							{
								Name = "Davao Occidental",
								Code = "DVO"
							},
							new RegionModel
							{
								Name = "Davao Oriental",
								Code = "DAO"
							},
							new RegionModel
							{
								Name = "Dinagat Islands",
								Code = "DIN"
							},
							new RegionModel
							{
								Name = "Eastern Samar",
								Code = "EAS"
							},
							new RegionModel
							{
								Name = "Guimaras",
								Code = "GUI"
							},
							new RegionModel
							{
								Name = "Ifugao",
								Code = "IFU"
							},
							new RegionModel
							{
								Name = "Ilocos Norte",
								Code = "ILN"
							},
							new RegionModel
							{
								Name = "Ilocos Sur",
								Code = "ILS"
							},
							new RegionModel
							{
								Name = "Iloilo",
								Code = "ILI"
							},
							new RegionModel
							{
								Name = "Isabela",
								Code = "ISA"
							},
							new RegionModel
							{
								Name = "Kalinga",
								Code = "KAL"
							},
							new RegionModel
							{
								Name = "La Union",
								Code = "LUN"
							},
							new RegionModel
							{
								Name = "Laguna",
								Code = "LAG"
							},
							new RegionModel
							{
								Name = "Lanao del Norte",
								Code = "LAN"
							},
							new RegionModel
							{
								Name = "Lanao del Sur",
								Code = "LAS"
							},
							new RegionModel
							{
								Name = "Leyte",
								Code = "LEY"
							},
							new RegionModel
							{
								Name = "Maguindanao",
								Code = "MAG"
							},
							new RegionModel
							{
								Name = "Masbate",
								Code = "MAS"
							},
							new RegionModel
							{
								Name = "Metro Manila",
								Code = "00"
							},
							new RegionModel
							{
								Name = "Mindoro Occidental",
								Code = "MDC"
							},
							new RegionModel
							{
								Name = "Mindoro Oriental",
								Code = "MDR"
							},
							new RegionModel
							{
								Name = "Misamis Occidental",
								Code = "MSC"
							},
							new RegionModel
							{
								Name = "Misamis Oriental",
								Code = "MSR"
							},
							new RegionModel
							{
								Name = "Mountain Province",
								Code = "MOU"
							},
							new RegionModel
							{
								Name = "Negros Occidental",
								Code = "NEC"
							},
							new RegionModel
							{
								Name = "Negros Oriental",
								Code = "NER"
							},
							new RegionModel
							{
								Name = "Northern Samar",
								Code = "NSA"
							},
							new RegionModel
							{
								Name = "Nueva Ecija",
								Code = "NUE"
							},
							new RegionModel
							{
								Name = "Nueva Vizcaya",
								Code = "NUV"
							},
							new RegionModel
							{
								Name = "Palawan",
								Code = "PLW"
							},
							new RegionModel
							{
								Name = "Pampanga",
								Code = "PAM"
							},
							new RegionModel
							{
								Name = "Pangasinan",
								Code = "PAN"
							},
							new RegionModel
							{
								Name = "Quezon",
								Code = "QUE"
							},
							new RegionModel
							{
								Name = "Quirino",
								Code = "QUI"
							},
							new RegionModel
							{
								Name = "Rizal",
								Code = "RIZ"
							},
							new RegionModel
							{
								Name = "Romblon",
								Code = "ROM"
							},
							new RegionModel
							{
								Name = "Samar",
								Code = "WSA"
							},
							new RegionModel
							{
								Name = "Sarangani",
								Code = "SAR"
							},
							new RegionModel
							{
								Name = "Siquijor",
								Code = "SIG"
							},
							new RegionModel
							{
								Name = "Sorsogon",
								Code = "SOR"
							},
							new RegionModel
							{
								Name = "Southern Leyte",
								Code = "SLE"
							},
							new RegionModel
							{
								Name = "Sultan Kudarat",
								Code = "AUK"
							},
							new RegionModel
							{
								Name = "Sulu",
								Code = "SLU"
							},
							new RegionModel
							{
								Name = "Surigao del Norte",
								Code = "SUN"
							},
							new RegionModel
							{
								Name = "Surigao del Sur",
								Code = "SUR"
							},
							new RegionModel
							{
								Name = "Tarlac",
								Code = "TAR"
							},
							new RegionModel
							{
								Name = "Tawi-Tawi",
								Code = "TAW"
							},
							new RegionModel
							{
								Name = "Zambales",
								Code = "ZMB"
							},
							new RegionModel
							{
								Name = "Zamboanga del Norte",
								Code = "ZAN"
							},
							new RegionModel
							{
								Name = "Zamboanga del Sur",
								Code = "ZAS"
							},
							new RegionModel
							{
								Name = "Zamboanga Sibugay",
								Code = "ZSI"
							}
						}
					},
					new CountryModel
					{
						Name = "Pitcairn",
						Code = "PN",
						NativeName = "Pitkern Ailen",
						PhoneCode = "+64",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Pitcairn Islands",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Poland",
						Code = "PL",
						NativeName = "Polska",
						PhoneCode = "+48",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Dolnośląskie",
								Code = "DS"
							},
							new RegionModel
							{
								Name = "Kujawsko-pomorskie",
								Code = "KP"
							},
							new RegionModel
							{
								Name = "Łódzkie",
								Code = "LD"
							},
							new RegionModel
							{
								Name = "Lubelskie",
								Code = "LU"
							},
							new RegionModel
							{
								Name = "Lubuskie",
								Code = "LB"
							},
							new RegionModel
							{
								Name = "Małopolskie",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Mazowieckie",
								Code = "MZ"
							},
							new RegionModel
							{
								Name = "Opolskie",
								Code = "OP"
							},
							new RegionModel
							{
								Name = "Podkarpackie",
								Code = "PK"
							},
							new RegionModel
							{
								Name = "Podlaskie",
								Code = "PD"
							},
							new RegionModel
							{
								Name = "Pomorskie",
								Code = "PM"
							},
							new RegionModel
							{
								Name = "Śląskie",
								Code = "SL"
							},
							new RegionModel
							{
								Name = "Świętokrzyskie",
								Code = "SK"
							},
							new RegionModel
							{
								Name = "Warmińsko-mazurskie",
								Code = "WN"
							},
							new RegionModel
							{
								Name = "Wielkopolskie",
								Code = "WP"
							},
							new RegionModel
							{
								Name = "Zachodniopomorskie",
								Code = "ZP"
							}
						}
					},
					new CountryModel
					{
						Name = "Portugal",
						Code = "PT",
						NativeName = "",
						PhoneCode = "+351",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Açores",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Aveiro",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Beja",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Braga",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Bragança",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Castelo Branco",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Coimbra",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Évora",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Faro",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Guarda",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Leiria",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Lisboa",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Madeira",
								Code = "30"
							},
							new RegionModel
							{
								Name = "Portalegre",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Porto",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Santarém",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Setúbal",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Viana do Castelo",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Vila Real",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Viseu",
								Code = "18"
							}
						}
					},
					new CountryModel
					{
						Name = "Puerto Rico",
						Code = "PR",
						NativeName = "",
						PhoneCode = "+1",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Adjuntas",
								Code = null
							},
							new RegionModel
							{
								Name = "Aguada",
								Code = null
							},
							new RegionModel
							{
								Name = "Aguadilla",
								Code = null
							},
							new RegionModel
							{
								Name = "Aguas Buenas",
								Code = null
							},
							new RegionModel
							{
								Name = "Aibonito",
								Code = null
							},
							new RegionModel
							{
								Name = "Anasco",
								Code = null
							},
							new RegionModel
							{
								Name = "Arecibo",
								Code = null
							},
							new RegionModel
							{
								Name = "Arroyo",
								Code = null
							},
							new RegionModel
							{
								Name = "Barceloneta",
								Code = null
							},
							new RegionModel
							{
								Name = "Barranquitas",
								Code = null
							},
							new RegionModel
							{
								Name = "Bayamon",
								Code = null
							},
							new RegionModel
							{
								Name = "Cabo Rojo",
								Code = null
							},
							new RegionModel
							{
								Name = "Caguas",
								Code = null
							},
							new RegionModel
							{
								Name = "Camuy",
								Code = null
							},
							new RegionModel
							{
								Name = "Canovanas",
								Code = null
							},
							new RegionModel
							{
								Name = "Carolina",
								Code = null
							},
							new RegionModel
							{
								Name = "Cat",
								Code = null
							},
							new RegionModel
							{
								Name = "Ceiba",
								Code = null
							},
							new RegionModel
							{
								Name = "Ciales",
								Code = null
							},
							new RegionModel
							{
								Name = "Cidra",
								Code = null
							},
							new RegionModel
							{
								Name = "Coamo",
								Code = null
							},
							new RegionModel
							{
								Name = "Comerio",
								Code = null
							},
							new RegionModel
							{
								Name = "Corozal",
								Code = null
							},
							new RegionModel
							{
								Name = "Culebra",
								Code = null
							},
							new RegionModel
							{
								Name = "Dorado",
								Code = null
							},
							new RegionModel
							{
								Name = "Fajardo",
								Code = null
							},
							new RegionModel
							{
								Name = "Florida",
								Code = null
							},
							new RegionModel
							{
								Name = "Guanica",
								Code = null
							},
							new RegionModel
							{
								Name = "Guayama",
								Code = null
							},
							new RegionModel
							{
								Name = "Guayanilla",
								Code = null
							},
							new RegionModel
							{
								Name = "Guaynabo",
								Code = null
							},
							new RegionModel
							{
								Name = "Gurabo",
								Code = null
							},
							new RegionModel
							{
								Name = "Hatillo",
								Code = null
							},
							new RegionModel
							{
								Name = "Hormigueros",
								Code = null
							},
							new RegionModel
							{
								Name = "Humacao",
								Code = null
							},
							new RegionModel
							{
								Name = "Isabe",
								Code = null
							},
							new RegionModel
							{
								Name = "Juana Diaz",
								Code = null
							},
							new RegionModel
							{
								Name = "Juncos",
								Code = null
							},
							new RegionModel
							{
								Name = "Lajas",
								Code = null
							},
							new RegionModel
							{
								Name = "Lares",
								Code = null
							},
							new RegionModel
							{
								Name = "Las Marias",
								Code = null
							},
							new RegionModel
							{
								Name = "Las oiza",
								Code = null
							},
							new RegionModel
							{
								Name = "Luquillo",
								Code = null
							},
							new RegionModel
							{
								Name = "Manati",
								Code = null
							},
							new RegionModel
							{
								Name = "Maricao",
								Code = null
							},
							new RegionModel
							{
								Name = "Maunabo",
								Code = null
							},
							new RegionModel
							{
								Name = "Mayaguez",
								Code = null
							},
							new RegionModel
							{
								Name = "Moca",
								Code = null
							},
							new RegionModel
							{
								Name = "Morovis",
								Code = null
							},
							new RegionModel
							{
								Name = "Naguabo",
								Code = null
							},
							new RegionModel
							{
								Name = "Naranjito",
								Code = null
							},
							new RegionModel
							{
								Name = "Orocovis",
								Code = null
							},
							new RegionModel
							{
								Name = "Patillas",
								Code = null
							},
							new RegionModel
							{
								Name = "Penuelas",
								Code = null
							},
							new RegionModel
							{
								Name = "Ponce",
								Code = null
							},
							new RegionModel
							{
								Name = "Quebradillas",
								Code = null
							},
							new RegionModel
							{
								Name = "Rincon",
								Code = null
							},
							new RegionModel
							{
								Name = "Rio Grande",
								Code = null
							},
							new RegionModel
							{
								Name = "Sabana linas",
								Code = null
							},
							new RegionModel
							{
								Name = "San German",
								Code = null
							},
							new RegionModel
							{
								Name = "San Juan",
								Code = null
							},
							new RegionModel
							{
								Name = "San Lorenzo",
								Code = null
							},
							new RegionModel
							{
								Name = "San Sebastian",
								Code = null
							},
							new RegionModel
							{
								Name = "Santa Isabel",
								Code = null
							},
							new RegionModel
							{
								Name = "Toa Alta",
								Code = null
							},
							new RegionModel
							{
								Name = "Toa Baja",
								Code = null
							},
							new RegionModel
							{
								Name = "Trujillo Alto",
								Code = null
							},
							new RegionModel
							{
								Name = "Utuado",
								Code = null
							},
							new RegionModel
							{
								Name = "Vega Alta",
								Code = null
							},
							new RegionModel
							{
								Name = "Vega ues",
								Code = null
							},
							new RegionModel
							{
								Name = "Villalba",
								Code = null
							},
							new RegionModel
							{
								Name = "Yabucoa",
								Code = null
							},
							new RegionModel
							{
								Name = "Yauco",
								Code = null
							}
						}
					},
					#endregion
					};
					break;
				case 'Q':
					countries = new ObservableCollection<CountryModel> { 
					#region Q
				
					new CountryModel
					{
						Name = "Qatar",
						Code = "QA",
						NativeName = "دولة قطر",
						PhoneCode = "+974",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ad Dawḩah",
								Code = "DA"
							},
							new RegionModel
							{
								Name = "Al Khawr wa adh Dhakhīrah",
								Code = "KH"
							},
							new RegionModel
							{
								Name = "Al Wakrah",
								Code = "WA"
							},
							new RegionModel
							{
								Name = "Ar Rayyān",
								Code = "RA"
							},
							new RegionModel
							{
								Name = "Ash Shamāl",
								Code = "MS"
							},
							new RegionModel
							{
								Name = "Az̧ Za̧`āyin",
								Code = "ZA"
							},
							new RegionModel
							{
								Name = "Umm Şalāl",
								Code = "US"
							}
						}
					},
					#endregion
					};
					break;
				case 'R':
					countries = new ObservableCollection<CountryModel> { 
					#region R
				
					new CountryModel
					{
						Name = "Réunion",
						Code = "RE",
						NativeName = "La Réunion",
						PhoneCode = "+262",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Réunion",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Romania",
						Code = "RO",
						NativeName = "România",
						PhoneCode = "+40",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Alba",
								Code = "AB"
							},
							new RegionModel
							{
								Name = "Arad",
								Code = "AR"
							},
							new RegionModel
							{
								Name = "Arges",
								Code = "AG"
							},
							new RegionModel
							{
								Name = "Bacau",
								Code = "BC"
							},
							new RegionModel
							{
								Name = "Bihor",
								Code = "BH"
							},
							new RegionModel
							{
								Name = "Bistrita-Nasaud",
								Code = "BN"
							},
							new RegionModel
							{
								Name = "Botosani",
								Code = "BT"
							},
							new RegionModel
							{
								Name = "Braila",
								Code = "BR"
							},
							new RegionModel
							{
								Name = "Brasov",
								Code = "BV"
							},
							new RegionModel
							{
								Name = "Bucuresti",
								Code = "B"
							},
							new RegionModel
							{
								Name = "Buzau",
								Code = "BZ"
							},
							new RegionModel
							{
								Name = "Calarasi",
								Code = "CL"
							},
							new RegionModel
							{
								Name = "Caras-Severin",
								Code = "CS"
							},
							new RegionModel
							{
								Name = "Cluj",
								Code = "CJ"
							},
							new RegionModel
							{
								Name = "Constanta",
								Code = "CT"
							},
							new RegionModel
							{
								Name = "Covasna",
								Code = "CV"
							},
							new RegionModel
							{
								Name = "Dambovita",
								Code = "DB"
							},
							new RegionModel
							{
								Name = "Dolj",
								Code = "DJ"
							},
							new RegionModel
							{
								Name = "Galati",
								Code = "GL"
							},
							new RegionModel
							{
								Name = "Giurgiu",
								Code = "GR"
							},
							new RegionModel
							{
								Name = "Gorj",
								Code = "GJ"
							},
							new RegionModel
							{
								Name = "Harghita",
								Code = "HR"
							},
							new RegionModel
							{
								Name = "Hunedoara",
								Code = "HD"
							},
							new RegionModel
							{
								Name = "Ialomita",
								Code = "IL"
							},
							new RegionModel
							{
								Name = "Iasi",
								Code = "IS"
							},
							new RegionModel
							{
								Name = "Maramures",
								Code = "MM"
							},
							new RegionModel
							{
								Name = "Mehedinti",
								Code = "MH"
							},
							new RegionModel
							{
								Name = "Mures",
								Code = "MS"
							},
							new RegionModel
							{
								Name = "Neamt",
								Code = "NT"
							},
							new RegionModel
							{
								Name = "Olt",
								Code = "OT"
							},
							new RegionModel
							{
								Name = "Prahova",
								Code = "PH"
							},
							new RegionModel
							{
								Name = "Salaj",
								Code = "SJ"
							},
							new RegionModel
							{
								Name = "Satu Mare",
								Code = "SM"
							},
							new RegionModel
							{
								Name = "Sibiu",
								Code = "SB"
							},
							new RegionModel
							{
								Name = "Suceava",
								Code = "SV"
							},
							new RegionModel
							{
								Name = "Teleorman",
								Code = "TR"
							},
							new RegionModel
							{
								Name = "Timis",
								Code = "TM"
							},
							new RegionModel
							{
								Name = "Tulcea",
								Code = "TL"
							},
							new RegionModel
							{
								Name = "Valcea",
								Code = "VL"
							},
							new RegionModel
							{
								Name = "Vaslui",
								Code = "VS"
							},
							new RegionModel
							{
								Name = "Vrancea",
								Code = "VN"
							}
						}
					},
					new CountryModel
					{
						Name = "Russian",
						Code = "RU",
						NativeName = "Россия",
						PhoneCode = "+7",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Republic of Adygea",
								Code = "AD"
							},
							new RegionModel
							{
								Name = "Republic of Altai (Gorno-Altaysk)",
								Code = "AL"
							},
							new RegionModel
							{
								Name = "Altai Krai",
								Code = "ALT"
							},
							new RegionModel
							{
								Name = "Amur Oblast",
								Code = "AMU"
							},
							new RegionModel
							{
								Name = "Arkhangelsk Oblast",
								Code = "ARK"
							},
							new RegionModel
							{
								Name = "Astrakhan Oblast",
								Code = "AST"
							},
							new RegionModel
							{
								Name = "Republic of Bashkortostan",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Belgorod Oblast",
								Code = "BEL"
							},
							new RegionModel
							{
								Name = "Bryansk Oblast",
								Code = "BRY"
							},
							new RegionModel
							{
								Name = "Republic of Buryatia",
								Code = "BU"
							},
							new RegionModel
							{
								Name = "Chechen Republic",
								Code = "CE"
							},
							new RegionModel
							{
								Name = "Chelyabinsk Oblast",
								Code = "CHE"
							},
							new RegionModel
							{
								Name = "Chukotka Autonomous Okrug",
								Code = "CHU"
							},
							new RegionModel
							{
								Name = "Chuvash Republic",
								Code = "CU"
							},
							new RegionModel
							{
								Name = "Republic of Dagestan",
								Code = "DA"
							},
							new RegionModel
							{
								Name = "Republic of Ingushetia",
								Code = "IN"
							},
							new RegionModel
							{
								Name = "Irkutsk Oblast",
								Code = "IRK"
							},
							new RegionModel
							{
								Name = "Ivanovo Oblast",
								Code = "IVA"
							},
							new RegionModel
							{
								Name = "Jewish Autonomous Oblast",
								Code = "JEW"
							},
							new RegionModel
							{
								Name = "Kabardino-Balkar Republic",
								Code = "KB"
							},
							new RegionModel
							{
								Name = "Kaliningrad Oblast",
								Code = "KLN"
							},
							new RegionModel
							{
								Name = "Republic of Kalmykia",
								Code = "KL"
							},
							new RegionModel
							{
								Name = "Kaluga Oblast",
								Code = "KLU"
							},
							new RegionModel
							{
								Name = "Kamchatka Krai",
								Code = "KAM"
							},
							new RegionModel
							{
								Name = "Karachay-Cherkess Republic",
								Code = "KC"
							},
							new RegionModel
							{
								Name = "Republic of Karelia",
								Code = "KR"
							},
							new RegionModel
							{
								Name = "Khabarovsk Krai",
								Code = "KHA"
							},
							new RegionModel
							{
								Name = "Republic of Khakassia",
								Code = "KK"
							},
							new RegionModel
							{
								Name = "Khanty-Mansi Autonomous Okrug - Yugra",
								Code = "KHM"
							},
							new RegionModel
							{
								Name = "Kemerovo Oblast",
								Code = "KEM"
							},
							new RegionModel
							{
								Name = "Kirov Oblast",
								Code = "KIR"
							},
							new RegionModel
							{
								Name = "Komi Republic",
								Code = "KO"
							},
							new RegionModel
							{
								Name = "Kostroma Oblast",
								Code = "KOS"
							},
							new RegionModel
							{
								Name = "Krasnodar Krai",
								Code = "KDA"
							},
							new RegionModel
							{
								Name = "Krasnoyarsk Krai",
								Code = "KYA"
							},
							new RegionModel
							{
								Name = "Kurgan Oblast",
								Code = "KGN"
							},
							new RegionModel
							{
								Name = "Kursk Oblast",
								Code = "KRS"
							},
							new RegionModel
							{
								Name = "Leningrad Oblast",
								Code = "LEN"
							},
							new RegionModel
							{
								Name = "Lipetsk Oblast",
								Code = "LIP"
							},
							new RegionModel
							{
								Name = "Magadan Oblast",
								Code = "MAG"
							},
							new RegionModel
							{
								Name = "Mari El Republic",
								Code = "ME"
							},
							new RegionModel
							{
								Name = "Republic of Mordovia",
								Code = "MO"
							},
							new RegionModel
							{
								Name = "Moscow Oblast",
								Code = "MOS"
							},
							new RegionModel
							{
								Name = "Moscow",
								Code = "MOW"
							},
							new RegionModel
							{
								Name = "Murmansk Oblast",
								Code = "MU"
							},
							new RegionModel
							{
								Name = "Nenets Autonomous Okrug",
								Code = "NEN"
							},
							new RegionModel
							{
								Name = "Nizhny Novgorod Oblast",
								Code = "NIZ"
							},
							new RegionModel
							{
								Name = "Novgorod Oblast",
								Code = "NGR"
							},
							new RegionModel
							{
								Name = "Novosibirsk Oblast",
								Code = "NVS"
							},
							new RegionModel
							{
								Name = "Omsk Oblast",
								Code = "OMS"
							},
							new RegionModel
							{
								Name = "Orenburg Oblast",
								Code = "ORE"
							},
							new RegionModel
							{
								Name = "Oryol Oblast",
								Code = "ORL"
							},
							new RegionModel
							{
								Name = "Penza Oblast",
								Code = "PNZ"
							},
							new RegionModel
							{
								Name = "Perm Krai",
								Code = "PER"
							},
							new RegionModel
							{
								Name = "Primorsky Krai",
								Code = "PRI"
							},
							new RegionModel
							{
								Name = "Pskov Oblast",
								Code = "PSK"
							},
							new RegionModel
							{
								Name = "Rostov Oblast",
								Code = "ROS"
							},
							new RegionModel
							{
								Name = "Ryazan Oblast",
								Code = "RYA"
							},
							new RegionModel
							{
								Name = "Saint Petersburg",
								Code = "SPE"
							},
							new RegionModel
							{
								Name = "Sakha (Yakutia) Republic",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "Sakhalin Oblast",
								Code = "SAK"
							},
							new RegionModel
							{
								Name = "Samara Oblast",
								Code = "SAM"
							},
							new RegionModel
							{
								Name = "Saratov Oblast",
								Code = "SAR"
							},
							new RegionModel
							{
								Name = "Republic of North Ossetia-Alania",
								Code = "NOA"
							},
							new RegionModel
							{
								Name = "Smolensk Oblast",
								Code = "SMO"
							},
							new RegionModel
							{
								Name = "Stavropol Krai",
								Code = "STA"
							},
							new RegionModel
							{
								Name = "Sverdlovsk Oblast",
								Code = "SVE"
							},
							new RegionModel
							{
								Name = "Tambov Oblast",
								Code = "TAM"
							},
							new RegionModel
							{
								Name = "Republic of Tatarstan",
								Code = "TA"
							},
							new RegionModel
							{
								Name = "Tomsk Oblast",
								Code = "TOM"
							},
							new RegionModel
							{
								Name = "Tuva Republic",
								Code = "TU"
							},
							new RegionModel
							{
								Name = "Tula Oblast",
								Code = "TUL"
							},
							new RegionModel
							{
								Name = "Tver Oblast",
								Code = "TVE"
							},
							new RegionModel
							{
								Name = "Tyumen Oblast",
								Code = "TYU"
							},
							new RegionModel
							{
								Name = "Udmurt Republic",
								Code = "UD"
							},
							new RegionModel
							{
								Name = "Ulyanovsk Oblast",
								Code = "ULY"
							},
							new RegionModel
							{
								Name = "Vladimir Oblast",
								Code = "VLA"
							},
							new RegionModel
							{
								Name = "Volgograd Oblast",
								Code = "VGG"
							},
							new RegionModel
							{
								Name = "Vologda Oblast",
								Code = "VLG"
							},
							new RegionModel
							{
								Name = "Voronezh Oblast",
								Code = "VOR"
							},
							new RegionModel
							{
								Name = "Yamalo-Nenets Autonomous Okrug",
								Code = "YAN"
							},
							new RegionModel
							{
								Name = "Yaroslavl Oblast",
								Code = "YAR"
							},
							new RegionModel
							{
								Name = "Zabaykalsky Krai",
								Code = "ZAB"
							}
						}
					},
					new CountryModel
					{
						Name = "Rwanda",
						Code = "RW",
						NativeName = "",
						PhoneCode = "+250",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Kigali",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Eastern",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Northern",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Western",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Southern",
								Code = "05"
							}
						}
					},
					#endregion
					};
					break;
				case 'S':
					countries = new ObservableCollection<CountryModel> { 
					#region S
					new CountryModel
					{
						Name = "Saint Barthélemy",
						Code = "BL",
						NativeName = "",
						PhoneCode = "+590",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Au Vent",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Sous le Vent",
								Code = "01"
							}
						}
					},
					new CountryModel
					{
						Name = "Saint Helena",
						Code = "SH",
						NativeName = "",
						PhoneCode = "+290",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ascension",
								Code = "AC"
							},
							new RegionModel
							{
								Name = "Saint Helena",
								Code = "HL"
							},
							new RegionModel
							{
								Name = "Tristan da Cunha",
								Code = "TA"
							}
						}
					},
					new CountryModel
					{
						Name = "Saint Kitts and Nevis",
						Code = "KN",
						NativeName = "",
						PhoneCode = "+1",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Saint Kitts",
								Code = "K"
							},
							new RegionModel
							{
								Name = "Nevis",
								Code = "N"
							}
						}
					},
					new CountryModel
					{
						Name = "Saint Lucia",
						Code = "LC",
						NativeName = "Sent Lisi",
						PhoneCode = "+1",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Anse-la-Raye",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Canaries",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Castries",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Choiseul",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Dennery",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Gros Islet",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Laborie",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Micoud",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Soufriere",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Vieux Fort",
								Code = "11"
							}
						}
					},
					new CountryModel
					{
						Name = "Saint Pierre and Miquelon",
						Code = "PM",
						NativeName = "Saint Pierre et Miquelon",
						PhoneCode = "+508",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Miquelon",
								Code = null
							},
							new RegionModel
							{
								Name = "Saint Pierre",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Saint Vincent and the Grenadines",
						Code = "VC",
						NativeName = "",
						PhoneCode = "+1 784",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Charlotte",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Grenadines",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Saint Andrew",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Saint David",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Saint George",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Saint Patrick",
								Code = "05"
							}
						}
					},
					new CountryModel
					{
						Name = "Samoa",
						Code = "WS",
						NativeName = "Sāmoa",
						PhoneCode = "+685",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "A'ana",
								Code = "AA"
							},
							new RegionModel
							{
								Name = "Aiga-i-le-Tai",
								Code = "AL"
							},
							new RegionModel
							{
								Name = "Atua",
								Code = "AT"
							},
							new RegionModel
							{
								Name = "Fa'asaleleaga",
								Code = "FA"
							},
							new RegionModel
							{
								Name = "Gaga'emauga",
								Code = "GE"
							},
							new RegionModel
							{
								Name = "Gagaifomauga",
								Code = "GI"
							},
							new RegionModel
							{
								Name = "Palauli",
								Code = "PA"
							},
							new RegionModel
							{
								Name = "Satupa'itea",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "Tuamasaga",
								Code = "TU"
							},
							new RegionModel
							{
								Name = "Va'a-o-Fonoti",
								Code = "VF"
							},
							new RegionModel
							{
								Name = "Vaisigano",
								Code = "VS"
							}
						}
					},
					new CountryModel
					{
						Name = "San Marino",
						Code = "SM",
						NativeName = "",
						PhoneCode = "+378",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Acquaviva",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Borgo Maggiore",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Chiesanuova",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Domagnano",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Faetano",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Fiorentino",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Montegiardino",
								Code = "08"
							},
							new RegionModel
							{
								Name = "San Marino",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Serravalle",
								Code = "09"
							}
						}
					},
					new CountryModel
					{
						Name = "Sao Tome and Principe",
						Code = "ST",
						NativeName = "São Tomé e Príncipe",
						PhoneCode = "+239",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Principe",
								Code = "P"
							},
							new RegionModel
							{
								Name = "Sao Tome",
								Code = "S"
							}
						}
					},
					new CountryModel
					{
						Name = "Saudi Arabia",
						Code = "SA",
						NativeName = "المملكة العربية السعودية",
						PhoneCode = "+966",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "'Asir",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Al Bahah",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Al Hudud ash Shamaliyah",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Al Jawf",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Al Madinah al Munawwarah",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Al Qasim",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Ar Riyad",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Ash Sharqiyah",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Ha'il",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Jazan",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Makkah al Mukarramah",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Najran",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Tabuk",
								Code = "07"
							}
						}
					},
					new CountryModel
					{
						Name = "Senegal",
						Code = "SN",
						NativeName = "Sénégal",
						PhoneCode = "+221",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Dakar",
								Code = "DK"
							},
							new RegionModel
							{
								Name = "Diourbel",
								Code = "DB"
							},
							new RegionModel
							{
								Name = "Fatick",
								Code = "FK"
							},
							new RegionModel
							{
								Name = "Kaffrine",
								Code = "KA"
							},
							new RegionModel
							{
								Name = "Kaolack",
								Code = "KL"
							},
							new RegionModel
							{
								Name = "Kedougou",
								Code = "KE"
							},
							new RegionModel
							{
								Name = "Kolda",
								Code = "KD"
							},
							new RegionModel
							{
								Name = "Louga",
								Code = "LG"
							},
							new RegionModel
							{
								Name = "Matam",
								Code = "MT"
							},
							new RegionModel
							{
								Name = "Saint-Louis",
								Code = "SL"
							},
							new RegionModel
							{
								Name = "Sedhiou",
								Code = "SE"
							},
							new RegionModel
							{
								Name = "Tambacounda",
								Code = "TC"
							},
							new RegionModel
							{
								Name = "Thies",
								Code = "TH"
							},
							new RegionModel
							{
								Name = "Ziguinchor",
								Code = "ZG"
							}
						}
					},
					new CountryModel
					{
						Name = "Serbia",
						Code = "RS",
						NativeName = "Србија , Srbija",
						PhoneCode = "+381",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Beograd (Belgrade)",
								Code = "00"
							},
							new RegionModel
							{
								Name = "Borski",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Braničevski",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Jablanički",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Južnobački",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Južnobanatski",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Kolubarski",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Kosovski",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Kosovsko-Mitrovački",
								Code = "28"
							},
							new RegionModel
							{
								Name = "Kosovsko-Pomoravski",
								Code = "29"
							},
							new RegionModel
							{
								Name = "Mačvanski",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Moravički",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Nišavski",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Pčinjski",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Pećki",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Pirotski",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Podunavski",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Pomoravski",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Prizrenski",
								Code = "27"
							},
							new RegionModel
							{
								Name = "Rasinski",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Raški",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Severnobački",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Severnobanatski",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Srednjebanatski",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Sremski",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Šumadijski",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Toplički",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Zaječarski",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Zapadnobački",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Zlatiborski",
								Code = "16"
							}
						}
					},
					new CountryModel
					{
						Name = "Seychelles",
						Code = "SC",
						NativeName = "Sesel",
						PhoneCode = "+248",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Anse aux Pins",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Anse Boileau",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Anse Etoile",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Anse Royale",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Anu Cap",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Baie Lazare",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Baie Sainte Anne",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Beau Vallon",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Bel Air",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Bel Ombre",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Cascade",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Glacis",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Grand'Anse Mahe",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Grand'Anse Praslin",
								Code = "14"
							},
							new RegionModel
							{
								Name = "La Digue",
								Code = "15"
							},
							new RegionModel
							{
								Name = "La Riviere Anglaise",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Les Mamelles",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Mont Buxton",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Mont Fleuri",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Plaisance",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Pointe La Rue",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Port Glaud",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Roche Caiman",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Saint Louis",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Takamaka",
								Code = "23"
							}
						}
					},
					new CountryModel
					{
						Name = "Sierra Leone",
						Code = "SL",
						NativeName = "",
						PhoneCode = "+232",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Eastern",
								Code = "E"
							},
							new RegionModel
							{
								Name = "Northern",
								Code = "N"
							},
							new RegionModel
							{
								Name = "Southern",
								Code = "S"
							},
							new RegionModel
							{
								Name = "Western",
								Code = "W"
							}
						}
					},
					new CountryModel
					{
						Name = "Singapore",
						Code = "SG",
						NativeName = "Singapura , 新加坡 , சிங்கப்பூர்",
						PhoneCode = "+65",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Central Singapore",
								Code = "01"
							},
							new RegionModel
							{
								Name = "North East",
								Code = "02"
							},
							new RegionModel
							{
								Name = "North West",
								Code = "03"
							},
							new RegionModel
							{
								Name = "South East",
								Code = "04"
							},
							new RegionModel
							{
								Name = "South West",
								Code = "05"
							}
						}
					},
					new CountryModel
					{
						Name = "Sint Maarten (Dutch part)",
						Code = "SX",
						NativeName = "Sint Maarten",
						PhoneCode = "+1 721",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Sint Maarten",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Slovakia",
						Code = "SK",
						NativeName = "Slovensko",
						PhoneCode = "+421",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Banskobystricky",
								Code = "BC"
							},
							new RegionModel
							{
								Name = "Bratislavsky",
								Code = "BL"
							},
							new RegionModel
							{
								Name = "Kosicky",
								Code = "KI"
							},
							new RegionModel
							{
								Name = "Nitriansky",
								Code = "NI"
							},
							new RegionModel
							{
								Name = "Presovsky",
								Code = "PV"
							},
							new RegionModel
							{
								Name = "Trenciansky",
								Code = "TC"
							},
							new RegionModel
							{
								Name = "Trnavsky",
								Code = "TA"
							},
							new RegionModel
							{
								Name = "Zilinsky",
								Code = "ZI"
							}
						}
					},
					new CountryModel
					{
						Name = "Slovenia",
						Code = "SI",
						NativeName = "Slovenija",
						PhoneCode = "+386",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ajdovscina",
								Code = "001"
							},
							new RegionModel
							{
								Name = "Apace",
								Code = "195"
							},
							new RegionModel
							{
								Name = "Beltinci",
								Code = "002"
							},
							new RegionModel
							{
								Name = "Benedikt",
								Code = "148"
							},
							new RegionModel
							{
								Name = "Bistrica ob Sotli",
								Code = "149"
							},
							new RegionModel
							{
								Name = "Bled",
								Code = "003"
							},
							new RegionModel
							{
								Name = "Bloke",
								Code = "150"
							},
							new RegionModel
							{
								Name = "Bohinj",
								Code = "004"
							},
							new RegionModel
							{
								Name = "Borovnica",
								Code = "005"
							},
							new RegionModel
							{
								Name = "Bovec",
								Code = "006"
							},
							new RegionModel
							{
								Name = "Braslovce",
								Code = "151"
							},
							new RegionModel
							{
								Name = "Brda",
								Code = "007"
							},
							new RegionModel
							{
								Name = "Brezice",
								Code = "009"
							},
							new RegionModel
							{
								Name = "Brezovica",
								Code = "008"
							},
							new RegionModel
							{
								Name = "Cankova",
								Code = "152"
							},
							new RegionModel
							{
								Name = "Celje",
								Code = "011"
							},
							new RegionModel
							{
								Name = "Cerklje na Gorenjskem",
								Code = "012"
							},
							new RegionModel
							{
								Name = "Cerknica",
								Code = "013"
							},
							new RegionModel
							{
								Name = "Cerkno",
								Code = "014"
							},
							new RegionModel
							{
								Name = "Cerkvenjak",
								Code = "153"
							},
							new RegionModel
							{
								Name = "Cirkulane",
								Code = "196"
							},
							new RegionModel
							{
								Name = "Crensovci",
								Code = "015"
							},
							new RegionModel
							{
								Name = "Crna na Koroskem",
								Code = "016"
							},
							new RegionModel
							{
								Name = "Crnomelj",
								Code = "017"
							},
							new RegionModel
							{
								Name = "Destrnik",
								Code = "018"
							},
							new RegionModel
							{
								Name = "Divaca",
								Code = "019"
							},
							new RegionModel
							{
								Name = "Dobje",
								Code = "154"
							},
							new RegionModel
							{
								Name = "Dobrepolje",
								Code = "020"
							},
							new RegionModel
							{
								Name = "Dobrna",
								Code = "155"
							},
							new RegionModel
							{
								Name = "Dobrova-Polhov Gradec",
								Code = "021"
							},
							new RegionModel
							{
								Name = "Dobrovnik",
								Code = "156"
							},
							new RegionModel
							{
								Name = "Dol pri Ljubljani",
								Code = "022"
							},
							new RegionModel
							{
								Name = "Dolenjske Toplice",
								Code = "157"
							},
							new RegionModel
							{
								Name = "Domzale",
								Code = "023"
							},
							new RegionModel
							{
								Name = "Dornava",
								Code = "024"
							},
							new RegionModel
							{
								Name = "Dravograd",
								Code = "025"
							},
							new RegionModel
							{
								Name = "Duplek",
								Code = "026"
							},
							new RegionModel
							{
								Name = "Gorenja Vas-Poljane",
								Code = "027"
							},
							new RegionModel
							{
								Name = "Gorisnica",
								Code = "028"
							},
							new RegionModel
							{
								Name = "Gorje",
								Code = "207"
							},
							new RegionModel
							{
								Name = "Gornja Radgona",
								Code = "029"
							},
							new RegionModel
							{
								Name = "Gornji Grad",
								Code = "030"
							},
							new RegionModel
							{
								Name = "Gornji Petrovci",
								Code = "031"
							},
							new RegionModel
							{
								Name = "Grad",
								Code = "158"
							},
							new RegionModel
							{
								Name = "Grosuplje",
								Code = "032"
							},
							new RegionModel
							{
								Name = "Hajdina",
								Code = "159"
							},
							new RegionModel
							{
								Name = "Hoce-Slivnica",
								Code = "160"
							},
							new RegionModel
							{
								Name = "Hodos",
								Code = "161"
							},
							new RegionModel
							{
								Name = "Horjul",
								Code = "162"
							},
							new RegionModel
							{
								Name = "Hrastnik",
								Code = "034"
							},
							new RegionModel
							{
								Name = "Hrpelje-Kozina",
								Code = "035"
							},
							new RegionModel
							{
								Name = "Idrija",
								Code = "036"
							},
							new RegionModel
							{
								Name = "Ig",
								Code = "037"
							},
							new RegionModel
							{
								Name = "Ilirska Bistrica",
								Code = "038"
							},
							new RegionModel
							{
								Name = "Ivancna Gorica",
								Code = "039"
							},
							new RegionModel
							{
								Name = "Izola",
								Code = "040"
							},
							new RegionModel
							{
								Name = "Jesenice",
								Code = "041"
							},
							new RegionModel
							{
								Name = "Jursinci",
								Code = "042"
							},
							new RegionModel
							{
								Name = "Kamnik",
								Code = "043"
							},
							new RegionModel
							{
								Name = "Kanal",
								Code = "044"
							},
							new RegionModel
							{
								Name = "Kidricevo",
								Code = "045"
							},
							new RegionModel
							{
								Name = "Kobarid",
								Code = "046"
							},
							new RegionModel
							{
								Name = "Kobilje",
								Code = "047"
							},
							new RegionModel
							{
								Name = "Kocevje",
								Code = "048"
							},
							new RegionModel
							{
								Name = "Komen",
								Code = "049"
							},
							new RegionModel
							{
								Name = "Komenda",
								Code = "164"
							},
							new RegionModel
							{
								Name = "Koper",
								Code = "050"
							},
							new RegionModel
							{
								Name = "Kodanjevica na Krki",
								Code = "197"
							},
							new RegionModel
							{
								Name = "Kostel",
								Code = "165"
							},
							new RegionModel
							{
								Name = "Kozje",
								Code = "051"
							},
							new RegionModel
							{
								Name = "Kranj",
								Code = "052"
							},
							new RegionModel
							{
								Name = "Kranjska Gora",
								Code = "053"
							},
							new RegionModel
							{
								Name = "Krizevci",
								Code = "166"
							},
							new RegionModel
							{
								Name = "Krsko",
								Code = "054"
							},
							new RegionModel
							{
								Name = "Kungota",
								Code = "055"
							},
							new RegionModel
							{
								Name = "Kuzma",
								Code = "056"
							},
							new RegionModel
							{
								Name = "Lasko",
								Code = "057"
							},
							new RegionModel
							{
								Name = "Lenart",
								Code = "058"
							},
							new RegionModel
							{
								Name = "Lendava",
								Code = "059"
							},
							new RegionModel
							{
								Name = "Litija",
								Code = "060"
							},
							new RegionModel
							{
								Name = "Ljubljana",
								Code = "061"
							},
							new RegionModel
							{
								Name = "Ljubno",
								Code = "062"
							},
							new RegionModel
							{
								Name = "Ljutomer",
								Code = "063"
							},
							new RegionModel
							{
								Name = "Log-Dragomer",
								Code = "208"
							},
							new RegionModel
							{
								Name = "Logatec",
								Code = "064"
							},
							new RegionModel
							{
								Name = "Loska Dolina",
								Code = "065"
							},
							new RegionModel
							{
								Name = "Loski Potok",
								Code = "066"
							},
							new RegionModel
							{
								Name = "Lovrenc na Pohorju",
								Code = "167"
							},
							new RegionModel
							{
								Name = "Lukovica",
								Code = "068"
							},
							new RegionModel
							{
								Name = "Luce",
								Code = "067"
							},
							new RegionModel
							{
								Name = "Majsperk",
								Code = "069"
							},
							new RegionModel
							{
								Name = "Makole",
								Code = "198"
							},
							new RegionModel
							{
								Name = "Maribor",
								Code = "070"
							},
							new RegionModel
							{
								Name = "Markovci",
								Code = "168"
							},
							new RegionModel
							{
								Name = "Medvode",
								Code = "071"
							},
							new RegionModel
							{
								Name = "Menges",
								Code = "072"
							},
							new RegionModel
							{
								Name = "Metlika",
								Code = "073"
							},
							new RegionModel
							{
								Name = "Mezica",
								Code = "074"
							},
							new RegionModel
							{
								Name = "Miklavz na Dravskem Polju",
								Code = "169"
							},
							new RegionModel
							{
								Name = "Miren-Kostanjevica",
								Code = "075"
							},
							new RegionModel
							{
								Name = "Mirna",
								Code = "212"
							},
							new RegionModel
							{
								Name = "Mirna Pec",
								Code = "170"
							},
							new RegionModel
							{
								Name = "Mislinja",
								Code = "076"
							},
							new RegionModel
							{
								Name = "Mokronog-Trebelno",
								Code = "199"
							},
							new RegionModel
							{
								Name = "Moravce",
								Code = "077"
							},
							new RegionModel
							{
								Name = "Moravske Toplice",
								Code = "078"
							},
							new RegionModel
							{
								Name = "Mozirje",
								Code = "079"
							},
							new RegionModel
							{
								Name = "Murska Sobota",
								Code = "080"
							},
							new RegionModel
							{
								Name = "Naklo",
								Code = "082"
							},
							new RegionModel
							{
								Name = "Nazarje",
								Code = "083"
							},
							new RegionModel
							{
								Name = "Nova Gorica",
								Code = "084"
							},
							new RegionModel
							{
								Name = "Novo Mesto",
								Code = "085"
							},
							new RegionModel
							{
								Name = "Odranci",
								Code = "086"
							},
							new RegionModel
							{
								Name = "Ormoz",
								Code = "087"
							},
							new RegionModel
							{
								Name = "Osilnica",
								Code = "088"
							},
							new RegionModel
							{
								Name = "Pesnica",
								Code = "089"
							},
							new RegionModel
							{
								Name = "Piran",
								Code = "090"
							},
							new RegionModel
							{
								Name = "Pivka",
								Code = "091"
							},
							new RegionModel
							{
								Name = "Podcetrtek",
								Code = "092"
							},
							new RegionModel
							{
								Name = "Podlehnik",
								Code = "172"
							},
							new RegionModel
							{
								Name = "Podvelka",
								Code = "093"
							},
							new RegionModel
							{
								Name = "Poljcane",
								Code = "200"
							},
							new RegionModel
							{
								Name = "Postojna",
								Code = "094"
							},
							new RegionModel
							{
								Name = "Prebold",
								Code = "174"
							},
							new RegionModel
							{
								Name = "Preddvor",
								Code = "095"
							},
							new RegionModel
							{
								Name = "Prevalje",
								Code = "175"
							},
							new RegionModel
							{
								Name = "Ptuj",
								Code = "096"
							},
							new RegionModel
							{
								Name = "Race-Fram",
								Code = "098"
							},
							new RegionModel
							{
								Name = "Radece",
								Code = "099"
							},
							new RegionModel
							{
								Name = "Radenci",
								Code = "100"
							},
							new RegionModel
							{
								Name = "Radlje ob Dravi",
								Code = "101"
							},
							new RegionModel
							{
								Name = "Radovljica",
								Code = "102"
							},
							new RegionModel
							{
								Name = "Ravne na Koroskem",
								Code = "103"
							},
							new RegionModel
							{
								Name = "Razkrizje",
								Code = "176"
							},
							new RegionModel
							{
								Name = "Recica ob Savinji",
								Code = "209"
							},
							new RegionModel
							{
								Name = "Rence-Vogrsko",
								Code = "201"
							},
							new RegionModel
							{
								Name = "Ribnica",
								Code = "104"
							},
							new RegionModel
							{
								Name = "Ribnica na Poboriu",
								Code = "177"
							},
							new RegionModel
							{
								Name = "Rogaska Slatina",
								Code = "106"
							},
							new RegionModel
							{
								Name = "Rogasovci",
								Code = "105"
							},
							new RegionModel
							{
								Name = "Rogatec",
								Code = "107"
							},
							new RegionModel
							{
								Name = "Ruse",
								Code = "108"
							},
							new RegionModel
							{
								Name = "Salovci",
								Code = "033"
							},
							new RegionModel
							{
								Name = "Selnica ob Dravi",
								Code = "178"
							},
							new RegionModel
							{
								Name = "Semic",
								Code = "109"
							},
							new RegionModel
							{
								Name = "Sempeter-Vrtojba",
								Code = "183"
							},
							new RegionModel
							{
								Name = "Sencur",
								Code = "117"
							},
							new RegionModel
							{
								Name = "Sentilj",
								Code = "118"
							},
							new RegionModel
							{
								Name = "Sentjernej",
								Code = "119"
							},
							new RegionModel
							{
								Name = "Sentjur",
								Code = "120"
							},
							new RegionModel
							{
								Name = "Sentrupert",
								Code = "211"
							},
							new RegionModel
							{
								Name = "Sevnica",
								Code = "110"
							},
							new RegionModel
							{
								Name = "Sezana",
								Code = "111"
							},
							new RegionModel
							{
								Name = "Skocjan",
								Code = "121"
							},
							new RegionModel
							{
								Name = "Skofja Loka",
								Code = "122"
							},
							new RegionModel
							{
								Name = "Skofljica",
								Code = "123"
							},
							new RegionModel
							{
								Name = "Slovenj Gradec",
								Code = "112"
							},
							new RegionModel
							{
								Name = "Slovenska Bistrica",
								Code = "113"
							},
							new RegionModel
							{
								Name = "Slovenske Konjice",
								Code = "114"
							},
							new RegionModel
							{
								Name = "Smarje pri elsah",
								Code = "124"
							},
							new RegionModel
							{
								Name = "Smarjeske Toplice",
								Code = "206"
							},
							new RegionModel
							{
								Name = "Smartno ob Paki",
								Code = "125"
							},
							new RegionModel
							{
								Name = "Smartno pri Litiji",
								Code = "194"
							},
							new RegionModel
							{
								Name = "Sodrazica",
								Code = "179"
							},
							new RegionModel
							{
								Name = "Solcava",
								Code = "180"
							},
							new RegionModel
							{
								Name = "Sostanj",
								Code = "126"
							},
							new RegionModel
							{
								Name = "Sredisce ob Dravi",
								Code = "202"
							},
							new RegionModel
							{
								Name = "Starse",
								Code = "115"
							},
							new RegionModel
							{
								Name = "Store",
								Code = "127"
							},
							new RegionModel
							{
								Name = "Straza",
								Code = "203"
							},
							new RegionModel
							{
								Name = "Sveta Ana",
								Code = "181"
							},
							new RegionModel
							{
								Name = "Sveta Trojica v Slovenskih Goricah",
								Code = "204"
							},
							new RegionModel
							{
								Name = "Sveta Andraz v Slovenskih Goricah",
								Code = "182"
							},
							new RegionModel
							{
								Name = "Sveti Jurij",
								Code = "116"
							},
							new RegionModel
							{
								Name = "Sveti Jurij v Slovenskih Goricah",
								Code = "210"
							},
							new RegionModel
							{
								Name = "Sveti Tomaz",
								Code = "205"
							},
							new RegionModel
							{
								Name = "Tabor",
								Code = "184"
							},
							new RegionModel
							{
								Name = "Tisina",
								Code = "010"
							},
							new RegionModel
							{
								Name = "Tolmin",
								Code = "128"
							},
							new RegionModel
							{
								Name = "Trbovlje",
								Code = "129"
							},
							new RegionModel
							{
								Name = "Trebnje",
								Code = "130"
							},
							new RegionModel
							{
								Name = "Trnovska Vas",
								Code = "185"
							},
							new RegionModel
							{
								Name = "Trzin",
								Code = "186"
							},
							new RegionModel
							{
								Name = "Trzic",
								Code = "131"
							},
							new RegionModel
							{
								Name = "Turnisce",
								Code = "132"
							},
							new RegionModel
							{
								Name = "Velenje",
								Code = "133"
							},
							new RegionModel
							{
								Name = "Velika Polana",
								Code = "187"
							},
							new RegionModel
							{
								Name = "Velike Lasce",
								Code = "134"
							},
							new RegionModel
							{
								Name = "Verzej",
								Code = "188"
							},
							new RegionModel
							{
								Name = "Videm",
								Code = "135"
							},
							new RegionModel
							{
								Name = "Vipava",
								Code = "136"
							},
							new RegionModel
							{
								Name = "Vitanje",
								Code = "137"
							},
							new RegionModel
							{
								Name = "Vodice",
								Code = "138"
							},
							new RegionModel
							{
								Name = "Vojnik",
								Code = "139"
							},
							new RegionModel
							{
								Name = "Vransko",
								Code = "189"
							},
							new RegionModel
							{
								Name = "Vrhnika",
								Code = "140"
							},
							new RegionModel
							{
								Name = "Vuzenica",
								Code = "141"
							},
							new RegionModel
							{
								Name = "Zagorje ob Savi",
								Code = "142"
							},
							new RegionModel
							{
								Name = "Zavrc",
								Code = "143"
							},
							new RegionModel
							{
								Name = "Zrece",
								Code = "144"
							},
							new RegionModel
							{
								Name = "Zalec",
								Code = "190"
							},
							new RegionModel
							{
								Name = "Zelezniki",
								Code = "146"
							},
							new RegionModel
							{
								Name = "Zetale",
								Code = "191"
							},
							new RegionModel
							{
								Name = "Ziri",
								Code = "147"
							},
							new RegionModel
							{
								Name = "Zirovnica",
								Code = "192"
							},
							new RegionModel
							{
								Name = "Zuzemberk",
								Code = "193"
							}
						}
					},
					new CountryModel
					{
						Name = "Solomon Islands",
						Code = "SB",
						NativeName = "",
						PhoneCode = "+677",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Central",
								Code = "CE"
							},
							new RegionModel
							{
								Name = "Choiseul",
								Code = "CH"
							},
							new RegionModel
							{
								Name = "Guadalcanal",
								Code = "GU"
							},
							new RegionModel
							{
								Name = "Honiara",
								Code = "CT"
							},
							new RegionModel
							{
								Name = "Isabel",
								Code = "IS"
							},
							new RegionModel
							{
								Name = "Makira-Ulawa",
								Code = "MK"
							},
							new RegionModel
							{
								Name = "Malaita",
								Code = "ML"
							},
							new RegionModel
							{
								Name = "Rennell and Bellona",
								Code = "RB"
							},
							new RegionModel
							{
								Name = "Temotu",
								Code = "TE"
							},
							new RegionModel
							{
								Name = "Western",
								Code = "WE"
							}
						}
					},
					new CountryModel
					{
						Name = "Somalia",
						Code = "SO",
						NativeName = "Jamhuuriyadda Federaalka Soomaaliya , جمهورية الصومال الفدرالية",
						PhoneCode = "+252",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Awdal",
								Code = "AW"
							},
							new RegionModel
							{
								Name = "Bakool",
								Code = "BK"
							},
							new RegionModel
							{
								Name = "Banaadir",
								Code = "BN"
							},
							new RegionModel
							{
								Name = "Bari",
								Code = "BR"
							},
							new RegionModel
							{
								Name = "Bay",
								Code = "BY"
							},
							new RegionModel
							{
								Name = "Galguduud",
								Code = "GA"
							},
							new RegionModel
							{
								Name = "Gedo",
								Code = "GE"
							},
							new RegionModel
							{
								Name = "Hiiraan",
								Code = "HI"
							},
							new RegionModel
							{
								Name = "Jubbada Dhexe",
								Code = "JD"
							},
							new RegionModel
							{
								Name = "Jubbada Hoose",
								Code = "JH"
							},
							new RegionModel
							{
								Name = "Mudug",
								Code = "MU"
							},
							new RegionModel
							{
								Name = "Nugaal",
								Code = "NU"
							},
							new RegionModel
							{
								Name = "Sanaag",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "Shabeellaha Dhexe",
								Code = "SD"
							},
							new RegionModel
							{
								Name = "Shabeellaha Hoose",
								Code = "SH"
							},
							new RegionModel
							{
								Name = "Sool",
								Code = "SO"
							},
							new RegionModel
							{
								Name = "Togdheer",
								Code = "TO"
							},
							new RegionModel
							{
								Name = "Woqooyi Galbeed",
								Code = "WO"
							}
						}
					},
					new CountryModel
					{
						Name = "South Africa",
						Code = "ZA",
						NativeName = "Suid-Afrika , Iningizimu Afrika , Mzantsi Afrika",
						PhoneCode = "+27",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Eastern Cape",
								Code = "EC"
							},
							new RegionModel
							{
								Name = "Free State",
								Code = "FS"
							},
							new RegionModel
							{
								Name = "Gauteng",
								Code = "GT"
							},
							new RegionModel
							{
								Name = "KwaZulu-Natal",
								Code = "NL"
							},
							new RegionModel
							{
								Name = "Limpopo",
								Code = "LP"
							},
							new RegionModel
							{
								Name = "Mpumalanga",
								Code = "MP"
							},
							new RegionModel
							{
								Name = "Northern Cape",
								Code = "NC"
							},
							new RegionModel
							{
								Name = "North West",
								Code = "NW"
							},
							new RegionModel
							{
								Name = "Western Cape",
								Code = "WC"
							}
						}
					},
					new CountryModel
					{
						Name = "South Georgia and South Sandwich Islands",
						Code = "GS",
						NativeName = "",
						PhoneCode = "+500",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bird Island",
								Code = null
							},
							new RegionModel
							{
								Name = "Bristol Island",
								Code = null
							},
							new RegionModel
							{
								Name = "Clerke Rocks",
								Code = null
							},
							new RegionModel
							{
								Name = "Montagu Island",
								Code = null
							},
							new RegionModel
							{
								Name = "Saunders Island",
								Code = null
							},
							new RegionModel
							{
								Name = "South Georgia",
								Code = null
							},
							new RegionModel
							{
								Name = "Southern Thule",
								Code = null
							},
							new RegionModel
							{
								Name = "Traversay Islands",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "South Sudan",
						Code = "SS",
						NativeName = "Jamhuri ya Sudan Kusini",
						PhoneCode = "+211",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Central Equatoria",
								Code = "CE"
							},
							new RegionModel
							{
								Name = "Eastern Equatoria",
								Code = "EE"
							},
							new RegionModel
							{
								Name = "Jonglei",
								Code = "JG"
							},
							new RegionModel
							{
								Name = "Lakes",
								Code = "LK"
							},
							new RegionModel
							{
								Name = "Northern Bahr el Ghazal",
								Code = "BN"
							},
							new RegionModel
							{
								Name = "Unity",
								Code = "UY"
							},
							new RegionModel
							{
								Name = "Upper Nile",
								Code = "NU"
							},
							new RegionModel
							{
								Name = "Warrap",
								Code = "WR"
							},
							new RegionModel
							{
								Name = "Western Bahr el Ghazal",
								Code = "BW"
							},
							new RegionModel
							{
								Name = "Western Equatoria",
								Code = "EW"
							}
						}
					},
					new CountryModel
					{
						Name = "Spain",
						Code = "ES",
						NativeName = "España",
						PhoneCode = "+34",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Albacete",
								Code = "AB"
							},
							new RegionModel
							{
								Name = "Alicante",
								Code = "A"
							},
							new RegionModel
							{
								Name = "Almería",
								Code = "AN"
							},
							new RegionModel
							{
								Name = "Araba/Álava",
								Code = "VI"
							},
							new RegionModel
							{
								Name = "Asturias",
								Code = "O"
							},
							new RegionModel
							{
								Name = "Ávila",
								Code = "AV"
							},
							new RegionModel
							{
								Name = "Badajoz",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Barcelona",
								Code = "B"
							},
							new RegionModel
							{
								Name = "Bizkaia",
								Code = "BI"
							},
							new RegionModel
							{
								Name = "Burgos",
								Code = "BU"
							},
							new RegionModel
							{
								Name = "Cáceres",
								Code = "CC"
							},
							new RegionModel
							{
								Name = "Cádiz",
								Code = "CA"
							},
							new RegionModel
							{
								Name = "Cantabria",
								Code = "S"
							},
							new RegionModel
							{
								Name = "Castellón/Castelló",
								Code = "CS"
							},
							new RegionModel
							{
								Name = "Ceuta",
								Code = "CE"
							},
							new RegionModel
							{
								Name = "Ciudad Real",
								Code = "CR"
							},
							new RegionModel
							{
								Name = "Córdoba",
								Code = "CO"
							},
							new RegionModel
							{
								Name = "A Coruña",
								Code = "C"
							},
							new RegionModel
							{
								Name = "Cuenca",
								Code = "CU"
							},
							new RegionModel
							{
								Name = "Gipuzkoa",
								Code = "SS"
							},
							new RegionModel
							{
								Name = "Girona",
								Code = "GI"
							},
							new RegionModel
							{
								Name = "Granada",
								Code = "GR"
							},
							new RegionModel
							{
								Name = "Guadalajara",
								Code = "GU"
							},
							new RegionModel
							{
								Name = "Huelva",
								Code = "H"
							},
							new RegionModel
							{
								Name = "Huesca",
								Code = "HU"
							},
							new RegionModel
							{
								Name = "Illes Balears",
								Code = "PM"
							},
							new RegionModel
							{
								Name = "Jaén",
								Code = "J"
							},
							new RegionModel
							{
								Name = "León",
								Code = "LE"
							},
							new RegionModel
							{
								Name = "Lleida",
								Code = "L"
							},
							new RegionModel
							{
								Name = "Lugo",
								Code = "LU"
							},
							new RegionModel
							{
								Name = "Madrid",
								Code = "M"
							},
							new RegionModel
							{
								Name = "Málaga",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Melilla",
								Code = "ML"
							},
							new RegionModel
							{
								Name = "Murcia",
								Code = "MU"
							},
							new RegionModel
							{
								Name = "Navarra/Nafarroa",
								Code = "NA"
							},
							new RegionModel
							{
								Name = "Ourense",
								Code = "OR"
							},
							new RegionModel
							{
								Name = "Palencia",
								Code = "P"
							},
							new RegionModel
							{
								Name = "Las Palmas",
								Code = "GC"
							},
							new RegionModel
							{
								Name = "Pontevedra",
								Code = "PO"
							},
							new RegionModel
							{
								Name = "La Rioja",
								Code = "LO"
							},
							new RegionModel
							{
								Name = "Salamanca",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "Santa Cruz de Tenerife",
								Code = "TF"
							},
							new RegionModel
							{
								Name = "Segovia",
								Code = "SG"
							},
							new RegionModel
							{
								Name = "Sevilla",
								Code = "SE"
							},
							new RegionModel
							{
								Name = "Soria",
								Code = "SO"
							},
							new RegionModel
							{
								Name = "Tarragona",
								Code = "T"
							},
							new RegionModel
							{
								Name = "Teruel",
								Code = "TE"
							},
							new RegionModel
							{
								Name = "Toledo",
								Code = "TO"
							},
							new RegionModel
							{
								Name = "Valencia/València",
								Code = "V"
							},
							new RegionModel
							{
								Name = "Valladolid",
								Code = "VA"
							},
							new RegionModel
							{
								Name = "Zamora",
								Code = "ZA"
							},
							new RegionModel
							{
								Name = "Zaragoza",
								Code = "Z"
							}
						}
					},
					new CountryModel
					{
						Name = "Sri Lanka",
						Code = "LK",
						NativeName = "ශ්රී ලංකාව , இலங்கை",
						PhoneCode = "+94",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Basnahira",
								Code = "1"
							},
							new RegionModel
							{
								Name = "Dakunu",
								Code = "3"
							},
							new RegionModel
							{
								Name = "Madhyama",
								Code = "2"
							},
							new RegionModel
							{
								Name = "Naegenahira",
								Code = "5"
							},
							new RegionModel
							{
								Name = "Sabaragamuwa",
								Code = "9"
							},
							new RegionModel
							{
								Name = "Uturu",
								Code = "4"
							},
							new RegionModel
							{
								Name = "Uturumaeda",
								Code = "7"
							},
							new RegionModel
							{
								Name = "Vayamba",
								Code = "6"
							},
							new RegionModel
							{
								Name = "Uva",
								Code = "8"
							}
						}
					},
					new CountryModel
					{
						Name = "Sudan",
						Code = "SD",
						NativeName = "جمهورية السودان",
						PhoneCode = "+249",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Al Bahr al Ahmar",
								Code = "RS"
							},
							new RegionModel
							{
								Name = "Al Jazirah",
								Code = "GZ"
							},
							new RegionModel
							{
								Name = "Al Khartum",
								Code = "KH"
							},
							new RegionModel
							{
								Name = "Al Qadarif",
								Code = "GD"
							},
							new RegionModel
							{
								Name = "An Nil al Abyad",
								Code = "NW"
							},
							new RegionModel
							{
								Name = "An Nil al Azraq",
								Code = "NB"
							},
							new RegionModel
							{
								Name = "Ash Shamaliyah",
								Code = "NO"
							},
							new RegionModel
							{
								Name = "Gharb Darfur",
								Code = "DW"
							},
							new RegionModel
							{
								Name = "Gharb Kurdufan",
								Code = "GK"
							},
							new RegionModel
							{
								Name = "Janub Darfur",
								Code = "DS"
							},
							new RegionModel
							{
								Name = "Janub Kurdufan",
								Code = "KS"
							},
							new RegionModel
							{
								Name = "Kassala",
								Code = "KA"
							},
							new RegionModel
							{
								Name = "Nahr an Nil",
								Code = "NR"
							},
							new RegionModel
							{
								Name = "Shamal Darfur",
								Code = "DN"
							},
							new RegionModel
							{
								Name = "Sharq Darfur",
								Code = "DE"
							},
							new RegionModel
							{
								Name = "Shiamal Kurdufan",
								Code = "KN"
							},
							new RegionModel
							{
								Name = "Sinnar",
								Code = "SI"
							},
							new RegionModel
							{
								Name = "Wasat Darfur Zalinjay",
								Code = "DC"
							}
						}
					},
					new CountryModel
					{
						Name = "Suriname",
						Code = "SR",
						NativeName = "",
						PhoneCode = "+597",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Brokopondo",
								Code = "BR"
							},
							new RegionModel
							{
								Name = "Commewijne",
								Code = "CM"
							},
							new RegionModel
							{
								Name = "Coronie",
								Code = "CR"
							},
							new RegionModel
							{
								Name = "Marowijne",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Nickerie",
								Code = "NI"
							},
							new RegionModel
							{
								Name = "Para",
								Code = "PR"
							},
							new RegionModel
							{
								Name = "Paramaribo",
								Code = "PM"
							},
							new RegionModel
							{
								Name = "Saramacca",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "Sipaliwini",
								Code = "SI"
							},
							new RegionModel
							{
								Name = "Wanica",
								Code = "WA"
							}
						}
					},
					new CountryModel
					{
						Name = "Swaziland",
						Code = "SZ",
						NativeName = "Umbuso weSwatini",
						PhoneCode = "+268",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Hhohho",
								Code = "HH"
							},
							new RegionModel
							{
								Name = "Lubombo",
								Code = "LU"
							},
							new RegionModel
							{
								Name = "Manzini",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Shiselweni",
								Code = "SH"
							}
						}
					},
					new CountryModel
					{
						Name = "Sweden",
						Code = "SE",
						NativeName = "Sverige",
						PhoneCode = "+46",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Blekinge",
								Code = "K"
							},
							new RegionModel
							{
								Name = "Dalarna",
								Code = "W"
							},
							new RegionModel
							{
								Name = "Gävleborg",
								Code = "X"
							},
							new RegionModel
							{
								Name = "Gotland",
								Code = "I"
							},
							new RegionModel
							{
								Name = "Halland",
								Code = "N"
							},
							new RegionModel
							{
								Name = "Jämtland",
								Code = "Z"
							},
							new RegionModel
							{
								Name = "Jönköping",
								Code = "F"
							},
							new RegionModel
							{
								Name = "Kalmar",
								Code = "H"
							},
							new RegionModel
							{
								Name = "Kronoberg",
								Code = "G"
							},
							new RegionModel
							{
								Name = "Norrbotten",
								Code = "BD"
							},
							new RegionModel
							{
								Name = "Örebro",
								Code = "T"
							},
							new RegionModel
							{
								Name = "Östergötland",
								Code = "E"
							},
							new RegionModel
							{
								Name = "Skåne",
								Code = "M"
							},
							new RegionModel
							{
								Name = "Södermanland",
								Code = "D"
							},
							new RegionModel
							{
								Name = "Stockholm",
								Code = "AB"
							},
							new RegionModel
							{
								Name = "Uppsala",
								Code = "C"
							},
							new RegionModel
							{
								Name = "Värmland",
								Code = "S"
							},
							new RegionModel
							{
								Name = "Västerbotten",
								Code = "AC"
							},
							new RegionModel
							{
								Name = "Västernorrland",
								Code = "Y"
							},
							new RegionModel
							{
								Name = "Västmanland",
								Code = "U"
							},
							new RegionModel
							{
								Name = "Västra Götaland",
								Code = "O"
							}
						}
					},
					new CountryModel
					{
						Name = "Switzerland",
						Code = "CH",
						NativeName = "Schweiz , Svizzera , la Suisse , Helvetia",
						PhoneCode = "+41",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aargau",
								Code = "AG"
							},
							new RegionModel
							{
								Name = "Appenzell Ausserrhoden",
								Code = "AR"
							},
							new RegionModel
							{
								Name = "Appenzell Innerhoden",
								Code = "AI"
							},
							new RegionModel
							{
								Name = "Basel-Landschaft",
								Code = "BL"
							},
							new RegionModel
							{
								Name = "Basel-Stadt",
								Code = "BS"
							},
							new RegionModel
							{
								Name = "Bern",
								Code = "BE"
							},
							new RegionModel
							{
								Name = "Fribourg",
								Code = "FR"
							},
							new RegionModel
							{
								Name = "Genève",
								Code = "GE"
							},
							new RegionModel
							{
								Name = "Glarus",
								Code = "GL"
							},
							new RegionModel
							{
								Name = "Graubünden",
								Code = "GR"
							},
							new RegionModel
							{
								Name = "Jura",
								Code = "JU"
							},
							new RegionModel
							{
								Name = "Luzern",
								Code = "LU"
							},
							new RegionModel
							{
								Name = "Neuchâtel",
								Code = "NE"
							},
							new RegionModel
							{
								Name = "Nidwalden",
								Code = "NW"
							},
							new RegionModel
							{
								Name = "Obwalden",
								Code = "OW"
							},
							new RegionModel
							{
								Name = "Sankt Gallen",
								Code = "SG"
							},
							new RegionModel
							{
								Name = "Schaffhausen",
								Code = "SH"
							},
							new RegionModel
							{
								Name = "Schwyz",
								Code = "SZ"
							},
							new RegionModel
							{
								Name = "Solothurn",
								Code = "SO"
							},
							new RegionModel
							{
								Name = "Thurgau",
								Code = "TG"
							},
							new RegionModel
							{
								Name = "Ticino",
								Code = "TI"
							},
							new RegionModel
							{
								Name = "Uri",
								Code = "UR"
							},
							new RegionModel
							{
								Name = "Valais",
								Code = "VS"
							},
							new RegionModel
							{
								Name = "Vaud",
								Code = "VD"
							},
							new RegionModel
							{
								Name = "Zug",
								Code = "ZG"
							},
							new RegionModel
							{
								Name = "Zürich",
								Code = "ZH"
							}
						}
					},
					new CountryModel
					{
						Name = "Syria ",
						Code = "SY",
						NativeName = "سوريا",
						PhoneCode = "+963",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Al Hasakah",
								Code = "HA"
							},
							new RegionModel
							{
								Name = "Al Ladhiqiyah",
								Code = "LA"
							},
							new RegionModel
							{
								Name = "Al Qunaytirah",
								Code = "QU"
							},
							new RegionModel
							{
								Name = "Ar Raqqah",
								Code = "RA"
							},
							new RegionModel
							{
								Name = "As Suwayda'",
								Code = "SU"
							},
							new RegionModel
							{
								Name = "Dar'a",
								Code = "DR"
							},
							new RegionModel
							{
								Name = "Dayr az Zawr",
								Code = "DY"
							},
							new RegionModel
							{
								Name = "Dimashq",
								Code = "DI"
							},
							new RegionModel
							{
								Name = "Halab",
								Code = "HL"
							},
							new RegionModel
							{
								Name = "Hamah",
								Code = "HM"
							},
							new RegionModel
							{
								Name = "Hims",
								Code = "HI"
							},
							new RegionModel
							{
								Name = "Idlib",
								Code = "ID"
							},
							new RegionModel
							{
								Name = "Rif Dimashq",
								Code = "RD"
							},
							new RegionModel
							{
								Name = "Tartus",
								Code = "TA"
							}
						}
					},
					#endregion
					};
					break;
				case 'T':
					countries = new ObservableCollection<CountryModel> { 
					#region T
					new CountryModel
					{
						Name = "Taiwan",
						Code = "TW",
						NativeName = "中华民国 , 台湾",
						PhoneCode = "+886",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Changhua",
								Code = "CHA"
							},
							new RegionModel
							{
								Name = "Chiayi",
								Code = "CYQ"
							},
							new RegionModel
							{
								Name = "Hsinchu",
								Code = "HSQ"
							},
							new RegionModel
							{
								Name = "Hualien",
								Code = "HUA"
							},
							new RegionModel
							{
								Name = "Kaohsiung",
								Code = "KHH"
							},
							new RegionModel
							{
								Name = "Keelung",
								Code = "KEE"
							},
							new RegionModel
							{
								Name = "Kinmen",
								Code = "KIN"
							},
							new RegionModel
							{
								Name = "Lienchiang",
								Code = "LIE"
							},
							new RegionModel
							{
								Name = "Miaoli",
								Code = "MIA"
							},
							new RegionModel
							{
								Name = "Nantou",
								Code = "NAN"
							},
							new RegionModel
							{
								Name = "Penghu",
								Code = "PEN"
							},
							new RegionModel
							{
								Name = "New Taipei",
								Code = "NWT"
							},
							new RegionModel
							{
								Name = "Pingtung",
								Code = "PIF"
							},
							new RegionModel
							{
								Name = "Taichung",
								Code = "TXG"
							},
							new RegionModel
							{
								Name = "Tainan",
								Code = "TNN"
							},
							new RegionModel
							{
								Name = "Taipei",
								Code = "TPE"
							},
							new RegionModel
							{
								Name = "Taitung",
								Code = "TTT"
							},
							new RegionModel
							{
								Name = "Taoyuan",
								Code = "TAO"
							},
							new RegionModel
							{
								Name = "Yilan",
								Code = "ILA"
							},
							new RegionModel
							{
								Name = "Yunlin",
								Code = "YUN"
							}
						}
					},
					new CountryModel
					{
						Name = "Tajikistan",
						Code = "TJ",
						NativeName = "Тоҷикистон , Таджикистан",
						PhoneCode = "+992",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Dushanbe",
								Code = "DU"
							},
							new RegionModel
							{
								Name = "Kŭhistoni Badakhshon",
								Code = "GB"
							},
							new RegionModel
							{
								Name = "Khatlon",
								Code = "KT"
							},
							new RegionModel
							{
								Name = "Sughd",
								Code = "SU"
							}
						}
					},
					new CountryModel
					{
						Name = "Tanzania",
						Code = "TZ",
						NativeName = "",
						PhoneCode = "+255",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Arusha",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Coast",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Dar es Salaam",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Dodoma",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Iringa",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Kagera",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Kigoma",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Kilimanjaro",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Lindi",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Manyara",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Mara",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Mbeya",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Morogoro",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Mtwara",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Mwanza",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Pemba North",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Pemba South",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Rukwa",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Ruvuma",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Shinyanga",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Singida",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Tabora",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Tanga",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Zanzibar North",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Zanzibar Central/South",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Zanzibar Urban/West",
								Code = "15"
							}
						}
					},
					new CountryModel
					{
						Name = "Thailand",
						Code = "TH",
						NativeName = "ราชอาณาจักรไทย",
						PhoneCode = "+66",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Amnat Charoen",
								Code = "37"
							},
							new RegionModel
							{
								Name = "Ang Thong",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Bueng Kan",
								Code = "38"
							},
							new RegionModel
							{
								Name = "Buri Ram",
								Code = "31"
							},
							new RegionModel
							{
								Name = "Chachoengsao",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Chai Nat",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Chaiyaphum",
								Code = "36"
							},
							new RegionModel
							{
								Name = "Chanthaburi",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Chiang Mai",
								Code = "50"
							},
							new RegionModel
							{
								Name = "Chiang Rai",
								Code = "57"
							},
							new RegionModel
							{
								Name = "Chon Buri",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Chumphon",
								Code = "86"
							},
							new RegionModel
							{
								Name = "Kalasin",
								Code = "46"
							},
							new RegionModel
							{
								Name = "Kamphaeng Phet",
								Code = "62"
							},
							new RegionModel
							{
								Name = "Kanchanaburi",
								Code = "71"
							},
							new RegionModel
							{
								Name = "Khon Kaen",
								Code = "40"
							},
							new RegionModel
							{
								Name = "Krabi",
								Code = "81"
							},
							new RegionModel
							{
								Name = "Krung Thep Mahanakhon (Bangkok)",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Lampang",
								Code = "52"
							},
							new RegionModel
							{
								Name = "Lamphun",
								Code = "51"
							},
							new RegionModel
							{
								Name = "Loei",
								Code = "42"
							},
							new RegionModel
							{
								Name = "Lop Buri",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Mae Hong Son",
								Code = "58"
							},
							new RegionModel
							{
								Name = "Maha Sarakham",
								Code = "44"
							},
							new RegionModel
							{
								Name = "Mukdahan",
								Code = "49"
							},
							new RegionModel
							{
								Name = "Nakhon Nayok",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Nakhon Phathom",
								Code = "73"
							},
							new RegionModel
							{
								Name = "Nakhon Phanom",
								Code = "48"
							},
							new RegionModel
							{
								Name = "Nakhon Ratchasima",
								Code = "30"
							},
							new RegionModel
							{
								Name = "Nakhon Sawan",
								Code = "60"
							},
							new RegionModel
							{
								Name = "Nakhon Si Thammarat",
								Code = "80"
							},
							new RegionModel
							{
								Name = "Nan",
								Code = "55"
							},
							new RegionModel
							{
								Name = "Narathiwat",
								Code = "96"
							},
							new RegionModel
							{
								Name = "Nong Bua Lam Phu",
								Code = "39"
							},
							new RegionModel
							{
								Name = "Nong Khai",
								Code = "43"
							},
							new RegionModel
							{
								Name = "Nonthaburi",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Pathum Thani",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Pattani",
								Code = "94"
							},
							new RegionModel
							{
								Name = "Phangnga",
								Code = "82"
							},
							new RegionModel
							{
								Name = "Phatthalung",
								Code = "93"
							},
							new RegionModel
							{
								Name = "Phayao",
								Code = "56"
							},
							new RegionModel
							{
								Name = "Phetchabun",
								Code = "67"
							},
							new RegionModel
							{
								Name = "Phetchaburi",
								Code = "76"
							},
							new RegionModel
							{
								Name = "Phichit",
								Code = "66"
							},
							new RegionModel
							{
								Name = "Phitsanulok",
								Code = "65"
							},
							new RegionModel
							{
								Name = "Phra Nakhon Si Ayutthaya",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Phrae",
								Code = "54"
							},
							new RegionModel
							{
								Name = "Phuket",
								Code = "83"
							},
							new RegionModel
							{
								Name = "Prachin Buri",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Prachuap Khiri Khan",
								Code = "77"
							},
							new RegionModel
							{
								Name = "Ranong",
								Code = "85"
							},
							new RegionModel
							{
								Name = "Ratchaburi",
								Code = "70"
							},
							new RegionModel
							{
								Name = "Rayong",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Roi Et",
								Code = "45"
							},
							new RegionModel
							{
								Name = "Sa Kaeo",
								Code = "27"
							},
							new RegionModel
							{
								Name = "Sakon Nakhon",
								Code = "47"
							},
							new RegionModel
							{
								Name = "Samut Prakan",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Samut Sakhon",
								Code = "74"
							},
							new RegionModel
							{
								Name = "Samut Songkhram",
								Code = "75"
							},
							new RegionModel
							{
								Name = "Saraburi",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Satun",
								Code = "91"
							},
							new RegionModel
							{
								Name = "Sing Buri",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Si Sa ket",
								Code = "33"
							},
							new RegionModel
							{
								Name = "Songkhla",
								Code = "90"
							},
							new RegionModel
							{
								Name = "Sukhothai",
								Code = "64"
							},
							new RegionModel
							{
								Name = "Suphan Buri",
								Code = "72"
							},
							new RegionModel
							{
								Name = "Surat Thani",
								Code = "84"
							},
							new RegionModel
							{
								Name = "Surin",
								Code = "32"
							},
							new RegionModel
							{
								Name = "Tak",
								Code = "63"
							},
							new RegionModel
							{
								Name = "Trang",
								Code = "92"
							},
							new RegionModel
							{
								Name = "Trat",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Ubon Ratchathani",
								Code = "34"
							},
							new RegionModel
							{
								Name = "Udon Thani",
								Code = "41"
							},
							new RegionModel
							{
								Name = "Uthai Thani",
								Code = "61"
							},
							new RegionModel
							{
								Name = "Uttaradit",
								Code = "53"
							},
							new RegionModel
							{
								Name = "Yala",
								Code = "95"
							},
							new RegionModel
							{
								Name = "Yasothon",
								Code = "35"
							}
						}
					},
					new CountryModel
					{
						Name = "Timor-Leste",
						Code = "TL",
						NativeName = "Timor Leste , Timor Lorosa'e",
						PhoneCode = "+670",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aileu",
								Code = "AL"
							},
							new RegionModel
							{
								Name = "Ainaro",
								Code = "AN"
							},
							new RegionModel
							{
								Name = "Baucau",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Bobonaro",
								Code = "BO"
							},
							new RegionModel
							{
								Name = "Cova Lima",
								Code = "CO"
							},
							new RegionModel
							{
								Name = "Dili",
								Code = "DI"
							},
							new RegionModel
							{
								Name = "Ermera",
								Code = "ER"
							},
							new RegionModel
							{
								Name = "Lautem",
								Code = "LA"
							},
							new RegionModel
							{
								Name = "Liquica",
								Code = "LI"
							},
							new RegionModel
							{
								Name = "Manatuto",
								Code = "MT"
							},
							new RegionModel
							{
								Name = "Manufahi",
								Code = "MF"
							},
							new RegionModel
							{
								Name = "Oecussi",
								Code = "OE"
							},
							new RegionModel
							{
								Name = "Viqueque",
								Code = "VI"
							}
						}
					},
					new CountryModel
					{
						Name = "Togo",
						Code = "TG",
						NativeName = "République du Togo",
						PhoneCode = "+228",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Centre",
								Code = "C"
							},
							new RegionModel
							{
								Name = "Kara",
								Code = "K"
							},
							new RegionModel
							{
								Name = "Maritime",
								Code = "M"
							},
							new RegionModel
							{
								Name = "Plateaux",
								Code = "P"
							},
							new RegionModel
							{
								Name = "Savannes",
								Code = "S"
							}
						}
					},
					new CountryModel
					{
						Name = "Tokelau",
						Code = "TK",
						NativeName = "",
						PhoneCode = "+690",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Atafu",
								Code = null
							},
							new RegionModel
							{
								Name = "Fakaofo",
								Code = null
							},
							new RegionModel
							{
								Name = "Nukunonu",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Tonga",
						Code = "TO",
						NativeName = "Pule'anga Fakatu'i 'o Tonga",
						PhoneCode = "+676",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "'Eua",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Ha'apai",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Niuas",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Tongatapu",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Vava'u",
								Code = "05"
							}
						}
					},
					new CountryModel
					{
						Name = "Trinidad and Tobago",
						Code = "TT",
						NativeName = "",
						PhoneCode = "+1 868",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Arima",
								Code = "ARI"
							},
							new RegionModel
							{
								Name = "Chaguanas",
								Code = "CHA"
							},
							new RegionModel
							{
								Name = "Couva-Tabaquite-Talparo",
								Code = "CTT"
							},
							new RegionModel
							{
								Name = "Diefo Martin",
								Code = "DMN"
							},
							new RegionModel
							{
								Name = "Mayaro-Rio Claro",
								Code = "MRC"
							},
							new RegionModel
							{
								Name = "Penal-Debe",
								Code = "PED"
							},
							new RegionModel
							{
								Name = "Point Fortin",
								Code = "PTF"
							},
							new RegionModel
							{
								Name = "Port-of-Spain",
								Code = "POS"
							},
							new RegionModel
							{
								Name = "Princes Town",
								Code = "PRT"
							},
							new RegionModel
							{
								Name = "San Fernando",
								Code = "SFO"
							},
							new RegionModel
							{
								Name = "San Juan-Laventille",
								Code = "SJL"
							},
							new RegionModel
							{
								Name = "Sangre Grande",
								Code = "SGE"
							},
							new RegionModel
							{
								Name = "Siparia",
								Code = "SIP"
							},
							new RegionModel
							{
								Name = "Tobago",
								Code = "TOB"
							},
							new RegionModel
							{
								Name = "Tunapuna-Piarco",
								Code = "TUP"
							}
						}
					},
					new CountryModel
					{
						Name = "Tunisia",
						Code = "TN",
						NativeName = "الجمهورية التونسية",
						PhoneCode = "+216",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ariana",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Beja",
								Code = "31"
							},
							new RegionModel
							{
								Name = "Ben Arous",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Bizerte",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Gabes",
								Code = "81"
							},
							new RegionModel
							{
								Name = "Gafsa",
								Code = "71"
							},
							new RegionModel
							{
								Name = "Jendouba",
								Code = "32"
							},
							new RegionModel
							{
								Name = "Kairouan",
								Code = "41"
							},
							new RegionModel
							{
								Name = "Kasserine",
								Code = "42"
							},
							new RegionModel
							{
								Name = "Kebili",
								Code = "73"
							},
							new RegionModel
							{
								Name = "Kef",
								Code = "33"
							},
							new RegionModel
							{
								Name = "Mahdia",
								Code = "53"
							},
							new RegionModel
							{
								Name = "Medenine",
								Code = "82"
							},
							new RegionModel
							{
								Name = "Monastir",
								Code = "52"
							},
							new RegionModel
							{
								Name = "Nabeul",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Sfax",
								Code = "61"
							},
							new RegionModel
							{
								Name = "Sidi Bouzid",
								Code = "43"
							},
							new RegionModel
							{
								Name = "Siliana",
								Code = "34"
							},
							new RegionModel
							{
								Name = "Sousse",
								Code = "51"
							},
							new RegionModel
							{
								Name = "Tataouine",
								Code = "83"
							},
							new RegionModel
							{
								Name = "Tozeur",
								Code = "72"
							},
							new RegionModel
							{
								Name = "Tunis",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Zaghouan",
								Code = "22"
							}
						}
					},
					new CountryModel
					{
						Name = "Turkey",
						Code = "TR",
						NativeName = "Türkiye",
						PhoneCode = "+90",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Adana",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Adiyaman",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Afyonkarahisar",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Agri",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Aksaray",
								Code = "68"
							},
							new RegionModel
							{
								Name = "Amasya",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Ankara",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Antalya",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Ardahan",
								Code = "75"
							},
							new RegionModel
							{
								Name = "Artvin",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Aydin",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Balikesir",
								Code = "10"
							},
							new RegionModel
							{
								Name = "Bartin",
								Code = "74"
							},
							new RegionModel
							{
								Name = "Batman",
								Code = "72"
							},
							new RegionModel
							{
								Name = "Bayburt",
								Code = "69"
							},
							new RegionModel
							{
								Name = "Bilecik",
								Code = "11"
							},
							new RegionModel
							{
								Name = "Bingol",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Bitlis",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Bolu",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Burdur",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Bursa",
								Code = "16"
							},
							new RegionModel
							{
								Name = "Canakkale",
								Code = "17"
							},
							new RegionModel
							{
								Name = "Cankiri",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Corum",
								Code = "19"
							},
							new RegionModel
							{
								Name = "Denizli",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Diyarbakir",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Duzce",
								Code = "81"
							},
							new RegionModel
							{
								Name = "Edirne",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Elazig",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Erzincan",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Erzurum",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Eskisehir",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Gaziantep",
								Code = "27"
							},
							new RegionModel
							{
								Name = "Giresun",
								Code = "28"
							},
							new RegionModel
							{
								Name = "Gumushane",
								Code = "29"
							},
							new RegionModel
							{
								Name = "Hakkari",
								Code = "30"
							},
							new RegionModel
							{
								Name = "Hatay",
								Code = "31"
							},
							new RegionModel
							{
								Name = "Igdir",
								Code = "76"
							},
							new RegionModel
							{
								Name = "Isparta",
								Code = "32"
							},
							new RegionModel
							{
								Name = "Istanbul",
								Code = "34"
							},
							new RegionModel
							{
								Name = "Izmir",
								Code = "35"
							},
							new RegionModel
							{
								Name = "Kahramanmaras",
								Code = "46"
							},
							new RegionModel
							{
								Name = "Karabuk",
								Code = "78"
							},
							new RegionModel
							{
								Name = "Karaman",
								Code = "70"
							},
							new RegionModel
							{
								Name = "Kars",
								Code = "36"
							},
							new RegionModel
							{
								Name = "Kastamonu",
								Code = "37"
							},
							new RegionModel
							{
								Name = "Kayseri",
								Code = "38"
							},
							new RegionModel
							{
								Name = "Kilis",
								Code = "79"
							},
							new RegionModel
							{
								Name = "Kirikkale",
								Code = "71"
							},
							new RegionModel
							{
								Name = "Kirklareli",
								Code = "39"
							},
							new RegionModel
							{
								Name = "Kirsehir",
								Code = "40"
							},
							new RegionModel
							{
								Name = "Kocaeli",
								Code = "41"
							},
							new RegionModel
							{
								Name = "Konya",
								Code = "42"
							},
							new RegionModel
							{
								Name = "Kutahya",
								Code = "43"
							},
							new RegionModel
							{
								Name = "Malatya",
								Code = "44"
							},
							new RegionModel
							{
								Name = "Manisa",
								Code = "45"
							},
							new RegionModel
							{
								Name = "Mardin",
								Code = "47"
							},
							new RegionModel
							{
								Name = "Mersin",
								Code = "33"
							},
							new RegionModel
							{
								Name = "Mugla",
								Code = "48"
							},
							new RegionModel
							{
								Name = "Mus",
								Code = "49"
							},
							new RegionModel
							{
								Name = "Nevsehir",
								Code = "50"
							},
							new RegionModel
							{
								Name = "Nigde",
								Code = "51"
							},
							new RegionModel
							{
								Name = "Ordu",
								Code = "52"
							},
							new RegionModel
							{
								Name = "Osmaniye",
								Code = "80"
							},
							new RegionModel
							{
								Name = "Rize",
								Code = "53"
							},
							new RegionModel
							{
								Name = "Sakarya",
								Code = "54"
							},
							new RegionModel
							{
								Name = "Samsun",
								Code = "55"
							},
							new RegionModel
							{
								Name = "Sanliurfa",
								Code = "63"
							},
							new RegionModel
							{
								Name = "Siirt",
								Code = "56"
							},
							new RegionModel
							{
								Name = "Sinop",
								Code = "57"
							},
							new RegionModel
							{
								Name = "Sirnak",
								Code = "73"
							},
							new RegionModel
							{
								Name = "Sivas",
								Code = "58"
							},
							new RegionModel
							{
								Name = "Tekirdag",
								Code = "59"
							},
							new RegionModel
							{
								Name = "Tokat",
								Code = "60"
							},
							new RegionModel
							{
								Name = "Trabzon",
								Code = "61"
							},
							new RegionModel
							{
								Name = "Tunceli",
								Code = "62"
							},
							new RegionModel
							{
								Name = "Usak",
								Code = "64"
							},
							new RegionModel
							{
								Name = "Van",
								Code = "65"
							},
							new RegionModel
							{
								Name = "Yalova",
								Code = "77"
							},
							new RegionModel
							{
								Name = "Yozgat",
								Code = "66"
							},
							new RegionModel
							{
								Name = "Zonguldak",
								Code = "67"
							}
						}
					},
					new CountryModel
					{
						Name = "Turkmenistan",
						Code = "TM",
						NativeName = "Türkmenistan , Туркменистан",
						PhoneCode = "+993",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Ahal",
								Code = "A"
							},
							new RegionModel
							{
								Name = "Asgabat",
								Code = "S"
							},
							new RegionModel
							{
								Name = "Balkan",
								Code = "B"
							},
							new RegionModel
							{
								Name = "Dashoguz",
								Code = "D"
							},
							new RegionModel
							{
								Name = "Lebap",
								Code = "L"
							},
							new RegionModel
							{
								Name = "Mary",
								Code = "M"
							}
						}
					},
					new CountryModel
					{
						Name = "Turks and Caicos Islands",
						Code = "TC",
						NativeName = "",
						PhoneCode = "+1 649",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Turks and Caicos Islands",
								Code = null
							}
						}
					},
					new CountryModel
					{
						Name = "Tuvalu",
						Code = "TV",
						NativeName = "",
						PhoneCode = "+688",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Funafuti",
								Code = "FUN"
							},
							new RegionModel
							{
								Name = "Nanumanga",
								Code = "NMG"
							},
							new RegionModel
							{
								Name = "Nanumea",
								Code = "NMA"
							},
							new RegionModel
							{
								Name = "Niutao",
								Code = "NIT"
							},
							new RegionModel
							{
								Name = "Nui",
								Code = "NUI"
							},
							new RegionModel
							{
								Name = "Nukufetau",
								Code = "NKF"
							},
							new RegionModel
							{
								Name = "Nukulaelae",
								Code = "NKL"
							},
							new RegionModel
							{
								Name = "Vaitupu",
								Code = "VAU"
							}
						}
					},
				
					#endregion
					};
					break;
				case 'U':
					countries = new ObservableCollection<CountryModel> { 
					#region U
					new CountryModel
					{
						Name = "Uganda",
						Code = "UG",
						NativeName = "",
						PhoneCode = "+256",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Abim",
								Code = "317"
							},
							new RegionModel
							{
								Name = "Adjumani",
								Code = "301"
							},
							new RegionModel
							{
								Name = "Amolatar",
								Code = "314"
							},
							new RegionModel
							{
								Name = "Amuria",
								Code = "216"
							},
							new RegionModel
							{
								Name = "Amuru",
								Code = "319"
							},
							new RegionModel
							{
								Name = "Apac",
								Code = "302"
							},
							new RegionModel
							{
								Name = "Arua",
								Code = "303"
							},
							new RegionModel
							{
								Name = "Budaka",
								Code = "217"
							},
							new RegionModel
							{
								Name = "Bududa",
								Code = "223"
							},
							new RegionModel
							{
								Name = "Bugiri",
								Code = "201"
							},
							new RegionModel
							{
								Name = "Bukedea",
								Code = "224"
							},
							new RegionModel
							{
								Name = "Bukwa",
								Code = "218"
							},
							new RegionModel
							{
								Name = "Buliisa",
								Code = "419"
							},
							new RegionModel
							{
								Name = "Bundibugyo",
								Code = "401"
							},
							new RegionModel
							{
								Name = "Bushenyi",
								Code = "402"
							},
							new RegionModel
							{
								Name = "Busia",
								Code = "202"
							},
							new RegionModel
							{
								Name = "Butaleja",
								Code = "219"
							},
							new RegionModel
							{
								Name = "Dokolo",
								Code = "318"
							},
							new RegionModel
							{
								Name = "Gulu",
								Code = "304"
							},
							new RegionModel
							{
								Name = "Hoima",
								Code = "403"
							},
							new RegionModel
							{
								Name = "Ibanda",
								Code = "416"
							},
							new RegionModel
							{
								Name = "Iganga",
								Code = "203"
							},
							new RegionModel
							{
								Name = "Isingiro",
								Code = "417"
							},
							new RegionModel
							{
								Name = "Jinja",
								Code = "204"
							},
							new RegionModel
							{
								Name = "Kaabong",
								Code = "315"
							},
							new RegionModel
							{
								Name = "Kabale",
								Code = "404"
							},
							new RegionModel
							{
								Name = "Kabarole",
								Code = "405"
							},
							new RegionModel
							{
								Name = "Kaberamaido",
								Code = "213"
							},
							new RegionModel
							{
								Name = "Kalangala",
								Code = "101"
							},
							new RegionModel
							{
								Name = "Kaliro",
								Code = "220"
							},
							new RegionModel
							{
								Name = "Kampala",
								Code = "102"
							},
							new RegionModel
							{
								Name = "Kamuli",
								Code = "205"
							},
							new RegionModel
							{
								Name = "Kamwenge",
								Code = "413"
							},
							new RegionModel
							{
								Name = "Kanungu",
								Code = "414"
							},
							new RegionModel
							{
								Name = "Kapchorwa",
								Code = "206"
							},
							new RegionModel
							{
								Name = "Kasese",
								Code = "406"
							},
							new RegionModel
							{
								Name = "Katakwi",
								Code = "207"
							},
							new RegionModel
							{
								Name = "Kayunga",
								Code = "112"
							},
							new RegionModel
							{
								Name = "Kibaale",
								Code = "407"
							},
							new RegionModel
							{
								Name = "Kiboga",
								Code = "103"
							},
							new RegionModel
							{
								Name = "Kiruhura",
								Code = "418"
							},
							new RegionModel
							{
								Name = "Kisoro",
								Code = "408"
							},
							new RegionModel
							{
								Name = "Kitgum",
								Code = "305"
							},
							new RegionModel
							{
								Name = "Koboko",
								Code = "316"
							},
							new RegionModel
							{
								Name = "Kotido",
								Code = "306"
							},
							new RegionModel
							{
								Name = "Kumi",
								Code = "208"
							},
							new RegionModel
							{
								Name = "Kyenjojo",
								Code = "415"
							},
							new RegionModel
							{
								Name = "Lira",
								Code = "307"
							},
							new RegionModel
							{
								Name = "Luwero",
								Code = "104"
							},
							new RegionModel
							{
								Name = "Lyantonde",
								Code = "116"
							},
							new RegionModel
							{
								Name = "Manafwa",
								Code = "221"
							},
							new RegionModel
							{
								Name = "Maracha",
								Code = "320"
							},
							new RegionModel
							{
								Name = "Masaka",
								Code = "105"
							},
							new RegionModel
							{
								Name = "Masindi",
								Code = "409"
							},
							new RegionModel
							{
								Name = "Mayuge",
								Code = "214"
							},
							new RegionModel
							{
								Name = "Mbale",
								Code = "209"
							},
							new RegionModel
							{
								Name = "Mbarara",
								Code = "410"
							},
							new RegionModel
							{
								Name = "Mityana",
								Code = "114"
							},
							new RegionModel
							{
								Name = "Moroto",
								Code = "308"
							},
							new RegionModel
							{
								Name = "Moyo",
								Code = "309"
							},
							new RegionModel
							{
								Name = "Mpigi",
								Code = "106"
							},
							new RegionModel
							{
								Name = "Mubende",
								Code = "107"
							},
							new RegionModel
							{
								Name = "Mukono",
								Code = "108"
							},
							new RegionModel
							{
								Name = "Nakapiripirit",
								Code = "311"
							},
							new RegionModel
							{
								Name = "Nakaseke",
								Code = "115"
							},
							new RegionModel
							{
								Name = "Nakasongola",
								Code = "109"
							},
							new RegionModel
							{
								Name = "Namutumba",
								Code = "222"
							},
							new RegionModel
							{
								Name = "Nebbi",
								Code = "310"
							},
							new RegionModel
							{
								Name = "Ntungamo",
								Code = "411"
							},
							new RegionModel
							{
								Name = "Oyam",
								Code = "321"
							},
							new RegionModel
							{
								Name = "Pader",
								Code = "312"
							},
							new RegionModel
							{
								Name = "Pallisa",
								Code = "210"
							},
							new RegionModel
							{
								Name = "Rakai",
								Code = "110"
							},
							new RegionModel
							{
								Name = "Rukungiri",
								Code = "412"
							},
							new RegionModel
							{
								Name = "Sembabule",
								Code = "111"
							},
							new RegionModel
							{
								Name = "Sironko",
								Code = "215"
							},
							new RegionModel
							{
								Name = "Soroti",
								Code = "211"
							},
							new RegionModel
							{
								Name = "Tororo",
								Code = "212"
							},
							new RegionModel
							{
								Name = "Wakiso",
								Code = "113"
							},
							new RegionModel
							{
								Name = "Yumbe",
								Code = "313"
							}
						}
					},
					new CountryModel
					{
						Name = "Ukraine",
						Code = "UA",
						NativeName = "Україна",
						PhoneCode = "+380",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Cherkasy",
								Code = "71"
							},
							new RegionModel
							{
								Name = "Chernihiv",
								Code = "74"
							},
							new RegionModel
							{
								Name = "Chernivtsi",
								Code = "77"
							},
							new RegionModel
							{
								Name = "Dnipropetrovsk",
								Code = "12"
							},
							new RegionModel
							{
								Name = "Donetsk",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Ivano-Frankivsk",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Kharkiv",
								Code = "63"
							},
							new RegionModel
							{
								Name = "Kherson",
								Code = "65"
							},
							new RegionModel
							{
								Name = "Khmelnytskyi",
								Code = "68"
							},
							new RegionModel
							{
								Name = "Kiev",
								Code = "32"
							},
							new RegionModel
							{
								Name = "Kirovohrad",
								Code = "35"
							},
							new RegionModel
							{
								Name = "Luhansk",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Lviv",
								Code = "46"
							},
							new RegionModel
							{
								Name = "Mykolaiv",
								Code = "48"
							},
							new RegionModel
							{
								Name = "Odessa",
								Code = "51"
							},
							new RegionModel
							{
								Name = "Poltava",
								Code = "53"
							},
							new RegionModel
							{
								Name = "Rivne",
								Code = "56"
							},
							new RegionModel
							{
								Name = "Sumy",
								Code = "59"
							},
							new RegionModel
							{
								Name = "Ternopil",
								Code = "61"
							},
							new RegionModel
							{
								Name = "Vinnytsia",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Volyn",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Zakarpattia",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Zaporizhia",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Zhytomyr",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Avtonomna Respublika Krym",
								Code = "43"
							},
							new RegionModel
							{
								Name = "Kyiv",
								Code = "30"
							},
							new RegionModel
							{
								Name = "Sevastopol",
								Code = "40"
							}
						}
					},
					new CountryModel
					{
						Name = "United Arab Emirates",
						Code = "AE",
						NativeName = "دولة الإمارات العربية المتحدة",
						PhoneCode = "+971",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Abu Dhabi",
								Code = "AZ"
							},
							new RegionModel
							{
								Name = "Ajman",
								Code = "AJ"
							},
							new RegionModel
							{
								Name = "Dubai",
								Code = "DU"
							},
							new RegionModel
							{
								Name = "Fujairah",
								Code = "FU"
							},
							new RegionModel
							{
								Name = "Ras al Khaimah",
								Code = "RK"
							},
							new RegionModel
							{
								Name = "Sharjah",
								Code = "SH"
							},
							new RegionModel
							{
								Name = "Umm Al Quwain",
								Code = "UQ"
							}
						}
					},
					new CountryModel
					{
						Name = "United Kingdom",
						Code = "GB",
						NativeName = "",
						PhoneCode = "+44",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Aberdeen City",
								Code = "ABE"
							},
							new RegionModel
							{
								Name = "Aberdeenshire",
								Code = "ABD"
							},
							new RegionModel
							{
								Name = "Angus",
								Code = "ANS"
							},
							new RegionModel
							{
								Name = "Antrim and Newtownabbey",
								Code = "ANN"
							},
							new RegionModel
							{
								Name = "Ards and North Down",
								Code = "AND"
							},
							new RegionModel
							{
								Name = "Argyll and Bute",
								Code = "AGB"
							},
							new RegionModel
							{
								Name = "Armagh, Banbridge and Craigavon",
								Code = "ABC"
							},
							new RegionModel
							{
								Name = "Barking and Dagenham",
								Code = "BDG"
							},
							new RegionModel
							{
								Name = "Barnet",
								Code = "BNE"
							},
							new RegionModel
							{
								Name = "Barnsley",
								Code = "BNS"
							},
							new RegionModel
							{
								Name = "Bath and North East Somerset",
								Code = "BAS"
							},
							new RegionModel
							{
								Name = "Bedford",
								Code = "BDF"
							},
							new RegionModel
							{
								Name = "Belfast",
								Code = "BFS"
							},
							new RegionModel
							{
								Name = "Bexley",
								Code = "BEX"
							},
							new RegionModel
							{
								Name = "Birmingham",
								Code = "BIR"
							},
							new RegionModel
							{
								Name = "Blackburn with Darwen",
								Code = "BBD"
							},
							new RegionModel
							{
								Name = "Blackpool",
								Code = "BPL"
							},
							new RegionModel
							{
								Name = "Blaenau Gwent",
								Code = "BGW"
							},
							new RegionModel
							{
								Name = "Bolton",
								Code = "BOL"
							},
							new RegionModel
							{
								Name = "Bournemouth",
								Code = "BMH"
							},
							new RegionModel
							{
								Name = "Bracknell Forest",
								Code = "BRC"
							},
							new RegionModel
							{
								Name = "Bradford",
								Code = "BRD"
							},
							new RegionModel
							{
								Name = "Brent",
								Code = "BEN"
							},
							new RegionModel
							{
								Name = "Bridgend",
								Code = "BGE"
							},
							new RegionModel
							{
								Name = "Brighton and Hove",
								Code = "BNH"
							},
							new RegionModel
							{
								Name = "Bristol, City of",
								Code = "BST"
							},
							new RegionModel
							{
								Name = "Bromley",
								Code = "BRY"
							},
							new RegionModel
							{
								Name = "Buckinghamshire",
								Code = "BKM"
							},
							new RegionModel
							{
								Name = "Bury",
								Code = "BUR"
							},
							new RegionModel
							{
								Name = "Caerphilly",
								Code = "CAY"
							},
							new RegionModel
							{
								Name = "Calderdale",
								Code = "CLD"
							},
							new RegionModel
							{
								Name = "Cambridgeshire",
								Code = "CAM"
							},
							new RegionModel
							{
								Name = "Camden",
								Code = "CMD"
							},
							new RegionModel
							{
								Name = "Cardiff",
								Code = "CRF"
							},
							new RegionModel
							{
								Name = "Carmarthenshire",
								Code = "CMN"
							},
							new RegionModel
							{
								Name = "Causeway Coast and Glens",
								Code = "CCG"
							},
							new RegionModel
							{
								Name = "Central Bedfordshire",
								Code = "CBF"
							},
							new RegionModel
							{
								Name = "Ceredigion",
								Code = "CGN"
							},
							new RegionModel
							{
								Name = "Cheshire East",
								Code = "CHE"
							},
							new RegionModel
							{
								Name = "Cheshire West and Chester",
								Code = "CHW"
							},
							new RegionModel
							{
								Name = "Clackmannanshire",
								Code = "CLK"
							},
							new RegionModel
							{
								Name = "Conwy",
								Code = "CWY"
							},
							new RegionModel
							{
								Name = "Cornwall",
								Code = "CON"
							},
							new RegionModel
							{
								Name = "Coventry",
								Code = "COV"
							},
							new RegionModel
							{
								Name = "Croydon",
								Code = "CRY"
							},
							new RegionModel
							{
								Name = "Cumbria",
								Code = "CMA"
							},
							new RegionModel
							{
								Name = "Darlington",
								Code = "DAL"
							},
							new RegionModel
							{
								Name = "Denbighshire",
								Code = "DEN"
							},
							new RegionModel
							{
								Name = "Derby",
								Code = "DER"
							},
							new RegionModel
							{
								Name = "Derbyshire",
								Code = "DBY"
							},
							new RegionModel
							{
								Name = "Derry and Strabane",
								Code = "DRS"
							},
							new RegionModel
							{
								Name = "Devon",
								Code = "DEV"
							},
							new RegionModel
							{
								Name = "Doncaster",
								Code = "DNC"
							},
							new RegionModel
							{
								Name = "Dorset",
								Code = "DOR"
							},
							new RegionModel
							{
								Name = "Dudley",
								Code = "DUD"
							},
							new RegionModel
							{
								Name = "Dumfries and Galloway",
								Code = "DGY"
							},
							new RegionModel
							{
								Name = "Dundee City",
								Code = "DND"
							},
							new RegionModel
							{
								Name = "Durham County",
								Code = "DUR"
							},
							new RegionModel
							{
								Name = "Ealing",
								Code = "EAL"
							},
							new RegionModel
							{
								Name = "East Ayrshire",
								Code = "EAY"
							},
							new RegionModel
							{
								Name = "East Dunbartonshire",
								Code = "EDU"
							},
							new RegionModel
							{
								Name = "East Lothian",
								Code = "ELN"
							},
							new RegionModel
							{
								Name = "East Renfrewshire",
								Code = "ERW"
							},
							new RegionModel
							{
								Name = "East Riding of Yorkshire",
								Code = "ERY"
							},
							new RegionModel
							{
								Name = "East Sussex",
								Code = "ESX"
							},
							new RegionModel
							{
								Name = "Edinburgh, City of",
								Code = "EDH"
							},
							new RegionModel
							{
								Name = "Eilean Siar",
								Code = "ELS"
							},
							new RegionModel
							{
								Name = "Enfield",
								Code = "ENF"
							},
							new RegionModel
							{
								Name = "Essex",
								Code = "ESS"
							},
							new RegionModel
							{
								Name = "Falkirk",
								Code = "FAL"
							},
							new RegionModel
							{
								Name = "Fermanagh and Omagh",
								Code = "FMO"
							},
							new RegionModel
							{
								Name = "Fife",
								Code = "FIF"
							},
							new RegionModel
							{
								Name = "Flintshire",
								Code = "FLN"
							},
							new RegionModel
							{
								Name = "Gateshead",
								Code = "GAT"
							},
							new RegionModel
							{
								Name = "Glasgow City",
								Code = "GLG"
							},
							new RegionModel
							{
								Name = "Gloucestershire",
								Code = "GLS"
							},
							new RegionModel
							{
								Name = "Greenwich",
								Code = "GRE"
							},
							new RegionModel
							{
								Name = "Gwynedd",
								Code = "GWN"
							},
							new RegionModel
							{
								Name = "Hackney",
								Code = "HCK"
							},
							new RegionModel
							{
								Name = "Halton",
								Code = "HAL"
							},
							new RegionModel
							{
								Name = "Hammersmith and Fulham",
								Code = "HMF"
							},
							new RegionModel
							{
								Name = "Hampshire",
								Code = "HAM"
							},
							new RegionModel
							{
								Name = "Haringey",
								Code = "HRY"
							},
							new RegionModel
							{
								Name = "Harrow",
								Code = "HRW"
							},
							new RegionModel
							{
								Name = "Hartlepool",
								Code = "HPL"
							},
							new RegionModel
							{
								Name = "Havering",
								Code = "HAV"
							},
							new RegionModel
							{
								Name = "Herefordshire",
								Code = "HEF"
							},
							new RegionModel
							{
								Name = "Hertfordshire",
								Code = "HRT"
							},
							new RegionModel
							{
								Name = "Highland",
								Code = "HLD"
							},
							new RegionModel
							{
								Name = "Hillingdon",
								Code = "HIL"
							},
							new RegionModel
							{
								Name = "Hounslow",
								Code = "HNS"
							},
							new RegionModel
							{
								Name = "Inverclyde",
								Code = "IVC"
							},
							new RegionModel
							{
								Name = "Isle of Anglesey",
								Code = "AGY"
							},
							new RegionModel
							{
								Name = "Isle of Wight",
								Code = "IOW"
							},
							new RegionModel
							{
								Name = "Isles of Scilly",
								Code = "IOS"
							},
							new RegionModel
							{
								Name = "Islington",
								Code = "ISL"
							},
							new RegionModel
							{
								Name = "Kensington and Chelsea",
								Code = "KEC"
							},
							new RegionModel
							{
								Name = "Kent",
								Code = "KEN"
							},
							new RegionModel
							{
								Name = "Kingston upon Hull",
								Code = "KHL"
							},
							new RegionModel
							{
								Name = "Kingston upon Thames",
								Code = "KTT"
							},
							new RegionModel
							{
								Name = "Kirklees",
								Code = "KIR"
							},
							new RegionModel
							{
								Name = "Knowsley",
								Code = "KWL"
							},
							new RegionModel
							{
								Name = "Lambeth",
								Code = "LBH"
							},
							new RegionModel
							{
								Name = "Lancashire",
								Code = "LAN"
							},
							new RegionModel
							{
								Name = "Leeds",
								Code = "LDS"
							},
							new RegionModel
							{
								Name = "Leicester",
								Code = "LCE"
							},
							new RegionModel
							{
								Name = "Leicestershire",
								Code = "LEC"
							},
							new RegionModel
							{
								Name = "Lewisham",
								Code = "LEW"
							},
							new RegionModel
							{
								Name = "Lincolnshire",
								Code = "LIN"
							},
							new RegionModel
							{
								Name = "Lisburn and Castlereagh",
								Code = "LBC"
							},
							new RegionModel
							{
								Name = "Liverpool",
								Code = "LIV"
							},
							new RegionModel
							{
								Name = "London, City of",
								Code = "LND"
							},
							new RegionModel
							{
								Name = "Luton",
								Code = "LUT"
							},
							new RegionModel
							{
								Name = "Manchester",
								Code = "MAN"
							},
							new RegionModel
							{
								Name = "Medway",
								Code = "MDW"
							},
							new RegionModel
							{
								Name = "Merthyr Tydfil",
								Code = "MTY"
							},
							new RegionModel
							{
								Name = "Merton",
								Code = "MRT"
							},
							new RegionModel
							{
								Name = "Mid and East Antrim",
								Code = "MEA"
							},
							new RegionModel
							{
								Name = "Mid Ulster",
								Code = "MUL"
							},
							new RegionModel
							{
								Name = "Middlesbrough",
								Code = "MDB"
							},
							new RegionModel
							{
								Name = "Midlothian",
								Code = "MLN"
							},
							new RegionModel
							{
								Name = "Milton Keynes",
								Code = "MIK"
							},
							new RegionModel
							{
								Name = "Monmouthshire",
								Code = "MON"
							},
							new RegionModel
							{
								Name = "Moray",
								Code = "MRY"
							},
							new RegionModel
							{
								Name = "Neath Port Talbot",
								Code = "NTL"
							},
							new RegionModel
							{
								Name = "Newcastle upon Tyne",
								Code = "NET"
							},
							new RegionModel
							{
								Name = "Newham",
								Code = "NWM"
							},
							new RegionModel
							{
								Name = "Newport",
								Code = "NWP"
							},
							new RegionModel
							{
								Name = "Newry, Mourne and Down",
								Code = "NMD"
							},
							new RegionModel
							{
								Name = "Norfolk",
								Code = "NFK"
							},
							new RegionModel
							{
								Name = "North Ayrshire",
								Code = "NAY"
							},
							new RegionModel
							{
								Name = "North East Lincolnshire",
								Code = "NEL"
							},
							new RegionModel
							{
								Name = "North Lanarkshire",
								Code = "NLK"
							},
							new RegionModel
							{
								Name = "North Lincolnshire",
								Code = "NLN"
							},
							new RegionModel
							{
								Name = "North Somerset",
								Code = "NSM"
							},
							new RegionModel
							{
								Name = "North Tyneside",
								Code = "NTY"
							},
							new RegionModel
							{
								Name = "North Yorkshire",
								Code = "NYK"
							},
							new RegionModel
							{
								Name = "Northamptonshire",
								Code = "NTH"
							},
							new RegionModel
							{
								Name = "Northumberland",
								Code = "NBL"
							},
							new RegionModel
							{
								Name = "Nottingham",
								Code = "NGM"
							},
							new RegionModel
							{
								Name = "Nottinghamshire",
								Code = "NTT"
							},
							new RegionModel
							{
								Name = "Oldham",
								Code = "OLD"
							},
							new RegionModel
							{
								Name = "Orkney Islands",
								Code = "ORK"
							},
							new RegionModel
							{
								Name = "Oxfordshire",
								Code = "OXF"
							},
							new RegionModel
							{
								Name = "Pembrokeshire",
								Code = "PEM"
							},
							new RegionModel
							{
								Name = "Perth and Kinross",
								Code = "PKN"
							},
							new RegionModel
							{
								Name = "Peterborough",
								Code = "PTE"
							},
							new RegionModel
							{
								Name = "Plymouth",
								Code = "PLY"
							},
							new RegionModel
							{
								Name = "Poole",
								Code = "POL"
							},
							new RegionModel
							{
								Name = "Portsmouth",
								Code = "POR"
							},
							new RegionModel
							{
								Name = "Powys",
								Code = "POW"
							},
							new RegionModel
							{
								Name = "Reading",
								Code = "RDG"
							},
							new RegionModel
							{
								Name = "Redbridge",
								Code = "RDB"
							},
							new RegionModel
							{
								Name = "Redcar and Cleveland",
								Code = "RCC"
							},
							new RegionModel
							{
								Name = "Renfrewshire",
								Code = "RFW"
							},
							new RegionModel
							{
								Name = "Rhondda, Cynon, Taff",
								Code = "RCT"
							},
							new RegionModel
							{
								Name = "Richmond upon Thames",
								Code = "RIC"
							},
							new RegionModel
							{
								Name = "Rochdale",
								Code = "RCH"
							},
							new RegionModel
							{
								Name = "Rotherham",
								Code = "ROT"
							},
							new RegionModel
							{
								Name = "Rutland",
								Code = "RUT"
							},
							new RegionModel
							{
								Name = "St. Helens",
								Code = "SHN"
							},
							new RegionModel
							{
								Name = "Salford",
								Code = "SLF"
							},
							new RegionModel
							{
								Name = "Sandwell",
								Code = "SAW"
							},
							new RegionModel
							{
								Name = "Scottish Borders, The",
								Code = "SCB"
							},
							new RegionModel
							{
								Name = "Sefton",
								Code = "SFT"
							},
							new RegionModel
							{
								Name = "Sheffield",
								Code = "SHF"
							},
							new RegionModel
							{
								Name = "Shetland Islands",
								Code = "ZET"
							},
							new RegionModel
							{
								Name = "Shropshire",
								Code = "SHR"
							},
							new RegionModel
							{
								Name = "Slough",
								Code = "SLG"
							},
							new RegionModel
							{
								Name = "Solihull",
								Code = "SOL"
							},
							new RegionModel
							{
								Name = "Somerset",
								Code = "SOM"
							},
							new RegionModel
							{
								Name = "South Ayrshire",
								Code = "SAY"
							},
							new RegionModel
							{
								Name = "South Gloucestershire",
								Code = "SGC"
							},
							new RegionModel
							{
								Name = "South Lanarkshire",
								Code = "SLK"
							},
							new RegionModel
							{
								Name = "South Tyneside",
								Code = "STY"
							},
							new RegionModel
							{
								Name = "Southampton",
								Code = "STH"
							},
							new RegionModel
							{
								Name = "Southend-on-Sea",
								Code = "SOS"
							},
							new RegionModel
							{
								Name = "Southwark",
								Code = "SWK"
							},
							new RegionModel
							{
								Name = "Staffordshire",
								Code = "STS"
							},
							new RegionModel
							{
								Name = "Stirling",
								Code = "STG"
							},
							new RegionModel
							{
								Name = "Stockport",
								Code = "SKP"
							},
							new RegionModel
							{
								Name = "Stockton-on-Tees",
								Code = "STT"
							},
							new RegionModel
							{
								Name = "Stoke-on-Trent",
								Code = "STE"
							},
							new RegionModel
							{
								Name = "Suffolk",
								Code = "SFK"
							},
							new RegionModel
							{
								Name = "Sunderland",
								Code = "SND"
							},
							new RegionModel
							{
								Name = "Surrey",
								Code = "SRY"
							},
							new RegionModel
							{
								Name = "Sutton",
								Code = "STN"
							},
							new RegionModel
							{
								Name = "Swansea",
								Code = "SWA"
							},
							new RegionModel
							{
								Name = "Swindon",
								Code = "SWD"
							},
							new RegionModel
							{
								Name = "Tameside",
								Code = "TAM"
							},
							new RegionModel
							{
								Name = "Telford and Wrekin",
								Code = "TFW"
							},
							new RegionModel
							{
								Name = "Thurrock",
								Code = "THR"
							},
							new RegionModel
							{
								Name = "Torbay",
								Code = "TOB"
							},
							new RegionModel
							{
								Name = "Torfaen",
								Code = "TOF"
							},
							new RegionModel
							{
								Name = "Tower Hamlets",
								Code = "TWH"
							},
							new RegionModel
							{
								Name = "Trafford",
								Code = "TRF"
							},
							new RegionModel
							{
								Name = "Vale of Glamorgan, The",
								Code = "VGL"
							},
							new RegionModel
							{
								Name = "Wakefield",
								Code = "WKF"
							},
							new RegionModel
							{
								Name = "Walsall",
								Code = "WLL"
							},
							new RegionModel
							{
								Name = "Waltham Forest",
								Code = "WFT"
							},
							new RegionModel
							{
								Name = "Wandsworth",
								Code = "WND"
							},
							new RegionModel
							{
								Name = "Warrington",
								Code = "WRT"
							},
							new RegionModel
							{
								Name = "Warwickshire",
								Code = "WAR"
							},
							new RegionModel
							{
								Name = "West Berkshire",
								Code = "WBK"
							},
							new RegionModel
							{
								Name = "West Dunbartonshire",
								Code = "WDU"
							},
							new RegionModel
							{
								Name = "West Lothian",
								Code = "WLN"
							},
							new RegionModel
							{
								Name = "West Sussex",
								Code = "WSX"
							},
							new RegionModel
							{
								Name = "Westminster",
								Code = "WSM"
							},
							new RegionModel
							{
								Name = "Wigan",
								Code = "WGN"
							},
							new RegionModel
							{
								Name = "Wiltshire",
								Code = "WIL"
							},
							new RegionModel
							{
								Name = "Windsor and Maidenhead",
								Code = "WNM"
							},
							new RegionModel
							{
								Name = "Wirral",
								Code = "WRL"
							},
							new RegionModel
							{
								Name = "Wokingham",
								Code = "WOK"
							},
							new RegionModel
							{
								Name = "Wolverhampton",
								Code = "WLV"
							},
							new RegionModel
							{
								Name = "Worcestershire",
								Code = "WOR"
							},
							new RegionModel
							{
								Name = "Wrexham",
								Code = "WRX"
							},
							new RegionModel
							{
								Name = "York",
								Code = "YOR"
							}
						}
					},
					new CountryModel
					{
						Name = "United States",
						Code = "US",
						NativeName = "Estados Unidos",
						PhoneCode = "+1",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Alabama",
								Code = "AL"
							},
							new RegionModel
							{
								Name = "Alaska",
								Code = "AK"
							},
							new RegionModel
							{
								Name = "Arizona",
								Code = "AZ"
							},
							new RegionModel
							{
								Name = "Arkansas",
								Code = "AR"
							},
							new RegionModel
							{
								Name = "California",
								Code = "CA"
							},
							new RegionModel
							{
								Name = "Colorado",
								Code = "CO"
							},
							new RegionModel
							{
								Name = "Connecticut",
								Code = "CT"
							},
							new RegionModel
							{
								Name = "Delaware",
								Code = "DE"
							},
							new RegionModel
							{
								Name = "District of Columbia",
								Code = "DC"
							},
							new RegionModel
							{
								Name = "Micronesia",
								Code = "FM"
							},
							new RegionModel
							{
								Name = "Florida",
								Code = "FL"
							},
							new RegionModel
							{
								Name = "Georgia",
								Code = "GA"
							},
							new RegionModel
							{
								Name = "Guam",
								Code = "GU"
							},
							new RegionModel
							{
								Name = "Hawaii",
								Code = "HI"
							},
							new RegionModel
							{
								Name = "Idaho",
								Code = "ID"
							},
							new RegionModel
							{
								Name = "Illinois",
								Code = "IL"
							},
							new RegionModel
							{
								Name = "Indiana",
								Code = "IN"
							},
							new RegionModel
							{
								Name = "Iowa",
								Code = "IA"
							},
							new RegionModel
							{
								Name = "Kansas",
								Code = "KS"
							},
							new RegionModel
							{
								Name = "Kentucky",
								Code = "KY"
							},
							new RegionModel
							{
								Name = "Louisiana",
								Code = "LA"
							},
							new RegionModel
							{
								Name = "Maine",
								Code = "ME"
							},
							new RegionModel
							{
								Name = "Marshall Islands",
								Code = "MH"
							},
							new RegionModel
							{
								Name = "Maryland",
								Code = "MD"
							},
							new RegionModel
							{
								Name = "Massachusetts",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Michigan",
								Code = "MI"
							},
							new RegionModel
							{
								Name = "Minnesota",
								Code = "MN"
							},
							new RegionModel
							{
								Name = "Mississippi",
								Code = "MS"
							},
							new RegionModel
							{
								Name = "Missouri",
								Code = "MO"
							},
							new RegionModel
							{
								Name = "Montana",
								Code = "MT"
							},
							new RegionModel
							{
								Name = "Nebraska",
								Code = "NE"
							},
							new RegionModel
							{
								Name = "Nevada",
								Code = "NV"
							},
							new RegionModel
							{
								Name = "New Hampshire",
								Code = "NH"
							},
							new RegionModel
							{
								Name = "New Jersey",
								Code = "NJ"
							},
							new RegionModel
							{
								Name = "New Mexico",
								Code = "NM"
							},
							new RegionModel
							{
								Name = "New York",
								Code = "NY"
							},
							new RegionModel
							{
								Name = "North Carolina",
								Code = "NC"
							},
							new RegionModel
							{
								Name = "North Dakota",
								Code = "ND"
							},
							new RegionModel
							{
								Name = "Northern Mariana Islands",
								Code = "MP"
							},
							new RegionModel
							{
								Name = "Ohio",
								Code = "OH"
							},
							new RegionModel
							{
								Name = "Oklahoma",
								Code = "OK"
							},
							new RegionModel
							{
								Name = "Oregon",
								Code = "OR"
							},
							new RegionModel
							{
								Name = "Palau",
								Code = "PW"
							},
							new RegionModel
							{
								Name = "Pennsylvania",
								Code = "PA"
							},
							new RegionModel
							{
								Name = "Rhode Island",
								Code = "RI"
							},
							new RegionModel
							{
								Name = "South Carolina",
								Code = "SC"
							},
							new RegionModel
							{
								Name = "South Dakota",
								Code = "SD"
							},
							new RegionModel
							{
								Name = "Tennessee",
								Code = "TN"
							},
							new RegionModel
							{
								Name = "Texas",
								Code = "TX"
							},
							new RegionModel
							{
								Name = "Utah",
								Code = "UT"
							},
							new RegionModel
							{
								Name = "Vermont",
								Code = "VT"
							},
							new RegionModel
							{
								Name = "Virgin Islands",
								Code = "VI"
							},
							new RegionModel
							{
								Name = "Virginia",
								Code = "VA"
							},
							new RegionModel
							{
								Name = "Washington",
								Code = "WA"
							},
							new RegionModel
							{
								Name = "West Virginia",
								Code = "WV"
							},
							new RegionModel
							{
								Name = "Wisconsin",
								Code = "WI"
							},
							new RegionModel
							{
								Name = "Wyoming",
								Code = "WY"
							},
							new RegionModel
							{
								Name = "Armed Forces Americas",
								Code = "AA"
							},
							new RegionModel
							{
								Name = "Armed Forces Europe, Canada, Africa and Middle East",
								Code = "AE"
							},
							new RegionModel
							{
								Name = "Armed Forces Pacific",
								Code = "AP"
							}
						}
					},
					new CountryModel
					{
						Name = "Uruguay",
						Code = "UY",
						NativeName = "",
						PhoneCode = "+598",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Artigas",
								Code = "AR"
							},
							new RegionModel
							{
								Name = "Canelones",
								Code = "CA"
							},
							new RegionModel
							{
								Name = "Cerro Largo",
								Code = "CL"
							},
							new RegionModel
							{
								Name = "Colonia",
								Code = "CO"
							},
							new RegionModel
							{
								Name = "Durazno",
								Code = "DU"
							},
							new RegionModel
							{
								Name = "Flores",
								Code = "FS"
							},
							new RegionModel
							{
								Name = "Florida",
								Code = "FD"
							},
							new RegionModel
							{
								Name = "Lavalleja",
								Code = "LA"
							},
							new RegionModel
							{
								Name = "Maldonado",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Montevideo",
								Code = "MO"
							},
							new RegionModel
							{
								Name = "Paysandú",
								Code = "PA"
							},
							new RegionModel
							{
								Name = "Río Negro",
								Code = "RN"
							},
							new RegionModel
							{
								Name = "Rivera",
								Code = "RV"
							},
							new RegionModel
							{
								Name = "Rocha",
								Code = "RO"
							},
							new RegionModel
							{
								Name = "Salto",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "San José",
								Code = "SJ"
							},
							new RegionModel
							{
								Name = "Soriano",
								Code = "SO"
							},
							new RegionModel
							{
								Name = "Tacuarembó",
								Code = "TA"
							},
							new RegionModel
							{
								Name = "Treinta y Tres",
								Code = "TT"
							}
						}
					},
					new CountryModel
					{
						Name = "Uzbekistan",
						Code = "UZ",
						NativeName = "Ўзбекистон , Узбекистан",
						PhoneCode = "+998",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Toshkent shahri",
								Code = "TK"
							},
							new RegionModel
							{
								Name = "Andijon",
								Code = "AN"
							},
							new RegionModel
							{
								Name = "Buxoro",
								Code = "BU"
							},
							new RegionModel
							{
								Name = "Farg‘ona",
								Code = "FA"
							},
							new RegionModel
							{
								Name = "Jizzax",
								Code = "JI"
							},
							new RegionModel
							{
								Name = "Namangan",
								Code = "NG"
							},
							new RegionModel
							{
								Name = "Navoiy",
								Code = "NW"
							},
							new RegionModel
							{
								Name = "Qashqadaryo (Qarshi)",
								Code = "QA"
							},
							new RegionModel
							{
								Name = "Samarqand",
								Code = "SA"
							},
							new RegionModel
							{
								Name = "Sirdaryo (Guliston)",
								Code = "SI"
							},
							new RegionModel
							{
								Name = "Surxondaryo (Termiz)",
								Code = "SU"
							},
							new RegionModel
							{
								Name = "Toshkent wiloyati",
								Code = "TO"
							},
							new RegionModel
							{
								Name = "Xorazm (Urganch)",
								Code = "XO"
							},
							new RegionModel
							{
								Name = "Qoraqalpog‘iston Respublikasi (Nukus)",
								Code = "QR"
							}
						}
					},
					#endregion
					};
					break;
				case 'V':
					countries = new ObservableCollection<CountryModel> { 
					#region V
					new CountryModel
					{
						Name = "Vanuatu",
						Code = "VU",
						NativeName = "",
						PhoneCode = "+678",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Malampa",
								Code = "MAP"
							},
							new RegionModel
							{
								Name = "Pénama",
								Code = "PAM"
							},
							new RegionModel
							{
								Name = "Sanma",
								Code = "SAM"
							},
							new RegionModel
							{
								Name = "Shéfa",
								Code = "SEE"
							},
							new RegionModel
							{
								Name = "Taféa",
								Code = "TAE"
							},
							new RegionModel
							{
								Name = "Torba",
								Code = "TOB"
							}
						}
					},
					new CountryModel
					{
						Name = "Venezuela",
						Code = "VE",
						NativeName = "",
						PhoneCode = "+58",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Dependencias Federales",
								Code = "W"
							},
							new RegionModel
							{
								Name = "Distrito Federal",
								Code = "A"
							},
							new RegionModel
							{
								Name = "Amazonas",
								Code = "Z"
							},
							new RegionModel
							{
								Name = "Anzoátegui",
								Code = "B"
							},
							new RegionModel
							{
								Name = "Apure",
								Code = "C"
							},
							new RegionModel
							{
								Name = "Aragua",
								Code = "D"
							},
							new RegionModel
							{
								Name = "Barinas",
								Code = "E"
							},
							new RegionModel
							{
								Name = "Bolívar",
								Code = "F"
							},
							new RegionModel
							{
								Name = "Carabobo",
								Code = "G"
							},
							new RegionModel
							{
								Name = "Cojedes",
								Code = "H"
							},
							new RegionModel
							{
								Name = "Delta Amacuro",
								Code = "Y"
							},
							new RegionModel
							{
								Name = "Falcón",
								Code = "I"
							},
							new RegionModel
							{
								Name = "Guárico",
								Code = "J"
							},
							new RegionModel
							{
								Name = "Lara",
								Code = "K"
							},
							new RegionModel
							{
								Name = "Mérida",
								Code = "L"
							},
							new RegionModel
							{
								Name = "Miranda",
								Code = "M"
							},
							new RegionModel
							{
								Name = "Monagas",
								Code = "N"
							},
							new RegionModel
							{
								Name = "Nueva Esparta",
								Code = "O"
							},
							new RegionModel
							{
								Name = "Portuguesa",
								Code = "P"
							},
							new RegionModel
							{
								Name = "Sucre",
								Code = "R"
							},
							new RegionModel
							{
								Name = "Táchira",
								Code = "S"
							},
							new RegionModel
							{
								Name = "Trujillo",
								Code = "T"
							},
							new RegionModel
							{
								Name = "Vargas",
								Code = "X"
							},
							new RegionModel
							{
								Name = "Yaracuy",
								Code = "U"
							},
							new RegionModel
							{
								Name = "Zulia",
								Code = "V"
							}
						}
					},
					new CountryModel
					{
						Name = "Vietnam",
						Code = "VN",
						NativeName = "Cộng hòa Xã hội chủ nghĩa Việt Nam",
						PhoneCode = "+84",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "An Giang",
								Code = "44"
							},
							new RegionModel
							{
								Name = "Bà Rịa - Vũng Tàu",
								Code = "43"
							},
							new RegionModel
							{
								Name = "Bình Dương",
								Code = "57"
							},
							new RegionModel
							{
								Name = "Bình Phước",
								Code = "58"
							},
							new RegionModel
							{
								Name = "Bình Định",
								Code = "31"
							},
							new RegionModel
							{
								Name = "Bình Thuận",
								Code = "40"
							},
							new RegionModel
							{
								Name = "Bạc Liêu",
								Code = "55"
							},
							new RegionModel
							{
								Name = "Bắc Giang",
								Code = "54"
							},
							new RegionModel
							{
								Name = "Bắc Kạn",
								Code = "53"
							},
							new RegionModel
							{
								Name = "Bắc Ninh",
								Code = "56"
							},
							new RegionModel
							{
								Name = "Bến Tre",
								Code = "50"
							},
							new RegionModel
							{
								Name = "Cao Bằng",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Cà Mau",
								Code = "59"
							},
							new RegionModel
							{
								Name = "Đắk Lắk",
								Code = "33"
							},
							new RegionModel
							{
								Name = "Đắk Nông",
								Code = "72"
							},
							new RegionModel
							{
								Name = "Điện Biên",
								Code = "71"
							},
							new RegionModel
							{
								Name = "Đồng Nai",
								Code = "39"
							},
							new RegionModel
							{
								Name = "Đồng Tháp",
								Code = "45"
							},
							new RegionModel
							{
								Name = "Gia Lai",
								Code = "30"
							},
							new RegionModel
							{
								Name = "Hà Giang",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Hà Nam",
								Code = "63"
							},
							new RegionModel
							{
								Name = "Hà Tây",
								Code = "15"
							},
							new RegionModel
							{
								Name = "Hà Tĩnh",
								Code = "23"
							},
							new RegionModel
							{
								Name = "Hải Dương",
								Code = "61"
							},
							new RegionModel
							{
								Name = "Hậu Giang",
								Code = "73"
							},
							new RegionModel
							{
								Name = "Hòa Bình",
								Code = "14"
							},
							new RegionModel
							{
								Name = "Hưng Yên",
								Code = "66"
							},
							new RegionModel
							{
								Name = "Khánh Hòa",
								Code = "34"
							},
							new RegionModel
							{
								Name = "Kiên Giang",
								Code = "47"
							},
							new RegionModel
							{
								Name = "Kon Tum",
								Code = "28"
							},
							new RegionModel
							{
								Name = "Lai Châu",
								Code = "01"
							},
							new RegionModel
							{
								Name = "Lâm Đồng",
								Code = "35"
							},
							new RegionModel
							{
								Name = "Lạng Sơn",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Lào Cai",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Long An",
								Code = "41"
							},
							new RegionModel
							{
								Name = "Nam Định",
								Code = "67"
							},
							new RegionModel
							{
								Name = "Nghệ An",
								Code = "22"
							},
							new RegionModel
							{
								Name = "Ninh Bình",
								Code = "18"
							},
							new RegionModel
							{
								Name = "Ninh Thuận",
								Code = "36"
							},
							new RegionModel
							{
								Name = "Phú Thọ",
								Code = "68"
							},
							new RegionModel
							{
								Name = "Phú Yên",
								Code = "32"
							},
							new RegionModel
							{
								Name = "Quảng Bình",
								Code = "24"
							},
							new RegionModel
							{
								Name = "Quảng Nam",
								Code = "27"
							},
							new RegionModel
							{
								Name = "Quảng Ngãi",
								Code = "29"
							},
							new RegionModel
							{
								Name = "Quảng Ninh",
								Code = "13"
							},
							new RegionModel
							{
								Name = "Quảng Trị",
								Code = "25"
							},
							new RegionModel
							{
								Name = "Sóc Trăng",
								Code = "52"
							},
							new RegionModel
							{
								Name = "Sơn La",
								Code = "05"
							},
							new RegionModel
							{
								Name = "Tây Ninh",
								Code = "37"
							},
							new RegionModel
							{
								Name = "Thái Bình",
								Code = "20"
							},
							new RegionModel
							{
								Name = "Thái Nguyên",
								Code = "69"
							},
							new RegionModel
							{
								Name = "Thanh Hóa",
								Code = "21"
							},
							new RegionModel
							{
								Name = "Thừa Thiên–Huế",
								Code = "26"
							},
							new RegionModel
							{
								Name = "Tiền Giang",
								Code = "46"
							},
							new RegionModel
							{
								Name = "Trà Vinh",
								Code = "51"
							},
							new RegionModel
							{
								Name = "Tuyên Quang",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Vĩnh Long",
								Code = "49"
							},
							new RegionModel
							{
								Name = "Vĩnh Phúc",
								Code = "70"
							},
							new RegionModel
							{
								Name = "Yên Bái",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Cần Thơ",
								Code = "CT"
							},
							new RegionModel
							{
								Name = "Đà Nẵng",
								Code = "DN"
							},
							new RegionModel
							{
								Name = "Hà Nội",
								Code = "HN"
							},
							new RegionModel
							{
								Name = "Hải Phòng",
								Code = "HP"
							},
							new RegionModel
							{
								Name = "Hồ Chí Minh (Sài Gòn)",
								Code = "SG"
							}
						}
					},
					new CountryModel
					{
						Name = "British Virgin Islands",
						Code = "VG",
						NativeName = "",
						PhoneCode = "+1 284",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Anegada",
								Code = "ANG"
							},
							new RegionModel
							{
								Name = "Jost Van Dyke",
								Code = "JVD"
							},
							new RegionModel
							{
								Name = "Tortola",
								Code = "TTA"
							},
							new RegionModel
							{
								Name = "Virgin Gorda",
								Code = "VGD"
							}
						}
					},
					#endregion
					};
					break;
				case 'W':
					countries = new ObservableCollection<CountryModel> { 
					#region W
					new CountryModel
					{
						Name = "Wallis and Futuna",
						Code = "WF",
						NativeName = "Wallis et Futuna",
						PhoneCode = "+681",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Alo",
								Code = "ALO"
							},
							new RegionModel
							{
								Name = "Sigave",
								Code = "SIG"
							},
							new RegionModel
							{
								Name = "Wallis",
								Code = "WAL"
							}
						}
					},
					#endregion
					};
					break;
				case 'Y':
					countries = new ObservableCollection<CountryModel> { 
					#region Y
					new CountryModel
					{
						Name = "Yemen",
						Code = "YE",
						NativeName = "الجمهوريّة اليمنية",
						PhoneCode = "+967",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Abyān",
								Code = "AB"
							},
							new RegionModel
							{
								Name = "'Adan",
								Code = "AD"
							},
							new RegionModel
							{
								Name = "Aḑ Ḑāli'",
								Code = "DA"
							},
							new RegionModel
							{
								Name = "Al Bayḑā'",
								Code = "BA"
							},
							new RegionModel
							{
								Name = "Al Ḩudaydah",
								Code = "HU"
							},
							new RegionModel
							{
								Name = "Al Jawf",
								Code = "JA"
							},
							new RegionModel
							{
								Name = "Al Mahrah",
								Code = "MR"
							},
							new RegionModel
							{
								Name = "Al Maḩwīt",
								Code = "MW"
							},
							new RegionModel
							{
								Name = "'Amrān",
								Code = "AM"
							},
							new RegionModel
							{
								Name = "Dhamār",
								Code = "DH"
							},
							new RegionModel
							{
								Name = "Ḩaḑramawt",
								Code = "HD"
							},
							new RegionModel
							{
								Name = "Ḩajjah",
								Code = "HJ"
							},
							new RegionModel
							{
								Name = "Ibb",
								Code = "IB"
							},
							new RegionModel
							{
								Name = "Laḩij",
								Code = "LA"
							},
							new RegionModel
							{
								Name = "Ma'rib",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Raymah",
								Code = "RA"
							},
							new RegionModel
							{
								Name = "Şā‘dah",
								Code = "SD"
							},
							new RegionModel
							{
								Name = "Şan‘ā'",
								Code = "SN"
							},
							new RegionModel
							{
								Name = "Shabwah",
								Code = "SH"
							},
							new RegionModel
							{
								Name = "Tā‘izz",
								Code = "TA"
							}
						}
					},
					#endregion
					};
					break;
				case 'Z':
					countries = new ObservableCollection<CountryModel> { 
					#region Z
					new CountryModel
					{
						Name = "Zambia",
						Code = "ZM",
						NativeName = "",
						PhoneCode = "+260",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Central",
								Code = "02"
							},
							new RegionModel
							{
								Name = "Copperbelt",
								Code = "08"
							},
							new RegionModel
							{
								Name = "Eastern",
								Code = "03"
							},
							new RegionModel
							{
								Name = "Luapula",
								Code = "04"
							},
							new RegionModel
							{
								Name = "Lusaka",
								Code = "09"
							},
							new RegionModel
							{
								Name = "Northern",
								Code = "05"
							},
							new RegionModel
							{
								Name = "North-Western",
								Code = "06"
							},
							new RegionModel
							{
								Name = "Southern",
								Code = "07"
							},
							new RegionModel
							{
								Name = "Western",
								Code = "01"
							}
						}
					},
					new CountryModel
					{
						Name = "Zimbabwe",
						Code = "ZW",
						NativeName = "",
						PhoneCode = "+263",
						Regions = new ObservableCollection<RegionModel>
						{
							new RegionModel
							{
								Name = "Bulawayo",
								Code = "BU"
							},
							new RegionModel
							{
								Name = "Harare",
								Code = "HA"
							},
							new RegionModel
							{
								Name = "Manicaland",
								Code = "MA"
							},
							new RegionModel
							{
								Name = "Mashonaland Central",
								Code = "MC"
							},
							new RegionModel
							{
								Name = "Mashonaland East",
								Code = "ME"
							},
							new RegionModel
							{
								Name = "Mashonaland West",
								Code = "MW"
							},
							new RegionModel
							{
								Name = "Masvingo",
								Code = "MV"
							},
							new RegionModel
							{
								Name = "Matabeleland North",
								Code = "MN"
							},
							new RegionModel
							{
								Name = "Matabeleland South",
								Code = "MS"
							},
							new RegionModel
							{
								Name = "Midlands",
								Code = "MI"
							}
						}
					}
					#endregion
					};
					break;
				default:
					countries = GetCountries();
					break;
			}

			return countries.Where(item => item.Code == code).FirstOrDefault();
		}

		public static string GetPhoneFormat(string intPhoneFormat)
        {
            switch (intPhoneFormat)
            {
				case "XX XXX XXXX":
					return "2 3 4";
				case "XXX XXX XXX":
					return "3 3 3";
				default:
					return "0 0 0 0 0";
			}
        }
	}

	public class RegionModel
	{
		public string Name { get; set; } = string.Empty;
		public string Code { get; set; } = string.Empty;
		public RegionModel() { }

		public RegionModel(string name, string code) 
		{
			Name = name ?? Name;
			Code = code ?? Code;
		}
	}
}