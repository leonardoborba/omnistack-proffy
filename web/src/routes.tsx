import React from 'react';
import { BrowserRouter, Route } from 'react-router-dom';

import Landing from './pages/landing';
import TeacherForm from './pages/teacher-form';
import TeacherList from './pages/teacher-list';

function Routes() {
    return (
        <BrowserRouter>
            <Route path="/" component={Landing} exact />
            <Route path="/study" component={TeacherList} />
            <Route path="/give-classes" component={TeacherForm} />
        </BrowserRouter>
    )
}

export default Routes;