import React from 'react'
import PropTypes from 'prop-types'
import './style.css'
import logo from "../../assets/logo.png"
import cloud from "../../assets/cloud.png"
import marco from "../../assets/marco-corps.png"
import romain from "../../assets/romain-corps.png"
import cheatSheet from "../../assets/cheat_sheet.png"

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
            <div className="seriousGameTitleContainer">
                <h1 className="seriousGameTitle">CHEAT SHEET</h1>
            </div>
            <div className="seriousGameTitleContainer">
                <img
                    src={cheatSheet}
                />
            </div>
            <div className="cheetSheetContainer">
                <p>
                    <strong>Informatique quantique</strong> : permet de résoudre des calculs à une vitesse fulgurante grâce à des Qubit
                </p>
                <p>
                    <strong>Bit</strong> : chiffre binaire qui peut prendre la valeur de 0 ou 1
                </p>
                <p>
                    <strong>Qubit</strong> : peut prendre la valeur 0, 1 ou une superposition quantique de 0 et de 1
                </p>
                <p>
                    <strong>Ordinateur quantique</strong> : peut résoudre des calculs à une vitesse fulgurante à l’aide de Qubit alors que pour un ordinateur classique, cela pourrait prendre plusieurs fois l'âge de la terre.
                </p>
                <p>
                    <strong>Cybersécurité</strong> : assurer la sécurité des systèmes et des données informatiques
                </p>
                <p>
                    <strong>Cryptographie</strong> : permet de protéger des messages (assurant confidentialité, authenticité et intégrité) en s'aidant souvent de secrets ou clés.
                </p>
                <p>
                    <strong>Chiffrement asymétrique</strong> : procédé qui intègre deux clés de chiffrement, une clé publique et une clé privée
                </p>
                <p>
                    <strong>Sphère de Bloch</strong> : représentation géométrique d'un état pur d'un système quantique à deux niveaux ; c'est donc une représentation d'un qubit.
                </p>
            </div>
        </div>
    )
}

HomeScreen.propTypes = {

}

export default HomeScreen