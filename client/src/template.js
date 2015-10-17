import React, { Component } from 'react';
import _ from 'lodash';

export class Template extends Component {
  render () {
    var template = _.template(this.props.template);
    var data = this.props.data;

    return (
      <div className={this.props.className}
           dangerouslySetInnerHTML={{__html: template(data)}}/>
    );
  }
}