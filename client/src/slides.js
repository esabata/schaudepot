import React, { Component } from 'react';
import { Template } from './template';

export class Slides extends Component {
  render () {
    var offset= '-' + (this.props.current * 100) + '%';

    return (
      <div className="slides"
           style={{marginLeft: offset}}>
        {this.props.slides.map((slide, i) => <Template className="slide" key={i} {...slide}/>)}
      </div>
    );
  }
}