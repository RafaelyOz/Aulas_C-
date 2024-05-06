//utilizei o chat para me ajudar na lógica.

iReserva reserva1 = new ReservaVooRegular();
reserva1.ReservarVoo();
Console.WriteLine(reserva1.VerificarStatusReserva());
reserva1.CancelarReserva();

Console.WriteLine("");

iReserva reserva2 = new ReservaVooComUpgrade();
reserva2.ReservarVoo();
Console.WriteLine(reserva2.VerificarStatusReserva());
reserva2.CancelarReserva();

Console.WriteLine();

iReserva reserva3 = new ReservaVooGrupoGrande();
reserva3.ReservarVoo();
Console.WriteLine(reserva3.VerificarStatusReserva());
reserva3.CancelarReserva();