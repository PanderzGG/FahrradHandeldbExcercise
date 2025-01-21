using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FahrradHandel
{
    public class Datenbank
    {
        private MySqlConnection con;
        private string connectionString;

        public Datenbank()
        {
            connectionString = string.Format("SERVER = localhost; DATABASE = Fahrradhandeldb; UID = {0}; PASSWORD = {1}", "root", "");
            con = new MySqlConnection(connectionString);
        }

        #region Connecion

        private void Open()
        {
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Close()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region Get all Lists

        public List<string> getTableName()
        {
            List<string> litab = new List<string>();

            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = string.Format("show tables;");
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    litab.Add(reader.GetString(0));
                }
                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Tabellen (getTableName()) können nicht geladen werden." + Environment.NewLine + ex.Message);
            }
            finally
            {
                Close();
            }

            return litab;
        }


        public List<Fahrrad> getFahrrad()
        {
            List<Fahrrad> liFahrrad = new List<Fahrrad>();

            try
            {
                Open();

                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM fahrrad;";
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liFahrrad.Add(
                        new Fahrrad(
                            reader.GetInt32("fahrradID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_Lager"),
                            reader.GetInt32("rahmenID"),
                            reader.GetInt32("laufraederID"),
                            reader.GetInt32("gabelID"),
                            reader.GetInt32("reifenID"),
                            reader.GetInt32("lenkerID"),
                            reader.GetInt32("vorbauID"),
                            reader.GetInt32("sattelID"),
                            reader.GetInt32("sattelstuetzeID"),
                            reader.GetInt32("pedaleID"),
                            reader.GetInt32("kettenblattID"),
                            reader.GetInt32("ketteID"),
                            reader.GetInt32("schaltwerkID"),
                            reader.GetInt32("ritzelID"),
                            reader.GetInt32("tretlagerID"),
                            reader.GetInt32("bremsenID"),
                            reader.GetInt32("bremshebelID"),
                            reader.GetInt32("lichtanlageID"),
                            reader.GetInt32("staenderID"),
                            reader.GetInt32("klingelID"),
                            reader.GetString("bild_dateiname")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                int list = liFahrrad.Count;

                MessageBox.Show(ex.Message);

                for (int i = 0; i < list; i++)
                {
                    MessageBox.Show("FahrradID: " + liFahrrad[i].FahrradID.ToString() + Environment.NewLine + "Marke: " +liFahrrad[i].Marke + Environment.NewLine + "Modell: " +liFahrrad[i].Modell + Environment.NewLine + "Preis: " + liFahrrad[i].Preis.ToString() + Environment.NewLine +
                            "Auf Lager: " + liFahrrad[i].AufLager.ToString() + Environment.NewLine + "RahmenID: " + liFahrrad[i].RahmenID.ToString() + Environment.NewLine + "LaufradID" + liFahrrad[i].LaufraederID.ToString() + Environment.NewLine +
                            "ReifenID: " + liFahrrad[i].ReifenID.ToString() + Environment.NewLine + "GabelID: " + liFahrrad[i].GabelID.ToString() + Environment.NewLine + "LenkerID" + liFahrrad[i].LenkerID.ToString() + Environment.NewLine +
                            "VorbauID: " + liFahrrad[i].VorbauID.ToString() + Environment.NewLine + "SattelID" + liFahrrad[i].SattelID.ToString() + Environment.NewLine + "SattelStützeID: " + liFahrrad[i].SattelstuetzeID.ToString() + Environment.NewLine +
                            "PedaleID: " + liFahrrad[i].PedaleID.ToString() + Environment.NewLine + "KettenblattID: " + liFahrrad[i].KettenblattID.ToString() + Environment.NewLine + "KetteID: " + liFahrrad[i].KetteID.ToString() + Environment.NewLine +
                            "SchaltwerkID: " + liFahrrad[i].SchaltwerkID.ToString() + Environment.NewLine + "RitzelID: " + liFahrrad[i].RitzelID.ToString() + Environment.NewLine + "TretlagerID: " + liFahrrad[i].TretlagerID.ToString() + Environment.NewLine +
                            "BremseID: " + liFahrrad[i].BremseID.ToString() + Environment.NewLine + "BremshebelID: " + liFahrrad[i].BremshebelID.ToString() + Environment.NewLine + "LichtanlagenID: " + liFahrrad[i].LichtanlageID.ToString() + Environment.NewLine +
                            "SänderID: " + liFahrrad[i].StaenderID.ToString() + Environment.NewLine + "KlingelID: " + liFahrrad[i].KlingelID.ToString() + Environment.NewLine + "Dateiname: " + liFahrrad[i].ImagePath.ToString()
                    );
                }


            }
            finally
            {
                Close();
            }

            return liFahrrad;
        }

        public List<Bremsen> getBremsen()
        {
            List<Bremsen> libremsen = new List<Bremsen>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM bremsen";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    libremsen.Add(
                        new Bremsen(
                            reader.GetInt32("bremsenID"),
                            reader.GetString("bremsart"),
                            reader.GetString("bremsbelagmaterial"),
                            reader.GetInt32("durchmesser"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("2 " +ex.Message);
            }
            finally
            {
                Close();
            }
            return libremsen;
        }

        public List<Bremshebel> getBremshebel()
        {
            List<Bremshebel> libremsh = new List<Bremshebel>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM bremshebel";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    libremsh.Add(
                        new Bremshebel(
                            reader.GetInt32("bremshebelID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetString("hebelmaterial"),
                            reader.GetBoolean("verstellbar"),
                            reader.GetString("ergonomie")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("3 " + ex.Message);
            }
            finally
            {
                Close();
            }
            return libremsh;
        }

        public List<Gabel> getGabel()
        {
            List<Gabel> ligabel = new List<Gabel>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM gabel";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    ligabel.Add(
                        new Gabel(
                            reader.GetInt32("gabelID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetString("gabeltyp"),
                            reader.GetString("material"),
                            reader.GetInt32("federweg")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("4 " + ex.Message);
            }
            finally
            {
                Close();
            }
            return ligabel;
        }

        public List<Kette> getKette()
        {
            List<Kette> likette = new List<Kette>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM kette";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    likette.Add(
                        new Kette(
                            reader.GetInt32("ketteID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetString("kettenart"),
                            reader.GetString("material"),
                            reader.GetInt32("laenge")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("5 " + ex.Message);
            }
            finally
            {
                Close();
            }
            return likette;
        }

        public List<Kettenblatt> getKettenblatt()
        {
            List<Kettenblatt> likettenb = new List<Kettenblatt>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM kettenblatt";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    likettenb.Add(
                        new Kettenblatt(
                            reader.GetInt32("kettenblattID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetInt32("zahnanzahl"),
                            reader.GetString("material"),
                            reader.GetInt32("lochkreis")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("6 " + ex.Message);
            }
            finally
            {
                Close();
            }
            return likettenb;
        }

        public List<Klingel> getKlingel()
        {
            List<Klingel> liklingel = new List<Klingel>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM klingel";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liklingel.Add(
                        new Klingel(
                            reader.GetInt32("klingelID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetString("klingeltyp"),
                            reader.GetString("material"),
                            reader.GetInt32("lautstaerke")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("7 " + ex.Message);
            }
            finally
            {
                Close();
            }
            return liklingel;
        }

        public List<Laufraeder> getLaufraeder()
        {
            List<Laufraeder> lilaufr = new List<Laufraeder>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM laufraeder";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    lilaufr.Add(
                        new Laufraeder(
                            reader.GetInt32("laufraederID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetString("felgengroesse"),
                            reader.GetString("nabenart"),
                            reader.GetString("reifentyp")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("8 " + ex.Message);
            }
            finally
            {
                Close();
            }
            return lilaufr;
        }

        public List<Lenker> getLenker()
        {
            List<Lenker> lilenker = new List<Lenker>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM lenker";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    lilenker.Add(
                        new(
                            reader.GetInt32("lenkerID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetString("lenkertyp"),
                            reader.GetString("material"),
                            reader.GetInt32("breite")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("9 " + ex.Message);
            }
            finally
            {
                Close();
            }
            return lilenker;
        }

        public List<Lichtanlage> getLichtanlage()
        {
            List<Lichtanlage> lilichtan = new List<Lichtanlage>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM lichtanlage";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    lilichtan.Add(
                        new Lichtanlage(
                            reader.GetInt32("lichtanlageID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetInt32("leuchtstaerke"),
                            reader.GetString("stromversorgung"),
                            reader.GetString("montagemoeglichkeit")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("10 " + ex.Message);
            }
            finally
            {
                Close();
            }
            return lilichtan;
        }

        public List<Pedale> getPedale()
        {
            List<Pedale> lipedale = new List<Pedale>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM pedale";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    lipedale.Add(
                        new Pedale(
                            reader.GetInt32("pedaleID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetString("pedaltyp"),
                            reader.GetString("material"),
                            reader.GetBoolean("reflektoren")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
            return lipedale;
        }

        public List<Rahmen> getRahmen()
        {
            List<Rahmen> lirahmen = new List<Rahmen>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM rahmen";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    lirahmen.Add(
                        new Rahmen(
                            reader.GetInt32("rahmenID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetString("material"),
                            reader.GetString("groesse"),
                            reader.GetString("farbe")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
            return lirahmen;
        }

        public List<Reifen> getReifen()
        {
            List<Reifen> lireifen = new List<Reifen>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM reifen";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    lireifen.Add(
                        new Reifen(
                            reader.GetInt32("reifenID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetString("reifentyp"),
                            reader.GetString("groesse"),
                            reader.GetString("profil")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
            return lireifen;
        }

        public List<Ritzel> getRitzel()
        {
            List<Ritzel> liritzel = new List<Ritzel>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM ritzel";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    liritzel.Add(
                        new Ritzel(
                            reader.GetInt32("ritzelID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetInt32("zahnanzahl"),
                            reader.GetString("material"),
                            reader.GetBoolean("freilauf")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
            return liritzel;
        }

        public List<Sattel> getSattel()
        {
            List<Sattel> lisattel = new List<Sattel>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM sattel";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    lisattel.Add(
                        new Sattel(
                            reader.GetInt32("sattelID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetString("satteltyp"),
                            reader.GetString("material"),
                            reader.GetString("polsterung")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
            return lisattel;
        }

        public List<Sattelstuetze> getSattelstuetze()
        {
            List<Sattelstuetze> lisattelst = new List<Sattelstuetze>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM sattelstuetze";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    lisattelst.Add(
                        new Sattelstuetze(
                            reader.GetInt32("sattelstuetzeID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetInt32("durchmesser"),
                            reader.GetString("material"),
                            reader.GetBoolean("federung")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
            return lisattelst;
        }

        public List<Schaltwerk> getSchaltwerk()
        {
            List<Schaltwerk> lischaltw = new List<Schaltwerk>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM schaltwerk";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    lischaltw.Add(
                        new Schaltwerk(
                            reader.GetInt32("schaltwerkID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetString("schaltungstyp"),
                            reader.GetString("material"),
                            reader.GetInt32("schaltstufen")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
            return lischaltw;
        }

        public List<Staender> getStaender()
        {
            List<Staender> listaender = new List<Staender>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM staender";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    listaender.Add(
                        new Staender(
                            reader.GetInt32("staenderID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetString("typ"),
                            reader.GetString("material"),
                            reader.GetBoolean("verstellbar")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
            return listaender;
        }

        public List<Tretlager> getTretlager()
        {
            List<Tretlager> litretl = new List<Tretlager>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM tretlager";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    litretl.Add(
                        new Tretlager(
                            reader.GetInt32("tretlagerID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetInt32("achsendurchmesser"),
                            reader.GetString("lagerart"),
                            reader.GetString("material")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
            return litretl;
        }

        public List<Vorbau> getVorbau()
        {
            List<Vorbau> livorbau = new List<Vorbau>();
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = "SELECT * FROM vorbau";
                MySqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    livorbau.Add(
                        new Vorbau(
                            reader.GetInt32("vorbauID"),
                            reader.GetString("marke"),
                            reader.GetString("modell"),
                            reader.GetDecimal("preis"),
                            reader.GetInt32("stk_auf_lager"),
                            reader.GetInt32("laenge"),
                            reader.GetInt32("winkel"),
                            reader.GetString("material")
                            )
                        );
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
            return livorbau;
        }
        #endregion

        #region Write to Database

        public void newFahrrad(Fahrrad fahrrad)
        {
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();

                // Todo speichern können

                if (fahrrad.FahrradID == -1)
                {
                    com.CommandText = "INSERT INTO fahrrad (marke, modell, preis, stk_auf_lager, rahmenID, laufraederID, reifenID, gabelID, lenkerID, vorbauID, sattelID, sattelstuetzeID, pedaleID, kettenblattID, ketteID, schaltwerkID, ritzelID, tretlagerID, bremsenID, bremshebelID,lichtanlageID, staenderID, klingelID, bild_dateiname)" +
                                      "VALUES (@Marke, @Modell, @Preis, @AufLager, @RahmenID, @LaufraederID, @ReifenID, @GabelID, @LenkerID, @VorbauID, @SattelID, @SattelstuetzeID, @PedaleID, @KettenblattID, @KetteID, @SchaltwerkID, @RitzelID, @TretlagerID, @BremsenID, @BremshebelID,@LichtanlageID, @StaenderID, @KlingelID, @bild_dateiname);";
                }
                else
                {
                    com.CommandText = "UPDATE fahrrad SET marke = @Marke, modell = @Modell, preis = @Preis, stk_auf_lager = @AufLager, rahmenID = @RahmenID, laufraederID = @LaufraederID, reifenID = @ReifenID, gabelID = @GabelID, lenkerID = @LenkerID, vorbauID = @VorbauID, sattelID = @SattelID, sattelstuetzeID = @SattelstuetzeID, pedaleID = @PedaleID, kettenblattID = @KettenblattID, ketteID = @KetteID, schaltwerkID = @SchaltwerkID, ritzelID = @RitzelID, tretlagerID = @TretlagerID, bremsenID = @BremsenID, bremshebelID = @bremshebelID, lichtanlageID = @LichtanlageID, staenderID = @StaenderID, klingelID = @KlingelID WHERE fahrradID = @FahrradID;";
                    com.Parameters.AddWithValue("@FahrradID", fahrrad.FahrradID);
                }

                com.Parameters.AddWithValue("@Marke", fahrrad.Marke);
                com.Parameters.AddWithValue("@Modell", fahrrad.Modell);
                com.Parameters.AddWithValue("@Preis", fahrrad.Preis);
                com.Parameters.AddWithValue("@AufLager", fahrrad.AufLager);
                com.Parameters.AddWithValue("@RahmenID", fahrrad.RahmenID);
                com.Parameters.AddWithValue("@LaufraederID", fahrrad.LaufraederID);
                com.Parameters.AddWithValue("@ReifenID", fahrrad.ReifenID);
                com.Parameters.AddWithValue("@GabelID", fahrrad.GabelID);
                com.Parameters.AddWithValue("@LenkerID", fahrrad.LenkerID);
                com.Parameters.AddWithValue("@VorbauID", fahrrad.VorbauID);
                com.Parameters.AddWithValue("@SattelID", fahrrad.SattelID);
                com.Parameters.AddWithValue("@SattelstuetzeID", fahrrad.SattelstuetzeID);
                com.Parameters.AddWithValue("@PedaleID", fahrrad.PedaleID);
                com.Parameters.AddWithValue("@KettenblattID", fahrrad.KettenblattID);
                com.Parameters.AddWithValue("@KetteID", fahrrad.KetteID);
                com.Parameters.AddWithValue("@SchaltwerkID", fahrrad.SchaltwerkID);
                com.Parameters.AddWithValue("@RitzelID", fahrrad.RitzelID);
                com.Parameters.AddWithValue("@TretlagerID", fahrrad.TretlagerID);
                com.Parameters.AddWithValue("@BremsenID", fahrrad.BremseID);
                com.Parameters.AddWithValue("@BremshebelID", fahrrad.BremshebelID);
                com.Parameters.AddWithValue("@LichtanlageID", fahrrad.LichtanlageID);
                com.Parameters.AddWithValue("@StaenderID", fahrrad.StaenderID);
                com.Parameters.AddWithValue("@KlingelID", fahrrad.KlingelID);
                com.Parameters.AddWithValue("@bild_dateiname", fahrrad.ImagePath);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("TEstooo " + ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public void newBremsen(Bremsen bremse)
        {
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();

                if (bremse.BremsenID == -1)
                {
                    com.CommandText = "INSERT INTO bremsen(marke, modell, preis, stk_auf_lager, bremsart, bremsbelagmaterial, durchmesser)" +
                                      "VALUES (@marke, @modell, @preis, @aufLager, @bremsart, @bremsbelagmaterial, @durchmesser)";
                }
                else
                {

                }
                com.Parameters.AddWithValue("@marke", bremse.Marke);
                com.Parameters.AddWithValue("@modell", bremse.Modell);
                com.Parameters.AddWithValue("@preis", bremse.Preis);
                com.Parameters.AddWithValue("@aufLager", bremse.AufLager);
                com.Parameters.AddWithValue("@bremsart", bremse.BremsArt);
                com.Parameters.AddWithValue("@bremsbelagmaterial", bremse.Bremsbelagmaterial);
                com.Parameters.AddWithValue("@durchmesser", bremse.Durchmesser);
                com.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

            }
            finally
            {
                Close();
            }
        }

        public void newBremshebel(Bremshebel bremsh)
        {
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();

                if(bremsh.BremshebelID == -1)
                {
                    
                    com.CommandText = "INSERT INTO bremshebel(marke, modell, preis, stk_auf_lager, hebelmaterial, verstellbar, ergonomie) " +
                                      "VALUES (@marke, @modell, @preis, @aufLager, @hebelmaterial, @verstellbar, @ergonomie)";
                }
                else
                {

                }
                
                com.Parameters.AddWithValue("@marke", bremsh.Marke);
                com.Parameters.AddWithValue("@modell", bremsh.Modell);
                com.Parameters.AddWithValue("@preis", bremsh.Preis);
                com.Parameters.AddWithValue("@aufLager", bremsh.AufLager);
                com.Parameters.AddWithValue("@hebelmaterial", bremsh.Hebelmaterial);
                com.Parameters.AddWithValue("@verstellbar", bremsh.Verstellbar);
                com.Parameters.AddWithValue("@ergonomie", bremsh.Ergonomie);
                
                com.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public void newGabel(Gabel gabel)
        {
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();

                if (gabel.GabelID == -1)
                {

                    com.CommandText = "INSERT INTO gabel(marke, modell, preis, stk_auf_lager, gabeltyp, material, federweg) " +
                                      "VALUES (@marke, @modell, @preis, @aufLager, @gabeltyp, @material, @federweg)";
                }
                else
                {

                }

                com.Parameters.AddWithValue("@marke", gabel.Marke);
                com.Parameters.AddWithValue("@modell", gabel.Modell);
                com.Parameters.AddWithValue("@preis", gabel.Preis);
                com.Parameters.AddWithValue("@aufLager", gabel.AufLager);
                com.Parameters.AddWithValue("@gabeltyp", gabel.Gabeltyp);
                com.Parameters.AddWithValue("@material", gabel.Material);
                com.Parameters.AddWithValue("@federweg", gabel.Federweg);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public void newKette(Kette kette)
        {
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();

                if (kette.KetteID == -1)
                {

                    com.CommandText = "INSERT INTO kette(marke, modell, preis, stk_auf_lager, kettenart, material, laenge) " +
                                      "VALUES (@marke, @modell, @preis, @aufLager, @kettenart, @material, @laenge)";
                }
                else
                {
                }

                com.Parameters.AddWithValue("@marke", kette.Marke);
                com.Parameters.AddWithValue("@modell", kette.Modell);
                com.Parameters.AddWithValue("@preis", kette.Preis);
                com.Parameters.AddWithValue("@aufLager", kette.AufLager);
                com.Parameters.AddWithValue("@kettenart", kette.Kettenart);
                com.Parameters.AddWithValue("@material", kette.Material);
                com.Parameters.AddWithValue("@laenge", kette.Laenge);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public void newKettenblatt(Kettenblatt kettenb)
        {
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();

                if (kettenb.KettenblattID == -1)
                {

                    com.CommandText = "INSERT INTO kettenblatt(marke, modell, preis, stk_auf_lager, zahnanzahl, material, lochkreis) " +
                                      "VALUES (@marke, @modell, @preis, @aufLager, @zahnanzahl, @material, @lochkreis)";
                }
                else
                {
                }

                com.Parameters.AddWithValue("@marke", kettenb.Marke);
                com.Parameters.AddWithValue("@modell", kettenb.Modell);
                com.Parameters.AddWithValue("@preis", kettenb.Preis);
                com.Parameters.AddWithValue("@aufLager", kettenb.AufLager);
                com.Parameters.AddWithValue("@zahnanzahl", kettenb.Zahnanzahl);
                com.Parameters.AddWithValue("@material", kettenb.Material);
                com.Parameters.AddWithValue("@lochkreis", kettenb.Lochkreis);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public void newKlingel(Klingel klingel)
        {
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();

                if (klingel.KlingelID == -1)
                {

                    com.CommandText = "INSERT INTO klingel(marke, modell, preis, stk_auf_lager, klingeltyp, material, lautstaerke) " +
                                      "VALUES (@marke, @modell, @preis, @aufLager, @klingeltyp, @material, @lautstaerke)";
                }
                else
                {
                }

                com.Parameters.AddWithValue("@marke", klingel.Marke);
                com.Parameters.AddWithValue("@modell", klingel.Modell);
                com.Parameters.AddWithValue("@preis", klingel.Preis);
                com.Parameters.AddWithValue("@aufLager", klingel.AufLager);
                com.Parameters.AddWithValue("@klingeltyp", klingel.Klingeltyp);
                com.Parameters.AddWithValue("@material", klingel.Material);
                com.Parameters.AddWithValue("@lautstaerke", klingel.Lautstaerke);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public void newLaufrad(Laufraeder laufrad)
        {
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();

                if (laufrad.LaufraederID == -1)
                {

                    com.CommandText = "INSERT INTO laufraeder(marke, modell, preis, stk_auf_lager, klingeltyp, material, lautstaerke) " +
                                      "VALUES (@marke, @modell, @preis, @aufLager, @klingeltyp, @material, @lautstaerke)";
                }
                else
                {
                }

                com.Parameters.AddWithValue("@marke", laufrad.Marke);
                com.Parameters.AddWithValue("@modell", laufrad.Modell);
                com.Parameters.AddWithValue("@preis", laufrad.Preis);
                com.Parameters.AddWithValue("@aufLager", laufrad.AufLager);
                com.Parameters.AddWithValue("@felgengroesse", laufrad.Felgengroesse);
                com.Parameters.AddWithValue("@nabenart", laufrad.Narbenart);
                com.Parameters.AddWithValue("@reifentyp", laufrad.Reifentyp);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public void newLenker(Lenker lenker)
        {
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();

                if (lenker.LenkerID== -1)
                {

                    com.CommandText = "INSERT INTO lenker(marke, modell, preis, stk_auf_lager, lenkertyp, material, breite) " +
                                      "VALUES (@marke, @modell, @preis, @aufLager, @lenkertyp, @material, @breite)";
                }
                else
                {
                }

                com.Parameters.AddWithValue("@marke", lenker.Marke);
                com.Parameters.AddWithValue("@modell", lenker.Modell);
                com.Parameters.AddWithValue("@preis", lenker.Preis);
                com.Parameters.AddWithValue("@aufLager", lenker.AufLager);
                com.Parameters.AddWithValue("@lenkertyp", lenker.Lenkertyp);
                com.Parameters.AddWithValue("@material", lenker.Material);
                com.Parameters.AddWithValue("@breite", lenker.Breite);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public void newLichtanlage(Lichtanlage lichtan)
        {
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();

                if (lichtan.LichtanlageID == -1)
                {

                    com.CommandText = "INSERT INTO lichtanlage(marke, modell, preis, stk_auf_lager, leuchtstaerke, stromversorgung, montagemoeglichkeit) " +
                                      "VALUES (@marke, @modell, @preis, @aufLager, @leuchtstaerke, @stromversorgung, @montage)";
                }
                else
                {
                }

                com.Parameters.AddWithValue("@marke", lichtan.Marke);
                com.Parameters.AddWithValue("@modell", lichtan.Modell);
                com.Parameters.AddWithValue("@preis", lichtan.Preis);
                com.Parameters.AddWithValue("@aufLager", lichtan.AufLager);
                com.Parameters.AddWithValue("@leuchtstaerke", lichtan.Leuchtstaerke);
                com.Parameters.AddWithValue("@stromversorgung", lichtan.Stromversorgung);
                com.Parameters.AddWithValue("@montage", lichtan.Montagemoeglichkeit);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public void newPedale(Pedale pedal)
        {
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();

                if (pedal.PedaleID == -1)
                {

                    com.CommandText = "INSERT INTO pedale(marke, modell, preis, stk_auf_lager, pedaltyp, material, reflektoren) " +
                                      "VALUES (@marke, @modell, @preis, @aufLager, @pedaltyp, @material, @reflektoren)";
                }
                else
                {
                }

                com.Parameters.AddWithValue("@marke", pedal.Marke);
                com.Parameters.AddWithValue("@modell", pedal.Modell);
                com.Parameters.AddWithValue("@preis", pedal.Preis);
                com.Parameters.AddWithValue("@aufLager", pedal.AufLager);
                com.Parameters.AddWithValue("@pedaltyp", pedal.Pedaltyp);
                com.Parameters.AddWithValue("@material", pedal.Material);
                com.Parameters.AddWithValue("@reflektoren", pedal.Reflektoren);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public void newRahmen(Rahmen rahmen)
        {
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();

                if (rahmen.RahmenID == -1)
                {

                    com.CommandText = "INSERT INTO rahmen(marke, modell, preis, stk_auf_lager, material, groesse, farbe) " +
                                      "VALUES (@marke, @modell, @preis, @aufLager, @material, @groesse, @farbe)";
                }
                else
                {
                }

                com.Parameters.AddWithValue("@marke", rahmen.Marke);
                com.Parameters.AddWithValue("@modell", rahmen.Modell);
                com.Parameters.AddWithValue("@preis", rahmen.Preis);
                com.Parameters.AddWithValue("@aufLager", rahmen.AufLager);
                com.Parameters.AddWithValue("@material", rahmen.Material);
                com.Parameters.AddWithValue("@groesse", rahmen.Groesse);
                com.Parameters.AddWithValue("@farbe", rahmen.Farbe);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        public void newReifen(Reifen reifen)
        {
            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();

                if (reifen.ReifenID == -1)
                {

                    com.CommandText = "INSERT INTO reifen(marke, modell, preis, stk_auf_lager, reifentyp, groesse, profil) " +
                                      "VALUES (@marke, @modell, @preis, @aufLager, @reifentyp, @groesse, @profil)";
                }
                else
                {
                }

                com.Parameters.AddWithValue("@marke", reifen.Marke);
                com.Parameters.AddWithValue("@modell", reifen.Modell);
                com.Parameters.AddWithValue("@preis", reifen.Preis);
                com.Parameters.AddWithValue("@aufLager", reifen.AufLager);
                com.Parameters.AddWithValue("@reifentyp", reifen.Reifentyp);
                com.Parameters.AddWithValue("@groesse", reifen.Groesse);
                com.Parameters.AddWithValue("@profil", reifen.Profil);

                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        #endregion

        #region Delete from Database

        public void deleteFahrrad(int fahrradID)
        {
            try
            {
                Open();

                MySqlCommand com = con.CreateCommand();
                com.CommandText = "DELETE FROM fahrrad WHERE fahrradID = @FahrradID";
                com.Parameters.AddWithValue("@FahrradID", fahrradID);
                com.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Fahrrad konnte nicht gelöscht werden: " + Environment.NewLine + ex.Message);
            }
            finally
            {
                Close();
                MessageBox.Show("Fahrrad wurde gelöscht");
            }
        }

        public void deleteTeil(string auswahl, int delID)
        {
            try
            {
                Open();

                MySqlCommand com = con.CreateCommand();
                com.CommandText = string.Format("DELETE FROM {0} WHERE {1}ID = {2};", auswahl, auswahl, delID);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Close();
            }
        }

        #endregion

        #region Read from Database

        public List<string> getselectedTeil(string auswahl)
        {
            List<string> liSpalten = new List<string>();

            try
            {
                Open();
                MySqlCommand com = con.CreateCommand();
                com.CommandText = string.Format("desc `{0}`;", auswahl);
                MySqlDataReader reader = com.ExecuteReader();

                while (reader.Read())
                {
                    liSpalten.Add(reader.GetString(0));
                }
                reader.Close();
            }
            catch(Exception ex)
            {

            }
            finally
            {
                Close();
            }

            return liSpalten;
        }

        #endregion

    }

}

