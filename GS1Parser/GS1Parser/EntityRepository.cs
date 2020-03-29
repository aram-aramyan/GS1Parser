﻿using System.Collections.Generic;
using System.Linq;

namespace GS1Parser
{
    public static class EntityRepository
    {
        private static readonly SortedDictionary<string, Entity> Entities = new SortedDictionary<string, Entity>(
            new List<Entity>
            {
                new Entity("00", "SerialShippingContainerCode", 2, DataType.Numeric, 18, false),
                new Entity("01", "EAN-NumberOfTradingUnit", 2, DataType.Numeric, 14, false),
                new Entity("02", "EAN-NumberOfTheWaresInTheShippingUnit", 2, DataType.Numeric, 14, false),
                new Entity("10", "Charge_Number", 2, DataType.Alphanumeric, 20, true),
                new Entity("11", "ProducerDate_YYMMDD", 2, DataType.Numeric, 6, false),
                new Entity("12", "DueDate_YYMMDD", 2, DataType.Numeric, 6, false),
                new Entity("13", "PackingDate_YYMMDD", 2, DataType.Numeric, 6, false),
                new Entity("15", "MinimumDurabilityDate_YYMMDD", 2, DataType.Numeric, 6, false),
                new Entity("17", "ExpiryDate_YYMMDD", 2, DataType.Numeric, 6, false),
                new Entity("20", "ProductModel", 2, DataType.Numeric, 2, false),
                new Entity("21", "SerialNumber", 2, DataType.Alphanumeric, 20, true),
                new Entity("22", "HIBCCNumber", 2, DataType.Alphanumeric, 29, false),
                new Entity("240", "ProductIdentificationOfProducer", 3, DataType.Alphanumeric, 30, true),
                new Entity("241", "CustomerPartsNumber", 3, DataType.Alphanumeric, 30, true),
                new Entity("250", "SerialNumberOfAIntegratedModule", 3, DataType.Alphanumeric, 30, true),
                new Entity("251", "ReferenceToTheBasisUnit", 3, DataType.Alphanumeric, 30, true),
                new Entity("252", "GlobalIdentifierSerializedForTrade", 3, DataType.Numeric, 2, false),
                new Entity("30", "AmountInParts", 2, DataType.Numeric, 8, true),
                new Entity("310d", "NetWeight_Kilogram", 4, DataType.Numeric, 6, false),
                new Entity("311d", "Length_Meter", 4, DataType.Numeric, 6, false),
                new Entity("312d", "Width_Meter", 4, DataType.Numeric, 6, false),
                new Entity("313d", "Height_Meter", 4, DataType.Numeric, 6, false),
                new Entity("314d", "Surface_SquareMeter", 4, DataType.Numeric, 6, false),
                new Entity("315d", "NetVolume_Liters", 4, DataType.Numeric, 6, false),
                new Entity("316d", "NetVolume_CubicMeters", 4, DataType.Numeric, 6, false),
                new Entity("320d", "NetWeight_Pounds", 4, DataType.Numeric, 6, false),
                new Entity("321d", "Length_Inches", 4, DataType.Numeric, 6, false),
                new Entity("322d", "Length_Feet", 4, DataType.Numeric, 6, false),
                new Entity("323d", "Length_Yards", 4, DataType.Numeric, 6, false),
                new Entity("324d", "Width_Inches", 4, DataType.Numeric, 6, false),
                new Entity("325d", "Width_Feed", 4, DataType.Numeric, 6, false),
                new Entity("326d", "Width_Yards", 4, DataType.Numeric, 6, false),
                new Entity("327d", "Height_Inches", 4, DataType.Numeric, 6, false),
                new Entity("328d", "Height_Feed", 4, DataType.Numeric, 6, false),
                new Entity("329d", "Height_Yards", 4, DataType.Numeric, 6, false),
                new Entity("330d", "GrossWeight_Kilogram", 4, DataType.Numeric, 6, false),
                new Entity("331d", "Length_Meter", 4, DataType.Numeric, 6, false),
                new Entity("332d", "Width_Meter", 4, DataType.Numeric, 6, false),
                new Entity("333d", "Height_Meter", 4, DataType.Numeric, 6, false),
                new Entity("334d", "Surface_SquareMeter", 4, DataType.Numeric, 6, false),
                new Entity("335d", "GrossVolume_Liters", 4, DataType.Numeric, 6, false),
                new Entity("336d", "GrossVolume_CubicMeters", 4, DataType.Numeric, 6, false),
                new Entity("337d", "KilogramPerSquareMeter", 4, DataType.Numeric, 6, false),
                new Entity("340d", "GrossWeight_Pounds", 4, DataType.Numeric, 6, false),
                new Entity("341d", "Length_Inches", 4, DataType.Numeric, 6, false),
                new Entity("342d", "Length_Feet", 4, DataType.Numeric, 6, false),
                new Entity("343d", "Length_Yards", 4, DataType.Numeric, 6, false),
                new Entity("344d", "Width_Inches", 4, DataType.Numeric, 6, false),
                new Entity("345d", "Width_Feed", 4, DataType.Numeric, 6, false),
                new Entity("346d", "Width_Yards", 4, DataType.Numeric, 6, false),
                new Entity("347d", "Height_Inches", 4, DataType.Numeric, 6, false),
                new Entity("348d", "Height_Feed", 4, DataType.Numeric, 6, false),
                new Entity("349d", "Height_Yards", 4, DataType.Numeric, 6, false),
                new Entity("350d", "Surface_SquareInches", 4, DataType.Numeric, 6, false),
                new Entity("351d", "Surface_SquareFeet", 4, DataType.Numeric, 6, false),
                new Entity("352d", "Surface_SquareYards", 4, DataType.Numeric, 6, false),
                new Entity("353d", "Surface_SquareInches", 4, DataType.Numeric, 6, false),
                new Entity("354d", "Surface_SquareFeed", 4, DataType.Numeric, 6, false),
                new Entity("355d", "Surface_SquareYards", 4, DataType.Numeric, 6, false),
                new Entity("356d", "NetWeight_TroyOunces", 4, DataType.Numeric, 6, false),
                new Entity("357d", "NetVolume_Ounces", 4, DataType.Numeric, 6, false),
                new Entity("360d", "NetVolume_Quarts", 4, DataType.Numeric, 6, false),
                new Entity("361d", "NetVolume_Gallons", 4, DataType.Numeric, 6, false),
                new Entity("362d", "GrossVolume_Quarts", 4, DataType.Numeric, 6, false),
                new Entity("363d", "GrossVolume_Gallons", 4, DataType.Numeric, 6, false),
                new Entity("364d", "NetVolume_CubicInches", 4, DataType.Numeric, 6, false),
                new Entity("365d", "NetVolume_CubicFeet", 4, DataType.Numeric, 6, false),
                new Entity("366d", "NetVolume_CubicYards", 4, DataType.Numeric, 6, false),
                new Entity("367d", "GrossVolume_CubicInches", 4, DataType.Numeric, 6, false),
                new Entity("368d", "GrossVolume_CubicFeet", 4, DataType.Numeric, 6, false),
                new Entity("369d", "GrossVolume_CubicYards", 4, DataType.Numeric, 6, false),
                new Entity("37", "QuantityInParts", 2, DataType.Numeric, 8, true),
                new Entity("390d", "AmountDue_DefinedCurrencyBand", 4, DataType.Numeric, 15, true),
                new Entity("391d", "AmountDue_WithISOCurrencyCode", 4, DataType.Numeric, 18, true),
                new Entity("392d", "BePayingAmount_DefinedCurrencyBand", 4, DataType.Numeric, 15, true),
                new Entity("393d", "BePayingAmount_WithISOCurrencyCode", 4, DataType.Numeric, 18, true),
                new Entity("400", "JobNumberOfGoodsRecipient", 3, DataType.Alphanumeric, 30, true),
                new Entity("401", "ShippingNumber", 3, DataType.Alphanumeric, 30, true),
                new Entity("402", "DeliveryNumber", 3, DataType.Numeric, 17, false),
                new Entity("403", "RoutingCode", 3, DataType.Alphanumeric, 30, true),
                new Entity("410", "EAN_UCC_GlobalLocationNumber(GLN)_GoodsRecipient", 3, DataType.Numeric, 13, false),
                new Entity("411", "EAN_UCC_GlobalLocationNumber(GLN)_InvoiceRecipient", 3, DataType.Numeric, 13, false),
                new Entity("412", "EAN_UCC_GlobalLocationNumber(GLN)_Distributor", 3, DataType.Numeric, 13, false),
                new Entity("413", "EAN_UCC_GlobalLocationNumber(GLN)_FinalRecipient", 3, DataType.Numeric, 13, false),
                new Entity("414", "EAN_UCC_GlobalLocationNumber(GLN)_PhysicalLocation", 3, DataType.Numeric, 13, false),
                new Entity("415", "EAN_UCC_GlobalLocationNumber(GLN)_ToBillingParticipant", 3, DataType.Numeric, 13, false),
                new Entity("420", "ZipCodeOfRecipient_withoutCountryCode", 3, DataType.Alphanumeric, 20, true),
                new Entity("421", "ZipCodeOfRecipient_withCountryCode", 3, DataType.Alphanumeric, 12, true),
                new Entity("422", "BasisCountryOfTheWares_ISO3166Format", 3, DataType.Numeric, 3, false),
                new Entity("7001", "Nato Stock Number", 4, DataType.Numeric, 13, false),
                new Entity("8001", "RolesProducts", 4, DataType.Numeric, 14, false),
                new Entity("8002", "SerialNumberForMobilePhones", 4, DataType.Alphanumeric, 20, true),
                new Entity("8003", "GlobalReturnableAssetIdentifier", 4, DataType.Alphanumeric, 34, true),
                new Entity("8004", "GlobalIndividualAssetIdentifier", 4, DataType.Numeric, 30, true),
                new Entity("8005", "SalesPricePerUnit", 4, DataType.Numeric, 6, false),
                new Entity("8006", "IdentificationOfAProductComponent", 4, DataType.Numeric, 18, false),
                new Entity("8007", "IBAN", 4, DataType.Alphanumeric, 30, true),
                new Entity("8008", "DataAndTimeOfManufacturing", 4, DataType.Numeric, 12, true),
                new Entity("8018", "GlobalServiceRelationNumber", 4, DataType.Numeric, 18, false),
                new Entity("8020", "NumberBillCoverNumber", 4, DataType.Alphanumeric, 25, false),
                new Entity("8100", "CouponExtendedCode_NSC_offerCode", 4, DataType.Numeric, 10, false),
                new Entity("8101", "CouponExtendedCode_NSC_offerCode_EndOfOfferCode", 4, DataType.Numeric, 14, false),
                new Entity("8102", "CouponExtendedCode_NSC", 4, DataType.Numeric, 6, false),
                new Entity("90", "InformationForBilateralCoordinatedApplications", 2, DataType.Alphanumeric, 30, true),
                new Entity("91", "Company specific", 2, DataType.Alphanumeric, 30, true),
                new Entity("92", "Company specific", 2, DataType.Alphanumeric, 30, true),
                new Entity("93", "Company specific", 2, DataType.Alphanumeric, 30, true),
                new Entity("94", "Company specific", 2, DataType.Alphanumeric, 30, true),
                new Entity("95", "Company specific", 2, DataType.Alphanumeric, 30, true),
                new Entity("96", "Company specific", 2, DataType.Alphanumeric, 30, true),
                new Entity("97", "Company specific", 2, DataType.Alphanumeric, 30, true),
                new Entity("98", "Company specific", 2, DataType.Alphanumeric, 30, true),
                new Entity("99", "Company specific", 2, DataType.Alphanumeric, 30, true)
            }.ToDictionary(e => e.AI, e => e));

        public static SortedDictionary<string, Entity> GetEntities()
        {
            return Entities;
        }
    }
}