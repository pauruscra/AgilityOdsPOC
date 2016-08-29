SELECT * FROM [dbo].[StageVwGtEmployee]
--WHERE PrsnCapabilityPrimary <> '' 
FOR XML PATH  ('Person'), root ('PersonStage');