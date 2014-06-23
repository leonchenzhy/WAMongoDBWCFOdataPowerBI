using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

/// <summary>
/// Summary description for FAAObjects
/// </summary>
public class FAAObjects
{
    public class ACFTREF_Table_Record
    {
        public String Id { get; set; }
        public String CODE { get; set; }
        public String MFR { get; set; }
        public String MODEL { get; set; }
        public String TYPE_ACFT { get; set; }
        public String TYPE_ENG { get; set; }
        public String AC_CAT { get; set; }
        public String BUILD_CERT_IND { get; set; }
        public String NO_ENG { get; set; }
        public String NO_SEATS { get; set; }
        public String AC_WEIGHT { get; set; }
        public String SPEED { get; set; }
    }

    public class DEALER_Table_Record
    {
        public String Id { get; set; }
        public String CERTIFICATE_NUMBER { get; set; }
        public String OWNERSHIP { get; set; }
        public String CERTIFICATE_DATE { get; set; }
        public String EXPIRATION_DATE { get; set; }
        public String EXPIRATION_FLAG { get; set; }
        public String CERTIFICATE_ISSUE_COUNT { get; set; }
        public String NAME { get; set; }
        public String STREET { get; set; }
        public String STREET2 { get; set; }
        public String CITY { get; set; }
        public String STATE_ABBREV { get; set; }
        public String ZIP_CODE { get; set; }
        public String OTHER_NAMES_COUNT { get; set; }
        public String OTHER_NAMES_1 { get; set; }
        public String OTHER_NAMES_2 { get; set; }
        public String OTHER_NAMES_3 { get; set; }
        public String OTHER_NAMES_4 { get; set; }
        public String OTHER_NAMES_5 { get; set; }
        public String OTHER_NAMES_6 { get; set; }
        public String OTHER_NAMES_7 { get; set; }
        public String OTHER_NAMES_8 { get; set; }
        public String OTHER_NAMES_9 { get; set; }
        public String OTHER_NAMES_10 { get; set; }
        public String OTHER_NAMES_11 { get; set; }
        public String OTHER_NAMES_12 { get; set; }
        public String OTHER_NAMES_13 { get; set; }
        public String OTHER_NAMES_14 { get; set; }
        public String OTHER_NAMES_15 { get; set; }
        public String OTHER_NAMES_16 { get; set; }
        public String OTHER_NAMES_17 { get; set; }
        public String OTHER_NAMES_18 { get; set; }
        public String OTHER_NAMES_19 { get; set; }
        public String OTHER_NAMES_20 { get; set; }
        public String OTHER_NAMES_21 { get; set; }
        public String OTHER_NAMES_22 { get; set; }
        public String OTHER_NAMES_23 { get; set; }
        public String OTHER_NAMES_24 { get; set; }
        public String OTHER_NAMES_25 { get; set; }
    }

    public class DEREG_Table_Record
    {
        public String Id { get; set; }
        public String N_NUMBER { get; set; }
        public String SERIAL_NUMBER { get; set; }
        public String MFR_MDL_CODE { get; set; }
        public String STATUS_CODE { get; set; }
        public String NAME { get; set; }
        public String STREET_MAIL { get; set; }
        public String STREET2_MAIL { get; set; }
        public String CITY_MAIL { get; set; }
        public String STATE_ABBREV_MAIL { get; set; }
        public String ZIP_CODE_MAIL { get; set; }
        public String ENG_MFR_MDL { get; set; }
        public String YEAR_MFR { get; set; }
        public String CERTIFICATION { get; set; }
        public String REGION { get; set; }
        public String COUNTY_MAIL { get; set; }
        public String COUNTRY_MAIL { get; set; }
        public String AIR_WORTH_DATE { get; set; }
        public String CANCEL_DATE { get; set; }
        public String MODE_S_CODE { get; set; }
        public String INDICATOR_GROUP { get; set; }
        public String EXP_COUNTRY { get; set; }
        public String LAST_ACT_DATE { get; set; }
        public String CERT_ISSUE_DATE { get; set; }
        public String STREET_PHYSICAL { get; set; }
        public String STREET2_PHYSICAL { get; set; }
        public String CITY_PHYSICAL { get; set; }
        public String STATE_ABBREV_PHYSICAL { get; set; }
        public String ZIP_CODE_PHYSICAL { get; set; }
        public String COUNTY_PHYSICAL { get; set; }
        public String COUNTRY_PHYSICAL { get; set; }
        public String OTHER_NAMES_1 { get; set; }
        public String OTHER_NAMES_2 { get; set; }
        public String OTHER_NAMES_3 { get; set; }
        public String OTHER_NAMES_4 { get; set; }
        public String OTHER_NAMES_5 { get; set; }
        public String KIT_MFR { get; set; }
        public String KIT_MODEL { get; set; }
        public String MODE_S_CODE_HEX { get; set; }
    }

