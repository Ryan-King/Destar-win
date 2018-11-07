﻿import * as React from 'react';
import { Route, Switch, Redirect } from 'react-router-dom';
import { Layout, Home } from './components/index';
import { League, Leagues } from './components/Leagues/index';
import { WebAuthentication } from './auth/WebAuthentication';

const auth = new WebAuthentication();

export const routes = <Layout auth={auth}>
    <Switch>
        <Route exact path="/" component={Home} />
        <Route path='/leagues/' component={Leagues} />
        <Route path='/leagues/:leagueName' component={League} />
        <Route path="/callback" render={() => {
            if (/access_token|id_token|error/.test(location.hash))
                auth.handleAuthentication();
            localStorage.setItem('expires_at', '9999999999999'); // optimistic login success, will be overwritten
            return <Redirect to="/" />; // should probably just wait before calling this but.. ¯\_(ツ)_/¯
        }} />
    </Switch>
</Layout>;
