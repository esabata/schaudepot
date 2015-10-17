import React, { Component } from 'react';
import { Slider } from './slider';

export class ClientApp extends Component {
  constructor () {
    super();
    this.state = {slides: [
      {
        template: '<h1><%= title %></h1>',
        data: {title: 'slide1'}
      },
      {
        template: '<h1><%= title %></h1>',
        data: {title: 'slide2'}
      },
      {
        template: '<h1><%= title %></h1>',
        data: {title: 'slide3'}
      }
    ]};
  }

  render () {
    return (
      <Slider interval={1000} slides={this.state.slides}/>
    );
  }
}