--
-- PostgreSQL database dump
--

-- Dumped from database version 15.6
-- Dumped by pg_dump version 15.6

-- Started on 2024-12-02 21:52:07

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SELECT pg_catalog.set_config('search_path', '', false);
SET check_function_bodies = false;
SET xmloption = content;
SET client_min_messages = warning;
SET row_security = off;

SET default_tablespace = '';

SET default_table_access_method = heap;

--
-- TOC entry 221 (class 1259 OID 25296)
-- Name: categoria; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.categoria (
    idcategoria integer NOT NULL,
    nomecategoria character varying(30) NOT NULL
);


ALTER TABLE public.categoria OWNER TO postgres;

--
-- TOC entry 220 (class 1259 OID 25295)
-- Name: categoria_idcategoria_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.categoria_idcategoria_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.categoria_idcategoria_seq OWNER TO postgres;

--
-- TOC entry 3372 (class 0 OID 0)
-- Dependencies: 220
-- Name: categoria_idcategoria_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.categoria_idcategoria_seq OWNED BY public.categoria.idcategoria;


--
-- TOC entry 223 (class 1259 OID 25303)
-- Name: pergunta; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pergunta (
    idpergunta integer NOT NULL,
    pergunta text NOT NULL,
    alter1 text NOT NULL,
    alter2 text NOT NULL,
    alter3 text NOT NULL,
    alter4 text NOT NULL,
    resp text NOT NULL,
    idcategoria integer NOT NULL
);


ALTER TABLE public.pergunta OWNER TO postgres;

--
-- TOC entry 222 (class 1259 OID 25302)
-- Name: pergunta_idpergunta_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.pergunta_idpergunta_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.pergunta_idpergunta_seq OWNER TO postgres;

--
-- TOC entry 3373 (class 0 OID 0)
-- Dependencies: 222
-- Name: pergunta_idpergunta_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.pergunta_idpergunta_seq OWNED BY public.pergunta.idpergunta;


--
-- TOC entry 219 (class 1259 OID 25284)
-- Name: pontuacao; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.pontuacao (
    idtentativa integer NOT NULL,
    idusuario integer NOT NULL,
    totalacertos integer NOT NULL,
    datatentativa timestamp without time zone NOT NULL,
    totalerros integer
);


ALTER TABLE public.pontuacao OWNER TO postgres;

--
-- TOC entry 218 (class 1259 OID 25283)
-- Name: pontuacao_idtentativa_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.pontuacao_idtentativa_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.pontuacao_idtentativa_seq OWNER TO postgres;

--
-- TOC entry 3374 (class 0 OID 0)
-- Dependencies: 218
-- Name: pontuacao_idtentativa_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.pontuacao_idtentativa_seq OWNED BY public.pontuacao.idtentativa;


--
-- TOC entry 215 (class 1259 OID 25261)
-- Name: tipousuario; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.tipousuario (
    idtipousuario integer NOT NULL,
    nometipousuario character varying(10) NOT NULL
);


ALTER TABLE public.tipousuario OWNER TO postgres;

--
-- TOC entry 214 (class 1259 OID 25260)
-- Name: tipousuario_idtipousuario_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.tipousuario_idtipousuario_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.tipousuario_idtipousuario_seq OWNER TO postgres;

--
-- TOC entry 3375 (class 0 OID 0)
-- Dependencies: 214
-- Name: tipousuario_idtipousuario_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.tipousuario_idtipousuario_seq OWNED BY public.tipousuario.idtipousuario;


--
-- TOC entry 217 (class 1259 OID 25268)
-- Name: usuario; Type: TABLE; Schema: public; Owner: postgres
--

CREATE TABLE public.usuario (
    idusuario integer NOT NULL,
    nomeusuario character varying(40) NOT NULL,
    email character varying(50) NOT NULL,
    senha character varying(13) NOT NULL,
    idtipousuario integer NOT NULL
);


ALTER TABLE public.usuario OWNER TO postgres;

--
-- TOC entry 216 (class 1259 OID 25267)
-- Name: usuario_idusuario_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE public.usuario_idusuario_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;


ALTER TABLE public.usuario_idusuario_seq OWNER TO postgres;

