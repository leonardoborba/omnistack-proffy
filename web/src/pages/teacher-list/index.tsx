import React from 'react';
import { Link } from 'react-router-dom';

import PageHeader from '../../components/page-header';

import './style.css'

function TeacherList() {
    return (
        <div id="page-teacher-list" className="container">
            <PageHeader title="Estes são os proffys disponíveis">
                <form id="search-teachers" action="">
                    <div className="input-block">
                        <label htmlFor="subject">Matéria</label>
                        <input type="text" id="subject"/>
                    </div>
                    <div className="input-block">
                        <label htmlFor="wek-day">Dia da semana</label>
                        <input type="text" id="wek-day"/>
                    </div>
                    <div className="input-block">
                        <label htmlFor="time">Horario</label>
                        <input type="text" id="time"/>
                    </div>
                </form>
            </PageHeader>
        </div>
    )
}

export default TeacherList;