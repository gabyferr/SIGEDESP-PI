﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using api.Data;

#nullable disable

namespace api.Migrations
{
    [DbContext(typeof(SigedespDBContex))]
    partial class SigedespDBContexModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("api.Models.DespesaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("despesaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AnoEmissao")
                        .HasMaxLength(50)
                        .HasColumnType("integer")
                        .HasColumnName("anoemissao");

                    b.Property<string>("AnoMesConsumo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("anomesconsumo");

                    b.Property<DateOnly>("DataPagamento")
                        .HasColumnType("date")
                        .HasColumnName("datapagamento");

                    b.Property<DateOnly>("DataVencimento")
                        .HasColumnType("date")
                        .HasColumnName("datavencimento");

                    b.Property<int?>("FornecedorId")
                        .HasColumnType("integer");

                    b.Property<int>("IdFornecedor")
                        .HasColumnType("integer")
                        .HasColumnName("fornecedorid");

                    b.Property<int>("IdInstituicao")
                        .HasColumnType("integer")
                        .HasColumnName("instituicaoid");

                    b.Property<int>("IdOrcamento")
                        .HasColumnType("integer")
                        .HasColumnName("orcamentoid");

                    b.Property<int>("IdTipoDespesa")
                        .HasColumnType("integer")
                        .HasColumnName("tipodespesaid");

                    b.Property<int>("IdUnidadeConsumidora")
                        .HasColumnType("integer")
                        .HasColumnName("unidadeconsumidoraid");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("integer")
                        .HasColumnName("usuarioid");

                    b.Property<int?>("InstituicaoId")
                        .HasColumnType("integer");

                    b.Property<int>("MesEmissao")
                        .HasMaxLength(50)
                        .HasColumnType("integer")
                        .HasColumnName("mesemissao");

                    b.Property<string>("NumeroControle")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("numerocontrole");

                    b.Property<string>("NumeroDocumento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("numerodocumento");

                    b.Property<int?>("OrcamentoId")
                        .HasColumnType("integer");

                    b.Property<double>("QuantidadeConsumida")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("quantidadeconsumida");

                    b.Property<int>("SemestreEmissao")
                        .HasMaxLength(50)
                        .HasColumnType("integer")
                        .HasColumnName("semestreemissao");

                    b.Property<int>("Situacao")
                        .HasColumnType("integer")
                        .HasColumnName("situacao");

                    b.Property<int?>("TipoDespesaId")
                        .HasColumnType("integer");

                    b.Property<int>("TrimestreEmissao")
                        .HasMaxLength(50)
                        .HasColumnType("integer")
                        .HasColumnName("trimestreemissao");

                    b.Property<int?>("UnidadeConsumidoraId")
                        .HasColumnType("integer");

                    b.Property<int?>("UsuarioId")
                        .HasColumnType("integer");

                    b.Property<double>("ValorPago")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("valorpago");

                    b.Property<double>("ValorPrevisto")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("valorprevisto");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("InstituicaoId");

                    b.HasIndex("OrcamentoId");

                    b.HasIndex("TipoDespesaId");

                    b.HasIndex("UnidadeConsumidoraId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Despesa");
                });

            modelBuilder.Entity("api.Models.FornecedorModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("fornecedorid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("bairro");

                    b.Property<int>("Cep")
                        .HasColumnType("integer")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("cidade");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("cnpj");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("email");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("estado");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nomefantasia");

                    b.Property<int>("Numero")
                        .HasColumnType("integer")
                        .HasColumnName("numero");

                    b.Property<int>("Situacao")
                        .HasColumnType("integer")
                        .HasColumnName("situacao");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("telefone");

                    b.Property<string>("nomeRazaoSocial")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nomerazaosocial");

                    b.HasKey("Id");

                    b.ToTable("fornecedor");
                });