--
-- TOC entry 3376 (class 0 OID 0)
-- Dependencies: 216
-- Name: usuario_idusuario_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE public.usuario_idusuario_seq OWNED BY public.usuario.idusuario;


--
-- TOC entry 3196 (class 2604 OID 25299)
-- Name: categoria idcategoria; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.categoria ALTER COLUMN idcategoria SET DEFAULT nextval('public.categoria_idcategoria_seq'::regclass);


--
-- TOC entry 3197 (class 2604 OID 25306)
-- Name: pergunta idpergunta; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pergunta ALTER COLUMN idpergunta SET DEFAULT nextval('public.pergunta_idpergunta_seq'::regclass);


--
-- TOC entry 3195 (class 2604 OID 25287)
-- Name: pontuacao idtentativa; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pontuacao ALTER COLUMN idtentativa SET DEFAULT nextval('public.pontuacao_idtentativa_seq'::regclass);


--
-- TOC entry 3193 (class 2604 OID 25264)
-- Name: tipousuario idtipousuario; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tipousuario ALTER COLUMN idtipousuario SET DEFAULT nextval('public.tipousuario_idtipousuario_seq'::regclass);


--
-- TOC entry 3194 (class 2604 OID 25271)
-- Name: usuario idusuario; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuario ALTER COLUMN idusuario SET DEFAULT nextval('public.usuario_idusuario_seq'::regclass);


--
-- TOC entry 3364 (class 0 OID 25296)
-- Dependencies: 221
-- Data for Name: categoria; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.categoria (idcategoria, nomecategoria) FROM stdin;
1	PORTUGUÊS
3	HISTÓRIA
2	GEOGRAFIA
4	MATEMATICA
\.


--
-- TOC entry 3366 (class 0 OID 25303)
-- Dependencies: 223
-- Data for Name: pergunta; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.pergunta (idpergunta, pergunta, alter1, alter2, alter3, alter4, resp, idcategoria) FROM stdin;
5	Qual é o resultado de 2 - 1?	3	4	1	2	1	4
7	Qual é o resultado de 2 - 1?	3	4	1	2	1	4
8	Qual é o resultado de 2 - 1?	3	4	1	2	1	4
1	Qual o período que durou o primeiro império?	De 1822 a 1831	De 1822 a 1832	De 1831 a 1841	De 1841 a 1846	De 1822 a 1831	3
9	A Guerra Cisplatina foi entre:	Brasil e Portugal	Portugal e Uruguai	Uruguai e Brasil	Brasil e Argentina	Brasil e Argentina	3
2	O Primeiro Império ficou conhecido também como:	Primeiro Reino	Primeiro Governo	Primeiro Reinado	Governo Geral	Primeiro Reinado	3
3	А frаѕе аbаіхо fісоu muіtо соnhесіdа, роіѕ mаrса umа іmроrtаntе раrtе dа hіѕtórіа dо Вrаѕіl: \n"Соmо é раrа о bеm dе tоdоѕ е fеlісіdаdе gеrаl dа Nаçãо, еѕtоu рrоntо. Dіgа ао роvо quе fісо". Quе mоmеntо fоі еѕtе?	Dia do Fico	Dia do retorno da familia real para portugal	Dia que Dom Pedro proclamou a independência do Brasil	Dia que Dom João volta para o Brasil	Dia do Fico	3
6	Qual é o resultado de 2 - 1?	4	2	1	8	1	4
4	Das opções abaixo, a que não representa um impacto ambiental é:	chuva ácida	assoreamento dos rios	desertificação	mobilidade urbana	mobilidade urbana	2
\.


--
-- TOC entry 3362 (class 0 OID 25284)
-- Dependencies: 219
-- Data for Name: pontuacao; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.pontuacao (idtentativa, idusuario, totalacertos, datatentativa, totalerros) FROM stdin;
1	1	2	2024-11-30 14:45:00	3
2	3	4	2024-11-30 16:38:55.722595	0
3	3	4	2024-11-30 16:52:12.996665	0
4	3	3	2024-11-30 16:53:56.996887	1
5	4	3	2024-12-01 06:54:38.172239	1
6	5	2	2024-12-01 06:57:08.123398	2
7	3	4	2024-12-02 10:20:52.166518	0
\.


