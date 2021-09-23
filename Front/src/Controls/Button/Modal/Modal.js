import "./Modal.css";
import React from "react";
import PropTypes from 'prop-types';

 class Modal extends React.Component {

    render(){
        if(!this.props.show) {
            return null;
        }

        return (
          <div className="modal-backdrop">
            <div className="modal-content">
              {this.props.children}
      
              <div className="modal-footer">
                <button onClick={this.props.onClose}>
                  Close
                </button>
              </div>
            </div>
          </div>
        );
    }
}

Modal.propTypes = {
    onClose: PropTypes.func.isRequired,
    show: PropTypes.bool,
    children: PropTypes.node
};

export default Modal;