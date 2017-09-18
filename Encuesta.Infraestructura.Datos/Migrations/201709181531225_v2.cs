namespace Encuesta.Infraestructura.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
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
                        ClaveUsuario = c.String(),
                        estadoUsuario = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.ID_USUARIO);
            
            CreateTable(
                "ENCUESTA.OPCIONES",
                c => new
                    {
                        ID_OPCION = c.Int(nullable: false, identity: true),
                        CON_OPCION = c.String(nullable: false, maxLength: 200),
                        idPregunta = c.Int(nullable: false),
                        Pregunta_idPregunta = c.Int(),
                    })
                .PrimaryKey(t => t.ID_OPCION)
                .ForeignKey("ENCUESTA.PREGUNTAS", t => t.Pregunta_idPregunta)
                .ForeignKey("ENCUESTA.PREGUNTAS", t => t.idPregunta, cascadeDelete: true)
                .Index(t => t.idPregunta)
                .Index(t => t.Pregunta_idPregunta);
            
            CreateTable(
                "ENCUESTA.PREGUNTAS",
                c => new
                    {
                        ID_PREGUNTA = c.Int(nullable: false, identity: true),
                        CON_PREGUNTA = c.String(nullable: false, maxLength: 100),
                        TIPO_PREGUNTA = c.String(nullable: false, maxLength: 11),
                        IDOPNCION_PREGUNTA = c.Int(nullable: false),
                        idDetalleEncuesta = c.Int(nullable: false),
                        DetalleEncuesta_idDetalleEncuesta = c.Int(),
                    })
                .PrimaryKey(t => t.ID_PREGUNTA)
                .ForeignKey("ENCUESTA.DET_ENCUESTAS", t => t.DetalleEncuesta_idDetalleEncuesta)
                .ForeignKey("ENCUESTA.DET_ENCUESTAS", t => t.idDetalleEncuesta, cascadeDelete: true)
                .Index(t => t.idDetalleEncuesta)
                .Index(t => t.DetalleEncuesta_idDetalleEncuesta);
            
            CreateTable(
                "ENCUESTA.DET_ENCUESTAS",
                c => new
                    {
                        ID_DETALLE_ENCUESTA = c.Int(nullable: false, identity: true),
                        RESPUESTA_PREGUNTA_DETALLE_ENCUESTA = c.String(nullable: false, maxLength: 200),
                        ID_ENCUESTA = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID_DETALLE_ENCUESTA)
                .ForeignKey("ENCUESTA.ENCUESTAS", t => t.ID_ENCUESTA, cascadeDelete: true)
                .Index(t => t.ID_ENCUESTA);
            
        }
        
        public override void Down()
        {
            DropForeignKey("ENCUESTA.OPCIONES", "idPregunta", "ENCUESTA.PREGUNTAS");
            DropForeignKey("ENCUESTA.OPCIONES", "Pregunta_idPregunta", "ENCUESTA.PREGUNTAS");
            DropForeignKey("ENCUESTA.PREGUNTAS", "idDetalleEncuesta", "ENCUESTA.DET_ENCUESTAS");
            DropForeignKey("ENCUESTA.PREGUNTAS", "DetalleEncuesta_idDetalleEncuesta", "ENCUESTA.DET_ENCUESTAS");
            DropForeignKey("ENCUESTA.DET_ENCUESTAS", "ID_ENCUESTA", "ENCUESTA.ENCUESTAS");
            DropForeignKey("ENCUESTA.ENCUESTAS", "ID_USUARIO", "ENCUESTA.USUARIOS");
            DropForeignKey("ENCUESTA.ENCUESTAS", "ID_EMPRESA", "ENCUESTA.EMPRESAS");
            DropIndex("ENCUESTA.DET_ENCUESTAS", new[] { "ID_ENCUESTA" });
            DropIndex("ENCUESTA.PREGUNTAS", new[] { "DetalleEncuesta_idDetalleEncuesta" });
            DropIndex("ENCUESTA.PREGUNTAS", new[] { "idDetalleEncuesta" });
            DropIndex("ENCUESTA.OPCIONES", new[] { "Pregunta_idPregunta" });
            DropIndex("ENCUESTA.OPCIONES", new[] { "idPregunta" });
            DropIndex("ENCUESTA.ENCUESTAS", new[] { "ID_USUARIO" });
            DropIndex("ENCUESTA.ENCUESTAS", new[] { "ID_EMPRESA" });
            DropTable("ENCUESTA.DET_ENCUESTAS");
            DropTable("ENCUESTA.PREGUNTAS");
            DropTable("ENCUESTA.OPCIONES");
            DropTable("ENCUESTA.USUARIOS");
            DropTable("ENCUESTA.ENCUESTAS");
            DropTable("ENCUESTA.EMPRESAS");
        }
    }
}
