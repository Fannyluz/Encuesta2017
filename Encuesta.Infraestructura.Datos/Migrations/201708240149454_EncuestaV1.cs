namespace Encuesta.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EncuestaV1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ENCUESTA.EMPRESAS",
                c => new
                    {
                        ID_EMPRESA = c.Int(nullable: false, identity: true),
                        NOM_EMPRESA = c.String(nullable: false, maxLength: 30),
                        DIR_EMPRESA = c.String(maxLength: 50),
                        TEL_EMPRESA = c.String(maxLength: 10),
                        RUC_EMPRESA = c.String(nullable: false, maxLength: 11),
                    })
                .PrimaryKey(t => t.ID_EMPRESA);

            
            CreateTable(
                "ENCUESTA.ENCUESTAS",
                c => new
                    {
                        ID_ENCUESTA = c.Int(nullable: false, identity: true),
                        DES_ENCUESTA = c.String(nullable: false, maxLength: 50),
                        ID_EMPRESA = c.Int(nullable: false),
                        FEC_ENCUESTA = c.DateTime(nullable: false),
                        TIPO_ENCUESTA = c.String(nullable: false, maxLength: 20),
                        EST_ENCUESTA = c.Byte(nullable: false),
                        ID_USUARIO = c.Int(nullable: false),

                      

                    })
                .PrimaryKey(t => t.ID_ENCUESTA)
                .ForeignKey("ENCUESTA.EMPRESAS", t => t.ID_EMPRESA, cascadeDelete: true)
                .ForeignKey("ENCUESTA.USUARIOS", t => t.ID_USUARIO, cascadeDelete: true)
                .Index(t => t.ID_EMPRESA)
                .Index(t => t.ID_USUARIO);

            
            CreateTable(
                "ENCUESTA.USUARIOS",
                c => new
                    {
                        ID_USUARIO = c.Int(nullable: false, identity: true),
                        NOM_USUARIO = c.String(nullable: false, maxLength: 30),
                        APE_USUARIO = c.String(nullable: false, maxLength: 30),
                        TEL_USUARIO = c.String(maxLength: 10),
                        DIR_USUARIO = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID_USUARIO);

            createTable(
                "ENCUESTA.DETALLE_ENCUESTA",
                C => new 
                {
        
                    

                         ID_DETALLE_ENCUESTA = c.Int(nullable: false, identity: true),
                        RESPUESTA_PREGUNTA = c.String(nullable: false, maxLength: 30),
                        ID_ENCUESTA =  c.Int(nullable: false),
                        ID_PREGUNTA =  c.Int(nullable: false),
                 } )
            .PrimaryKey(t => t.ID_DETALLE_ENCUESTA)
                .ForeignKey("ENCUESTA.ENCUESTA", t => t.ID_ENCUESTA, cascadeDelete: true)
                .ForeignKey("ENCUESTA.PREGUNTA", t => t.ID_PREGUNTA, cascadeDelete: true)
                .Index(t => t.ID_ENCUESTA)
                .Index(t => t.ID_PREGUNTA);


        }
        
        public override void Down()
        {
            DropForeignKey("ENCUESTA.ENCUESTAS", "ID_USUARIO", "ENCUESTA.USUARIOS");
            DropForeignKey("ENCUESTA.ENCUESTAS", "ID_EMPRESA", "ENCUESTA.EMPRESAS");
            DropIndex("ENCUESTA.ENCUESTAS", new[] { "ID_USUARIO" });
            DropIndex("ENCUESTA.ENCUESTAS", new[] { "ID_EMPRESA" });
            DropTable("ENCUESTA.USUARIOS");
            DropTable("ENCUESTA.ENCUESTAS");
            DropTable("ENCUESTA.EMPRESAS");
        }
    }
}
