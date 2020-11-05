import { Component } from '@angular/core';
import _ from 'lodash';

@Component({
  selector: 'app-tab2',
  templateUrl: 'tab2.page.html',
  styleUrls: ['tab2.page.scss']
})
export class Tab2Page {

  doRefresh(event) {
    console.log('Begin async operation');

    setTimeout(() => {
      console.log('Async operation has ended');
      event.target.complete();
    }, 2000);
  }

    comidas: Array<{nome:string, tipo:string}>;
    allcomidas:any;
    queryText: string;

    constructor(){
      this.queryText = ' ';
      this.comidas = [
        {nome: 'tomate', tipo: 'fruta'},
        {nome: 'batata', tipo: 'tuberculo'},
        {nome: 'feijão', tipo: 'legume'},
        {nome: 'couve', tipo: 'verdura'}
      ]

      this.allcomidas = this.comidas;
    }

    filterComida(cmd: any){
      let val = cmd.target.value;
      if (val && val.trim() != ''){
        this.comidas = _.values(this.allcomidas);
        this.comidas = this.comidas.filter((comida) => {
          return (comida.nome.toLowerCase().indexOf(val.toLowerCase()) > -1);
        })
      } else {
        this.comidas = this.allcomidas;
      }
    }

  

}
