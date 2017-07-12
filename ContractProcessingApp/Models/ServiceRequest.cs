using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ContractProcessingApp.Models
{
    public enum ServiceRequestStatus
    {
        Draft,
        Submitted,
        Approved,
        Rejected,
        Completed,
        Cancelled
    }

    public enum ServiceRequestCategory
    {
        Land,
        Plan,
        Materials,
        Foundation,
        Roof,
        Interior,
        Floor,
        Landscape,
        Power,
        Water,
        Renewable,
        Security
    }

    public enum CountryList
    {
        Ghana
    }

    public enum CityList
    {
        Aboso,
        Aburi,
        Accra,
        Adenta_East,
        Aflao,
        Agogo,
        Agona_Swedru,
        Akim_Oda,
        Akim_Swedru,
        Akropong,
        Akwatia,
        Anloga,
        Anomabu,
        Apam,
        Asamankese,
        Ashiaman,
        Axim,
        Banda_Ahenkro,
        Bawku,
        Bechem,
        Begoro,
        Bekwai,
        Berekum,
        Bibiani,
        Bolgatanga,
        Cape_Coast,
        Dome,
        Duayaw_Nkwanta,
        Dunkwa_on_Offin,
        Effiakuma,
        Ejura,
        Elmina,
        Foso,
        Gbawe,
        Ho,
        Hohoe,
        Japekrom,
        Kade,
        Keta,
        Kete_Krachi,
        Kibi,
        Kintampo,
        Koforidua,
        Konongo,
        Kpandae,
        Kpandu,
        Kumasi,
        Lashibi,
        Madina,
        Mampong,
        Mpraeso,
        Mumford,
        Navrongo,
        Nkawkaw,
        Nsawam,
        Nungua,
        Nyakrom,
        Obuasi,
        Oduponkpehe,
        Prestea,
        Salaga,
        Saltpond,
        Savelugu,
        Sekondi_Takoradi,
        Shama,
        Somanya,
        Suhum,
        Sunyani,
        Tafo,
        Taifa,
        Tamale,
        Tarkwa,
        Techiman,
        Tema,
        Tema_New_Town,
        Teshie,
        Wa,
        Wenchi,
        Winneba,
        Yendi
    }

    public class ServiceRequest
    {
        /**Primary Key**/
        [Key]
        public int ServiceRequestID { get; set; }

        /**Other Attributes**/
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public ServiceRequestCategory RequestCategory { get; set; }
        public string Summary { get; set; }
        public CountryList RequeustCountry { get; set; }
        public CityList RequestCity { get; set; }
        public string RequestLocality { get; set; }
        public string AdditionalLocationInfo { get; set; }
        public DateTime DateTimeProperty { get; set; }
        public DateTime? DateTimeNullableProperty { get; set; }
        public TimeSpan TimeSpanProperty { get; set; }
        public ServiceRequestStatus Status { get; set; }

        /**Foreign Keys***/

        [ForeignKey("User")]
        public string CustomerID { get; set; }
        public virtual ApplicationUser User { get; set; } //Customer
    }
}