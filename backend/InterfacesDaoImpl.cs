using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Connexion;
using System.Data;

namespace InterfaceDaoImpl;

//UserDaoImpl 
class UserDaoImpl 
{
    public SqlConnection conn =ConnectBd.getInstance().getConn();
    public SqlCommand stmt;


    
    public User login(string username, string pwd)
    {
        User u=null;
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = @"SELECT CodeUser,nom,prenom,privilege FROM dbo.users WHERE username='"+username+"' AND password='"+pwd+"'";
        conn.Open();
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        if (dt.Rows.Count == 1)
        {
            int id = (int)dt.Rows[0]["CodeUser"];
            string nom = dt.Rows[0]["nom"].ToString();
            string prenom = dt.Rows[0]["prenom"].ToString();
            bool privilege = (bool)dt.Rows[0]["privilege"];
            u = new User(id,nom,prenom,privilege);
        }
            conn.Close();
        return u;

    }
}

//PatientDaoImpl

class PatientDaoImpl
{
    public SqlConnection conn = ConnectBd.getInstance().getConn();
    public SqlCommand stmt;


    //Pour récuprér le CodePatient pour insérer consultation
    public Patient getPatientByCin(string cin)
    {

        Patient p = null;
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = @"SELECT CodePatient,nom,prenom FROM dbo.patients WHERE cin='" +cin+"'";
        conn.Open();
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        if (dt.Rows.Count == 1)
        {
            p = new Patient();
            p.codePatient =(int) dt.Rows[0]["CodePatient"];
            p.nom = dt.Rows[0]["nom"].ToString();
            p.prenom = dt.Rows[0]["prenom"].ToString();
        }
        conn.Close();
        return p;
    }

    //Pour récuprér le CodePatient pour modifié le patient didié

    public Patient getPatientById(int id)
    {

        Patient p = null;
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = @"SELECT * FROM dbo.patients WHERE CodePatient=" + id;
        conn.Open();
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        if (dt.Rows.Count == 1)
        {
            p = new Patient();
            p.codePatient = (int)dt.Rows[0]["CodePatient"];
            p.nom = dt.Rows[0]["nom"].ToString();
            p.prenom = dt.Rows[0]["prenom"].ToString();
            p.cin = dt.Rows[0]["cin"].ToString();
            p.telephone = dt.Rows[0]["telephone"].ToString();
            p.adresse = dt.Rows[0]["adresse"].ToString();
            p.sexe =Convert.ToChar(dt.Rows[0]["sexe"]);
            p.date_naissance = Convert.ToDateTime(dt.Rows[0]["date_naissance"].ToString());
        }
        conn.Close();
        return p;
    }


    //l'ajout d'un patient
    public bool add_p(Patient p)
    {
        this.conn.Open();
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = "INSERT INTO dbo.patients ([nom],[prenom],[cin],[telephone],[adresse],[sexe],[date_naissance]) VALUES ('" + p.nom+ "','" + p.prenom+ "','" + p.cin +"','"+p.telephone+"','"+p.adresse+"','"+p.sexe+"','"+p.date_naissance.Date+"')";

        if (stmt.ExecuteNonQuery() == 1) { 
            conn.Close();
            return true;
        }
        conn.Close();
        return false;

    }

    //Affichage Patients
    public DataTable patients()
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"SELECT CodePatient as 'Code',cin,CONCAT(nom,' ',prenom) as 'nom', telephone,adresse,sexe,date_naissance as 'Date naissance'
                            FROM dbo.patients";
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        conn.Close();
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        return dt;
    }

   
    //Filtrage des patients 
    public DataTable patients(string val, string column)
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"SELECT CodePatient as 'Code',cin,CONCAT(nom,' ',prenom) as 'nom', telephone,adresse,sexe,date_naissance as 'Date naissance'
                            FROM dbo.patients
                            WHERE "+column+" LIKE '"+val+"%'";
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        conn.Close();
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        return dt;
    }


    public bool UpdatePatient(Patient p)
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"UPDATE dbo.patients SET nom='"+p.nom+"', prenom='"+p.prenom+"'," +
                            "date_naissance='"+p.date_naissance.Date+"',cin='"+p.cin+"',telephone='"+p.telephone+"',adresse='"+p.adresse+ "',sexe='"+p.sexe+"'" +
                            "WHERE CodePatient="+ p.codePatient;
        if (stmt.ExecuteNonQuery() == 1)
        {
            conn.Close();
            return true;
        }
        conn.Close();
        return false;
    }

}

//OrdonnanceDaoImpl

class OrdonnanceDaoImpl
{
    public SqlConnection conn = ConnectBd.getInstance().getConn();
    public SqlCommand stmt;

