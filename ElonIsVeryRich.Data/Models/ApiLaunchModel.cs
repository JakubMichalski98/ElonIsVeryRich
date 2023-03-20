using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElonIsVeryRich.Data.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Core
    {
        [JsonProperty("core_serial")]
        public string CoreSerial { get; set; }

        [JsonProperty("flight")]
        public int? Flight { get; set; }

        [JsonProperty("block")]
        public int? Block { get; set; }

        [JsonProperty("gridfins")]
        public bool? Gridfins { get; set; }

        [JsonProperty("legs")]
        public bool? Legs { get; set; }

        [JsonProperty("reused")]
        public bool? Reused { get; set; }

        [JsonProperty("land_success")]
        public bool? LandSuccess { get; set; }

        [JsonProperty("landing_intent")]
        public bool? LandingIntent { get; set; }

        [JsonProperty("landing_type")]
        public string LandingType { get; set; }

        [JsonProperty("landing_vehicle")]
        public string LandingVehicle { get; set; }
    }

    public class Fairings
    {
        [JsonProperty("reused")]
        public bool? Reused { get; set; }

        [JsonProperty("recovery_attempt")]
        public bool? RecoveryAttempt { get; set; }

        [JsonProperty("recovered")]
        public bool? Recovered { get; set; }

        [JsonProperty("ship")]
        public string Ship { get; set; }
    }

    public class FirstStage
    {
        [JsonProperty("cores")]
        public List<Core> Cores { get; set; }
    }

    public class LaunchFailureDetails
    {
        [JsonProperty("time")]
        public int? Time { get; set; }

        [JsonProperty("altitude")]
        public int? Altitude { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }
    }

    public class LaunchSite
    {
        [JsonProperty("site_id")]
        public string SiteId { get; set; }

        [JsonProperty("site_name")]
        public string SiteName { get; set; }

        [JsonProperty("site_name_long")]
        public string SiteNameLong { get; set; }
    }

    public class Links
    {
        [JsonProperty("mission_patch")]
        public string MissionPatch { get; set; }

        [JsonProperty("mission_patch_small")]
        public string MissionPatchSmall { get; set; }

        [JsonProperty("reddit_campaign")]
        public string RedditCampaign { get; set; }

        [JsonProperty("reddit_launch")]
        public string RedditLaunch { get; set; }

        [JsonProperty("reddit_recovery")]
        public string RedditRecovery { get; set; }

        [JsonProperty("reddit_media")]
        public string RedditMedia { get; set; }

        [JsonProperty("presskit")]
        public string Presskit { get; set; }

        [JsonProperty("article_link")]
        public string ArticleLink { get; set; }

        [JsonProperty("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonProperty("video_link")]
        public string VideoLink { get; set; }

        [JsonProperty("youtube_id")]
        public string YoutubeId { get; set; }

        [JsonProperty("flickr_images")]
        public List<string> FlickrImages { get; set; }
    }

    public class OrbitParams
    {
        [JsonProperty("reference_system")]
        public string ReferenceSystem { get; set; }

        [JsonProperty("regime")]
        public string Regime { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("semi_major_axis_km")]
        public double? SemiMajorAxisKm { get; set; }

        [JsonProperty("eccentricity")]
        public double? Eccentricity { get; set; }

        [JsonProperty("periapsis_km")]
        public double? PeriapsisKm { get; set; }

        [JsonProperty("apoapsis_km")]
        public double? ApoapsisKm { get; set; }

        [JsonProperty("inclination_deg")]
        public double? InclinationDeg { get; set; }

        [JsonProperty("period_min")]
        public double? PeriodMin { get; set; }

        [JsonProperty("lifespan_years")]
        public double? LifespanYears { get; set; }

        [JsonProperty("epoch")]
        public DateTime? Epoch { get; set; }

        [JsonProperty("mean_motion")]
        public double? MeanMotion { get; set; }

        [JsonProperty("raan")]
        public double? Raan { get; set; }

        [JsonProperty("arg_of_pericenter")]
        public double? ArgOfPericenter { get; set; }

        [JsonProperty("mean_anomaly")]
        public double? MeanAnomaly { get; set; }
    }

    public class Payload
    {
        [JsonProperty("payload_id")]
        public string PayloadId { get; set; }

        [JsonProperty("norad_id")]
        public List<int?> NoradId { get; set; }

        [JsonProperty("reused")]
        public bool? Reused { get; set; }

        [JsonProperty("customers")]
        public List<string> Customers { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        [JsonProperty("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonProperty("payload_type")]
        public string PayloadType { get; set; }

        [JsonProperty("payload_mass_kg")]
        public double? PayloadMassKg { get; set; }

        [JsonProperty("payload_mass_lbs")]
        public double? PayloadMassLbs { get; set; }

        [JsonProperty("orbit")]
        public string Orbit { get; set; }

        [JsonProperty("orbit_params")]
        public OrbitParams OrbitParams { get; set; }

        [JsonProperty("cap_serial")]
        public string CapSerial { get; set; }

        [JsonProperty("mass_returned_kg")]
        public double? MassReturnedKg { get; set; }

        [JsonProperty("mass_returned_lbs")]
        public double? MassReturnedLbs { get; set; }

        [JsonProperty("flight_time_sec")]
        public int? FlightTimeSec { get; set; }

        [JsonProperty("cargo_manifest")]
        public string CargoManifest { get; set; }
    }

    public class Rocket
    {
        [JsonProperty("rocket_id")]
        public string RocketId { get; set; }

        [JsonProperty("rocket_name")]
        public string RocketName { get; set; }

        [JsonProperty("rocket_type")]
        public string RocketType { get; set; }

        [JsonProperty("first_stage")]
        public FirstStage FirstStage { get; set; }

        [JsonProperty("second_stage")]
        public SecondStage SecondStage { get; set; }

        [JsonProperty("fairings")]
        public Fairings Fairings { get; set; }
    }

    public class LaunchRoot
    {
        [JsonProperty("flight_number")]
        public int? FlightNumber { get; set; }

        [JsonProperty("mission_name")]
        public string MissionName { get; set; }

        [JsonProperty("mission_id")]
        public List<string> MissionId { get; set; }

        [JsonProperty("upcoming")]
        public bool? Upcoming { get; set; }

        [JsonProperty("launch_year")]
        public string LaunchYear { get; set; }

        [JsonProperty("launch_date_unix")]
        public int? LaunchDateUnix { get; set; }

        [JsonProperty("launch_date_utc")]
        public DateTime? LaunchDateUtc { get; set; }

        [JsonProperty("launch_date_local")]
        public DateTime? LaunchDateLocal { get; set; }

        [JsonProperty("is_tentative")]
        public bool? IsTentative { get; set; }

        [JsonProperty("tentative_max_precision")]
        public string TentativeMaxPrecision { get; set; }

        [JsonProperty("tbd")]
        public bool? Tbd { get; set; }

        [JsonProperty("launch_window")]
        public int? LaunchWindow { get; set; }

        [JsonProperty("rocket")]
        public Rocket Rocket { get; set; }

        [JsonProperty("ships")]
        public List<string> Ships { get; set; }

        [JsonProperty("telemetry")]
        public Telemetry Telemetry { get; set; }

        [JsonProperty("launch_site")]
        public LaunchSite LaunchSite { get; set; }

        [JsonProperty("launch_success")]
        public bool? LaunchSuccess { get; set; }

        [JsonProperty("launch_failure_details")]
        public LaunchFailureDetails LaunchFailureDetails { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }

        [JsonProperty("static_fire_date_utc")]
        public DateTime? StaticFireDateUtc { get; set; }

        [JsonProperty("static_fire_date_unix")]
        public int? StaticFireDateUnix { get; set; }

        [JsonProperty("timeline")]
        public Timeline Timeline { get; set; }
    }

    public class SecondStage
    {
        [JsonProperty("block")]
        public int? Block { get; set; }

        [JsonProperty("payloads")]
        public List<Payload> Payloads { get; set; }
    }

    public class Telemetry
    {
        [JsonProperty("flight_club")]
        public string FlightClub { get; set; }
    }

    public class Timeline
    {
        [JsonProperty("webcast_liftoff")]
        public int? WebcastLiftoff { get; set; }

        [JsonProperty("go_for_prop_loading")]
        public int? GoForPropLoading { get; set; }

        [JsonProperty("rp1_loading")]
        public int? Rp1Loading { get; set; }

        [JsonProperty("stage1_lox_loading")]
        public int? Stage1LoxLoading { get; set; }

        [JsonProperty("stage2_lox_loading")]
        public int? Stage2LoxLoading { get; set; }

        [JsonProperty("engine_chill")]
        public int? EngineChill { get; set; }

        [JsonProperty("prelaunch_checks")]
        public int? PrelaunchChecks { get; set; }

        [JsonProperty("propellant_pressurization")]
        public int? PropellantPressurization { get; set; }

        [JsonProperty("go_for_launch")]
        public int? GoForLaunch { get; set; }

        [JsonProperty("ignition")]
        public int? Ignition { get; set; }

        [JsonProperty("liftoff")]
        public int? Liftoff { get; set; }

        [JsonProperty("maxq")]
        public int? Maxq { get; set; }

        [JsonProperty("meco")]
        public int? Meco { get; set; }

        [JsonProperty("stage_sep")]
        public int? StageSep { get; set; }

        [JsonProperty("second_stage_ignition")]
        public int? SecondStageIgnition { get; set; }

        [JsonProperty("seco-1")]
        public int? Seco1 { get; set; }

        [JsonProperty("dragon_separation")]
        public int? DragonSeparation { get; set; }

        [JsonProperty("dragon_solar_deploy")]
        public int? DragonSolarDeploy { get; set; }

        [JsonProperty("dragon_bay_door_deploy")]
        public int? DragonBayDoorDeploy { get; set; }

        [JsonProperty("fairing_deploy")]
        public int? FairingDeploy { get; set; }

        [JsonProperty("payload_deploy")]
        public int? PayloadDeploy { get; set; }

        [JsonProperty("second_stage_restart")]
        public int? SecondStageRestart { get; set; }

        [JsonProperty("seco-2")]
        public int? Seco2 { get; set; }

        [JsonProperty("webcast_launch")]
        public int? WebcastLaunch { get; set; }

        [JsonProperty("payload_deploy_1")]
        public int? PayloadDeploy1 { get; set; }

        [JsonProperty("payload_deploy_2")]
        public int? PayloadDeploy2 { get; set; }

        [JsonProperty("first_stage_boostback_burn")]
        public int? FirstStageBoostbackBurn { get; set; }

        [JsonProperty("first_stage_entry_burn")]
        public int? FirstStageEntryBurn { get; set; }

        [JsonProperty("first_stage_landing")]
        public int? FirstStageLanding { get; set; }

        [JsonProperty("beco")]
        public int? Beco { get; set; }

        [JsonProperty("side_core_sep")]
        public int? SideCoreSep { get; set; }

        [JsonProperty("side_core_boostback")]
        public int? SideCoreBoostback { get; set; }

        [JsonProperty("center_stage_sep")]
        public int? CenterStageSep { get; set; }

        [JsonProperty("center_core_boostback")]
        public int? CenterCoreBoostback { get; set; }

        [JsonProperty("side_core_entry_burn")]
        public int? SideCoreEntryBurn { get; set; }

        [JsonProperty("center_core_entry_burn")]
        public int? CenterCoreEntryBurn { get; set; }

        [JsonProperty("side_core_landing")]
        public int? SideCoreLanding { get; set; }

        [JsonProperty("center_core_landing")]
        public int? CenterCoreLanding { get; set; }
    }





}
