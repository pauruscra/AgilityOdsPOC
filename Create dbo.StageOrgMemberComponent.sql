USE [AODS]
GO

/****** Object: Table [dbo].[StageOrgMemberComponent] Script Date: 2016-08-23 6:57:06 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Stage].[OrgComponentListValue] (
    [OrgIdCode]               VARCHAR (20) NULL,
    [ComponentSequenceNumber] INT           NULL,
    [Code]                    VARCHAR (30) NULL,
    [Name]                    VARCHAR (80) NULL
);


