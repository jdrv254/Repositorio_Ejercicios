using Tennis;

Jugador player_1 = new Jugador();
player_1.nombre = "Nadal";
player_1.nacionalidad = "Español";
player_1.manoH = true;

Jugador player_2 = new Jugador();
player_2.nombre = "Federer";
player_2.nacionalidad = "Suizo";
player_2.manoH = false;

Torneo torneo = new Torneo("Torneo 1",999);
torneo.AgregarJugador(player_1);
torneo.AgregarJugador(player_2);

torneo.JugarPartido();