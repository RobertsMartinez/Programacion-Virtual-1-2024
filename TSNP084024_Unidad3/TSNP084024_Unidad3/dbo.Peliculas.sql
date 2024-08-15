CREATE TABLE [dbo].[Peliculas] (
    [IdPelicula]    INT           IDENTITY (1, 1) NOT NULL,
    [Titulo]        VARCHAR (100) NULL,
    [Autor]         VARCHAR (100) NULL,
    [Sinopsis]      VARCHAR (500) NULL,
    [Duracion]      INT           NULL,
    [Clasificacion] NCHAR (10)    NULL,
    PRIMARY KEY CLUSTERED ([IdPelicula] ASC)
);

