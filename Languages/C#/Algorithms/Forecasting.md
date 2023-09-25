## Statistical Inference & Forecasting Performance Metrics

| [Category](#Statistical-Inference-&-Forecasting) | [Algorithm](#Algorithm) | Time Complexity | Space Complexity | Data Sensitivity | Cache Performance |
|--------------------------------------------------|-------------------------|-----------------|------------------|------------------|-------------------|
| [Classical Statistical Methods](#Classical-Statistical-Methods) | [Linear Regression](#Linear-Regression) | O(n) | O(n) | High | Moderate |
| | [Logistic Regression](#Logistic-Regression) | O(n) | O(n) | High | Moderate |
| | [Chi-Square Test](#Chi-Square-Test) | O(n) | O(1) | Low | High |
| | [T-Test](#T-Test) | O(n) | O(1) | Low | High |
| | [ANOVA](#ANOVA) | O(n) | O(n) | Moderate | Moderate |
| | [Factor Analysis](#Factor-Analysis) | O(n^2) | O(n^2) | High | Low |
| | [Principal Component Analysis (PCA)](#PCA) | O(n^2) | O(n^2) | High | Low |
| | [Discriminant Analysis](#Discriminant-Analysis) | O(n^2) | O(n^2) | High | Low |
| | [Survival Analysis](#Survival-Analysis) | O(n log n) | O(n) | Moderate | Moderate |
| | [Nonlinear Regression](#Nonlinear-Regression) | O(n^2) | O(n) | High | Low |
| [Bayesian Inference](#Bayesian-Inference) | [Bayesian Networks](#Bayesian-Networks) | O(2^n) | O(2^n) | High | Low |
| | [Naive Bayes Classifier](#Naive-Bayes-Classifier) | O(n) | O(n) | Low | High |
| | [Bayesian Linear Regression](#Bayesian-Linear-Regression) | O(n^3) | O(n^2) | High | Low |
| | [Hidden Markov Models](#Hidden-Markov-Models) | O(n^2) | O(n) | High | Moderate |
| | [Monte Carlo Methods](#Monte-Carlo-Methods) | O(n) | O(n) | Low | High |
| | [Markov Chain Monte Carlo (MCMC)](#MCMC) | O(n) | O(n) | High | Low |
| | [Gibbs Sampling](#Gibbs-Sampling) | O(n) | O(n) | High | Low |
| | [Bayesian Optimization](#Bayesian-Optimization) | O(n log n) | O(n) | High | Moderate |
| | [Expectation-Maximization (EM)](#EM) | O(n^2) | O(n) | High | Low |
| | [Bayesian Hierarchical Models](#Bayesian-Hierarchical-Models) | O(n^3) | O(n^2) | High | Low |
| [Time Series Analysis & Forecasting](#Time-Series-Analysis-&-Forecasting) | [ARIMA Models](#ARIMA-Models) | O(n) | O(n) | High | Moderate |
| | [Exponential Smoothing (Holt-Winters)](#Holt-Winters) | O(n) | O(n) | Moderate | High |
| | [Seasonal Decomposition](#Seasonal-Decomposition) | O(n) | O(n) | Low | High |
| | [Fourier Transform for Signal Analysis](#Fourier-Transform) | O(n log n) | O(n) | Low | High |
| | [Wavelet Transform](#Wavelet-Transform) | O(n) | O(n) | Low | High |
| | [Kalman Filters](#Kalman-Filters) | O(n) | O(n) | High | Moderate |
| | [State Space Models](#State-Space-Models) | O(n) | O(n) | High | Moderate |
| | [GARCH Models](#GARCH-Models) | O(n) | O(n) | High | Moderate |
| | [Cointegration Analysis](#Cointegration-Analysis) | O(n^2) | O(n) | High | Low |
| | [Long Short-Term Memory (LSTM)](#LSTM) | O(n) | O(n) | High | Moderate |
| [Machine Learning Algorithms](#Machine-Learning-Algorithms) | [Neural Networks (ANN, CNN, RNN)](#Neural-Networks) | O(n^2) | O(n) | High | Low |
| | [Decision Trees (ID3, CART)](#Decision-Trees) | O(n log n) | O(n) | Moderate | High |
| | [Random Forests](#Random-Forests) | O(n log n) | O(n) | Moderate | High |
| | [Support Vector Machines (SVM)](#SVM) | O(n^2) | O(n) | High | Low |
| | [K-Nearest Neighbors (K-NN)](#K-NN) | O(n) | O(n) | Low | High |
| | [Gradient Boosting Machines (GBM)](#GBM) | O(n) | O(n) | Moderate | High |
| | [AdaBoost](#AdaBoost) | O(n) | O(n) | Moderate | High |
| | [XGBoost](#XGBoost) | O(n) | O(n) | Moderate | High |
| | [LightGBM](#LightGBM) | O(n) | O(n) | Moderate | High |
| | [CatBoost](#CatBoost) | O(n) | O(n) | Moderate | High |
| [Cluster Analysis & Anomaly Detection](#Cluster-Analysis-&-Anomaly-Detection) | [K-Means Clustering](#K-Means) | O(n) | O(n) | Low | High |
| | [Hierarchical Clustering](#Hierarchical-Clustering) | O(n^2) | O(n) | High | Low |
| | [DBSCAN](#DBSCAN) | O(n log n) | O(n) | Moderate | Moderate |
| | [Gaussian Mixture Model (GMM)](#GMM) | O(n) | O(n) | High | Moderate |
| | [Anomaly Detection Algorithms](#Anomaly-Detection) | O(n) | O(n) | High | Moderate |
| | [Isolation Forest](#Isolation-Forest) | O(n) | O(n) | Moderate | High |
| | [One-Class SVM](#One-Class-SVM) | O(n^2) | O(n) | High | Low |
| | [Local Outlier Factor (LOF)](#LOF) | O(n^2) | O(n) | High | Low |
| | [Elliptic Envelope](#Elliptic-Envelope) | O(n^2) | O(n) | High | Low |
| | [Autoencoders for Anomaly Detection](#Autoencoders) | O(n) | O(n) | High | Moderate |

