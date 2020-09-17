import React from 'react';

import whatsappIcon from '../../assets/images/icons/whatsapp.svg';

import './style.css'

function TeacherItem() {
    return (
        <article className="teacher-item">
            <header>
                <img src="https://lh3.googleusercontent.com/ogw/ADGmqu-NtjAmX-n0BAKxQi1fzq_SoHtPTP5LiyRH70TI=s192-c-mo" alt="Nome" />
                <div>
                    <strong>Diego Fernandes</strong>
                    <span>Química</span>
                </div>
            </header>
            <p>
                Entusiasta das melhores tecnologias
                <br /><br />
                Apaixonado por explodir
            </p>
            <footer>
                <p>
                    Preço/hora
                    <strong>R$ 80,00</strong>
                </p>
                <button type="button">
                    <img src={whatsappIcon} alt="Whatsapp" />
                    Entrar em contato
                </button>
            </footer>
        </article>
    )
}

export default TeacherItem