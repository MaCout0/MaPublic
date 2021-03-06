import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';

function formatDate(date){
  return date.toLocaleDateString();
}

function Comment(props){
  return (
    <div className="Comment">
      <UserInfo user={props.author} />       
        <div className="Comment-text">{props.text}</div>
        <div className="Comment-date">
          {formatDate(props.date)}
        </div>
      
    </div>
  );
}

function Avatar(props){
  return (
    <img 
    className="Avatar"
    src={props.author.avatarUrl}
    alt={props.author.name}
    />
  );
}

function UserInfo(props) {
  return (
    <Avatar user={props.author} />
    <div className="UserInfo-name">
      {props.author.name}
    </div>
  );
}

const comment = {
  date: new Date(),
  text: 'Espero que goste de aprender react',
  author: {
    name: 'Olá gatinho',
    avatarUrl: 'https://placekitten.com/g/64/64',
  },
};

ReactDOM.render(
  <Comment
    date={comment.date}
    text={comment.text}
    author={comment.author}
  />,
  document.getElementById('root')
);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();