--
-- TOC entry 3358 (class 0 OID 25261)
-- Dependencies: 215
-- Data for Name: tipousuario; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.tipousuario (idtipousuario, nometipousuario) FROM stdin;
1	Admin
2	Aluno
3	Professor
\.


--
-- TOC entry 3360 (class 0 OID 25268)
-- Dependencies: 217
-- Data for Name: usuario; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY public.usuario (idusuario, nomeusuario, email, senha, idtipousuario) FROM stdin;
1	EduardoPROF	eduardoP@teste.com	123pro	3
2	EduardoADM	eduardo@teste.com	123edu	1
3	EduardoALUNO	eduardoA@teste.com	123alu	2
4	LucasALUNO	lucascarlos@fatec.sp.gov.br	123456	2
5	Beatriz Mesquita	beatrizmesquita@fatec.teste.com	bia123	2
11	pokemon	pokemon@teste.com	pokemon	2
12	usuario	usuario@teste	1234	2
13	Marcos	marcos@teste.com	marcos123	2
14	BeatrizProf	beatriz@teste.com.br	bia123	3
6	Marcelo Neves	marceloAluno@teste.com	neves123	2
7	Teste	teste	teste	2
15	AdminTeste1	adminteste1@gmail.com	adm1234	1
\.


--
-- TOC entry 3377 (class 0 OID 0)
-- Dependencies: 220
-- Name: categoria_idcategoria_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.categoria_idcategoria_seq', 4, true);


--
-- TOC entry 3378 (class 0 OID 0)
-- Dependencies: 222
-- Name: pergunta_idpergunta_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.pergunta_idpergunta_seq', 9, true);


--
-- TOC entry 3379 (class 0 OID 0)
-- Dependencies: 218
-- Name: pontuacao_idtentativa_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.pontuacao_idtentativa_seq', 7, true);


--
-- TOC entry 3380 (class 0 OID 0)
-- Dependencies: 214
-- Name: tipousuario_idtipousuario_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.tipousuario_idtipousuario_seq', 3, true);


--
-- TOC entry 3381 (class 0 OID 0)
-- Dependencies: 216
-- Name: usuario_idusuario_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('public.usuario_idusuario_seq', 15, true);


--
-- TOC entry 3209 (class 2606 OID 25301)
-- Name: categoria categoria_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.categoria
    ADD CONSTRAINT categoria_pkey PRIMARY KEY (idcategoria);


--
-- TOC entry 3211 (class 2606 OID 25310)
-- Name: pergunta pergunta_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pergunta
    ADD CONSTRAINT pergunta_pkey PRIMARY KEY (idpergunta);


--
-- TOC entry 3207 (class 2606 OID 25289)
-- Name: pontuacao pontuacao_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pontuacao
    ADD CONSTRAINT pontuacao_pkey PRIMARY KEY (idtentativa);


--
-- TOC entry 3199 (class 2606 OID 25266)
-- Name: tipousuario tipousuario_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.tipousuario
    ADD CONSTRAINT tipousuario_pkey PRIMARY KEY (idtipousuario);


--
-- TOC entry 3201 (class 2606 OID 25277)
-- Name: usuario usuario_email_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_email_key UNIQUE (email);


--
-- TOC entry 3203 (class 2606 OID 25275)
-- Name: usuario usuario_nomeusuario_key; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_nomeusuario_key UNIQUE (nomeusuario);


--
-- TOC entry 3205 (class 2606 OID 25273)
-- Name: usuario usuario_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_pkey PRIMARY KEY (idusuario);


--
-- TOC entry 3214 (class 2606 OID 25311)
-- Name: pergunta fk_categoria; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pergunta
    ADD CONSTRAINT fk_categoria FOREIGN KEY (idcategoria) REFERENCES public.categoria(idcategoria);


--
-- TOC entry 3212 (class 2606 OID 25278)
-- Name: usuario fk_tipo_usuario; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT fk_tipo_usuario FOREIGN KEY (idtipousuario) REFERENCES public.tipousuario(idtipousuario);


--
-- TOC entry 3213 (class 2606 OID 25290)
-- Name: pontuacao fk_usuario; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY public.pontuacao
    ADD CONSTRAINT fk_usuario FOREIGN KEY (idusuario) REFERENCES public.usuario(idusuario);


-- Completed on 2024-12-02 21:52:07

--
-- PostgreSQL database dump complete
--

