export const environment = {
  production: true,
  application: {
    name: 'Hygge',
    logoUrl: ''
  },
  oAuthConfig: {
    issuer: 'https://localhost:44395',
    clientId: 'Hygge_App',
    dummyClientSecret: '1q2w3e*',
    scope: 'Hygge',
    showDebugInformation: true,
    oidc: false,
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44331'
    }
  },
  localization: {
    defaultResourceName: 'Hygge'
  }
};
