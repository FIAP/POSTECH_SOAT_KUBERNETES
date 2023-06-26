import http from 'k6/http';
import { sleep } from 'k6';

export const options = {
  vus: 10000,
  duration: '3s',
};

export default function () {
  http.get('https://net6heroku.herokuapp.com/WeatherForecast');
  sleep(1);
}