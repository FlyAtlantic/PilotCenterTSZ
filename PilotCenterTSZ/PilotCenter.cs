using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using ExamCenterTSZ.Functions;
using MySql.Data.MySqlClient;

namespace PilotCenterTSZ
{
    public class UserInfo
    {
        public int UserID
        { get; set; }

        public int LevelID
        { get; }

        public string UserName
        { get; set; }

        public string UserSurname
        { get; set; }

        public string Rank
        { get; set; }

        public int RankID
        { get; set; }

        public string Rate
        { get; set; }

        public int Callsign
        { get; set; }

        public TimeSpan PilotHours
        { get; set; }

        public DateTime LastFlight
        { get; set; }

        public string Hub
        { get; set; }

        public string Location
        { get; set; }

        public int Eps
        { get; set; }

        public UserInfo()
        {
            string sqlPilotInformations = "SELECT user_id, user_nome, user_apelido, ranks.rank, ratings.ratingname, utilizadores.callsign, utilizadores.pilot_hours, pireps.date, hubs.icao, utilizadores.location, utilizadores.eps, ranks.rankid, utilizadores.levelid from utilizadores left join ratings on utilizadores.rate = ratings.id left join ranks on utilizadores.rank = ranks.rankid left join pireps on utilizadores.user_id = pireps.pilotid LEFT JOIN flights ON pireps.flightid = flights.idf left join hubs on utilizadores.hub = hubs.id where user_email=@Email order by pireps.date desc LIMIT 1";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlPilotInformations, conn);
                sqlCmd.Parameters.AddWithValue("@Email", Properties.Settings.Default.Email);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        UserID = (int)sqlCmdRes[0];
                        UserName = (string)sqlCmdRes[1];
                        UserSurname = (string)sqlCmdRes[2];
                        Rank = (string)sqlCmdRes[3];
                        Rate = (string)sqlCmdRes[4];
                        Callsign = (int)sqlCmdRes[5];
                        PilotHours = TimeSpan.FromMinutes((float)sqlCmdRes[6]);
                        if ((float)sqlCmdRes[6] > 0)
                        {
                            LastFlight = (DateTime)sqlCmdRes[7];
                        }
                        Hub = (string)sqlCmdRes[8];
                        if ((string)sqlCmdRes[9] != "")
                            Location = (string)sqlCmdRes[9];
                        else
                            Location = (string)sqlCmdRes[8];
                        Eps = (int)sqlCmdRes[10];
                        RankID = (int)sqlCmdRes[11];
                        LevelID = (int)sqlCmdRes[12];
                    }

            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @UserInfo()", crap);
            }
            finally
            {

                conn.Close();
            }
        }
    }

    public class TypeRating
    {
        public string TypeRatingName
        { get; set; }

        public DateTime Validity
        { get; set; }

        public DateTime Expiration
        { get; set; }

        public TypeRating() { }

        public static List<TypeRating> Get()
        {
            return new MySqlConnection(Login.ConnectionString).Query<TypeRating>(
                @"
SELECT
    typeratingsname.name as TypeRatingName,
    typeratings.validity as Validity,
    typeratings.expire as Expiration
from typeratings
left join utilizadores
    on typeratings.pilot = utilizadores.user_id
left join typeratingsname
    on typeratings.typerating = typeratingsname.id
where user_email=@Email",
                new
                {
                    Email = Properties.Settings.Default.Email
                }).ToList();
        }
    }

    public class Qualification
    {
        public string QualificationName
        { get; set; }

        public DateTime Validity
        { get; set; }

        public DateTime Expiration
        { get; set; }

        public Qualification() { }

        public static List<Qualification> Get()
        {
            return new MySqlConnection(Login.ConnectionString).Query<Qualification>(
                @"
SELECT
    qualificationsname.name as QualificationName,
    qualifications.validity as Validity,
    qualifications.expire as Expiration
from qualifications
left join utilizadores
    on qualifications.pilot = utilizadores.user_id
left join qualificationsname
    on qualifications.qualification = qualificationsname.id
where user_email=@Email and qualification != 0",
                new
                {
                    Email = Properties.Settings.Default.Email
                }).ToList();
        }
    }

    public class UserOverallEfficiency
    {
        public int PirepsCount
        { get; set; }

        public int PirepsCountSum
        { get; set; }

        public int Efficiency
        { get; set; }

        public UserOverallEfficiency()
        {


            string sqlPirepsCount = "SELECT COUNT(*) FROM `pireps` left join utilizadores on user_id = pireps.pilotid WHERE user_email=@Email and accepted = 1";
            string sqlPirepsCountSum = "SELECT SUM(sum) FROM `pireps` left join utilizadores on user_id = pireps.pilotid WHERE user_email=@Email and accepted = 1";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlPirepsCount, conn);
                sqlCmd.Parameters.AddWithValue("@Email", Properties.Settings.Default.Email);

                if (Convert.ToInt32(sqlCmd.ExecuteScalar()) != 0)
                    PirepsCount = Convert.ToInt32(sqlCmd.ExecuteScalar());
                else
                    PirepsCount = 0;

                MySqlCommand sqlCmd1 = new MySqlCommand(sqlPirepsCountSum, conn);
                sqlCmd1.Parameters.AddWithValue("@Email", Properties.Settings.Default.Email);
                var tytt = sqlCmd1.ExecuteScalar();

                if (PirepsCount == 0)
                    PirepsCountSum = 0;
                else
                    PirepsCountSum = Convert.ToInt32(sqlCmd1.ExecuteScalar());

                if (PirepsCountSum > 0 && PirepsCount > 0)
                    Efficiency = PirepsCountSum / PirepsCount;
                else
                    Efficiency = 0;
            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @UserOverallEfficiency()", crap);
            }
            finally
            {

                conn.Close();
            }
        }
    }

    public class UserHourAward
    {
        public int AwardID
        { get; set; }

        public int AwardMinHours
        { get; set; }

        public int AwardEps
        { get; set; }

        public UserHourAward()
        {


            string sqlAwardID = "Select hour_award from utilizadores where user_email = @Email";

            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlAwardID, conn);
                sqlCmd.Parameters.AddWithValue("@Email", Properties.Settings.Default.Email);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        AwardID = (int)sqlCmdRes[0];

                        if (AwardID == 0)
                        {
                            AwardMinHours = 25;
                            AwardEps = 25;
                        }
                        else if (AwardID == 1)
                        {
                            AwardMinHours = 50;
                            AwardEps = 50;
                        }
                        else if (AwardID == 2)
                        {
                            AwardMinHours = 75;
                            AwardEps = 75;
                        }
                        else if (AwardID == 3)
                        {
                            AwardMinHours = 100;
                            AwardEps = 100;
                        }
                    }
            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @UserHourAward()", crap);
            }
            finally
            {

                conn.Close();
            }
        }

        public static void SendAwardEps(int awardID, int awardEps)
        {
            string sqlSendAwardEps = "Update utilizadores SET hour_award = @AwardID, eps = eps + @Eps where user_email = @Email LIMIT 1";

            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlSendAwardEps, conn);
                sqlCmd.Parameters.AddWithValue("@Email", Properties.Settings.Default.Email);
                sqlCmd.Parameters.AddWithValue("@AwardID", awardID + 1);
                sqlCmd.Parameters.AddWithValue("@Eps", awardEps);

                sqlCmd.ExecuteScalar();
            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @SendAwardEps()", crap);
            }
            finally
            {

                conn.Close();
            }
        }
    }

    public class UserStatistics
    {
        public int Day
        { get; set; }

        public int NumFlights
        { get; set; }

        public UserStatistics()
        {

        }

        public static List<UserStatistics> Get()
        {
            return new MySqlConnection(Login.ConnectionString).Query<UserStatistics>(
                @"
select 
    DAY(date) as Day, COUNT(date) as NumFlights
from
    pireps 
left join
    utilizadores
on
    pireps.pilotid = utilizadores.user_id
where 
    accepted = 1 
and 
    user_email=@Email 
and 
    MONTH(date) = MONTH(CURRENT_DATE()) 
group by 
    DAY(date)",
                new
                {
                    Email = Properties.Settings.Default.Email
                }).ToList();
        }
    }

    public class AssignFlight
    {
        public static int UserID
        { get; set; }

        public int FlightID
        { get; set; }

        public string FlightCallsign
        { get; set; }

        public string UserDeparture
        { get; set; }

        public string UserArrival
        { get; set; }

        public string UserAircraft
        { get; set; }

        public string FlightBriefing
        { get; set; }

        public DateTime UserDateAssign
        { get; set; }

        public AssignFlight()
        {

        }

        public void VerifyFlightAssign()
        {
            string sqlVerifyFlightAssign = "select departure, destination, aircraft, idf, user_id, date_assigned, flights.callsign, flights.briefing from pilotassignments LEFT JOIN flights ON pilotassignments.flightid = flights.idf left join utilizadores on pilotassignments.pilot = utilizadores.user_id where user_email=@Email LIMIT 1";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlVerifyFlightAssign, conn);
                sqlCmd.Parameters.AddWithValue("@Email", Properties.Settings.Default.Email);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        UserID = (int)sqlCmdRes[4];
                        FlightID = (int)sqlCmdRes[3];
                        UserDeparture = (string)sqlCmdRes[0];
                        UserArrival = (string)sqlCmdRes[1];
                        UserAircraft = (string)sqlCmdRes[2];
                        UserDateAssign = (DateTime)sqlCmdRes[5];
                        FlightCallsign = (string)sqlCmdRes[6];
                        FlightBriefing = (string)sqlCmdRes[7];
                    }

            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @UserInfo()", crap);
            }
            finally
            {
                Dashboard.GetFlightInfosToDash(FlightID, FlightCallsign, UserDeparture, UserArrival, UserAircraft);
                conn.Close();
            }
        }

        public void RandAssignFlight(string userLocation, string aircraft, string flightTime)
        {
            string sqlRandAssignFlight = "select departure, destination, aircraft, idf, user_id  from qualifications inner join flights on qualifications.qualification = flights.qualification_need left join utilizadores on qualifications.pilot = utilizadores.user_id where user_email = @Email and aircraft=@Aircraft and flighttime<=@FlightTime and departure =@Location ORDER BY RAND() LIMIT 1";
            string sqlInsertAssign = "INSERT INTO `pilotassignments` (`flightid`, `pilot`, `date_assigned`) VALUES (@FlightID, @UserID, NOW())";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlRandAssignFlight, conn);
                sqlCmd.Parameters.AddWithValue("@Email", Properties.Settings.Default.Email);
                sqlCmd.Parameters.AddWithValue("@Aircraft", aircraft);
                sqlCmd.Parameters.AddWithValue("@FlightTime", flightTime);
                sqlCmd.Parameters.AddWithValue("@Location", userLocation);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                {
                    while (sqlCmdRes.Read())
                    {
                        UserID = (int)sqlCmdRes[4];
                        FlightID = (int)sqlCmdRes[3];
                        UserDeparture = (string)sqlCmdRes[0];
                        UserArrival = (string)sqlCmdRes[1];
                        UserAircraft = (string)sqlCmdRes[2];
                    }
                    conn.Close();
                    conn.Open();
                    MySqlCommand sqlCmd1 = new MySqlCommand(sqlInsertAssign, conn);
                    sqlCmd1.Parameters.AddWithValue("@FlightID", FlightID);
                    sqlCmd1.Parameters.AddWithValue("@UserID", UserID);

                    sqlCmd1.ExecuteScalar();
                }
            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @UserInfo()", crap);
            }
            finally
            {

                conn.Close();
            }
        }

        public static void VerifyFlightTimeOut()
        {

            string sqlDeleteAssignment = "DELETE FROM pilotassignments WHERE pilot=@UserID and NOW() >=  DATE_ADD(date_assigned, INTERVAL 30 MINUTE) LIMIT 1";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlDeleteAssignment, conn);
                sqlCmd.Parameters.AddWithValue("@UserID", UserID);

                sqlCmd.ExecuteScalar();

            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @sqlDeleteAssignment()", crap);
            }
            finally
            {

                conn.Close();
            }
        }

    }

    public class FlightLog
    {

        public int Alt
        { get; set; }

        public DateTime Time
        { get; set; }


        public static List<FlightLog> GetClimb(string idf, int idp)
        {
            return new MySqlConnection(Login.ConnectionString).Query<FlightLog>(
                @"SELECT DISTINCT ALT as Alt, time as Time FROM flightLog left join flight_phases on flightLog.phase = flight_phases.code left join pireps on flightLog.pirepid = pireps.id left join flights on pireps.flightid = flights.idf left join utilizadores on pireps.pilotid= utilizadores.user_id where flights.callsign=@Callsign and user_email = @Email and alt < 10000 and phase <= 5 order by IDL asc",
                new
                {
                    Callsign = idf,
                    Email = Properties.Settings.Default.Email
                }).ToList();
        }

        public static List<FlightLog> GetDescent(string idf, int idp)
        {
            return new MySqlConnection(Login.ConnectionString).Query<FlightLog>(
                @"SELECT DISTINCT ALT as Alt, time as Time FROM flightLog left join flight_phases on flightLog.phase = flight_phases.code left join pireps on flightLog.pirepid = pireps.id left join flights on pireps.flightid = flights.idf left join utilizadores on pireps.pilotid= utilizadores.user_id where flights.callsign=@Callsign and user_email = @Email and alt < 10000 and phase >= 5 order by IDL asc",
                new
                {
                    Callsign = idf,
                    Email = Properties.Settings.Default.Email
                }).ToList();
        }
    }

    public class LogBook
    {
        public int IDP
        { get; set; }

        public string Callsign
        { get; set; }

        public string Departure
        { get; set; }

        public string Arrival
        { get; set; }

        public string Aircraft
        { get; set; }

        public int FlightTime
        { get; set; }

        public int FtPerMin
        { get; set; }

        public int Sum
        { get; set; }

        public int Eps
        { get; set; }

        public LogBook()
        {

        }

        public static List<LogBook> Get()
        {
            return new MySqlConnection(Login.ConnectionString).Query<LogBook>(
                @"select flights.callsign as Callsign, departure as Departure, destination as Arrival, aircraft as Aircraft, pireps.flighttime as FlightTime, `ft/pm` as FtPerMin, sum as Sum, eps_granted as Eps, pireps.id as IDP from pireps left join flights on pireps.flightid = flights.idf left join utilizadores on pilotid = user_id where user_email = @Email and accepted = 1 order by id desc",
                new
                {
                    Email = Properties.Settings.Default.Email
                }).ToList();
        }



    }

    public class AllTypeRatingsByUserRank
    {
        public bool ExamTypeAssign
        { get; set; }

        public int TypeRatingID
        { get; set; }

        public string TypeRatingName
        { get; set; }

        public int Eps
        { get; set; }

        public AllTypeRatingsByUserRank()
        {

        }

        public static List<AllTypeRatingsByUserRank> Get()
        {
            return new MySqlConnection(Login.ConnectionString).Query<AllTypeRatingsByUserRank>(
                @"
SELECT
    typeratingsname.name as TypeRatingName,
    typeratingsname.eps as Eps,
    typeratingsname.id as TypeRatingID
from typeratingsname left join utilizadores on typeratingsname.rank <= utilizadores.rank where user_email=@Email",
                new
                {
                    Email = Properties.Settings.Default.Email
                }).ToList();
        }

        public void GetTypeRatingExamAssign(int typerating)
        {
            string sqlPushExamID = "Select COUNT(*) from exam_assigns left join exams on exam_assigns.exam_id = exams.exam_id where exams.type = @typerating and after_submit = 1 and (NOW() <= DATE_ADD(dateassign, INTERVAL 1 DAY) || avaiable = 1)";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlPushExamID, conn);
                sqlCmd.Parameters.AddWithValue("@typerating", typerating);

                ExamTypeAssign = Convert.ToBoolean(Convert.ToInt32(sqlCmd.ExecuteScalar()));


            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @UserInfo()", crap);
            }
            finally
            {

                conn.Close();
            }
        }
    }

    public class AllQualificationsByUserRank
    {
        public bool ExamTypeAssign
        { get; set; }

        public string QualificationName
        { get; set; }

        public int Eps
        { get; set; }

        public int QualificationID
        { get; set; }

        public AllQualificationsByUserRank()
        {

        }

        public static List<AllQualificationsByUserRank> Get()
        {
            return new MySqlConnection(Login.ConnectionString).Query<AllQualificationsByUserRank>(
                @"
SELECT
    qualificationsname.name as QualificationName,
    qualificationsname.eps as Eps,
    qualificationsname.id as QualificationID
from qualificationsname left join utilizadores on qualificationsname.rank <= utilizadores.rank where user_email=@Email",
                new
                {
                    Email = Properties.Settings.Default.Email
                }).ToList();
        }

        public void GetTypeQualificationExamAssign(int qualification)
        {
            string sqlPushExamID = "Select COUNT(*) from exam_assigns left join exams on exam_assigns.exam_id = exams.exam_id where exams.type = @qualification and after_submit = 1 and (NOW() <= DATE_ADD(dateassign, INTERVAL 1 DAY) || avaiable = 1)";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlPushExamID, conn);
                sqlCmd.Parameters.AddWithValue("@qualification", qualification);

                ExamTypeAssign = Convert.ToBoolean(Convert.ToInt32(sqlCmd.ExecuteScalar()));


            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @UserInfo()", crap);
            }
            finally
            {

                conn.Close();
            }
        }
    }

    public class UserNextRank
    {
        public bool ExamTypeAssign
        { get; set; }

        public int NextRankID
        { get; set; }

        public string NextRank
        { get; set; }

        public int CountType
        { get; set; }

        public int CountQual
        { get; set; }

        public int MinType
        { get; set; }

        public int MinQual
        { get; set; }

        public UserNextRank()
        {

        }

        public static List<UserNextRank> Get()
        {
            return new MySqlConnection(Login.ConnectionString).Query<UserNextRank>(
                @"select COUNT(DISTINCT(qualification)) as CountQual, COUNT(typerating) as CountType, ranks.rank as NextRank, ranks.minqualifications as MinQual, ranks.mintyperatings as MinType, ranks.rankid as NextRankID from utilizadores left join typeratings on typeratings.pilot = utilizadores.user_id left join qualifications on qualifications.pilot = utilizadores.user_id LEFT JOIN ratings ON utilizadores.rate = ratings.id LEFT JOIN ranks ON utilizadores.rank=ranks.rankid - 1 where user_email = @Email and qualification != 0",
                new
                {
                    Email = Properties.Settings.Default.Email
                }).ToList();
        }

        public void GetTypePromotionExamAssign(int promotion)
        {
            string sqlPushExamID = "Select COUNT(*) from exam_assigns left join exams on exam_assigns.exam_id = exams.exam_id where exams.type = @promotion and after_submit = 1 and (NOW() <= DATE_ADD(dateassign, INTERVAL 1 DAY) || avaiable = 1)";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlPushExamID, conn);
                sqlCmd.Parameters.AddWithValue("@promotion", promotion);

                ExamTypeAssign = Convert.ToBoolean(Convert.ToInt32(sqlCmd.ExecuteScalar()));


            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @UserInfo()", crap);
            }
            finally
            {

                conn.Close();
            }
        }
    }

    public class TakeExamForPilot
    {
        public static int ExamID
        { get; set; }

        public TakeExamForPilot()
        {

        }

        public static void TakeExamTypeRating(int typeID, int userID)
        {
            

            string sqlPushExamID = "Select exam_id from exams where type = @typeID";
            string sqlTakeExamForPilot = "INSERT INTO `exam_assigns` (`idpilot`, `exam_id`, dateassign) VALUES (@UserID, @ExamID, NOW())";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlPushExamID, conn);
                sqlCmd.Parameters.AddWithValue("@typeID", typeID);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        ExamID = (int)sqlCmdRes[0];
                    }

                conn.Close();
                conn.Open();

                MySqlCommand sqlCmd1 = new MySqlCommand(sqlTakeExamForPilot, conn);
                sqlCmd1.Parameters.AddWithValue("@ExamID", ExamID);
                sqlCmd1.Parameters.AddWithValue("@UserID", userID);

                sqlCmd1.ExecuteScalar();
            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @UserInfo()", crap);
            }
            finally
            {

                conn.Close();
            }
        }

        public static void TakeExamQualification(int qualID, int userID)
        {


            string sqlPushExamID = "Select exam_id from exams where qual = @qualID";
            string sqlTakeExamForPilot = "INSERT INTO `exam_assigns` (`idpilot`, `exam_id`, dateassign) VALUES (@UserID, @ExamID, NOW())";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlPushExamID, conn);
                sqlCmd.Parameters.AddWithValue("@qualID", qualID);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        ExamID = (int)sqlCmdRes[0];
                    }

                conn.Close();
                conn.Open();

                MySqlCommand sqlCmd1 = new MySqlCommand(sqlTakeExamForPilot, conn);
                sqlCmd1.Parameters.AddWithValue("@ExamID", ExamID);
                sqlCmd1.Parameters.AddWithValue("@UserID", userID);

                sqlCmd1.ExecuteScalar();
            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @UserInfo()", crap);
            }
            finally
            {

                conn.Close();
            }
        }

        public static void TakeExamPromotion(int examID, int userID)
        {


            string sqlPushExamID = "Select exam_id from exams where exam_id = @examID";
            string sqlTakeExamForPilot = "INSERT INTO `exam_assigns` (`idpilot`, `exam_id`, typequalprom, dateassign) VALUES (@UserID, @ExamID, NOW())";
            MySqlConnection conn = new MySqlConnection(Login.ConnectionString);

            try
            {
                conn.Open();

                MySqlCommand sqlCmd = new MySqlCommand(sqlPushExamID, conn);
                sqlCmd.Parameters.AddWithValue("@examID", examID);

                MySqlDataReader sqlCmdRes = sqlCmd.ExecuteReader();
                if (sqlCmdRes.HasRows)
                    while (sqlCmdRes.Read())
                    {
                        ExamID = (int)sqlCmdRes[0];
                    }

                conn.Close();
                conn.Open();

                MySqlCommand sqlCmd1 = new MySqlCommand(sqlTakeExamForPilot, conn);
                sqlCmd1.Parameters.AddWithValue("@ExamID", ExamID);
                sqlCmd1.Parameters.AddWithValue("@UserID", userID);

                sqlCmd1.ExecuteScalar();
            }
            catch (Exception crap)
            {
                throw new ApplicationException("Failed to load exam @UserInfo()", crap);
            }
            finally
            {

                conn.Close();
            }
        }


    }

    public class OnLiveMap
    {

        public double LAT
        { get; set; }

        public double LON
        { get; set; }

        public double LiveLAT
        { get; set; }

        public double LiveLON
        { get; set; }

        public string LiveCallsign
        { get; set; }

        public int PirepID
        { get; set; }

        public OnLiveMap()
        {

        }

        public static List<OnLiveMap> Get(int tag)
        {
            return (List<OnLiveMap>)new MySqlConnection(Login.ConnectionString).Query<OnLiveMap>(
                @"select flightLog.LAT as LAT, flightLog.LON as LON, flights.callsign as LiveCallsign, flightLog.pirepid as PirepID, flight_on_live.LAT as LiveLAT, flight_on_live.LON as LiveLON from flightLog left join pireps on flightLog.pirepid = pireps.id left join flight_on_live on pireps.id = flight_on_live.pirepid left join flights on pireps.flightid = flights.idf where NOW() < date_add(flight_on_live.last_report, interval 15 minute) and flightLog.pirepid = @MarkerTag",
                new
                {
                    MarkerTag = tag
                });
        }

        public static List<OnLiveMap> GetAircraft()
        {
            return (List<OnLiveMap>)new MySqlConnection(Login.ConnectionString).Query<OnLiveMap>(
                @"select flight_on_live.LAT as LiveLAT, flight_on_live.LON as LiveLON, flight_on_live.pirepid as PirepID from flight_on_live where NOW() < date_add(flight_on_live.last_report, interval 15 minute)");
        }
    }
}

