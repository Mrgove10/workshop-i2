import React from 'react'
import PropTypes from 'prop-types'
import './style.css'
import logo from "../../assets/logo.png"
import cloud from "../../assets/cloud.png"
import marco from "../../assets/marco-corps.png"
import romain from "../../assets/romain-corps.png"

function HomeScreen(props: any) {
    return (
        <div className="container">
            <div className="titleContainer">
                <div className="cloudContainer">
                    <img
                        src={cloud}
                        width="500"
                    />
                </div>
                <div className="logoContainer">
                    <img
                        src={logo}
                        width="400"
                    />
                </div>
            </div>
            <div className="boysContainer">
                <img
                    src={marco}
                    width="300"
                />
                <div className="iframeVideoContainer">
                    <iframe className="iframeVideo"
                        src="https://www.youtube.com/embed/3DJAwvLZp9Q"
                        frameBorder="0"
                        allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture"
                        allowFullScreen>
                    </iframe>
                </div>
                <img
                    src={romain}
                    width="300"
                />
            </div>
            <div className="seriousGameTitleContainer">
                <h1 className="seriousGameTitle">SERIOUS GAME</h1>
            </div>
            <div className="iframeGameContainer">
                <iframe className="iframeGame"
                    src="https://eclisson.duckdns.org/static/"
                    scrolling="no">
                </iframe>
            </div>
        </div>
    )
}

HomeScreen.propTypes = {

}

export default HomeScreen