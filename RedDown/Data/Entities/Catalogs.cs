using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RedDown.Data.Entities
{
    public class Catalogs
    {
    }

    public enum States {
        [Display(Name="Aguascalientes")]
        Ags,
        [Display(Name="Baja California")]
        BC,
        [Display(Name="Baja California Sur")]
        BCS,
        [Display(Name="Campeche")]
        Camp,
        [Display(Name="Chiapas")]
        Chis,
        [Display(Name="Chihuahua")]
        Chih,
        [Display(Name="Ciudad de México")]
        CdMx,
        [Display(Name="Coahuila")]
        Coah,
        [Display(Name="Colima")]
        Col,
        [Display(Name="Durango")]
        Dgo,
        [Display(Name="Guanajuato")]
        Gto,
        [Display(Name="Guerrero")]
        Gro,
        [Display(Name="Hidalgo")]
        Hgo,
        [Display(Name="Jalisco")]
        Jal,
        [Display(Name="México")]
        Mx,
        [Display(Name="Nichoacán")]
        Mich,
        [Display(Name="Morelos")]
        Mor,
        [Display(Name="Nayarit")]
        Nay,
        [Display(Name="Nuevo León")]
        NL,
        [Display(Name="Oaxaca")]
        Oax,
        [Display(Name="Puebla")]
        Pue,
        [Display(Name="Querétaro")]
        Qro,
        [Display(Name="Quintana Roo")]
        Qr,
        [Display(Name="San Luis Potosi")]
        Slp,
        [Display(Name="Sinaloa")]
        Sin,
        [Display(Name="Sonora")]
        Son,
        [Display(Name="Tabasco")]
        Tab,
        [Display(Name="Tamaulipas")]
        Tamps,
        [Display(Name="Tlaxcala")]
        Tlax,
        [Display(Name="Veracruz")]
        Ver,
        [Display(Name="Yucatán")]
        Yuc,
        [Display(Name="Zacatecas")]
        Zac
    }

    public enum MedicalAtention {
        [Display(Name="I.M.S.S")]
        IMSS,
        [Display(Name="I.S.S.S.T.E")]
        ISSSTE,
        [Display(Name="Seguro Popular")]
        SegPop,
        [Display(Name="Seguro de Gastos Médicos")]
        SGM,
        [Display(Name="Atención Privada")]
        Priv
    }

    public enum Diagnostic
    {
        [Display(Name="Pre Natal")]
        Pre,
        [Display(Name="Al nacer")]
        Birth,
        [Display(Name="A los 3 meses")]
        Months3
    }

    public enum Pupilage {
        [Display(Name="Primaria")]
        Primary,
        [Display(Name="Secundaria")]
        JuniorSchool,
        [Display(Name="Preparatoria")]
        HighSchool,
        [Display(Name="Universidad")]
        University,
        [Display(Name="Postgrado")]
        Postdegree
    }

    public enum ActivitySchool
    {
        [Display(Name="Escuela de educación especial")]
        Special,
        [Display(Name="Escuela regular")]
        Regular,
        [Display(Name="Proyecto laboral")]
        Job
    }

    public enum ActivityTherapy
    {
        [Display(Name="Asiste")]
        Attend,
        [Display(Name="Asistió")]
        Attended,
        [Display(Name="Nunca ha ido")]
        Never
    }

    public enum MainCarer
    {
        [Display(Name="Mamá")]
        Mom,
        [Display(Name="Papá")]
        Dad,
        [Display(Name="Abuelos")]
        Grand,
        [Display(Name="Cuidador externo")]
        Other
    }
}
