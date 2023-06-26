import http from 'k6/http';
import { sleep } from 'k6';

//10 vus usuarios
//30 duration segundos de duração

export const options = {
   vus: 100,
   duration: '30s',
};


export default function() {
   http.get('http://localhost:8080/');
   sleep(1);
}
