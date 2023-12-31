﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using developChallenge.Infra.Context;

#nullable disable

namespace developChallenge.Infra.Migrations
{
    [DbContext(typeof(MyDatabaseContext))]
    [Migration("20231027180641_creatingAllTablesAndPopulateData")]
    partial class creatingAllTablesAndPopulateData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("developChallenge.Domain.Entities.Airport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AtualizadoEm")
                        .HasColumnType("datetime2");

                    b.Property<string>("CodigoIcao")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Condicao")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CondicaoDesc")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("DirecaoVento")
                        .HasColumnType("int");

                    b.Property<float>("PressaoAtmosferica")
                        .HasColumnType("real");

                    b.Property<int>("Temperatura")
                        .HasColumnType("int");

                    b.Property<int>("Umidade")
                        .HasColumnType("int");

                    b.Property<int>("Vento")
                        .HasColumnType("int");

                    b.Property<string>("Visibilidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Airports");
                });

            modelBuilder.Entity("developChallenge.Domain.Entities.AirportInfo", b =>
                {
                    b.Property<string>("ICAO")
                        .HasMaxLength(4)
                        .HasColumnType("nvarchar(4)");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Description")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("IATA")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StateCode")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.HasKey("ICAO");

                    b.ToTable("AirportsInfos");

                    b.HasData(
                        new
                        {
                            ICAO = "SBBR",
                            CityName = "Brasília",
                            Description = "Presidente Juscelino Kubitschek",
                            IATA = "BSB",
                            Name = "Aeroporto Internacional de Brasília",
                            StateCode = "DF"
                        },
                        new
                        {
                            ICAO = "SBSP",
                            CityName = "São Paulo",
                            Description = "Congonhas",
                            IATA = "CGH",
                            Name = "Aeroporto Internacional de São Paulo",
                            StateCode = "SP"
                        },
                        new
                        {
                            ICAO = "SBGL",
                            CityName = "Rio de Janeiro",
                            Description = "Galeão-Antônio Carlos Jobim",
                            IATA = "GIG",
                            Name = "Aeroporto Internacional do Rio de Janeiro",
                            StateCode = "RJ"
                        },
                        new
                        {
                            ICAO = "SBSV",
                            CityName = "Salvador",
                            Description = "Deputado Luis Eduardo Magalhães",
                            IATA = "SSA",
                            Name = "Aeroporto Internacional de Salvador",
                            StateCode = "BA"
                        },
                        new
                        {
                            ICAO = "SBFL",
                            CityName = "Florianópolis",
                            Description = "Hercílio Luz",
                            IATA = "FLN",
                            Name = "Aeroporto Internacional de Florianópolis",
                            StateCode = "SC"
                        },
                        new
                        {
                            ICAO = "SBPA",
                            CityName = "Porto Alegre",
                            Description = "Salgado Filho",
                            IATA = "POA",
                            Name = "Aeroporto Internacional de Porto Alegre",
                            StateCode = "RS"
                        },
                        new
                        {
                            ICAO = "SBKP",
                            CityName = "Campinas",
                            Description = "Campinas",
                            IATA = "VCP",
                            Name = "Aeroporto Internacional de Viracopos",
                            StateCode = "SP"
                        },
                        new
                        {
                            ICAO = "SBRF",
                            CityName = "Recife",
                            Description = "Guararapes – Gilberto Freyre",
                            IATA = "REC",
                            Name = "Aeroporto Internacional do Recife",
                            StateCode = "PE"
                        },
                        new
                        {
                            ICAO = "SBCT",
                            CityName = "Curitiba",
                            Description = "Afonso Pena",
                            IATA = "CWB",
                            Name = "Aeroporto Internacional de Curitiba",
                            StateCode = "PR"
                        },
                        new
                        {
                            ICAO = "SBBE",
                            CityName = "Belém",
                            Description = "Val de Cans",
                            IATA = "BEL",
                            Name = "Aeroporto Internacional de Belém",
                            StateCode = "PA"
                        },
                        new
                        {
                            ICAO = "SBVT",
                            CityName = "Vitória",
                            Description = "Eurico de Aguiar Salles",
                            IATA = "VIX",
                            Name = "Aeroporto de Vitória",
                            StateCode = "ES"
                        },
                        new
                        {
                            ICAO = "SBRJ",
                            CityName = "Santos Dumont",
                            IATA = "SDU",
                            Name = "Aeroporto Santos Dumont",
                            StateCode = "RJ"
                        },
                        new
                        {
                            ICAO = "SBCY",
                            CityName = "Cuiabá",
                            Description = "Marechal Rondon",
                            IATA = "CGB",
                            Name = "Aeroporto Internacional de Cuiabá",
                            StateCode = "MT"
                        },
                        new
                        {
                            ICAO = "SBCG",
                            CityName = "Campo Grande",
                            IATA = "CGR",
                            Name = "Aeroporto Internacional de Campo Grande",
                            StateCode = "MS"
                        },
                        new
                        {
                            ICAO = "SBFZ",
                            CityName = "Fortaleza",
                            Description = "Pinto Martins",
                            IATA = "FOR",
                            Name = "Aeroporto Internacional de Fortaleza",
                            StateCode = "CE"
                        },
                        new
                        {
                            ICAO = "SBMQ",
                            CityName = "Macapá",
                            IATA = "MCP",
                            Name = "Aeroporto Internacional de Macapá",
                            StateCode = "AP"
                        },
                        new
                        {
                            ICAO = "SBMG",
                            CityName = "Maringá",
                            Description = "Silvio Name Junior",
                            IATA = "MGF",
                            Name = "Aeroporto Regional de Maringá",
                            StateCode = "PR"
                        },
                        new
                        {
                            ICAO = "SBGO",
                            CityName = "Goiânia",
                            Description = "Santa Genoveva",
                            IATA = "GYN",
                            Name = "Aeroporto de Goiânia",
                            StateCode = "GO"
                        },
                        new
                        {
                            ICAO = "SBNF",
                            CityName = "Navegantes",
                            Description = "Ministro Victor Konder",
                            IATA = "NVT",
                            Name = "Aeroporto Internacional de Navegantes",
                            StateCode = "SC"
                        },
                        new
                        {
                            ICAO = "SBEG",
                            CityName = "Manaus",
                            Description = "Eduardo Gomes",
                            IATA = "MAO",
                            Name = "Aeroporto Internacional de Manaus",
                            StateCode = "AM"
                        },
                        new
                        {
                            ICAO = "SBNT",
                            CityName = "Natal",
                            Description = "Augusto Severo",
                            IATA = "NAT",
                            Name = "Aeroporto Internacional de Natal",
                            StateCode = "RN"
                        },
                        new
                        {
                            ICAO = "SBPS",
                            CityName = "Porto Seguro",
                            IATA = "BPS",
                            Name = "Aeroporto Internacional de Porto Seguro",
                            StateCode = "BA"
                        },
                        new
                        {
                            ICAO = "SBMO",
                            CityName = "Maceió",
                            Description = "Zumbi dos Palmares",
                            IATA = "MCZ",
                            Name = "Aeroporto de Maceió",
                            StateCode = "AL"
                        },
                        new
                        {
                            ICAO = "SSPS",
                            CityName = "Palmas",
                            Description = "Brigadeiro Lysias Rodrigues",
                            IATA = "PMW",
                            Name = "Aeroporto de Palmas",
                            StateCode = "TO"
                        },
                        new
                        {
                            ICAO = "SBSL",
                            CityName = "São Luís",
                            Description = "Marechal Cunha Machado",
                            IATA = "SLZ",
                            Name = "Aeroporto Internacional de São Luís",
                            StateCode = "MA"
                        },
                        new
                        {
                            ICAO = "SBGR",
                            CityName = "Guarulhos",
                            Description = "Guarulhos-Governador André Franco Motoro",
                            IATA = "GRU",
                            Name = "Aeroporto Internacional de São Paulo",
                            StateCode = "SP"
                        },
                        new
                        {
                            ICAO = "SBLO",
                            CityName = "Londrina",
                            Description = "Governador José Richa",
                            IATA = "LDB",
                            Name = "Aeroporto de Londrina",
                            StateCode = "PR"
                        },
                        new
                        {
                            ICAO = "SBPV",
                            CityName = "Porto Velho",
                            Description = "Governador Jorge Teixeira de Oliveira",
                            IATA = "PVH",
                            Name = "Aeroporto Internacional de Porto Velho",
                            StateCode = "RO"
                        },
                        new
                        {
                            ICAO = "SBRB",
                            CityName = "Rio Branco",
                            Description = "Plácido de Castro",
                            IATA = "RBR",
                            Name = "Aeroporto Internacional de Rio Branco",
                            StateCode = "AC"
                        },
                        new
                        {
                            ICAO = "SBJV",
                            CityName = "Joinville",
                            Description = "Lauro Carneiro de Loyola",
                            IATA = "JOI",
                            Name = "Aeroporto de Joinville",
                            StateCode = "SC"
                        },
                        new
                        {
                            ICAO = "SBUL",
                            CityName = "Uberlândia",
                            Description = "Ten. Cel. Av. César Bombonato",
                            IATA = "UDI",
                            Name = "Aeroporto de Uberlândia",
                            StateCode = "MG"
                        },
                        new
                        {
                            ICAO = "SBCX",
                            CityName = "Caxias do Sul",
                            Description = "Hugo Cantergiani",
                            IATA = "CXJ",
                            Name = "Aeroporto Regional de Caxias do Sul",
                            StateCode = "RS"
                        },
                        new
                        {
                            ICAO = "SBFI",
                            CityName = "Foz do Iguaçu",
                            IATA = "IGU",
                            Name = "Aeroporto Internacional de Foz do Iguaçu",
                            StateCode = "PR"
                        },
                        new
                        {
                            ICAO = "SBTE",
                            CityName = "Teresina",
                            Description = "Senador Petrônio Portella",
                            IATA = "THE",
                            Name = "Aeroporto de Teresina",
                            StateCode = "PI"
                        },
                        new
                        {
                            ICAO = "SBAR",
                            CityName = "Aracaju",
                            Description = "Santa Maria",
                            IATA = "AJU",
                            Name = "Aeroporto Internacional de Aracaju",
                            StateCode = "SE"
                        },
                        new
                        {
                            ICAO = "SBJP",
                            CityName = "João Pessoa",
                            Description = "Presidente Castro Pinto",
                            IATA = "JPA",
                            Name = "Aeroporto Internacional de João Pessoa",
                            StateCode = "PB"
                        },
                        new
                        {
                            ICAO = "SBPL",
                            CityName = "Petrolina",
                            Description = "Senador Nilo Coelho",
                            IATA = "PNZ",
                            Name = "Aeroporto de Petrolina",
                            StateCode = "PE"
                        },
                        new
                        {
                            ICAO = "SBCF",
                            CityName = "Confins",
                            Description = "Confins – Tancredo Neves",
                            IATA = "CNF",
                            Name = "Aeroporto Internacional de Minas Gerais",
                            StateCode = "MG"
                        },
                        new
                        {
                            ICAO = "SBBV",
                            CityName = "Boa Vista",
                            Description = "Atlas Brasil Cantanhede",
                            IATA = "BVB",
                            Name = "Aeroporto Internacional de Boa Vista",
                            StateCode = "RR"
                        },
                        new
                        {
                            ICAO = "SBKG",
                            CityName = "Campina Grande",
                            Description = "Presidente João Suassuna",
                            IATA = "CPV",
                            Name = "Aeroporto de Campina Grande",
                            StateCode = "PB"
                        },
                        new
                        {
                            ICAO = "SBSN",
                            CityName = "Santarém",
                            Description = "Maestro Wilson Fonseca",
                            IATA = "STM",
                            Name = "Aeroporto de Santarém",
                            StateCode = "PA"
                        },
                        new
                        {
                            ICAO = "SBIL",
                            CityName = "Ilhéus",
                            IATA = "IOS",
                            Name = "Aeroporto de Ilhéus/Bahia-Jorge Amado",
                            StateCode = "BA"
                        },
                        new
                        {
                            ICAO = "SBJU",
                            CityName = "Juazeiro do Norte",
                            Description = "Orlando Bezerra",
                            IATA = "JDO",
                            Name = "Aeroporto de Juazeiro do Norte",
                            StateCode = "CE"
                        },
                        new
                        {
                            ICAO = "SBIZ",
                            CityName = "Imperatriz",
                            Description = "Prefeito Renato Moreira",
                            IATA = "IMP",
                            Name = "Aeroporto de Imperatriz",
                            StateCode = "MA"
                        },
                        new
                        {
                            ICAO = "SBCH",
                            CityName = "Chapecó",
                            Description = "Serafin Enoss Bertaso",
                            IATA = "XAP",
                            Name = "Aeroporto de Chapecó",
                            StateCode = "SC"
                        },
                        new
                        {
                            ICAO = "SBMA",
                            CityName = "Marabá",
                            IATA = "MAB",
                            Name = "Aeroporto de Marabá",
                            StateCode = "PA"
                        },
                        new
                        {
                            ICAO = "SBCZ",
                            CityName = "Cruzeiro do Sul",
                            IATA = "CZS",
                            Name = "Aeroporto Internacional de Cruzeiro do Sul",
                            StateCode = "AC"
                        },
                        new
                        {
                            ICAO = "SBDN",
                            CityName = "Presidente Prudente",
                            IATA = "PPB",
                            Name = "Aeroporto Estadual de Presidente Prudente",
                            StateCode = "SP"
                        },
                        new
                        {
                            ICAO = "SBCB",
                            CityName = "Cabo Frio",
                            IATA = "CFB",
                            Name = "Aeroporto Internacional de Cabo Frio",
                            StateCode = "RJ"
                        },
                        new
                        {
                            ICAO = "SBFN",
                            CityName = "Fernando de Noronha",
                            IATA = "FEN",
                            Name = "Aeroporto de Fernando de Noronha",
                            StateCode = "PE"
                        },
                        new
                        {
                            ICAO = "SJTC",
                            CityName = "Bauru",
                            IATA = "JTC",
                            Name = "Aeroporto Estadual de Bauru/Arealva",
                            StateCode = "SP"
                        },
                        new
                        {
                            ICAO = "SBMK",
                            CityName = "Montes Claros",
                            IATA = "MOC",
                            Name = "Aeroporto de Montes Claros/Mário Ribeiro",
                            StateCode = "MG"
                        },
                        new
                        {
                            ICAO = "SBME",
                            CityName = "Macaé",
                            IATA = "MEA",
                            Name = "Aeroporto de Macaé",
                            StateCode = "RJ"
                        },
                        new
                        {
                            ICAO = "SBGU",
                            CityName = "Ponta Grossa",
                            IATA = "GPB",
                            Name = "Aeroporto Internacional de Ponta Grossa",
                            StateCode = "PR"
                        },
                        new
                        {
                            ICAO = "SNEN",
                            CityName = "Erechim",
                            IATA = "ERM",
                            Name = "Aeroporto de Erechim",
                            StateCode = "RS"
                        },
                        new
                        {
                            ICAO = "SDPY",
                            CityName = "Pouso Alegre",
                            IATA = "PPY",
                            Name = "Aeroporto de Pouso Alegre",
                            StateCode = "MG"
                        },
                        new
                        {
                            ICAO = "SBVG",
                            CityName = "Varginha",
                            IATA = "VAG",
                            Name = "Aeroporto de Varginha/Major-Brigadeiro Trompowsky",
                            StateCode = "MG"
                        });
                });

            modelBuilder.Entity("developChallenge.Domain.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("StateCode")
                        .HasMaxLength(2)
                        .HasColumnType("nvarchar(2)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("cityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("developChallenge.Domain.Entities.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("developChallenge.Domain.Entities.Weather", b =>
                {
                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Condition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Condition_desc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("MaxTemperature")
                        .HasColumnType("real");

                    b.Property<float>("MinTemperature")
                        .HasColumnType("real");

                    b.Property<float>("UVIndice")
                        .HasColumnType("real");

                    b.HasKey("CityId");

                    b.ToTable("Climas");
                });

            modelBuilder.Entity("developChallenge.Domain.Entities.Weather", b =>
                {
                    b.HasOne("developChallenge.Domain.Entities.City", "City")
                        .WithOne("clima")
                        .HasForeignKey("developChallenge.Domain.Entities.Weather", "CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("developChallenge.Domain.Entities.City", b =>
                {
                    b.Navigation("clima")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