    //Get ord by date ordonnance and Patient
    //Ajouter nouveau patient
    public int add_ord(Ordonnance o)
    {
        int row_inserted = 0;
        this.conn.Open();
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = "INSERT INTO dbo.ordonnances ([CodeConsultation],[remarque],[dateOrd]) VALUES (" + o.CodeConsultation + ",'" + o.remarque + "','" + o.dateOrd.Date + "')";

        if (stmt.ExecuteNonQuery() >= 1) row_inserted = 1;
        conn.Close();
        return row_inserted;

    }

    //Affichage des ordonnances avec nom et prénom du patient
    public DataTable ordonnances()
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"SELECT o.CodeOrdonnance AS 'Code Ordonnance',o.CodeConsultation AS 'Code Consultation',CONCAT(nom,' ',prenom) as 'nom',
                            o.remarque,o.dateOrd FROM dbo.ordonnances o 
                            JOIN dbo.consultations c ON (c.CodeConsultation=o.CodeConsultation)
                            JOIN dbo.patients p ON (p.CodePatient=c.CodePatient)";
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        conn.Close();
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        return dt;
    }

    //récupération des ordonnances d'un patient
    public DataTable ordonnances(string cinPatient)
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"SELECT o.CodeOrdonnance AS 'Code Ordonnance',o.CodeConsultation AS 'Code Consultation',CONCAT(nom,' ',prenom) as 'nom',
                            o.remarque,o.dateOrd FROM dbo.ordonnances o 
                            LEFT JOIN dbo.consultations c ON(c.CodeConsultation=o.CodeConsultation) 
                            JOIN dbo.patients p ON(p.CodePatient=c.CodePatient) 
                            WHERE p.cin LIKE '" + cinPatient + "%' ";
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        conn.Close();
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        return dt;
    }

    //Vérification si une consultation a une ordonnance
    public int ordonnances(int id)
    {
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = @"SELECT COUNT(*) as 'Nbr' FROM dbo.ordonnances WHERE CodeConsultation=" + id + "";
        conn.Open();
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        int total = Convert.ToInt32(dt.Rows[0]["Nbr"]);
        conn.Close();
        return total;

    }



    //Suppression Ordonnance 
    public bool DeleteOrd(int code)
    {
        this.conn.Open();
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = @"DELETE From dbo.details_ordonnance WHERE  CodeOrdonnance=" + code+";" 
            + "DELETE FROM dbo.ordonnances WHERE CodeOrdonnance=" + code+";";

        if (stmt.ExecuteNonQuery() >= 1)
        {
            conn.Close(); 
            return true;
        }
        conn.Close();
        return false;

    }
}

//DetOrdonnanceDaoImpl

class DetOrdonnanceDaoImpl
{
    public SqlConnection conn = ConnectBd.getInstance().getConn();
    public SqlCommand stmt;
    

    //Récupérations des détails
    public DataTable getDetOrdonnance()
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"SELECT CodeOrdDet AS 'Code',CodeOrdonnance AS 'Code Ordonnance',
                            medicament AS 'médicament',quantite,utilisation FROM dbo.details_ordonnance";
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        conn.Close();
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        return dt;


    }

    //Récupérations des détails didié
    public DataTable getDetOrdonnance(int code)
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"SELECT CodeOrdDet AS 'Code',CodeOrdonnance AS 'Code Ordonnance',
                            medicament AS 'médicament',quantite,utilisation
                            FROM dbo.details_ordonnance
                            WHERE CodeOrdonnance="+code;
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        conn.Close();
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        return dt;


    }

    //Ajout DetOrd
    public int add_detOrd(detailsOrdonnance d)
    {
        int row_inserted = 0;
        this.conn.Open();
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = "INSERT INTO dbo.details_ordonnance ([CodeOrdonnance],[medicament],[quantite],[utilisation]) VALUES (" + d.CodeOrdonnance+ ",'" + d.medicament + "'," + d.quantite+ ",'"+d.utilisation + "')";

        if (stmt.ExecuteNonQuery() >= 1) row_inserted = 1;
        conn.Close();
        return row_inserted;

    }

    //suprimmer detail
    public int delete_detOrd(int code)
    {
        int row_inserted = 0;
        this.conn.Open();
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = @"DELETE From dbo.details_ordonnance WHERE CodeOrdDet="+code;

        if (stmt.ExecuteNonQuery() >= 1) row_inserted = 1;
        conn.Close();
        return row_inserted;

    }


}

//RdvDaoImpl
class RdvDaoImpl
{
    public SqlConnection conn = ConnectBd.getInstance().getConn();
    public SqlCommand stmt;


