CREATE TABLE [dbo].[BNKSEEK] (
    [REAL]    VARCHAR (4)  NULL,
    [PZN]     VARCHAR (2)  NULL,
    [UER]     VARCHAR (1)  NOT NULL,
    [RGN]     VARCHAR (2)  NOT NULL,
    [IND]     VARCHAR (6)  NULL,
    [TNP]     VARCHAR (1)  NULL,
    [NNP]     VARCHAR (25) NULL,
    [ADR]     VARCHAR (30) NULL,
    [RKC]     VARCHAR (9)  NULL,
    [NAMEP]   VARCHAR (45) NOT NULL,
    [NEWNUM]  VARCHAR (9)  NOT NULL,
    [TELEF]   VARCHAR (25) NULL,
    [REGN]    VARCHAR (9)  NULL,
    [OKPO]    VARCHAR (8)  NULL,
    [DT_IZM]  DATE         NOT NULL,
    [KSNP]    VARCHAR (20) NULL,
    [DATE_IN] DATE         NOT NULL,
    [DATE_CH] DATE         NULL,
    UNIQUE NONCLUSTERED ([NEWNUM] ASC)
);

