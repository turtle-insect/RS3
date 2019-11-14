using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Collections.ObjectModel;

namespace RS3
{
	// http://json2csharp.com/

	[DataContract]
	class OriginalJson
	{
		[DataMember]
		public List<string> m_playerWork { get; set; }
		[DataMember]
		public string m_partyWork { get; set; }
	}

	[DataContract]
	public class PlayerWork
	{
		[DataMember]
		public int _data_version { get; set; }
		[DataMember]
		public int _number { get; set; }
		[DataMember]
		public string _name { get; set; }
		[DataMember]
		public int _looks { get; set; }
		[DataMember]
		public int _class { get; set; }
		[DataMember]
		public int _id { get; set; }
		[DataMember]
		public int _speciality { get; set; }
		[DataMember]
		public int _status0 { get; set; }
		[DataMember]
		public int _status1 { get; set; }
		[DataMember]
		public int _status2 { get; set; }
		[DataMember]
		public int _status3 { get; set; }
		[DataMember]
		public int _status4 { get; set; }
		[DataMember]
		public int _status5 { get; set; }
		[DataMember]
		public int _status6 { get; set; }
		[DataMember]
		public int _bad_status0 { get; set; }
		[DataMember]
		public int _bad_status1 { get; set; }
		[DataMember]
		public int _timer0 { get; set; }
		[DataMember]
		public int _timer1 { get; set; }
		[DataMember]
		public int _timer2 { get; set; }
		[DataMember]
		public int _timer3 { get; set; }
		[DataMember]
		public int _timer4 { get; set; }
		[DataMember]
		public int _timer5 { get; set; }
		[DataMember]
		public int _hp { get; set; }
		[DataMember]
		public int _hp_max { get; set; }
		[DataMember]
		public int _lp { get; set; }
		[DataMember]
		public int _lp_max { get; set; }
		[DataMember]
		public int _waza_p { get; set; }
		[DataMember]
		public int _waza_p_max { get; set; }
		[DataMember]
		public int _jyutu_p { get; set; }
		[DataMember]
		public int _jyutu_p_max { get; set; }
		[DataMember]
		public int _strength { get; set; }
		[DataMember]
		public int _dexterity { get; set; }
		[DataMember]
		public int _agility { get; set; }
		[DataMember]
		public int _endure { get; set; }
		[DataMember]
		public int _force { get; set; }
		[DataMember]
		public int _will { get; set; }
		[DataMember]
		public int _fascination { get; set; }
		[DataMember]
		public int _slash { get; set; }
		[DataMember]
		public int _beat { get; set; }
		[DataMember]
		public int _thrust { get; set; }
		[DataMember]
		public int _shoot { get; set; }
		[DataMember]
		public int _wrestle { get; set; }
		[DataMember]
		public int _souryu { get; set; }
		[DataMember]
		public int _syuchoh { get; set; }
		[DataMember]
		public int _byakko { get; set; }
		[DataMember]
		public int _genbu { get; set; }
		[DataMember]
		public int _sun { get; set; }
		[DataMember]
		public int _moon { get; set; }
		[DataMember]
		public int _command_flg { get; set; }
		[DataMember]
		public int _general_lv { get; set; }
		[DataMember]
		public int _skill_grade { get; set; }
		[DataMember]
		public int _waza_grade { get; set; }
		[DataMember]
		public int _action_modify { get; set; }
		[DataMember]
		public int _waza_getting { get; set; }
		[DataMember]
		public ObservableCollection<int> _waza_equip { get; set; }
		[DataMember]
		public List<int> _jyutu_equip { get; set; }
		[DataMember]
		public int _weapon0 { get; set; }
		[DataMember]
		public int _weapon1 { get; set; }
		[DataMember]
		public int _weapon2 { get; set; }
		[DataMember]
		public int _weapon3 { get; set; }
		[DataMember]
		public int _armor0 { get; set; }
		[DataMember]
		public int _armor1 { get; set; }
		[DataMember]
		public int _armor2 { get; set; }
		[DataMember]
		public int _armor3 { get; set; }
		[DataMember]
		public int _weapon_lock { get; set; }
		[DataMember]
		public int _form_own { get; set; }
		[DataMember]
		public int _destiny_star { get; set; }
		[DataMember]
		public int _guardian { get; set; }
		[DataMember]
		public int _strong_point { get; set; }
		[DataMember]
		public int _fix_weapon { get; set; }
		[DataMember]
		public int _fix_armor { get; set; }
		[DataMember]
		public int _fix_magic { get; set; }
		[DataMember]
		public int _equip_kind_w { get; set; }
		[DataMember]
		public int _equip_kind_j { get; set; }
		[DataMember]
		public List<int> _prop_def_base { get; set; }
		[DataMember]
		public List<int> _prop_defence { get; set; }
		[DataMember]
		public int _cond_defence { get; set; }
		[DataMember]
		public int _parry_success { get; set; }
		[DataMember]
		public int _parry_prop { get; set; }
		[DataMember]
		public int _def_addition { get; set; }
		[DataMember]
		public int _strength_b { get; set; }
		[DataMember]
		public int _dexterity_b { get; set; }
		[DataMember]
		public int _agility_b { get; set; }
		[DataMember]
		public int _endure_b { get; set; }
		[DataMember]
		public int _force_b { get; set; }
		[DataMember]
		public int _will_b { get; set; }
		[DataMember]
		public int _fascination_b { get; set; }
		[DataMember]
		public int _weapon0_b { get; set; }
		[DataMember]
		public int _weapon1_b { get; set; }
		[DataMember]
		public int _weapon2_b { get; set; }
		[DataMember]
		public int _weapon3_b { get; set; }
		[DataMember]
		public List<int> _prop_b { get; set; }
		[DataMember]
		public int _g_counter { get; set; }
		[DataMember]
		public int _char_type { get; set; }
		[DataMember]
		public int _grade { get; set; }
		[DataMember]
		public int _hirameki_type_id { get; set; }
		[DataMember]
		public int _use_point_reduce_id { get; set; }
		[DataMember]
		public int _fixed_spell_id { get; set; }
		[DataMember]
		public int _reserve { get; set; }
		[DataMember]
		public int _selectTargetNum { get; set; }
		[DataMember]
		public int _selectSkillId { get; set; }
		[DataMember]
		public int _cursorLine { get; set; }
		[DataMember]
		public int _cursorPage { get; set; }
		[DataMember]
		public int _cursor_def_page { get; set; }
		[DataMember]
		public int _menuScroll { get; set; }
		[DataMember]
		public List<int> _all_weapon_b { get; set; }
		[DataMember]
		public int _pre_pc_counter { get; set; }
		[DataMember]
		public bool _once_join { get; set; }
	}

