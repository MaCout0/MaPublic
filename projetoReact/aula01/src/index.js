import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import App from './App';
import * as serviceWorker from './serviceWorker';
import './mysass.scss';

class Header extends React.Component {
        render() {
            const style = {
                color: 'green',
                backgroundColor: 'DodgerBlue',
                padding: '10px',
                fontSize1: '30px'
            }

            return (
                <div>
                    <h1 style={{color: "red", backgroundColor: "blue"}}>Meu css inline</h1>

                    <p style={style}>Meu css interno</p>

                    <p className="teste">Meu css externo: teste</p>

                    <span> Tests SCSS</span>
                </div>
            );
        }
    }

ReactDOM.render(
    <Header />,
     document.getElementById('root')
);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();