CREATE TABLE IF NOT EXISTS `okprojetos`.`Ord_Recebimento` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `numero_de_NF` VARCHAR(45) NULL DEFAULT NULL,
  `status` VARCHAR(45) NULL DEFAULT NULL,
  `data_de_recebimento` DATETIME NULL DEFAULT NULL,
  `data_de_criacao` DATETIME NULL DEFAULT NULL,
  `ultima_modificacao` DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 21
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

CREATE TABLE IF NOT EXISTS `okprojetos`.`Ord_Servicos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `numero_de_PO` VARCHAR(45) NULL DEFAULT NULL,
  `nome_operadora` VARCHAR(45) NULL DEFAULT NULL,
  `descricao_de_PO` VARCHAR(45) NULL DEFAULT NULL,
  `fase_atual` VARCHAR(45) NULL DEFAULT NULL,
  `data_de_criacao` DATETIME NULL DEFAULT NULL,
  `ultima_modificacao` DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 19
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;

CREATE TABLE IF NOT EXISTS `okprojetos`.`Itn_Serv_Rec` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `id_OrdServ` INT NULL DEFAULT NULL,
  `id_OrdRec` INT NULL DEFAULT NULL,
  `descricao` VARCHAR(45) NULL DEFAULT NULL,
  `valor` DOUBLE NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `idOrd_Serv_idx` (`id_OrdServ` ASC) VISIBLE,
  INDEX `id_idx` (`id_OrdRec` ASC) VISIBLE,
  CONSTRAINT `id_OrdRec`
    FOREIGN KEY (`id_OrdRec`)
    REFERENCES `okprojetos`.`Ord_Recebimento` (`id`),
  CONSTRAINT `id_OrdServ`
    FOREIGN KEY (`id_OrdServ`)
    REFERENCES `okprojetos`.`Ord_Servicos` (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 21
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;