	[DataContract]
	public class PartyWork
	{
		[DataMember]
		public bool _dash_flag { get; set; }
		[DataMember]
		public bool _battle_mess_defa_speed_flag { get; set; }
		[DataMember]
		public bool _indicator_flag { get; set; }
		[DataMember]
		public bool _D_button_Left_flag { get; set; }
		[DataMember]
		public List<int> _bank7e { get; set; }
		[DataMember]
		public List<int> _spare { get; set; }
		[DataMember]
		public int _data_version { get; set; }
		[DataMember]
		public string _hero_name { get; set; }
		[DataMember]
		public int _hero_star { get; set; }
		[DataMember]
		public int _hero_favorite { get; set; }
		[DataMember]
		public int _play_time { get; set; }
		[DataMember]
		public string _hero_map_name { get; set; }
		[DataMember]
		public int _hero_map { get; set; }
		[DataMember]
		public int _hero_area { get; set; }
		[DataMember]
		public int _hero_map_id { get; set; }
		[DataMember]
		public int _hero_prev_map_id { get; set; }
		[DataMember]
		public int _hero_pos_x { get; set; }
		[DataMember]
		public int _hero_pos_y { get; set; }
		[DataMember]
		public int _hero_prev_pos_x { get; set; }
		[DataMember]
		public int _hero_prev_pos_y { get; set; }
		[DataMember]
		public int _hero_dir { get; set; }
		[DataMember]
		public List<int> _viecle_pos { get; set; }
		[DataMember]
		public int _party_number { get; set; }
		[DataMember]
		public int _party_money { get; set; }
		[DataMember]
		public int _savings { get; set; }
		[DataMember]
		public int _form_flag { get; set; }
		[DataMember]
		public int _formation { get; set; }
		[DataMember]
		public List<int> _tsuikajun { get; set; }
		[DataMember]
		public List<int> _narabi { get; set; }
		[DataMember]
		public int _battle_mode { get; set; }
		[DataMember]
		public List<int> _party_item_syurui { get; set; }
		[DataMember]
		public List<int> _party_item_kazu { get; set; }
		[DataMember]
		public List<int> _stock_item { get; set; }
		[DataMember]
		public List<int> _kat_stock_item { get; set; }
		[DataMember]
		public List<int> _flag_tbl { get; set; }
		[DataMember]
		public List<int> _box_flag_tbl { get; set; }
		[DataMember]
		public List<bool> _waza_flag { get; set; }
		[DataMember]
		public List<bool> _tactics_flag { get; set; }
		[DataMember]
		public int _pc_counter { get; set; }
		[DataMember]
		public List<int> _mon_counter { get; set; }
		[DataMember]
		public int _spell_combo { get; set; }
		[DataMember]
		public int _mess_speed { get; set; }
		[DataMember]
		public int _sound { get; set; }
		[DataMember]
		public string _field_music { get; set; }
		[DataMember]
		public string _current_music { get; set; }
		[DataMember]
		public List<int> _ret_jump { get; set; }
		[DataMember]
		public int _combat_no { get; set; }
		[DataMember]
		public int _battle_count { get; set; }
		[DataMember]
		public int _trade_count { get; set; }
		[DataMember]
		public int _scenario_count { get; set; }
		[DataMember]
		public int _combat_count { get; set; }
		[DataMember]
		public List<int> _battle_cursors { get; set; }
		[DataMember]
		public int _menu_cursors { get; set; }
		[DataMember]
		public List<int> _party_reserve { get; set; }
		[DataMember]
		public int _tatiana_gimei_id { get; set; }
		[DataMember]
		public List<bool> _record_flag { get; set; }
		[DataMember]
		public List<bool> _record_new_flag { get; set; }
		[DataMember]
		public List<int> _record_narabi { get; set; }
		[DataMember]
		public int _commander_cursor_line { get; set; }
		[DataMember]
		public int _commander_cursor_page { get; set; }
		[DataMember]
		public int _commander_cursor_scroll { get; set; }
		[DataMember]
		public int _commander_tactics_cursor_line { get; set; }
		[DataMember]
		public int _commander_tactics_cursor_scroll { get; set; }
		[DataMember]
		public int _commander_formation_cursor_line { get; set; }
		[DataMember]
		public int _commander_formation_cursor_scroll { get; set; }
		[DataMember]
		public bool _silver_charl { get; set; }
		[DataMember]
		public bool _harman_to_brack { get; set; }
		[DataMember]
		public int _tbox_flag { get; set; }
		[DataMember]
		public int _tbox_gid { get; set; }
		[DataMember]
		public int _tbox_tflag { get; set; }
		[DataMember]
		public int _tbox_val { get; set; }
		[DataMember]
		public int _tbox_x { get; set; }
		[DataMember]
		public int _tbox_y { get; set; }
		[DataMember]
		public List<bool> _bukken_flag { get; set; }
		[DataMember]
		public List<bool> _tr_group { get; set; }
		[DataMember]
		public List<bool> _tr_nego { get; set; }
		[DataMember]
		public List<bool> _tr_network { get; set; }
		[DataMember]
		public int _tr_pop { get; set; }
		[DataMember]
		public List<int> _t_lv { get; set; }
		[DataMember]
		public List<int> _tr_complv { get; set; }
		[DataMember]
		public int _tr_money { get; set; }
		[DataMember]
		public int _tr_timeplus { get; set; }
		[DataMember]
		public int _worldplus { get; set; }
		[DataMember]
		public int _tr_kyouju { get; set; }
		[DataMember]
		public List<int> _tr_cnf { get; set; }
		[DataMember]
		public int _tr_debt { get; set; }
		[DataMember]
		public List<bool> _tr_flag { get; set; }
		[DataMember]
		public List<int> _bukken_souba { get; set; }
		[DataMember]
		public List<int> _bukken_sisan { get; set; }
		[DataMember]
		public List<int> _town_trust { get; set; }
		[DataMember]
		public List<int> _tr_doumei { get; set; }
		[DataMember]
		public List<bool> _tr_doumei_once { get; set; }
		[DataMember]
		public List<int> _tr_abyss { get; set; }
		[DataMember]
		public int _tr_economy { get; set; }
		[DataMember]
		public int _tr_boe_count { get; set; }
		[DataMember]
		public int _tr_rec_count { get; set; }
		[DataMember]
		public int _tr_trend_1 { get; set; }
		[DataMember]
		public int _tr_trend_2 { get; set; }
		[DataMember]
		public List<int> _combat_works { get; set; }
		[DataMember]
		public List<int> _combat_unitflag { get; set; }
		[DataMember]
		public List<bool> _combat_opeflag { get; set; }
		[DataMember]
		public List<bool> _combat_formflag { get; set; }
		[DataMember]
		public int _combat_form1 { get; set; }
		[DataMember]
		public int _combat_form2 { get; set; }
		[DataMember]
		public List<int> _combat_ope1 { get; set; }
		[DataMember]
		public List<int> _combat_ope2 { get; set; }
		[DataMember]
		public int _map_npc_count { get; set; }
		[DataMember]
		public List<int> _npc_cell_x { get; set; }
		[DataMember]
		public List<int> _npc_cell_y { get; set; }
		[DataMember]
		public List<int> _npc_x { get; set; }
		[DataMember]
		public List<int> _npc_y { get; set; }
		[DataMember]
		public List<int> _npc_dir { get; set; }
		[DataMember]
		public List<bool> _npc_hide { get; set; }
		[DataMember]
		public List<int> _npc_obj_no { get; set; }
		[DataMember]
		public List<int> _npc_event { get; set; }
		[DataMember]
		public List<int> _npc_move_ptn { get; set; }
		[DataMember]
		public List<int> _npc_actionVM_counter { get; set; }
		[DataMember]
		public List<int> _npc_floor { get; set; }
	}
}
