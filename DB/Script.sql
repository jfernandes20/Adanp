CREATE TABLE Caracteristica
(
    Id                    INTEGER PRIMARY KEY AUTOINCREMENT,
    CaracteristicaNumero  INTEGER,      
    CaracteristicaNome    VARCHAR(100),
    
    CONSTRAINT UQ_UniqueNumero UNIQUE (CaracteristicaNumero)
);


CREATE TABLE SubCaracteristica
(
    Id                      INTEGER PRIMARY KEY AUTOINCREMENT,
    CaracteristicaId        INTEGER,  
    SubCaracteristicaNome   VARCHAR(100),
    
    CONSTRAINT FK_SubCaracteristica_Caracteristica FOREIGN KEY (CaracteristicaId) REFERENCES Caracteristica (Id)
);


INSERT INTO Caracteristica (CaracteristicaNumero, CaracteristicaNome) VALUES 
(1,'Funcionalidade'),
(2,'Confiabilidade'),
(3,'Usabilidade'),
(4,'Eficiência'),
(5,'Manutenibilidade'),
(6,'Portabilidade');


INSERT INTO SubCaracteristica (CaracteristicaId, SubCaracteristicaNome) VALUES
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 1), 'Adequação'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 1), 'Acurácia'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 1), 'Interoperabilidade'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 1), 'Conformidade'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 1), 'Segurança de acesso'),

((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 2), 'Maturidade'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 2), 'Tolerância a falhas'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 2), 'Recuperabilidade'),

((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 3), 'Inteligibilidade'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 3), 'Apreensibilidade'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 3), 'Operacionalidade'),

((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 4), 'Tempo'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 4), 'Recursos'),

((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 5), 'Analisabilidade'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 5), 'Modificabilidade'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 5), 'Estabilidade'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 5), 'Testabilidade'),

((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 6), 'Adaptabilidade'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 6), 'Capacidade para ser instalado'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 6), 'Conformidade'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 6), 'Capacidade para substituir');

CREATE TABLE Questao
(
    Id                      INTEGER PRIMARY KEY AUTOINCREMENT,
    SubCaracteristicaId     INTEGER,
    TextoQuestao            VARCHAR(1000),
    
    CONSTRAINT FK_Questoes_SubCaracteristica FOREIGN KEY (SubCaracteristicaId) REFERENCES SubCaracteristica (Id)
);

CREATE TABLE Software
(
    Id                      INTEGER PRIMARY KEY AUTOINCREMENT,
    NomeSoftware            VARCHAR(100),
    TecnologiaSoftware      VARCHAR(100),
    FornecedorSoftware      VARCHAR(100),
    DataInsercao            DATETIME
);

CREATE TABLE Avaliacao
(
    Id                     INTEGER PRIMARY KEY AUTOINCREMENT,
    SoftwareId             INTEGER,
    DataAvaliacao          DATETIME,
    NomeAvaliador             VARCHAR(100),
    
    CONSTRAINT FK_Avaliacao_Software FOREIGN KEY (SoftwareId) REFERENCES Software (Id)
);

CREATE TABLE NotaAvaliacao
(
    Id                     INTEGER PRIMARY KEY AUTOINCREMENT,
    AvaliacaoId            INTEGER,
    QuestaoId              INTEGER,
    Nota                   INTEGER,
    
    CONSTRAINT FK_NotaAvaliacao_Avaliacao FOREIGN KEY (AvaliacaoId) REFERENCES Avaliacao (Id) ON DELETE CASCADE,
    CONSTRAINT FK_NotaAvaliacao_Questao FOREIGN KEY (QuestaoId) REFERENCES Questao (Id)
);

--Resetar autoIncrement
--delete from sqlite_sequence where name='Avaliacao';
select * from SubCaracteristica;
