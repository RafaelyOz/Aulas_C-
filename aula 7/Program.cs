pedagio Ped_Curitiba = new pedagio();
Ped_Curitiba.preco_eixo = 5.00;
passeio Santana = new passeio();
Santana.combustivel = "Gasolina";
Santana.eixos = 2;
Ped_Curitiba.CobrarPedagio(Santana);

motocicleta mobilete = new motocicleta();
mobilete.cilindrada = "50";
Ped_Curitiba.CobrarPedagio(mobilete);

Caminhao Scania = new Caminhao();
Scania.eixos = 10;
Scania.carga_risco = false;
Scania.TipodeCarga = "Gado";
Ped_Curitiba.CobrarPedagio(Scania);
