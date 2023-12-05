using ObserverWeatherTvs.Elements;

WeatherStation weatherStation = new WeatherStation();
Tv1 tv1 = new Tv1();
Tv2 tv2 = new Tv2();

weatherStation.RegisterObserver(tv1);
weatherStation.RegisterObserver(tv2);

weatherStation.SetMeasurements(80, 65, 30.4f);
weatherStation.SetMeasurements(82, 45, 33.2f);
weatherStation.SetMeasurements(83, 48, 35.2f);