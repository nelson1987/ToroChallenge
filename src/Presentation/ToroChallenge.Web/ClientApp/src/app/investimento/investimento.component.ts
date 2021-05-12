import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-investimento',
  templateUrl: './investimento.component.html'
})
export class InvestimentoComponent {
  public investimentos: Investimento[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Investimento[]>(baseUrl + 'investimento').subscribe(result => {
      console.log("aqui", baseUrl + 'investimento');
      this.investimentos = result;
    }, error => console.error(error));
  };

  //comprar(id: number, quantidade: number)
  //{
  //  console.log("id ", id);
  //  console.log("quantidade ", quantidade);
  //}
}

interface Investimento {
  id: number;
  nome: string;
  valor: number;
  urlComprar: string;
  urlVender: string;
}
