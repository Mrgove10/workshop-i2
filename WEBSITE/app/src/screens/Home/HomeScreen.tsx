import React from 'react'
import PropTypes from 'prop-types'
import './style.css'

function HomeScreen(props: any) {
    return (
        <div className="container">
            <div className="iframeContainer">
                <iframe
                    height="400"
                    width="2"
                    src="https://www.youtube.com/embed/G1IbRujko-A"
                    title="YouTube video player"
                    frameBorder="0"
                    allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
                    allowFullScreen>
                </iframe>
            </div>
        </div>
    )
}

HomeScreen.propTypes = {

}

export default HomeScreen