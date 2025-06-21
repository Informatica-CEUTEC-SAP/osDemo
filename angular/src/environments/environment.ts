 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44345/',
  redirectUri: baseUrl,
  clientId: 'OSDemo_App',
  responseType: 'code',
  scope: 'offline_access OSDemo',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'OSDemo',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44345',
      rootNamespace: 'OSDemo',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
