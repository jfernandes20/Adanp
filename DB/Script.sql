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
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 1), 'Segurança de Acesso'),

((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 2), 'Maturidade'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 2), 'Tolerância a Falhas'),
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
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 6), 'Capacidade para ser Instalado'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 6), 'Conformidade'),
((SELECT Id FROM Caracteristica WHERE CaracteristicaNumero = 6), 'Capacidade para Substituir');

CREATE TABLE Questoes
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


--Resetar autoIncrement
--delete from sqlite_sequence where name='Questoes';