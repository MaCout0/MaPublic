import { Component } from '@angular/core';
import { AlertController } from '@ionic/angular';

@Component({
  selector: 'app-tab3',
  templateUrl: 'tab3.page.html',
  styleUrls: ['tab3.page.scss']
})
export class Tab3Page {

  constructor(
    private alertCtrl: AlertController
  ) {}

  async showAlert(){
    const meuAlert = await this.alertCtrl.create({
      header : 'Aviso',
      subHeader: 'Responda rápido',
      message: 'O alert funciona?',

      buttons: [
        {
          text: 'Sim'
        },
        {
          text: 'Não'
        }
      ]
    });

    meuAlert.present();
  }

  doRefresh(event) {
    console.log('Begin async operation');

    setTimeout(() => {
      console.log('Async operation has ended');
      event.target.complete();
    }, 2000);
  }

}
