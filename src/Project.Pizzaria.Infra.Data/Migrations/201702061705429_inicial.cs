namespace Project.Pizzaria.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.bairro",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        Taxa = c.Double(),
                        CreateAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Id_Company = c.Guid(nullable: false),
                        Id_DeletedByUser = c.Guid(nullable: false),
                        Id_CreateByUser = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.endereco",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Id_Bairro = c.Guid(nullable: false),
                        Id_Municipio = c.Guid(nullable: false),
                        Id_Conta = c.Guid(nullable: false),
                        Id_Uf = c.Guid(nullable: false),
                        Rua = c.String(nullable: false, maxLength: 300),
                        Numero = c.Int(nullable: false),
                        Telefone1 = c.String(nullable: false, maxLength: 20),
                        Telefone2 = c.String(maxLength: 20),
                        Complemento = c.String(maxLength: 300),
                        CreateAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Id_Company = c.Guid(nullable: false),
                        Id_DeletedByUser = c.Guid(nullable: false),
                        Id_CreateByUser = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.bairro", t => t.Id_Bairro)
                .ForeignKey("dbo.conta", t => t.Id_Conta)
                .ForeignKey("dbo.municipio", t => t.Id_Municipio)
                .ForeignKey("dbo.uf", t => t.Id_Uf)
                .Index(t => t.Id_Bairro)
                .Index(t => t.Id_Municipio)
                .Index(t => t.Id_Conta)
                .Index(t => t.Id_Uf);
            
            CreateTable(
                "dbo.conta",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Id_endereco = c.Guid(nullable: false),
                        Id_Conta_Tipo = c.Guid(nullable: false),
                        Aniversario = c.DateTime(),
                        Email = c.String(maxLength: 100),
                        CreateAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Id_Company = c.Guid(nullable: false),
                        Id_DeletedByUser = c.Guid(nullable: false),
                        Id_CreateByUser = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.conta_tipo", t => t.Id_Conta_Tipo)
                .Index(t => t.Id_Conta_Tipo);
            
            CreateTable(
                "dbo.conta_tipo",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        IsCompany = c.Boolean(nullable: false),
                        IsUser = c.Boolean(nullable: false),
                        CreateAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Id_Company = c.Guid(nullable: false),
                        Id_DeletedByUser = c.Guid(nullable: false),
                        Id_CreateByUser = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.municipio",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 50),
                        CreateAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Id_Company = c.Guid(nullable: false),
                        Id_DeletedByUser = c.Guid(nullable: false),
                        Id_CreateByUser = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.uf",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 2, fixedLength: true),
                        CreateAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Id_Company = c.Guid(nullable: false),
                        Id_DeletedByUser = c.Guid(nullable: false),
                        Id_CreateByUser = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.produto_tipo",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        CreateAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Id_Company = c.Guid(nullable: false),
                        Id_DeletedByUser = c.Guid(nullable: false),
                        Id_CreateByUser = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.produto",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Id_produto_tipo = c.Guid(nullable: false),
                        Descricao = c.String(nullable: false, maxLength: 100),
                        Codigo = c.Int(nullable: false),
                        Observacoes = c.String(maxLength: 300),
                        ImagemUri = c.String(maxLength: 1000),
                        BaixaEstoque = c.Boolean(nullable: false),
                        VenderSemEstoque = c.Boolean(nullable: false),
                        Saldo = c.Double(nullable: false),
                        CreateAt = c.DateTime(nullable: false),
                        DeletedAt = c.DateTime(nullable: false),
                        Active = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        Id_Company = c.Guid(nullable: false),
                        Id_DeletedByUser = c.Guid(nullable: false),
                        Id_CreateByUser = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.produto_tipo", t => t.Id_produto_tipo)
                .Index(t => t.Id_produto_tipo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.produto", "Id_produto_tipo", "dbo.produto_tipo");
            DropForeignKey("dbo.endereco", "Id_Uf", "dbo.uf");
            DropForeignKey("dbo.endereco", "Id_Municipio", "dbo.municipio");
            DropForeignKey("dbo.endereco", "Id_Conta", "dbo.conta");
            DropForeignKey("dbo.conta", "Id_Conta_Tipo", "dbo.conta_tipo");
            DropForeignKey("dbo.endereco", "Id_Bairro", "dbo.bairro");
            DropIndex("dbo.produto", new[] { "Id_produto_tipo" });
            DropIndex("dbo.conta", new[] { "Id_Conta_Tipo" });
            DropIndex("dbo.endereco", new[] { "Id_Uf" });
            DropIndex("dbo.endereco", new[] { "Id_Conta" });
            DropIndex("dbo.endereco", new[] { "Id_Municipio" });
            DropIndex("dbo.endereco", new[] { "Id_Bairro" });
            DropTable("dbo.produto");
            DropTable("dbo.produto_tipo");
            DropTable("dbo.uf");
            DropTable("dbo.municipio");
            DropTable("dbo.conta_tipo");
            DropTable("dbo.conta");
            DropTable("dbo.endereco");
            DropTable("dbo.bairro");
        }
    }
}
