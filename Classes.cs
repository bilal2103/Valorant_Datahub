using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valorant_Datahub
{
    public class MapInformation
    {
        public string map_name, suited_weapon, description, location;
        public int spikesites;
        public MapInformation() { }
        public MapInformation(string a, int b, string d, string e, string f)
        {
            map_name = a;
            spikesites = b;
            suited_weapon = d;
            location = e;
            description = f;
        }
    }
    public class AgentInformation
    {
        public string agent_name, tier, category, suited_weapon, ultimate, voiced_by, Description;
        public float pick_pct, win_pct;
        public AgentInformation() { }
        public AgentInformation(string agent_name,float pick_pct, float win_pct, string tier, 
            string category,string suited_weapon,string ultimate, string Description,string voiced_by)
        {
            this.agent_name= agent_name;
            this.tier= tier;
            this.category   = category;
            this.suited_weapon= suited_weapon;
            this.ultimate=ultimate;
            this.voiced_by= voiced_by;
            this.Description = Description;
            this.pick_pct= pick_pct;
            this.win_pct= win_pct;
        }
    }
    public static class vars
    {
        public static string connection = "Data Source=AIMANANANANA;Initial Catalog=Valo_Data;Integrated Security=True";
        public static string image_path = "C:\\Users\\Dell\\OneDrive\\Desktop\\Valorant_Datahub\\Images\\";
    }
    public class LocationsInformation
    {
        public int location_id;
        public string country, state, city;
        public LocationsInformation() { }
        public LocationsInformation(int location_id, string country, string state, string city)
        {
            this.location_id = location_id;
            this.country = country;
            this.state = state;
            this.city = city;
        }
    }
    public class TeamsInformation
    {
        public int team_id,matches_played,matches_won,tournaments_played,tournaments_won;
        public string team_name;
        public TeamsInformation() { }
        public TeamsInformation(int team_id, int matches_played, int matches_won, int tournaments_played, int tournaments_won, string team_name)
        {
            this.team_id = team_id;
            this.matches_played = matches_played;
            this.matches_won = matches_won;
            this.tournaments_played = tournaments_played;
            this.tournaments_won = tournaments_won;
            this.team_name = team_name;
        }
    }
    public class TournamentsInformation
    {
        public int tournament_id, prize_pool, location_id;
        public string tournament_title;
        public TournamentsInformation() { }
        public TournamentsInformation(int tournament_id, int prize_pool, int location_id, string tournament_title)
        {
            this.tournament_id = tournament_id;
            this.prize_pool = prize_pool;
            this.location_id = location_id;
            this.tournament_title = tournament_title;
        }
    }
    public class MatchesInformation
    {
        public int match_id,team1_id,team2_id,winner_id;
        public string map_name;
        public MatchesInformation() { }
        public MatchesInformation(int match_id, int team1_id, int team2_id, int winner_id, string map_name)
        {
            this.match_id = match_id;
            this.team1_id = team1_id;
            this.team2_id = team2_id;
            this.winner_id = winner_id;
            this.map_name = map_name;
        }
        public MatchesInformation(int match_id)
        {
            this.match_id=match_id;
        }
    }
    public class WeaponsInformation
    {
        public string weapon_name, weapon_type, fire_mode;
        public int capacity, max_range;
        public float damage, fire_rate, reload_speed;
        public WeaponsInformation() { }
        public WeaponsInformation(string weapon_name, string weapon_type, string fire_mode, int capacity, int max_range, float damage, float fire_rate, float reload_speed)
        {
            this.weapon_name = weapon_name;
            this.weapon_type = weapon_type;
            this.fire_mode = fire_mode;
            this.capacity = capacity;
            this.max_range = max_range;
            this.damage = damage;
            this.fire_rate = fire_rate;
            this.reload_speed = reload_speed;
        }
    }
    public static class Colors
    {
        public static string fore_color = "#000000";
        public static string back_color = "#E2D1F9";
        public static string btn_color = "#7092be";
        public static string btn_fore_color = "#FFFFFF";
        public static string tb_backcolor = "#FFFFFF";
        public static string tb_forecolor = "#000000";
    }

}