    public class DOCINDEX_Table_Record
    {
        public String Id { get; set; }
        public String TYPE_COLLATERAL { get; set; }
        public String COLLATERAL { get; set; }
        public String PARTY { get; set; }
        public String DOC_ID { get; set; }
        public String DRDATE { get; set; }
        public String PROCESSING_DATE { get; set; }
        public String CORR_DATE { get; set; }
        public String CORR_ID { get; set; }
        public String SERIAL_ID { get; set; }
    }

    public class ENGINE_Table_Record
    {
        public String Id { get; set; }
        public String CODE { get; set; }
        public String MFR { get; set; }
        public String MODEL { get; set; }
        public String TYPE { get; set; }
        public String HORSEPOWER { get; set; }
        public String THRUST { get; set; }
    }

    public class MASTER_Table_Record
    {
        public String Id { get; set; }
        public String N_NUMBER { get; set; }
        public String SERIAL_NUMBER { get; set; }
        public String MFR_MDL_CODE { get; set; }
        public String ENG_MFR_MDL { get; set; }
        public String YEAR_MFR { get; set; }
        public String TYPE_REGISTRANT { get; set; }
        public String NAME { get; set; }
        public String STREET { get; set; }
        public String STREET2 { get; set; }
        public String CITY { get; set; }
        public String STATE { get; set; }
        public String ZIP_CODE { get; set; }
        public String REGION { get; set; }
        public String COUNTY { get; set; }
        public String COUNTRY { get; set; }
        public String LAST_ACTION_DATE { get; set; }
        public String CERT_ISSUE_DATE { get; set; }
        public String CERTIFICATION { get; set; }
        public String TYPE_AIRCRAFT { get; set; }
        public String TYPE_ENGINE { get; set; }
        public String STATUS_CODE { get; set; }
        public String MODE_S_CODE { get; set; }
        public String FRACT_OWNER { get; set; }
        public String AIR_WORTH_DATE { get; set; }
        public String OTHER_NAMES_1 { get; set; }
        public String OTHER_NAMES_2 { get; set; }
        public String OTHER_NAMES_3 { get; set; }
        public String OTHER_NAMES_4 { get; set; }
        public String OTHER_NAMES_5 { get; set; }
        public String EXPIRATION_DATE { get; set; }
        public String UNIQUE_ID { get; set; }
        public String KIT_MFR { get; set; }
        public String KIT_MODEL { get; set; }
        public String MODE_S_CODE_HEX { get; set; }
    }

    public class RESERVED_Table_Record
    {
        public String Id { get; set; }
        public String N_NUMBER { get; set; }
        public String REGISTRANT { get; set; }
        public String STREET { get; set; }
        public String STREET2 { get; set; }
        public String CITY { get; set; }
        public String STATE { get; set; }
        public String ZIP_CODE { get; set; }
        public String RSV_DATE { get; set; }
        public String TR { get; set; }
        public String EXP_DATE { get; set; }
        public String N_NUM_CHG { get; set; }
    }

    [MongoDatabase("test")]
    public class OdataFAAObjects
    {
        [MongoCollection("MASTER_Data")]
        public MongoCollection<MASTER_Table_Record> MASTER_Table_Records { get; set; }

        [MongoCollection("ACFTREF_Data")]
        public MongoCollection<ACFTREF_Table_Record> ACFTREF_Table_Records { get; set; }

        [MongoCollection("DEALER_Data")]
        public MongoCollection<DEALER_Table_Record> DEALER_Table_Records { get; set; }

        [MongoCollection("DEREG_Data")]
        public MongoCollection<DEREG_Table_Record> DEREG_Table_Records { get; set; }

        [MongoCollection("DOCINDEX_Data")]
        public MongoCollection<DOCINDEX_Table_Record> DOCINDEX_Table_Records { get; set; }

        [MongoCollection("ENGINE_Data")]
        public MongoCollection<ENGINE_Table_Record> ENGINE_Table_Records { get; set; }

        [MongoCollection("RESERVED_Data")]
        public MongoCollection<RESERVED_Table_Record> RESERVED_Table_Records { get; set; }
    }
}