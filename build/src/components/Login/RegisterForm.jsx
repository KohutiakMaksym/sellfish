import React, {useRef, useState} from 'react';
import "../componentsStyles.scss";
import "../buttons/buttonsStyles.scss";
import store from "../../services/AuthService";
//import axios from "axios";

const RegisterForm = () => {
    //const {setAuth} = useContext(AuthContext);
    const userRef = useRef();
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    return (
        <section>
            <h2 className="login__title">Sign up</h2>
            <form className="loginForm">
                <label htmlFor="username"></label>
                <input
                    type="email"
                    id="username"
                    placeholder="Email"
                    className={`login__inp`}
                    ref={userRef}
                    autoComplete="on"
                    onChange={(e) => setEmail(e.target.value)}
                    value={email}
                    required
                />
                <label htmlFor="password"></label>
                <input
                    type="password"
                    id="password"
                    placeholder="Password"
                    className={`login__inp`}
                    onChange={(e) => setPassword(e.target.value)}
                    value={password}
                    required
                />
                <button
                    className="blueButton login__blueButton"
                    onClick={() => store.registration(email, password)}
                >Sign up</button>
            </form>
        </section>
    )
}

export default RegisterForm;
/*
class Form extends Component {
    constructor (props) {
        super(props);
        this.state = {
            email: '',
            password: '',
            formErrors: {email: '', password: ''},
            emailValid: false,
            passwordValid: false,
            formValid: false
        }
    }

    handleUserInput = (e) => {
        const name = e.target.name;
        const value = e.target.value;
        this.setState({[name]: value},
            () => { this.validateField(name, value) });
    }

    validateField(fieldName, value) {
        let fieldValidationErrors = this.state.formErrors;
        let emailValid = this.state.emailValid;
        let passwordValid = this.state.passwordValid;

        switch(fieldName) {
            case 'email':
                emailValid = value.match(/^([\w.%+-]+)@([\w-]+\.)+([\w]{2,})$/i);
                fieldValidationErrors.email = emailValid ? '' : ' is invalid';
                break;
            case 'password':
                passwordValid = value.length >= 6;
                fieldValidationErrors.password = passwordValid ? '': ' is too short';
                break;
            default:
                break;
        }
        this.setState({formErrors: fieldValidationErrors,
            emailValid: emailValid,
            passwordValid: passwordValid
        }, this.validateForm);
    }

    validateForm() {
        this.setState({formValid: this.state.emailValid && this.state.passwordValid});
    }

    errorClass(error) {
        return(error.length === 0 ? '' : 'has-error');
    }

    handleSubmit(e){
        //const [ success, setSuccess ] = useState();
        e.preventDefault();
        const name = e.target.name;
        const value = e.target.value;
        let mail = "";
        let pass = "";
        switch(name) {
            case 'email':
                mail = value;
                break;
            case 'password':
                pass = value;
                break;
            default:
                break;
        }
        //setSuccess(true);

        //sent to check
        const [data, setData] = useState();
        console.log(Check(mail,pass,data,setData));
        /!*axios.post('/user',{
            name: mail,
            password: pass
        })
            .then(res=>{
                console.log(res.data)
            })
        *!/
    }

    render () {
        return (
            <>
                {0 ? (
                    <section>
                        <h1>You are logged in!</h1>
                        <br />
                        <CustomLink to="/loginPage">Go to Home</CustomLink>
                    </section>
                ) : (
                    <form className="loginForm" onSubmit={this.handleSubmit}>
                        <h2 className="login__title">Log In</h2>
                        {/!*<div className="panel panel-default">
                        <FormErrors formErrors={this.state.formErrors} />
                    </div>*!/}
                        <div className={`form-group`}>
                            <label htmlFor="email"></label>
                            <input id="email"
                                   type="email" required
                                   className={`form-control login__inp ${this.errorClass(this.state.formErrors.email)}`}
                                   name="email"
                                   placeholder="Email"
                                   value={this.state.email}
                                   onChange={this.handleUserInput}  />
                        </div>
                        <div className={`form-group`}>
                            <label htmlFor="password"></label>
                            <input id="password"
                                   type="password"
                                   className={`form-control login__inp ${this.errorClass(this.state.formErrors.password)}`}
                                   name="password"
                                   placeholder="Password"
                                   value={this.state.password}
                                   onChange={this.handleUserInput}  />
                        </div>
                        <button  className="blueButton login__blueButton" disabled={!this.state.formValid}>Sign up</button>
                    </form>
                )}
            </>
        )
    }
}*/




