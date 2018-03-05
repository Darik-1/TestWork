CREATE TABLE [dbo].[PZN] (
    [PZN]     VARCHAR (2)   NULL,
    [IMY]     VARCHAR (10)  NULL,
    [NAME]    VARCHAR (100) NULL,
    [CB_DATE] DATE          NULL,
    [CE_DATE] DATE          NULL,
    UNIQUE NONCLUSTERED ([PZN] ASC)
);

