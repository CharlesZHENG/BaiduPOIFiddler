﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BaiduBusFiddler
{

    public class SearchExt
    {

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("wd")]
        public string Wd { get; set; }
    }

    public class PlaceInfo
    {

        [JsonProperty("d_activity_gwj_section")]
        public string DActivityGwjSection { get; set; }

        [JsonProperty("d_brand_id_section")]
        public string DBrandIdSection { get; set; }

        [JsonProperty("d_business_id")]
        public string DBusinessId { get; set; }

        [JsonProperty("d_business_type")]
        public string DBusinessType { get; set; }

        [JsonProperty("d_cater_book_pc_section")]
        public string DCaterBookPcSection { get; set; }

        [JsonProperty("d_cater_book_wap_section")]
        public string DCaterBookWapSection { get; set; }

        [JsonProperty("d_cater_rating_section")]
        public string DCaterRatingSection { get; set; }

        [JsonProperty("d_data_type")]
        public string DDataType { get; set; }

        [JsonProperty("d_discount2_section")]
        public string DDiscount2Section { get; set; }

        [JsonProperty("d_discount_section")]
        public string DDiscountSection { get; set; }

        [JsonProperty("d_discount_tm2_section")]
        public string DDiscountTm2Section { get; set; }

        [JsonProperty("d_discount_tm_section")]
        public string DDiscountTmSection { get; set; }

        [JsonProperty("d_dist")]
        public string DDist { get; set; }

        [JsonProperty("d_filt_type_section")]
        public string DFiltTypeSection { get; set; }

        [JsonProperty("d_free_section")]
        public string DFreeSection { get; set; }

        [JsonProperty("d_groupon_section")]
        public string DGrouponSection { get; set; }

        [JsonProperty("d_groupon_type_section")]
        public string DGrouponTypeSection { get; set; }

        [JsonProperty("d_health_score_section")]
        public string DHealthScoreSection { get; set; }

        [JsonProperty("d_hotel_book_pc_section")]
        public string DHotelBookPcSection { get; set; }

        [JsonProperty("d_hotel_book_wap_section")]
        public string DHotelBookWapSection { get; set; }

        [JsonProperty("d_hourly_day1_bookable_section")]
        public string DHourlyDay1BookableSection { get; set; }

        [JsonProperty("d_hourly_day1_fullroom_section")]
        public string DHourlyDay1FullroomSection { get; set; }

        [JsonProperty("d_hourly_day1_price_section")]
        public string DHourlyDay1PriceSection { get; set; }

        [JsonProperty("d_hourly_day2_bookable_section")]
        public string DHourlyDay2BookableSection { get; set; }

        [JsonProperty("d_hourly_day2_fullroom_section")]
        public string DHourlyDay2FullroomSection { get; set; }

        [JsonProperty("d_hourly_day2_price_section")]
        public string DHourlyDay2PriceSection { get; set; }

        [JsonProperty("d_hourly_day3_bookable_section")]
        public string DHourlyDay3BookableSection { get; set; }

        [JsonProperty("d_hourly_day3_fullroom_section")]
        public string DHourlyDay3FullroomSection { get; set; }

        [JsonProperty("d_hourly_day3_price_section")]
        public string DHourlyDay3PriceSection { get; set; }

        [JsonProperty("d_hourly_day4_bookable_section")]
        public string DHourlyDay4BookableSection { get; set; }

        [JsonProperty("d_hourly_day4_fullroom_section")]
        public string DHourlyDay4FullroomSection { get; set; }

        [JsonProperty("d_hourly_day4_price_section")]
        public string DHourlyDay4PriceSection { get; set; }

        [JsonProperty("d_hourly_day5_bookable_section")]
        public string DHourlyDay5BookableSection { get; set; }

        [JsonProperty("d_hourly_day5_fullroom_section")]
        public string DHourlyDay5FullroomSection { get; set; }

        [JsonProperty("d_hourly_day5_price_section")]
        public string DHourlyDay5PriceSection { get; set; }

        [JsonProperty("d_level_section")]
        public string DLevelSection { get; set; }

        [JsonProperty("d_lowprice_flag_section")]
        public string DLowpriceFlagSection { get; set; }

        [JsonProperty("d_meishipaihao_section")]
        public string DMeishipaihaoSection { get; set; }

        [JsonProperty("d_movie_book_section")]
        public string DMovieBookSection { get; set; }

        [JsonProperty("d_overall_rating_section")]
        public string DOverallRatingSection { get; set; }

        [JsonProperty("d_price_section")]
        public string DPriceSection { get; set; }

        [JsonProperty("d_query_attr_type")]
        public string DQueryAttrType { get; set; }

        [JsonProperty("d_rebate_section")]
        public string DRebateSection { get; set; }

        [JsonProperty("d_sort_rule")]
        public string DSortRule { get; set; }

        [JsonProperty("d_sort_type")]
        public string DSortType { get; set; }

        [JsonProperty("d_spothot_section")]
        public string DSpothotSection { get; set; }

        [JsonProperty("d_sub_type")]
        public string DSubType { get; set; }

        [JsonProperty("d_support_imax_section")]
        public string DSupportImaxSection { get; set; }

        [JsonProperty("d_tag_filter")]
        public string DTagFilter { get; set; }

        [JsonProperty("d_tag_info_list")]
        public string DTagInfoList { get; set; }

        [JsonProperty("d_tag_section")]
        public string DTagSection { get; set; }

        [JsonProperty("d_ticket_book_flag_section")]
        public string DTicketBookFlagSection { get; set; }

        [JsonProperty("d_tonight_sale_flag_section")]
        public string DTonightSaleFlagSection { get; set; }

        [JsonProperty("d_total_score_section")]
        public string DTotalScoreSection { get; set; }

        [JsonProperty("d_wise_price_section")]
        public string DWisePriceSection { get; set; }

        [JsonProperty("search_ext")]
        public SearchExt[] SearchExt { get; set; }
    }

    public class ImpressionTag
    {

        [JsonProperty("hotel")]
        public string Hotel { get; set; }

        [JsonProperty("life")]
        public string Life { get; set; }
    }

    public class Catalog
    {

        [JsonProperty("field_name")]
        public string FieldName { get; set; }

        [JsonProperty("priority")]
        public string Priority { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }
    }

    public class SourceMap
    {

        [JsonProperty("catalog")]
        public Catalog Catalog { get; set; }
    }

    public class DisplayInfo
    {

        [JsonProperty("catalog_fields")]
        public object[] CatalogFields { get; set; }

        [JsonProperty("impression_tag")]
        public ImpressionTag ImpressionTag { get; set; }

        [JsonProperty("redu")]
        public string Redu { get; set; }

        [JsonProperty("source_map")]
        public SourceMap SourceMap { get; set; }

        [JsonProperty("src_name")]
        public string SrcName { get; set; }
    }

    public class ExtDisplay
    {

        [JsonProperty("display_info")]
        public DisplayInfo DisplayInfo { get; set; }
    }

    public class OriginId
    {

        [JsonProperty("lbc_uid")]
        public string LbcUid { get; set; }
    }

    public class Content
    {

        [JsonProperty("acc_flag")]
        public int AccFlag { get; set; }

        [JsonProperty("addr")]
        public string Addr { get; set; }

        [JsonProperty("address_norm")]
        public string AddressNorm { get; set; }

        [JsonProperty("aoi")]
        public string Aoi { get; set; }

        [JsonProperty("area")]
        public int Area { get; set; }

        [JsonProperty("biz_type")]
        public int BizType { get; set; }

        [JsonProperty("brand_id")]
        public object BrandId { get; set; }

        [JsonProperty("catalogID")]
        public int CatalogID { get; set; }

        [JsonProperty("cla")]
        public object[][] Cla { get; set; }

        [JsonProperty("detail")]
        public int Detail { get; set; }

        [JsonProperty("diPointX")]
        public int DiPointX { get; set; }

        [JsonProperty("diPointY")]
        public int DiPointY { get; set; }

        [JsonProperty("dis")]
        public int Dis { get; set; }

        [JsonProperty("dist2route")]
        public int Dist2route { get; set; }

        [JsonProperty("dist2start")]
        public int Dist2start { get; set; }

        [JsonProperty("ext")]
        public object Ext { get; set; }

        [JsonProperty("ext_display")]
        public ExtDisplay ExtDisplay { get; set; }

        [JsonProperty("ext_type")]
        public int ExtType { get; set; }

        [JsonProperty("f_flag")]
        public int FFlag { get; set; }

        [JsonProperty("father_son")]
        public int FatherSon { get; set; }

        [JsonProperty("flag_type")]
        public string FlagType { get; set; }

        [JsonProperty("geo")]
        public string Geo { get; set; }

        [JsonProperty("geo_type")]
        public int GeoType { get; set; }

        [JsonProperty("indoor_pano")]
        public string IndoorPano { get; set; }

        [JsonProperty("ismodified")]
        public int Ismodified { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("navi_x")]
        public string NaviX { get; set; }

        [JsonProperty("navi_y")]
        public string NaviY { get; set; }

        [JsonProperty("new_catalog_id")]
        public string NewCatalogId { get; set; }

        [JsonProperty("pano")]
        public int Pano { get; set; }

        [JsonProperty("poiType")]
        public int PoiType { get; set; }

        [JsonProperty("poi_click_num")]
        public int PoiClickNum { get; set; }

        [JsonProperty("poi_profile")]
        public int PoiProfile { get; set; }

        [JsonProperty("primary_uid")]
        public string PrimaryUid { get; set; }

        [JsonProperty("prio_flag")]
        public int PrioFlag { get; set; }

        [JsonProperty("route_flag")]
        public int RouteFlag { get; set; }

        [JsonProperty("show_tag")]
        public object[] ShowTag { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("std_tag")]
        public string StdTag { get; set; }

        [JsonProperty("storage_src")]
        public string StorageSrc { get; set; }

        [JsonProperty("street_id")]
        public string StreetId { get; set; }

        [JsonProperty("tag")]
        public string Tag { get; set; }

        [JsonProperty("ty")]
        public int Ty { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("view_type")]
        public int ViewType { get; set; }

        [JsonProperty("x")]
        public int X { get; set; }

        [JsonProperty("y")]
        public int Y { get; set; }

        [JsonProperty("tel")]
        public string Tel { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("alias")]
        public string[] Alias { get; set; }

        [JsonProperty("origin_id")]
        public OriginId OriginId { get; set; }
    }

    public class CurrentCity
    {

        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("geo")]
        public string Geo { get; set; }

        [JsonProperty("level")]
        public int Level { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sup")]
        public int Sup { get; set; }

        [JsonProperty("sup_bus")]
        public int SupBus { get; set; }

        [JsonProperty("sup_business_area")]
        public int SupBusinessArea { get; set; }

        [JsonProperty("sup_lukuang")]
        public int SupLukuang { get; set; }

        [JsonProperty("sup_subway")]
        public int SupSubway { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("up_province_name")]
        public string UpProvinceName { get; set; }
    }

    public class Param
    {

        [JsonProperty("d_brand_id")]
        public string DBrandId { get; set; }

        [JsonProperty("d_query_attr_type")]
        public string DQueryAttrType { get; set; }

        [JsonProperty("d_tag_info_list")]
        public string DTagInfoList { get; set; }

        [JsonProperty("query_show_click_flag")]
        public int QueryShowClickFlag { get; set; }

        [JsonProperty("sample_experiment")]
        public object[] SampleExperiment { get; set; }

        [JsonProperty("view_city")]
        public int ViewCity { get; set; }
    }

    public class LbsForward
    {

        [JsonProperty("param")]
        public Param[] Param { get; set; }
    }

    public class Result
    {

        [JsonProperty("ad_display_type")]
        public int AdDisplayType { get; set; }

        [JsonProperty("aladdin_res_num")]
        public int AladdinResNum { get; set; }

        [JsonProperty("aladin_query_type")]
        public int AladinQueryType { get; set; }

        [JsonProperty("area_profile")]
        public int AreaProfile { get; set; }

        [JsonProperty("business_bound")]
        public string BusinessBound { get; set; }

        [JsonProperty("catalogID")]
        public int CatalogID { get; set; }

        [JsonProperty("cmd_no")]
        public int CmdNo { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("current_null")]
        public int CurrentNull { get; set; }

        [JsonProperty("data_security_filt_res")]
        public int DataSecurityFiltRes { get; set; }

        [JsonProperty("db")]
        public int Db { get; set; }

        [JsonProperty("debug")]
        public int Debug { get; set; }

        [JsonProperty("jump_back")]
        public int JumpBack { get; set; }

        [JsonProperty("loc_attr")]
        public int LocAttr { get; set; }

        [JsonProperty("op_gel")]
        public int OpGel { get; set; }

        [JsonProperty("page_num")]
        public int PageNum { get; set; }

        [JsonProperty("pattern_sign")]
        public int PatternSign { get; set; }

        [JsonProperty("profile_uid")]
        public string ProfileUid { get; set; }

        [JsonProperty("qid")]
        public string Qid { get; set; }

        [JsonProperty("requery")]
        public string Requery { get; set; }

        [JsonProperty("res_bound")]
        public string ResBound { get; set; }

        [JsonProperty("res_bound_acc")]
        public string ResBoundAcc { get; set; }

        [JsonProperty("res_l")]
        public int ResL { get; set; }

        [JsonProperty("res_x")]
        public string ResX { get; set; }

        [JsonProperty("res_y")]
        public string ResY { get; set; }

        [JsonProperty("result_show")]
        public int ResultShow { get; set; }

        [JsonProperty("return_query")]
        public string ReturnQuery { get; set; }

        [JsonProperty("rp_strategy")]
        public int RpStrategy { get; set; }

        [JsonProperty("spec_dispnum")]
        public int SpecDispnum { get; set; }

        [JsonProperty("spothot")]
        public bool Spothot { get; set; }

        [JsonProperty("sug_index")]
        public int SugIndex { get; set; }

        [JsonProperty("time")]
        public int Time { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("total_busline_num")]
        public int TotalBuslineNum { get; set; }

        [JsonProperty("tp")]
        public int Tp { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("wd")]
        public string Wd { get; set; }

        [JsonProperty("wd2")]
        public string Wd2 { get; set; }

        [JsonProperty("what")]
        public string What { get; set; }

        [JsonProperty("where")]
        public string Where { get; set; }

        [JsonProperty("uii_type")]
        public string UiiType { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("uii_qt")]
        public string UiiQt { get; set; }

        [JsonProperty("login_debug")]
        public int LoginDebug { get; set; }

        [JsonProperty("lbs_forward")]
        public LbsForward LbsForward { get; set; }
    }

    public class BaiduPOI_JSON
    {

        [JsonProperty("place_info")]
        public PlaceInfo PlaceInfo { get; set; }

        [JsonProperty("content")]
        public Content[] Content { get; set; }

        [JsonProperty("current_city")]
        public CurrentCity CurrentCity { get; set; }

        [JsonProperty("hot_city")]
        public string[] HotCity { get; set; }

        [JsonProperty("result")]
        public Result Result { get; set; }

        [JsonProperty("damoce")]
        public object Damoce { get; set; }
    }

}