            modelBuilder.Entity("api.Models.InstituicaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("instituicaoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("bairro");

                    b.Property<int>("Cep")
                        .HasColumnType("integer")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("cidade");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("cnpj");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("email");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("estado");

                    b.Property<int>("IdSecretaria")
                        .HasColumnType("integer")
                        .HasColumnName("secretariaid");

                    b.Property<int>("IdTipoInstituicao")
                        .HasColumnType("integer")
                        .HasColumnName("tipoinstituicaoid");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.Property<int>("Numero")
                        .HasColumnType("integer")
                        .HasColumnName("numero");

                    b.Property<int?>("SecretariaModelId")
                        .HasColumnType("integer");

                    b.Property<int>("Situacao")
                        .HasColumnType("integer")
                        .HasColumnName("situacao");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("telefone");

                    b.Property<int?>("TipoInstituicaoModelId")
                        .HasColumnType("integer");

                    b.Property<string>("nomeRazaoSocial")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nomerazaosocial");

                    b.HasKey("Id");

                    b.HasIndex("IdSecretaria");

                    b.HasIndex("IdTipoInstituicao");

                    b.HasIndex("SecretariaModelId");

                    b.HasIndex("TipoInstituicaoModelId");

                    b.ToTable("instituicao");
                });

            modelBuilder.Entity("api.Models.OrcamentoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("orcamentoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AnoOrcamento")
                        .HasMaxLength(50)
                        .HasColumnType("integer")
                        .HasColumnName("anoorcamento");

                    b.Property<int>("IdInstituicao")
                        .HasColumnType("integer")
                        .HasColumnName("instituicaoid");

                    b.Property<int>("IdTipoDespesa")
                        .HasColumnType("integer")
                        .HasColumnName("tipodespesaid");

                    b.Property<int?>("InstituicaoModelId")
                        .HasColumnType("integer");

                    b.Property<int?>("TipoDespesaModelId")
                        .HasColumnType("integer");

                    b.Property<double>("ValorOrcamento")
                        .HasMaxLength(50)
                        .HasColumnType("double precision")
                        .HasColumnName("valororcamento");

                    b.HasKey("Id");

                    b.HasIndex("IdInstituicao");

                    b.HasIndex("IdTipoDespesa");

                    b.HasIndex("InstituicaoModelId");

                    b.HasIndex("TipoDespesaModelId");

                    b.ToTable("orcamento");
                });

            modelBuilder.Entity("api.Models.SecretariaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("secretariaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("bairro");

                    b.Property<int>("Cep")
                        .HasColumnType("integer")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("cidade");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("cnpj");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("descricao");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("email");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("estado");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nome");

                    b.Property<int>("Numero")
                        .HasColumnType("integer")
                        .HasColumnName("numero");

                    b.Property<int>("Situacao")
                        .HasColumnType("integer")
                        .HasColumnName("situacao");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("telefone");

                    b.Property<string>("nomeRazaoSocial")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nomerazaosocial");

                    b.HasKey("Id");

                    b.ToTable("secretaria");
                });

            modelBuilder.Entity("api.Models.TipoDespesaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("tipodespesaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("descricao");

                    b.Property<int>("IdUnidadeMedida")
                        .HasColumnType("integer")
                        .HasColumnName("idunidademedida");

                    b.Property<string>("SolicitaUC")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("solicitauc");

                    b.Property<int?>("UnidadeMedidaModelId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IdUnidadeMedida");

                    b.HasIndex("UnidadeMedidaModelId");

                    b.ToTable("tipodespesa");
                });

            modelBuilder.Entity("api.Models.TipoInstituicaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("tipoinstituicaoid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("descricao");

                    b.HasKey("Id");

                    b.ToTable("tipoinstituicao");
                });

            modelBuilder.Entity("api.Models.UnidadeConsumidoraModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("unidadeconsumidoraid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CodigoUC")
                        .HasColumnType("integer")
                        .HasColumnName("unidadeconsumidora");

                    b.Property<int?>("FornecedorModelId")
                        .HasColumnType("integer");

                    b.Property<int>("IdFornecedor")
                        .HasColumnType("integer")
                        .HasColumnName("fornecedorid");

                    b.Property<int>("IdInstituicao")
                        .HasColumnType("integer")
                        .HasColumnName("instituicaoid");

                    b.Property<int?>("InstituicaoModelId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorModelId");

                    b.HasIndex("IdFornecedor");

                    b.HasIndex("IdInstituicao");

                    b.HasIndex("InstituicaoModelId");

                    b.ToTable("unidadeconsumidora");
                });

            modelBuilder.Entity("api.Models.UnidadeMedidaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("unidademedidaid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Abreviatura")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("abreviatura");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("descrição");

                    b.HasKey("Id");

                    b.ToTable("unidademedida");
                });

            modelBuilder.Entity("api.Models.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("usuarioid");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("bairro");

                    b.Property<int>("CEP")
                        .HasColumnType("integer")
                        .HasColumnName("cep");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("cidade");

                    b.Property<string>("CpfCnpj")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("cpfcnpj");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("email");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("estado");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("logradouro");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("matricula");

                    b.Property<string>("NomeRazaoSocial")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("nomerazaosocial");

                    b.Property<int>("Numero")
                        .HasColumnType("integer")
                        .HasColumnName("numero");

                    b.Property<int>("RgLe")
                        .HasColumnType("integer")
                        .HasColumnName("rgle");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("senha");

                    b.Property<int>("Situacao")
                        .HasColumnType("integer")
                        .HasColumnName("situacao");

                    b.HasKey("Id");

                    b.ToTable("usuario");
                });

            modelBuilder.Entity("api.Models.DespesaModel", b =>
                {
                    b.HasOne("api.Models.FornecedorModel", "Fornecedor")
                        .WithMany("Despesa")
                        .HasForeignKey("FornecedorId");

                    b.HasOne("api.Models.InstituicaoModel", "Instituicao")
                        .WithMany("Despesa")
                        .HasForeignKey("InstituicaoId");

                    b.HasOne("api.Models.OrcamentoModel", "Orcamento")
                        .WithMany("Despesa")
                        .HasForeignKey("OrcamentoId");

                    b.HasOne("api.Models.TipoDespesaModel", "TipoDespesa")
                        .WithMany("Despesa")
                        .HasForeignKey("TipoDespesaId");

                    b.HasOne("api.Models.UnidadeConsumidoraModel", "UnidadeConsumidora")
                        .WithMany("Despesa")
                        .HasForeignKey("UnidadeConsumidoraId");

                    b.HasOne("api.Models.UsuarioModel", "Usuario")
                        .WithMany("Despesa")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Fornecedor");

                    b.Navigation("Instituicao");

                    b.Navigation("Orcamento");

                    b.Navigation("TipoDespesa");

                    b.Navigation("UnidadeConsumidora");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("api.Models.InstituicaoModel", b =>
                {
                    b.HasOne("api.Models.SecretariaModel", "Secretaria")
                        .WithMany()
                        .HasForeignKey("IdSecretaria")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.TipoInstituicaoModel", "tipoInstituicao")
                        .WithMany()
                        .HasForeignKey("IdTipoInstituicao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.SecretariaModel", null)
                        .WithMany("InstituicaoLista")
                        .HasForeignKey("SecretariaModelId");

                    b.HasOne("api.Models.TipoInstituicaoModel", null)
                        .WithMany("InstituicaoLista")
                        .HasForeignKey("TipoInstituicaoModelId");

                    b.Navigation("Secretaria");

                    b.Navigation("tipoInstituicao");
                });

            modelBuilder.Entity("api.Models.OrcamentoModel", b =>
                {
                    b.HasOne("api.Models.InstituicaoModel", "Instituicao")
                        .WithMany()
                        .HasForeignKey("IdInstituicao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.TipoDespesaModel", "TipoDespesa")
                        .WithMany()
                        .HasForeignKey("IdTipoDespesa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.InstituicaoModel", null)
                        .WithMany("Orcamento")
                        .HasForeignKey("InstituicaoModelId");

                    b.HasOne("api.Models.TipoDespesaModel", null)
                        .WithMany("Orcamento")
                        .HasForeignKey("TipoDespesaModelId");

                    b.Navigation("Instituicao");

                    b.Navigation("TipoDespesa");
                });

            modelBuilder.Entity("api.Models.TipoDespesaModel", b =>
                {
                    b.HasOne("api.Models.UnidadeMedidaModel", "UnidadeMedida")
                        .WithMany()
                        .HasForeignKey("IdUnidadeMedida")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.UnidadeMedidaModel", null)
                        .WithMany("TipoDespesa")
                        .HasForeignKey("UnidadeMedidaModelId");

                    b.Navigation("UnidadeMedida");
                });

            modelBuilder.Entity("api.Models.UnidadeConsumidoraModel", b =>
                {
                    b.HasOne("api.Models.FornecedorModel", null)
                        .WithMany("UnidadeConsumidora")
                        .HasForeignKey("FornecedorModelId");

                    b.HasOne("api.Models.FornecedorModel", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("IdFornecedor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.InstituicaoModel", "Instituicao")
                        .WithMany()
                        .HasForeignKey("IdInstituicao")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.Models.InstituicaoModel", null)
                        .WithMany("UnidadeConsumidora")
                        .HasForeignKey("InstituicaoModelId");

                    b.Navigation("Fornecedor");

                    b.Navigation("Instituicao");
                });

            modelBuilder.Entity("api.Models.FornecedorModel", b =>
                {
                    b.Navigation("Despesa");

                    b.Navigation("UnidadeConsumidora");
                });

            modelBuilder.Entity("api.Models.InstituicaoModel", b =>
                {
                    b.Navigation("Despesa");

                    b.Navigation("Orcamento");

                    b.Navigation("UnidadeConsumidora");
                });

            modelBuilder.Entity("api.Models.OrcamentoModel", b =>
                {
                    b.Navigation("Despesa");
                });

            modelBuilder.Entity("api.Models.SecretariaModel", b =>
                {
                    b.Navigation("InstituicaoLista");
                });

            modelBuilder.Entity("api.Models.TipoDespesaModel", b =>
                {
                    b.Navigation("Despesa");

                    b.Navigation("Orcamento");
                });

            modelBuilder.Entity("api.Models.TipoInstituicaoModel", b =>
                {
                    b.Navigation("InstituicaoLista");
                });

            modelBuilder.Entity("api.Models.UnidadeConsumidoraModel", b =>
                {
                    b.Navigation("Despesa");
                });

            modelBuilder.Entity("api.Models.UnidadeMedidaModel", b =>
                {
                    b.Navigation("TipoDespesa");
                });

            modelBuilder.Entity("api.Models.UsuarioModel", b =>
                {
                    b.Navigation("Despesa");
                });
#pragma warning restore 612, 618
        }
    }
}