    //Création d'un rendez-vous
    public bool Add_rdv(RendezVous rv)
    {
        this.conn.Open();
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = @"INSERT INTO dbo.rendezVous ([codePatient],[dateRdv],[timeRdv],[objectRdv],[CodeUser]) VALUES (" + rv.CodePatient + ",'" + rv.dateRdv.Date + "','" + rv.timeRdv + "','" + rv.objectRdv + "'," + rv.CodeUser + ")";

        if (stmt.ExecuteNonQuery() >= 1)
        {
            conn.Close();
            return true;
        }
        conn.Close();
        return false;
    }


    //Récuperation nombre des rendeé vous par jour
    public int nbrRvparJour(DateTime date_r)
    {
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = @"SELECT COUNT(*) as 'NbrRv' FROM dbo.rendezVous WHERE dateRdv='" + date_r.Date+ "'";
        conn.Open();
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        int jrs = Convert.ToInt32(dt.Rows[0]["NbrRv"]);
        conn.Close();
          return jrs;
        
    }


    //Affichage des rendez vous par date
    public DataTable Rvs(string date_r)
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"SELECT p.nom,p.prenom,convert(char(5),r.timeRdv) AS 'heure' FROM dbo.rendezVous r JOIN dbo.patients p
                            ON(p.CodePatient=r.CodePatient)
                            WHERE dateRdv='"+ date_r+"'";
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        conn.Close();
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        return dt;

    }
   
}

//ConsutationDaoImpl
class ConsultationDaoImpl
{
    public SqlConnection conn = ConnectBd.getInstance().getConn();
    public SqlCommand stmt;


    //Affichage des consultations
    public DataTable consultations()
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"SELECT CodeConsultation AS 'Code',c.CodePatient AS 'Code Patient',CONCAT(p.nom,' ',p.prenom) as 'nom',
                           dateConsultation AS 'date ' FROM dbo.consultations c JOIN dbo.patients p ON(p.CodePatient=c.CodePatient)";
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        conn.Close();
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        return dt;

    }

    //Affichage des consultations d'un patient
    public DataTable consultations(string cin)
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"SELECT CodeConsultation AS 'Code',c.CodePatient AS 'Code Patient',CONCAT(p.nom,' ',p.prenom) as 'nom',
                           dateConsultation AS 'date ' FROM dbo.consultations c JOIN dbo.patients p ON(p.CodePatient=c.CodePatient)
                           WHERE p.cin= '"+cin+"'";
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        conn.Close();
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        return dt;

    }


    //Ajout d'un consultation pout patient didié
    public bool Add_consultation(Consultation c)
    {
        this.conn.Open();
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = @"INSERT INTO dbo.consultations ([CodePatient],[dateConsultation]) VALUES (" +c.CodePatient+",'"+c.dateConsultation.Date+"')";

        if (stmt.ExecuteNonQuery() == 1)
        {
            conn.Close();
            return true;
        }
        conn.Close();
        return false;
    }


    public bool delete_Consultation(int Code)
    {
        this.conn.Open();
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = @"DELETE FROM dbo.interventions WHERE CodeConsultation=" + Code+";" +
                            "DELETE FROM dbo.certificats WHERE CodeConsultation=" + Code + ";" +
                            "DELETE FROM dbo.consultations WHERE CodeConsultation=" + Code + ";";

        if (stmt.ExecuteNonQuery() >= 1)
        {
            conn.Close();
            return true;
        }
        conn.Close();
        return false;
    }

}

//InterventionDaoImpl
class InterventionDaoImpl
{
    public SqlConnection conn = ConnectBd.getInstance().getConn();
    public SqlCommand stmt;

    public DataTable inteventions()
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"SELECT CodeIntervention AS 'Code',CodeConsultation AS 'Code Consultation',
                           dent , intervention FROM dbo.interventions";
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        conn.Close();
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        return dt;

    }

    public DataTable inteventions(int code)
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"SELECT CodeIntervention AS 'Code',CodeConsultation AS 'Code Consultation',
                           dent , intervention FROM dbo.interventions
                           WHERE CodeConsultation =" + code ;
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        conn.Close();
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        return dt;

    }

    public bool Add_Intervention(Intervention i)
    {
        this.conn.Open();
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = @"INSERT INTO dbo.interventions ([CodeConsultation],[dent],[intervention]) VALUES (" + i.CodeConsultation+ "," + i.dent + ",'"+i.intervention+"')";

        if (stmt.ExecuteNonQuery() == 1)
        {
            conn.Close();
            return true;
        }
        conn.Close();
        return false;
    }

    public bool delete_Intervention(int CodeIntervention)
    {
        this.conn.Open();
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = @"DELETE FROM dbo.interventions WHERE CodeIntervention="+CodeIntervention;

        if (stmt.ExecuteNonQuery() >= 1)
        {
            conn.Close();
            return true;
        }
        conn.Close();
        return false;
    }
}

