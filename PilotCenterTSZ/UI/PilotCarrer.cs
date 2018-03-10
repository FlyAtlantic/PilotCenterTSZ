using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilotCenterTSZ.UI
{
    public partial class PilotCarrer : UserControl
    {
        public PilotCarrer()
        {
            InitializeComponent();
            GetUserTypeRatings();
            GetQualifications();
            GetPromotion();
        }

        public void Actions()
        {
            GetUserTypeRatings();
            GetQualifications();
            GetPromotion();
        }

        UserInfo a = new UserInfo();

        public void GetUserTypeRatings()
        {

            int progress;

            foreach (AllTypeRatingsByUserRank p in AllTypeRatingsByUserRank.Get())
            {
                switch (p.TypeRatingName)
                {
                    case "C172":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / 1;

                        lblC172.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarC172.Value = 100;
                            lblC172.Visible = false;
                            lblC172.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnC172.Visible = false;
                            else
                                btnC172.Visible = true;
                            btnC172.Tag = p.TypeRatingID;
                        }
                        else
                        {
                            pbarC172.Value = progress;
                            lblC172.Visible = true;
                            lblC172.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarC172.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarC172.ProgressColor = Color.Red;
                        }

                        break;

                    case "B190":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / p.Eps;

                        lblB190.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarB190.Value = 100;
                            lblB190.Visible = false;
                            lblB190.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnB190.Visible = false;
                            else
                                btnB190.Visible = true;
                            btnB190.Tag = p.TypeRatingID;

                        }
                        else
                        {
                            pbarB190.Value = progress;
                            lblB190.Visible = true;
                            lblB190.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarB190.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarB190.ProgressColor = Color.Red;
                        }

                        break;

                    case "JS41":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / p.Eps;

                        lblJS41.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarJS41.Value = 100;
                            lblJS41.Visible = false;
                            lblJS41.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnJS41.Visible = false;
                            else
                                btnJS41.Visible = true;
                            btnJS41.Tag = p.TypeRatingID;
                        }
                        else
                        {
                            pbarJS41.Value = progress;
                            lblJS41.Visible = true;
                            lblJS41.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarJS41.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarJS41.ProgressColor = Color.Red;
                        }

                        break;

                    case "DH8D":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / p.Eps;

                        lblDH8D.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarDH8D.Value = 100;
                            lblDH8D.Visible = false;
                            lblDH8D.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnDH8D.Visible = false;
                            else
                                btnDH8D.Visible = true;
                            btnDH8D.Tag = p.TypeRatingID;
                        }
                        else
                        {
                            pbarDH8D.Value = progress;
                            lblDH8D.Visible = true;
                            lblDH8D.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarDH8D.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarDH8D.ProgressColor = Color.Red;
                        }

                        break;

                    case "AT72":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / p.Eps;

                        lblAT72.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarAT72.Value = 100;
                            lblAT72.Visible = false;
                            lblAT72.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnAT72.Visible = false;
                            else
                                btnAT72.Visible = true;
                            btnAT72.Tag = p.TypeRatingID;
                        }
                        else
                        {
                            pbarAT72.Value = progress;
                            lblAT72.Visible = true;
                            lblAT72.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarAT72.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarAT72.ProgressColor = Color.Red;
                        }

                        break;

                    case "RJ1H":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / p.Eps;

                        lblRJ1H.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarRJ1H.Value = 100;
                            lblRJ1H.Visible = false;
                            lblRJ1H.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnRJ1H.Visible = false;
                            else
                                btnRJ1H.Visible = true;
                            btnRJ1H.Tag = p.TypeRatingID;
                        }
                        else
                        {
                            pbarRJ1H.Value = progress;
                            lblRJ1H.Visible = true;
                            lblRJ1H.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarRJ1H.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarRJ1H.ProgressColor = Color.Red;
                        }

                        break;

                    case "A32F":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / p.Eps;

                        lblA32F.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarA32F.Value = 100;
                            lblA32F.Visible = false;
                            lblA32F.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnA32F.Visible = false;
                            else
                                btnA32F.Visible = true;
                            btnA32F.Tag = p.TypeRatingID;
                        }
                        else
                        {
                            pbarA32F.Value = progress;
                            lblA32F.Visible = true;
                            lblA32F.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarA32F.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarA32F.ProgressColor = Color.Red;
                        }

                        break;

                    case "A332":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / p.Eps;

                        lblA332.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarA332.Value = 100;
                            lblA332.Visible = false;
                            lblA332.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnA332.Visible = false;
                            else
                                btnA332.Visible = true;
                            btnA332.Tag = p.TypeRatingID;
                        }
                        else
                        {
                            pbarA332.Value = progress;
                            lblA332.Visible = true;
                            lblA332.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarA332.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarA332.ProgressColor = Color.Red;
                        }

                        break;

                    case "A343":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / p.Eps;

                        lblA343.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarA343.Value = 100;
                            lblA343.Visible = false;
                            lblA343.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnA343.Visible = false;
                            else
                                btnA343.Visible = true;
                            btnA343.Tag = p.TypeRatingID;
                        }
                        else
                        {
                            pbarA343.Value = progress;
                            lblA343.Visible = true;
                            lblA343.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarA343.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarA343.ProgressColor = Color.Red;
                        }

                        break;

                    case "B738":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / p.Eps;

                        lblB738.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarB738.Value = 100;
                            lblB738.Visible = false;
                            lblB738.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnB738.Visible = false;
                            else
                                btnB738.Visible = true;
                            btnB738.Tag = p.TypeRatingID;
                        }
                        else
                        {
                            pbarB738.Value = progress;
                            lblB738.Visible = true;
                            lblB738.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarB738.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarB738.ProgressColor = Color.Red;
                        }

                        break;

                    case "B744":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / p.Eps;

                        lblB744.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarB744.Value = 100;
                            lblB744.Visible = false;
                            lblB744.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnB744.Visible = false;
                            else
                                btnB744.Visible = true;
                            btnB744.Tag = p.TypeRatingID;
                        }
                        else
                        {
                            pbarB744.Value = progress;
                            lblB744.Visible = true;
                            lblB744.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarB744.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarB744.ProgressColor = Color.Red;
                        }

                        break;

                    case "B763":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / p.Eps;

                        lblB763.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarB763.Value = 100;
                            lblB763.Visible = false;
                            lblB763.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnB763.Visible = false;
                            else
                                btnB763.Visible = true;
                            btnB763.Tag = p.TypeRatingID;
                        }
                        else
                        {
                            pbarB763.Value = progress;
                            lblB763.Visible = true;
                            lblB763.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarB763.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarB763.ProgressColor = Color.Red;
                        }

                        break;

                    case "B77L":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / p.Eps;

                        lblB77L.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarB77L.Value = 100;
                            lblB77L.Visible = false;
                            lblB77L.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnB77L.Visible = false;
                            else
                                btnB77L.Visible = true;
                            btnB77L.Tag = p.TypeRatingID;
                        }
                        else
                        {
                            pbarB77L.Value = progress;
                            lblB77L.Visible = true;
                            lblB77L.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarB77L.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarB77L.ProgressColor = Color.Red;
                        }

                        break;

                    case "B787":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / p.Eps;

                        lblB787.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarB787.Value = 100;
                            lblB787.Visible = false;
                            lblB787.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnB787.Visible = false;
                            else
                                btnB787.Visible = true;
                            btnB787.Tag = p.TypeRatingID;
                        }
                        else
                        {
                            pbarB787.Value = progress;
                            lblB787.Visible = true;
                            lblB787.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarB787.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarB787.ProgressColor = Color.Red;
                        }

                        break;

                    case "MD11":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / p.Eps;

                        lblMD11.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarMD11.Value = 100;
                            lblMD11.Visible = false;
                            lblMD11.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnMD11.Visible = false;
                            else
                                btnMD11.Visible = true;
                            btnMD11.Tag = p.TypeRatingID;
                        }
                        else
                        {
                            pbarMD11.Value = progress;
                            lblMD11.Visible = true;
                            lblMD11.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarMD11.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarMD11.ProgressColor = Color.Red;
                        }

                        break;

                    case "CONC":

                        p.GetTypeRatingExamAssign(p.TypeRatingID);

                        progress = (a.Eps * 100) / p.Eps;

                        lblCONC.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarCONC.Value = 100;
                            lblCONC.Visible = false;
                            lblCONC.ForeColor = Color.ForestGreen;
                            if (p.ExamTypeAssign)
                                btnCONC.Visible = false;
                            else
                                btnCONC.Visible = true;
                            btnCONC.Tag = p.TypeRatingID;
                        }
                        else
                        {
                            pbarCONC.Value = progress;
                            lblCONC.Visible = true;
                            lblCONC.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarCONC.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarCONC.ProgressColor = Color.Red;
                        }

                        break;

                    default:
                        break;
                }

            }

            foreach (TypeRating t in TypeRating.Get())
            {
 
                switch (t.TypeRatingName)
                {
                    case "C172":

                        lblC172.Visible = true;
                        lblC172.Text = "Obtained!";
                        lblC172.ForeColor = Color.ForestGreen;
                        pbarC172.Value = 100;
                        btnC172.Visible = false;
                        pbarC172.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "B190":

                        lblB190.Visible = true;
                        lblB190.Text = "Obtained!";
                        lblB190.ForeColor = Color.ForestGreen;
                        pbarB190.Value = 100;
                        btnB190.Visible = false;
                        pbarB190.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "JS41":

                        lblJS41.Visible = true;
                        lblJS41.Text = "Obtained!";
                        lblJS41.ForeColor = Color.ForestGreen;
                        pbarJS41.Value = 100;
                        btnJS41.Visible = false;
                        pbarJS41.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "DH8D":

                        lblDH8D.Visible = true;
                        lblDH8D.Text = "Obtained!";
                        lblDH8D.ForeColor = Color.ForestGreen;
                        pbarDH8D.Value = 100;
                        btnDH8D.Visible = false;
                        pbarDH8D.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "AT72":

                        lblAT72.Visible = true;
                        lblAT72.Text = "Obtained!";
                        lblAT72.ForeColor = Color.ForestGreen;
                        pbarAT72.Value = 100;
                        btnAT72.Visible = false;
                        pbarAT72.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "RJ1H":

                        lblRJ1H.Visible = true;
                        lblRJ1H.Text = "Obtained!";
                        lblRJ1H.ForeColor = Color.ForestGreen;
                        pbarRJ1H.Value = 100;
                        btnRJ1H.Visible = false;
                        pbarRJ1H.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "A32F":

                        lblA32F.Visible = true;
                        lblA32F.Text = "Obtained!";
                        lblA32F.ForeColor = Color.ForestGreen;
                        pbarA32F.Value = 100;
                        btnA32F.Visible = false;
                        pbarA32F.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "A332":

                        lblA332.Visible = true;
                        lblA332.Text = "Obtained!";
                        lblA332.ForeColor = Color.ForestGreen;
                        pbarA332.Value = 100;
                        btnA332.Visible = false;
                        pbarA332.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "A343":

                        lblA343.Visible = true;
                        lblA343.Text = "Obtained!";
                        lblA343.ForeColor = Color.ForestGreen;
                        pbarA343.Value = 100;
                        btnA343.Visible = false;
                        pbarA343.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "B738":

                        lblB738.Visible = true;
                        lblB738.Text = "Obtained!";
                        lblB738.ForeColor = Color.ForestGreen;
                        pbarB738.Value = 100;
                        btnB738.Visible = false;
                        pbarB738.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "B744":

                        lblB744.Visible = true;
                        lblB744.Text = "Obtained!";
                        lblB744.ForeColor = Color.ForestGreen;
                        pbarB744.Value = 100;
                        btnB744.Visible = false;
                        pbarB744.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "B763":

                        lblB763.Visible = true;
                        lblB763.Text = "Obtained!";
                        lblB763.ForeColor = Color.ForestGreen;
                        pbarB763.Value = 100;
                        btnB763.Visible = false;
                        pbarB763.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "B77L":

                        lblB77L.Visible = true;
                        lblB77L.Text = "Obtained!";
                        lblB77L.ForeColor = Color.ForestGreen;
                        pbarB77L.Value = 100;
                        btnB77L.Visible = false;
                        pbarB77L.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "B787":

                        lblB787.Visible = true;
                        lblB787.Text = "Obtained!";
                        lblB787.ForeColor = Color.ForestGreen;
                        pbarB787.Value = 100;
                        btnB787.Visible = false;
                        pbarB787.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "MD11":

                        lblMD11.Visible = true;
                        lblMD11.Text = "Obtained!";
                        lblMD11.ForeColor = Color.ForestGreen;
                        pbarMD11.Value = 100;
                        btnMD11.Visible = false;
                        pbarMD11.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "CONC":

                        lblCONC.Visible = true;
                        lblCONC.Text = "Obtained!";
                        lblCONC.ForeColor = Color.ForestGreen;
                        pbarCONC.Value = 100;
                        btnCONC.Visible = false;
                        pbarCONC.ProgressColor = Color.CornflowerBlue;

                        break;

                    default:
                        break;
                }
            }
        }

        public void GetQualifications()
        {
            int progress;

            foreach (AllQualificationsByUserRank q in AllQualificationsByUserRank.Get())
            {
                switch (q.QualificationName)
                {
                    case "RVSM / ETOPS":

                        q.GetTypeQualificationExamAssign(q.QualificationID);

                        progress = (a.Eps * 100) / q.Eps;

                        lblRVSMETOPS.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarRVSMETOPS.Value = 100;
                            lblRVSMETOPS.Visible = false;
                            lblRVSMETOPS.ForeColor = Color.ForestGreen;
                            if (q.ExamTypeAssign)
                                btnRVSMETOPS.Visible = false;
                            else
                                btnRVSMETOPS.Visible = true;
                            btnRVSMETOPS.Tag = q.QualificationID;
                        }
                        else
                        {
                            pbarRVSMETOPS.Value = progress;
                            lblRVSMETOPS.Visible = true;
                            lblRVSMETOPS.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarRVSMETOPS.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarRVSMETOPS.ProgressColor = Color.Red;
                        }

                        break;

                    case "Gibraltar":

                        q.GetTypeQualificationExamAssign(q.QualificationID);

                        progress = (a.Eps * 100) / q.Eps;

                        lblLXGB.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarLXGB.Value = 100;
                            lblLXGB.Visible = false;
                            lblLXGB.ForeColor = Color.ForestGreen;
                            if (q.ExamTypeAssign)
                                btnLXGB.Visible = false;
                            else
                                btnLXGB.Visible = true;
                            btnLXGB.Tag = q.QualificationID;

                        }
                        else
                        {
                            pbarLXGB.Value = progress;
                            lblLXGB.Visible = true;
                            lblLXGB.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarLXGB.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarLXGB.ProgressColor = Color.Red;
                        }

                        break;

                    case "Madeira":

                        q.GetTypeQualificationExamAssign(q.QualificationID);

                        progress = (a.Eps * 100) / q.Eps;

                        lblLPMA.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarLPMA.Value = 100;
                            lblLPMA.Visible = false;
                            lblLPMA.ForeColor = Color.ForestGreen;
                            if (q.ExamTypeAssign)
                                btnLPMA.Visible = false;
                            else
                                btnLPMA.Visible = true;
                            btnLPMA.Tag = q.QualificationID;
                        }
                        else
                        {
                            pbarLPMA.Value = progress;
                            lblLPMA.Visible = true;
                            lblLPMA.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarLPMA.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarLPMA.ProgressColor = Color.Red;
                        }

                        break;                  

                    default:
                        break;
                }

            }

            foreach (Qualification q in Qualification.Get())
            {

                switch (q.QualificationName)
                {
                    case "RVSM / ETOPS":

                        lblRVSMETOPS.Visible = true;
                        lblRVSMETOPS.Text = "Obtained!";
                        lblRVSMETOPS.ForeColor = Color.ForestGreen;
                        pbarRVSMETOPS.Value = 100;
                        btnRVSMETOPS.Visible = false;
                        pbarRVSMETOPS.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "Gibraltar":

                        lblLXGB.Visible = true;
                        lblLXGB.Text = "Obtained!";
                        lblLXGB.ForeColor = Color.ForestGreen;
                        pbarLXGB.Value = 100;
                        btnLXGB.Visible = false;
                        pbarLXGB.ProgressColor = Color.CornflowerBlue;

                        break;

                    case "Madeira":

                        lblLPMA.Visible = true;
                        lblLPMA.Text = "Obtained!";
                        lblLPMA.ForeColor = Color.ForestGreen;
                        pbarLPMA.Value = 100;
                        btnLPMA.Visible = false;
                        pbarLPMA.ProgressColor = Color.CornflowerBlue;

                        break;                   

                    default:
                        break;
                }
            }
        }

        public void GetPromotion()
        {
            foreach (UserNextRank q in UserNextRank.Get())
            {

                int progressTypes;
                int progressQuals;
                int progress;

                if ((q.NextRankID) == 0)
                    gboxPromotion.Visible = false;
                else
                    gboxPromotion.Visible = true;

                switch (q.NextRank)
                {
                    case "Senior Student":

                        q.GetTypePromotionExamAssign(q.NextRankID);

                        imgPromotion.Image = Properties.Resources.seniorstudent;
                        btnPromotion.Tag = q.NextRankID;

                        lblNextRank.Text = "Senior Student";

                        progressTypes = (q.CountType * 100) / q.MinType;

                        progressQuals = 100;

                        progress = (progressTypes + progressQuals) / 2;

                        lblPromotion.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarPromotion.Value = 100;
                            lblPromotion.Visible = false;
                            lblPromotion.ForeColor = Color.ForestGreen;
                            if (q.ExamTypeAssign)
                                btnPromotion.Visible = false;
                            else
                                btnPromotion.Visible = true;
                        }
                        else
                        {
                            pbarPromotion.Value = progress;
                            lblPromotion.Visible = true;
                            lblPromotion.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarPromotion.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarPromotion.ProgressColor = Color.Red;
                        }

                        break;

                    case "Second Officer":

                        q.GetTypePromotionExamAssign(q.NextRankID);

                        imgPromotion.Image = Properties.Resources.secondofficer;
                        btnPromotion.Tag = q.NextRankID;

                        lblNextRank.Text = "Second Officer";

                        progressTypes = (q.CountType * 100) / q.MinType;

                        progressQuals = (q.CountQual * 100) / q.MinQual;

                        progress = (progressTypes + progressQuals) / 2;

                        lblPromotion.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarPromotion.Value = 100;
                            lblPromotion.Visible = false;
                            lblPromotion.ForeColor = Color.ForestGreen;
                            if (q.ExamTypeAssign)
                                btnPromotion.Visible = false;
                            else
                                btnPromotion.Visible = true;
                        }
                        else
                        {
                            pbarPromotion.Value = progress;
                            lblPromotion.Visible = true;
                            lblPromotion.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarPromotion.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarPromotion.ProgressColor = Color.Red;
                        }

                        break;

                    case "First Officer":

                        q.GetTypePromotionExamAssign(q.NextRankID);

                        imgPromotion.Image = Properties.Resources.firstofficer;
                        btnPromotion.Tag = q.NextRankID;

                        lblNextRank.Text = "First Officer";

                        progressTypes = (q.CountType * 100) / q.MinType;

                        progressQuals = (q.CountQual * 100) / q.MinQual;

                        progress = (progressTypes + progressQuals) / 2;

                        lblPromotion.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarPromotion.Value = 100;
                            lblPromotion.Visible = false;
                            lblPromotion.ForeColor = Color.ForestGreen;
                            if (q.ExamTypeAssign)
                                btnPromotion.Visible = false;
                            else
                                btnPromotion.Visible = true;
                        }
                        else
                        {
                            pbarPromotion.Value = progress;
                            lblPromotion.Visible = true;
                            lblPromotion.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarPromotion.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarPromotion.ProgressColor = Color.Red;
                        }

                        break;

                    case "Captain":

                        q.GetTypePromotionExamAssign(q.NextRankID);

                        imgPromotion.Image = Properties.Resources.captain;
                        btnPromotion.Tag = q.NextRankID;

                        lblNextRank.Text = "Captain";

                        progressTypes = (q.CountType * 100) / q.MinType;

                        progressQuals = (q.CountQual * 100) / q.MinQual;

                        progress = (progressTypes + progressQuals) / 2;

                        lblPromotion.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarPromotion.Value = 100;
                            lblPromotion.Visible = false;
                            lblPromotion.ForeColor = Color.ForestGreen;
                            if (q.ExamTypeAssign)
                                btnPromotion.Visible = false;
                            else
                                btnPromotion.Visible = true;
                        }
                        else
                        {
                            pbarPromotion.Value = progress;
                            lblPromotion.Visible = true;
                            lblPromotion.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarPromotion.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarPromotion.ProgressColor = Color.Red;
                        }

                        break;

                    case "Senior Captain":

                        q.GetTypePromotionExamAssign(q.NextRankID);

                        imgPromotion.Image = Properties.Resources.seniorcaptain;
                        btnPromotion.Tag = q.NextRankID;

                        lblNextRank.Text = "Senior Captain";

                        progressTypes = (q.CountType * 100) / q.MinType;

                        progressQuals = (q.CountQual * 100) / q.MinQual;

                        progress = (progressTypes + progressQuals) / 2;

                        lblPromotion.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarPromotion.Value = 100;
                            lblPromotion.Visible = false;
                            lblPromotion.ForeColor = Color.ForestGreen;
                            if (q.ExamTypeAssign)
                                btnPromotion.Visible = false;
                            else
                                btnPromotion.Visible = true;
                        }
                        else
                        {
                            pbarPromotion.Value = progress;
                            lblPromotion.Visible = true;
                            lblPromotion.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarPromotion.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarPromotion.ProgressColor = Color.Red;
                        }

                        break;

                    case "Flight Instructor":

                        q.GetTypePromotionExamAssign(q.NextRankID);

                        imgPromotion.Image = Properties.Resources.flightinstructor;
                        btnPromotion.Tag = q.NextRankID;

                        lblNextRank.Text = "Flight Instructor";

                        progressTypes = (q.CountType * 100) / q.MinType;

                        progressQuals = (q.CountQual * 100) / q.MinQual;

                        progress = (progressTypes + progressQuals) / 2;

                        lblPromotion.Text = String.Format("{0}% to Complete", progress);

                        if (progress >= 100)
                        {
                            pbarPromotion.Value = 100;
                            lblPromotion.Visible = false;
                            lblPromotion.ForeColor = Color.ForestGreen;
                            if (q.ExamTypeAssign)
                                btnPromotion.Visible = false;
                            else
                                btnPromotion.Visible = true;
                        }
                        else
                        {
                            pbarPromotion.Value = progress;
                            lblPromotion.Visible = true;
                            lblPromotion.ForeColor = Color.MediumBlue;

                            if (progress < 100 && progress >= 50)
                                pbarPromotion.ProgressColor = Color.Goldenrod;
                            else if (progress < 50)
                                pbarPromotion.ProgressColor = Color.Red;
                        }

                        break;

                    default:
                        break;
                }

            }           
        }

        private void btnC172_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnC172.Tag), a.UserID);
            btnC172.Visible = false;
        }

        private void btnB190_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnB190.Tag), a.UserID);
            btnB190.Visible = false;
        }

        private void btnJS41_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnJS41.Tag), a.UserID);
            btnJS41.Visible = false;
        }

        private void btnDH8D_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnDH8D.Tag), a.UserID);
            btnDH8D.Visible = false;
        }

        private void btnAT72_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnAT72.Tag), a.UserID);
            btnAT72.Visible = false;
        }

        private void btnRJ1H_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnRJ1H.Tag), a.UserID);
            btnRJ1H.Visible = false;
        }

        private void btnA32F_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnA32F.Tag), a.UserID);
            btnA32F.Visible = false;
        }

        private void btnB738_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnB738.Tag), a.UserID);
            btnB738.Visible = false;
        }

        private void btnA332_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnA332.Tag), a.UserID);
            btnA332.Visible = false;
        }

        private void btnB763_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnB763.Tag), a.UserID);
            btnB763.Visible = false;
        }

        private void btnB77L_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnB77L.Tag), a.UserID);
            btnB77L.Visible = false;
        }

        private void btnB787_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnB787.Tag), a.UserID);
            btnB787.Visible = false;
        }

        private void btnMD11_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnMD11.Tag), a.UserID);
            btnMD11.Visible = false;
        }

        private void btnA343_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnA343.Tag), a.UserID);
            btnA343.Visible = false;
        }

        private void btnB744_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnB744.Tag), a.UserID);
            btnB744.Visible = false;
        }

        private void btnCONC_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamTypeRating(Convert.ToInt32(btnCONC.Tag), a.UserID);
            btnCONC.Visible = false;
        }

        private void btnRVSMETOPS_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamQualification(Convert.ToInt32(btnRVSMETOPS.Tag), a.UserID);
            btnRVSMETOPS.Visible = false;
        }

        private void btnLXGB_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamQualification(Convert.ToInt32(btnLXGB.Tag), a.UserID);
            btnLXGB.Visible = false;
        }

        private void btnLPMA_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamQualification(Convert.ToInt32(btnLPMA.Tag), a.UserID);
            btnLPMA.Visible = false;
        }

        private void btnPromotion_Click(object sender, EventArgs e)
        {
            TakeExamForPilot.TakeExamPromotion(Convert.ToInt32(btnPromotion.Tag), a.UserID);
            btnPromotion.Visible = false;
        }
    }
}
