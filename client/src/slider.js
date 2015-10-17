import React, { Component } from 'react';
import {Slides} from './slides';

export class Slider extends Component {

  constructor () {
    super();
    this.state = {current: 0};
  }

  nextSlide () {
    this.setState({current : (this.state.current + 1) % this.props.slides.length });
  }

  componentDidMount () {
    this._timeout = setInterval(this.nextSlide.bind(this), this.props.interval);
  }

  componentWillUnmount () {
    clearInterval(this._timeout);
  }

  render () {
    return (
      <Slides current={this.state.current} slides={this.props.slides}/>
    );
  }
}