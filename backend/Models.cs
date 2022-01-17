using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;

//Model User
class User
{
    public int CodeUser { get; set; }
    public string nom { get; set; }
    public string prenom { get; set; }
    public string username { get; set; }
    public string password { get; set; }
    public bool privilege { get; set; }


    public User() { }
    public User(int CodeUser, string nom,string prenom, bool privilege)
    {
        this.nom = nom;
        this.prenom = prenom;
        this.privilege = privilege;
        this.CodeUser = CodeUser;


    }
}

//Model Patient
class Patient
{
    public int codePatient { get; set; }
    public string nom { get; set; }
    public string prenom { get; set; }
    public string cin { get; set; }
    public string telephone { get; set; }
    public string adresse { get; set; }
    public char sexe { get; set; }
    public DateTime date_naissance { get; set; }

    public Patient(){}
    public Patient(int codePatient,string nom,string prenom,string cin, string telephone, string adresse,char sexe, DateTime date_n)
    {
        this.codePatient = codePatient;
        this.nom=nom;
        this.prenom=prenom;
        this.cin=cin;
        this.telephone=telephone;
        this.adresse=adresse;
        this.sexe= sexe;
        this.date_naissance=date_n;
    }


}

//Model rendezVous
class RendezVous
{
    public int CodeRdv { get; set; }

    public int CodePatient { get; set; }

    public DateTime dateRdv { get; set; }

    public string timeRdv { get; set; }
    public string objectRdv { get; set; }

    public int CodeUser { get; set; }

    public RendezVous(int codeRdv, int CodePatient,DateTime dateRdv, string timeRdv, string objectRdv,int CodeUser)
    {
        this.CodeRdv = codeRdv;
        this.CodePatient=CodePatient;
        this.dateRdv = dateRdv;
        this.timeRdv = timeRdv;
        this.objectRdv = objectRdv;
        this.CodeUser = CodeUser;
    }
    

}

//Model Consultation
class Consultation
{
    public int CodeConsultation { get; set; }
    public DateTime dateConsultation { get; set; }

    public int CodePatient;

    public Consultation(int codeConsult, int CodePatient,DateTime dateCon)
    {
        this.CodeConsultation = codeConsult;
        this.dateConsultation = dateCon;
        this.CodePatient = CodePatient;
    }
    
}

//Model Intervention

class Intervention
{
    public int CodeIntervention { get; set; }
    public int CodeConsultation { get; set; }
    public int dent { get; set; }
    public string intervention { get; set; }

    public Intervention(int codeInter,int codeCons,int dent,string intervention)
    {
        this.CodeIntervention = codeInter;
        this.CodeConsultation = codeCons;
        this.dent = dent;
        this.intervention=intervention;
    }
}

//Model Certificat
class Certificat
{
    public int CodeCertificat { get; set; }
    public int CodeConsultation { get; set;}
    public DateTime dateCertificat { get; set; }

    public Certificat(int CodeCertificat, int codeConsultation, DateTime dateCertificat)
    {
        this.CodeCertificat = CodeCertificat;
        this.CodeConsultation = codeConsultation;
        this.dateCertificat = dateCertificat;
    }


}

//Model Ordonnance
class Ordonnance
{
    public int CodeOrdonnance { get; set; }
    public int CodeConsultation { get; set; }
    public string remarque { get; set; }
    public DateTime dateOrd { get; set; }

    public Ordonnance(int codeOrd,int codeConsult,string remarque, DateTime dateOrd)
    {
        this.CodeOrdonnance = codeOrd;
        this.CodeConsultation = codeConsult;
        this.remarque = remarque;
        this.dateOrd = dateOrd;
    }
}

//Model detailsOrdonnance
class detailsOrdonnance
{
    public int CodeOrdDet { get; set; }
    public int CodeOrdonnance { get; set; }
    public string medicament { get; set; }
    public int  quantite { get; set; }
    public string utilisation { get; set; }

    public detailsOrdonnance() { }
    public detailsOrdonnance(int CodeOrdDet,int CodeOrdonnance,string medicament, int quantite, string utilisation) {
        
        this.CodeOrdDet= CodeOrdDet;
        this.CodeOrdonnance = CodeOrdonnance;
        this.medicament = medicament;
        this.quantite = quantite;
        this.utilisation = utilisation;
    }


}

//Model Facture
class Facture
{
    public int CodeFacture { get; set; }
    public int CodeConsultation { get; set; }
    public float prixFacture { get; set; }
    public DateTime dateFacture { get; set; }

    public Facture(int CodeFacture, int CodeConsultation, float prixFacture, DateTime dateFacture)
    {
        this.CodeFacture=CodeFacture;
        this.CodeConsultation=CodeConsultation;
        this.prixFacture=prixFacture;
        this.dateFacture=dateFacture;
    }
}