/*



            if (Check(user, pwd, data, setData, your_id))  {


            /!*const response = await axios.post('/user',
                JSON.stringify({ user, pwd }),
                {
                    headers: { 'Content-Type': 'application/json' },
                    withCredentials: true
                }
            );*!/
            //console.log(JSON.stringify(response?.data));
            //console.log(JSON.stringify(response));
            // const accessToken = response?.data?.accessToken;
            // const roles = response?.data?.roles;
            //setAuth({ user, pwd, roles, accessToken });

            setUser('');
            setPwd('');
            setSuccess(true);
        } else {
            setErrMsg('Login Failed');
        }
            errRef.current.focus();
        }
            let res;*/
/*if (success) {
    res = data?.map((obj) => {
        return (
            <div key={obj.id}>
                firstName: {obj.firstName}
                <br/>
                lastName: {obj.lastName}
                <>
                {
                    obj.isAdmin ? (
                        <p>Admin</p>
                    ) : (
                        <p></p>
                    )
                }
                </>
            </div>
        )
    } )
}*/
/*
    class Form extends Component {
    constructor (props) {
    super(props);
    this.state = {
    email: '',
    password: '',
    formErrors: {email: '', password: ''},
    emailValid: false,
    passwordValid: false,
    formValid: false
}
}

    handleUserInput = (e) => {
    const name = e.target.name;
    const value = e.target.value;
    this.setState({[name]: value},
    () => { this.validateField(name, value) });
}

    validateField(fieldName, value) {
    let fieldValidationErrors = this.state.formErrors;
    let emailValid = this.state.emailValid;
    let passwordValid = this.state.passwordValid;

    switch(fieldName) {
    case 'email':
    emailValid = value.match(/^([\w.%+-]+)@([\w-]+\.)+([\w]{2,})$/i);
    fieldValidationErrors.email = emailValid ? '' : ' is invalid';
    break;
    case 'password':
    passwordValid = value.length >= 6;
    fieldValidationErrors.password = passwordValid ? '': ' is too short';
    break;
    default:
    break;
}
    this.setState({formErrors: fieldValidationErrors,
    emailValid: emailValid,
    passwordValid: passwordValid
}, this.validateForm);
}

    validateForm() {
    this.setState({formValid: this.state.emailValid && this.state.passwordValid});
}

    errorClass(error) {
    return(error.length === 0 ? '' : 'has-error');
}

    handleSubmit(e){
    //const [ success, setSuccess ] = useState();
    e.preventDefault();
    const name = e.target.name;
    const value = e.target.value;
    let mail = "";
    let pass = "";
    switch(name) {
    case 'email':
    mail = value;
    break;
    case 'password':
    pass = value;
    break;
    default:
    break;
}
    //setSuccess(true);

    //sent to check
    const [data, setData] = useState();
    console.log(Check(mail,pass,data,setData));
    /!*axios.post('/user',{
    name: mail,
    password: pass
})
    .then(res=>{
    console.log(res.data)
})
    *!/
}

    render () {
    return (
    <>
{0 ? (
    <section>
    <h1>You are logged in!</h1>
    <br />
    <CustomLink to="/loginPage">Go to Home</CustomLink>
    </section>
    ) : (
    <form className="loginForm" onSubmit={this.handleSubmit}>
    <h2 className="login__title">Log In</h2>
{/!*<div className="panel panel-default">
    <FormErrors formErrors={this.state.formErrors} />
    </div>*!/}
    <div className={`form-group`}>
    <label htmlFor="email"></label>
    <input id="email"
    type="email" required
    className={`form-control login__inp ${this.errorClass(this.state.formErrors.email)}`}
    name="email"
    placeholder="Email"
    value={this.state.email}
    onChange={this.handleUserInput}  />
    </div>
    <div className={`form-group`}>
    <label htmlFor="password"></label>
    <input id="password"
    type="password"
    className={`form-control login__inp ${this.errorClass(this.state.formErrors.password)}`}
    name="password"
    placeholder="Password"
    value={this.state.password}
    onChange={this.handleUserInput}  />
    </div>
    <button  className="blueButton login__blueButton" disabled={!this.state.formValid}>Sign up</button>
    </form>
    )}
    </>
    )
}
    }*/




//import { FormErrors } from './FormErrors';