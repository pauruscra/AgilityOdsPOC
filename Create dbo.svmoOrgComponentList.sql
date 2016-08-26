USE [AODS]
GO

/****** Object: Table [dbo].[svmoOrgComponentList] Script Date: 2016-08-22 5:12:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[svmoOrgComponentListValue] (
    [OrgclvComponentListValueId]             INT                                         IDENTITY (1, 1) NOT NULL,
    [OrgclvComponentListOrgIdCode]      VARCHAR (40)                                NOT NULL,
    [OrgclvComponentListOrgIdCodeName]  VARCHAR (60)                                NOT NULL,
    [OrgclvComponentListOrgTypeId]      INT                                         NOT NULL,
    [OrgclvComponentListOrgTypeIdCode]  VARCHAR (10)                                NOT NULL,
    [OrgclvComponentListSequenceNumber] INT                                         NOT NULL,
    [OrgclvComponentOrgId]              INT                                         NOT NULL,
    [OrgclvComponentOrgIdCode]          VARCHAR (20)                                NOT NULL,
    [OrgclvComponentOrgTypeId]          INT                                         NOT NULL,
    [OrgclvComponentOrgTypeIdCode]      VARCHAR (10)                                NOT NULL,
    [OrgclvComponentListOrgIdIsActive]  CHAR (1)                                    NOT NULL,
    [OrgclvComponentListValueCode]      VARCHAR (40)                               NOT NULL,
    [OrgclvComponentListValueCodeName]  VARCHAR (60)                               NOT NULL,
    [DateModified]                     DATETIME                                    NOT NULL,
    [EtlProcessID]                     INT                                         NOT NULL,
    [EtlSourceSystemID]                INT                                         NOT NULL,
    [SysStartTime]                     DATETIME2 (7) GENERATED ALWAYS AS ROW START NOT NULL,
    [SysEndTime]                       DATETIME2 (7) GENERATED ALWAYS AS ROW END   NOT NULL,
    PRIMARY KEY NONCLUSTERED ([OrgclvComponentListOrgIdCode] ASC, [OrgclvComponentListSequenceNumber] ASC),
    PERIOD FOR SYSTEM_TIME ([SysStartTime], [SysEndTime])
)
WITH (MEMORY_OPTIMIZED = ON, SYSTEM_VERSIONING = ON (HISTORY_TABLE=[History].[svmoOrgComponentListValue], DATA_CONSISTENCY_CHECK=ON));