//CertificatDaoImpl
class CertificatDaoImpl
{
    public SqlConnection conn = ConnectBd.getInstance().getConn();
    public SqlCommand stmt;

    public DataTable certificats()
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"SELECT CodeCertificat AS 'Code',ce.CodeConsultation AS 'Code Consultation',CONCAT(p.nom,' ',p.prenom) as 'nom',
                           dateCertificat as 'date' FROM dbo.certificats ce JOIN dbo.consultations c ON(c.CodeConsultation=ce.CodeConsultation)
                           JOIN dbo.patients p ON(p.CodePatient=c.CodePatient)";
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        conn.Close();
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        return dt;

    }

    public DataTable certificats(string cin)
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"SELECT CodeCertificat AS 'Code',ce.CodeConsultation AS 'Code Consultation',CONCAT(p.nom,' ',p.prenom) as 'nom',
                           dateCertificat as 'date' FROM dbo.certificats ce 
                           JOIN dbo.consultations c ON(c.CodeConsultation=ce.CodeConsultation)
                           JOIN dbo.patients p ON(p.CodePatient=c.CodePatient)
                           WHERE p.cin='" + cin+"'";
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        conn.Close();
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        return dt;

    }

    public int certificats(int id)
    {
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = @"SELECT COUNT(*) as 'Nbr' FROM dbo.certificats WHERE CodeConsultation=" + id + "";
        conn.Open();
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        int total = Convert.ToInt32(dt.Rows[0]["Nbr"]);
        conn.Close();
        return total;

    }
    public bool add_Certificat(Certificat c)
    {
            this.conn.Open();
            this.stmt = this.conn.CreateCommand();
            stmt.CommandText = @"INSERT INTO dbo.certificats ([CodeConsultation],[dateCertificat]) VALUES (" + c.CodeConsultation + ",'" + c.dateCertificat.Date+ "')";

            if (stmt.ExecuteNonQuery() == 1)
            {
                conn.Close();
                return true;
            }
            conn.Close();
            return false;
    }

 


}

class FactureDaoImpl
{
    public SqlConnection conn = ConnectBd.getInstance().getConn();
    public SqlCommand stmt;

    public DataTable factures()
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"SELECT CodeFacture AS 'Code',f.CodeConsultation AS 'Code Consultation',p.CodePatient as 'Code Patient',CONCAT(p.nom,' ',p.prenom) as 'nom',
                            PrixFacture as 'prix',dateFacture as 'date' FROM dbo.factures f 
                           JOIN dbo.consultations c ON(c.CodeConsultation=f.CodeConsultation)
                           JOIN dbo.patients p ON(p.CodePatient=c.CodePatient) ";
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        conn.Close();
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        return dt;

    }

    public DataTable factures(string cin)
    {
        this.stmt = this.conn.CreateCommand();
        conn.Open();
        stmt.CommandText = @"SELECT CodeFacture AS 'Code',f.CodeConsultation AS 'Code Consultation',p.CodePatient as 'Code Patient',CONCAT(p.nom,' ',p.prenom) as 'nom',
                            PrixFacture as 'prix',dateFacture as 'date' FROM dbo.factures f 
                           JOIN dbo.consultations c ON(c.CodeConsultation=f.CodeConsultation)
                           JOIN dbo.patients p ON(p.CodePatient=c.CodePatient)
                           WHERE p.cin='" + cin+"'";
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        conn.Close();
        DataTable dt = new DataTable();
        adapter.Fill(dt);

        return dt;

    }


    public int factures(int id)
    {
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = @"SELECT COUNT(*) as 'Nbr' FROM dbo.factures WHERE CodeConsultation=" + id + "";
        conn.Open();
        SqlDataAdapter adapter = new SqlDataAdapter();
        adapter.SelectCommand = stmt;
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        int total = Convert.ToInt32(dt.Rows[0]["Nbr"]);
        conn.Close();
        return total;

    }
    public bool add_Facture(Facture f)
    {
        this.conn.Open();
        this.stmt = this.conn.CreateCommand();
        stmt.CommandText = @"INSERT INTO dbo.factures ([CodeConsultation],[prixFacture],[dateFacture]) VALUES (" + f.CodeConsultation + ","+f.prixFacture+",'" + f.dateFacture.Date + "')";

        if (stmt.ExecuteNonQuery() == 1)
        {
            conn.Close();
            return true;
        }
        conn.Close();
        return false;
    }

   


}
